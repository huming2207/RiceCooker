using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Command
{
    public class QueryDeviceCommand
    {
        [JsonProperty("cmd")]
        public string Command { get; }

        [JsonIgnore] 
        private string Id;

        public QueryDeviceCommand(string deviceId)
        {
            Command = "";
            Id = deviceId;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}