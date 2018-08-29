using Newtonsoft.Json;
using RiceCooker.Core.Model.Status;

namespace RiceCooker.Core.Model.Product
{
    public class WirelessButton
    {
        [JsonProperty("status")]
        public ButtonStatus Status { get; set; }

        [JsonProperty("voltage")]
        public int Voltage { get; set; }
    }
}
