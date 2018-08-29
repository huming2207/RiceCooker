using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Query
{
    public class ListDeviceQuery : IQuery
    {
        [JsonProperty("cmd")]
        public QueryType Command { get; }

        public ListDeviceQuery()
        {
            Command = QueryType.GetDeviceIdList;
        }
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}