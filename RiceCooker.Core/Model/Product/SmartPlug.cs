using Newtonsoft.Json;
using RiceCooker.Core.Model.Status;

namespace RiceCooker.Core.Model.Product
{
    public class SmartPlug
    {
        [JsonProperty("status")]
        public WindowStatus Status { get; set; }

        [JsonProperty("voltage")]
        public int Voltage { get; set; }
    }
}
