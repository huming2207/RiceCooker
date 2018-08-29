using RiceCooker.Core.Model.Query;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Input;

namespace RiceCooker.Core
{
    public class MiHome
    {
        public MiHome()
        {
            
        }

        public string PerformQuery<T>(T command, string ipAddress = "") where T : IQuery
        {
            // If IP address is empty, then it will assume this request is a multicast request
            // The multicast IP is 224.0.0.50 with port at 4321
            var isMulticast = string.IsNullOrEmpty(ipAddress);
            if (isMulticast)
            {
                ipAddress = "224.0.0.50";
            }

            var port = isMulticast ? 4343 : 9898;
        
            var ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            var udpClient = new UdpClient(port)
            {
                EnableBroadcast = isMulticast
            };

            var commandString = command.ToString();

            // If the command is an invalid one, do not continue and return an empty string
            if (string.IsNullOrEmpty(commandString)) return string.Empty;

            // Convert the string to binary and send to the dest
            var strBinary = Encoding.UTF8.GetBytes(commandString);
            udpClient.Send(strBinary, strBinary.Length, ipEndPoint);
            
            // ...then see if we can receive something
            var receivedBinary = udpClient.Receive(ref ipEndPoint);
            udpClient.Close();
            udpClient.Dispose();
            
            return receivedBinary.Length < 0 ? string.Empty : Encoding.UTF8.GetString(receivedBinary);
        }
    }
}
