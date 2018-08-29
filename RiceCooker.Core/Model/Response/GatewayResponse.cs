using Newtonsoft.Json;
using RiceCooker.Core.Model.Product;

namespace RiceCooker.Core.Model.Response
{
    public class GatewayResponse : IResponse
    {
        [JsonProperty("cmd")]
        public ResponseType Command { get; set; }
        
        [JsonProperty("port")]
        public uint PortNumber { get; set; }
        
        [JsonProperty("sid")]
        public string DeviceId { get; set; }
        
        [JsonProperty("model")]
        public ProductModel ProductModel { get; set; }
        
        [JsonProperty("proto_version")]
        public string ProtocolVersion { get; set; }
        
        [JsonProperty("data")]
        public string RawDataPayload { get; set; }
        
        [JsonProperty("ip")]
        public string IpAddress { get; set; }
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}