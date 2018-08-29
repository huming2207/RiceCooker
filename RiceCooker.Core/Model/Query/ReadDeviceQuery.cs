using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Query
{
    public class ReadDeviceQuery : IQuery
    {
        [JsonProperty("cmd")]
        public QueryType Command { get; }

        [JsonProperty("sid")] 
        public string DeviceId { get; }

        public ReadDeviceQuery(string deviceId)
        {
            Command = QueryType.ReadDevice;
            DeviceId = deviceId;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}