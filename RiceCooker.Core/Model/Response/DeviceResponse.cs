using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Response
{
    public class DeviceResponse : IResponse
    {
        [JsonProperty("cmd")]
        public ResponseType Command { get; set; }
        
        [JsonProperty("sid")]
        public string DeviceId { get; set; }
        
        [JsonProperty("short_id")]
        public string ZigBeeId { get; set; }
       
        [JsonProperty("data")]
        public string RawDataPayload { get; set; }

        public T GetDeviceDetails<T>()
        {
            return JsonConvert.DeserializeObject<T>(RawDataPayload);
        }
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}