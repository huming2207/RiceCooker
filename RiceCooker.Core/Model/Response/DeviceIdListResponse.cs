using System.Collections.Generic;
using Newtonsoft.Json;
using RiceCooker.Core.Model.Product;

namespace RiceCooker.Core.Model.Response
{
    public class DeviceIdListResponse  : IResponse
    {
        [JsonProperty("cmd")]
        public ResponseType Command { get; set; }
        
        [JsonProperty("model")]
        public ProductModel ProductModel { get; set; }
        
        [JsonProperty("data")]
        public string RawDataPayload { get; set; }

        public List<string> GetDeviceIdList()
        {
            return JsonConvert.DeserializeObject<List<string>>(RawDataPayload);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}