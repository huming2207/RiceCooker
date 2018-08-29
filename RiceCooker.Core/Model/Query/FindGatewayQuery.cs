using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Query
{
    public class FindGatewayQuery : IQuery
    {
        [JsonProperty("cmd")]
        public QueryType Command { get; }
        
        public FindGatewayQuery()
        {
            Command = QueryType.FindGateway;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}