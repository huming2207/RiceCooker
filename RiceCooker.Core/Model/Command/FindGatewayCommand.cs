using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Command
{
    public class FindGatewayCommand
    {
        [JsonProperty("cmd")]
        public string Command { get; }
        
        public FindGatewayCommand()
        {
            Command = "whoami";
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}