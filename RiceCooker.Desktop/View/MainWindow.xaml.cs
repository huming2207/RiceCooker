using Newtonsoft.Json;
using RiceCooker.Core;
using RiceCooker.Core.Model.Product;
using RiceCooker.Core.Model.Query;
using RiceCooker.Core.Model.Response;
using RiceCooker.Desktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows;

namespace RiceCooker.Desktop.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Gateway> GatewayList = new List<Gateway>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void AutoConnectButton_Click(object sender, RoutedEventArgs e)
        {
            // Perform query 
            MiHome miHome = new MiHome();
            var responseStr = miHome.PerformQuery(new FindGatewayQuery());
            Console.WriteLine($"Got gateway response: {responseStr}");

            var gatewayResponse = JsonConvert.DeserializeObject<GatewayResponse>(responseStr);
            var gateway = new Gateway
            {
                GatewayIpAddr = gatewayResponse.IpAddress,
                GatewayId = gatewayResponse.DeviceId
            };

            DeviceQuery(ref gateway);
        }

        private void ManualConnectButton_Click(object sender, RoutedEventArgs e)
        {
            var gateway = new Gateway();
            DeviceQuery(ref gateway, IpAddrTextBox.Text);
        }

        private void DeviceQuery(ref Gateway gateway, string ipAddress = "")
        {
            // Detect if it's a manual connection. If does, set the IP.
            var manualConnect = !string.IsNullOrEmpty(ipAddress);
            if (manualConnect) gateway.GatewayIpAddr = ipAddress;

            // Query sub devices (ZigBee devices)
            var miHome = new MiHome();
            var responseStr = miHome.PerformQuery(new ListDeviceQuery(), gateway.GatewayIpAddr);
            var devieListResponse = JsonConvert.DeserializeObject<DeviceIdListResponse>(responseStr);
            if (manualConnect) gateway.GatewayId = devieListResponse.GatewayId;

            // Iterate all the devices found from the gateway
            foreach (var deviceId in devieListResponse.GetDeviceIdList())
            {
                responseStr = miHome.PerformQuery(new ReadDeviceQuery(deviceId), gateway.GatewayIpAddr);
                var deviceResponse = JsonConvert.DeserializeObject<DeviceResponse>(responseStr);
                gateway.Devices.Add(new Device()
                {
                    DeviceId = deviceResponse.DeviceId,
                    Model = Enum.GetName(typeof(ProductModel), deviceResponse.ProductModel),
                    DataPayload = deviceResponse.RawDataPayload
                });
            }

            // Add gateway as root
            GatewayList.Add(gateway);
            DeviceTree.ItemsSource = GatewayList;
        }
    }
}
