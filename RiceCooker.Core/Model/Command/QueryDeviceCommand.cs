using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Command
{
    public class QueryDeviceCommand : ICommand
    {
        [JsonProperty("cmd")]
        public string Command { get; }

        [JsonProperty("sid")] 
        public string DeviceId { get; }

        public QueryDeviceCommand(string deviceId)
        {
            Command = CommandList.CmdReadDevices;
            DeviceId = deviceId;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}