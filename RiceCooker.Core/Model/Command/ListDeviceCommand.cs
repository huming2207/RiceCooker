using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Command
{
    public class ListDeviceCommand : ICommand
    {
        [JsonProperty("cmd")]
        public string Command { get; }

        public ListDeviceCommand()
        {
            Command = CommandList.CmdListDevices;
        }
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}