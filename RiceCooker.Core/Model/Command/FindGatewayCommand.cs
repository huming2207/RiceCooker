using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Command
{
    public class FindGatewayCommand : ICommand
    {
        [JsonProperty("cmd")]
        public string Command { get; }
        
        public FindGatewayCommand()
        {
            Command = CommandList.CmdFindGateway;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}