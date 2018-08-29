using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Command
{
    public class ListDeviceCommand
    {
        [JsonProperty("cmd")]
        public string Command { get; }

        public ListDeviceCommand()
        {
            Command = "get_id_list";
        }
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}