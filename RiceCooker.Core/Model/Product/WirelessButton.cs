using Newtonsoft.Json;
using RiceCooker.Core.Model.Status;

namespace RiceCooker.Core.Model.Product
{
    public class WirelessButton : IProduct
    {
        [JsonProperty("status")]
        public ButtonStatus Status { get; set; }

        [JsonProperty("voltage")]
        public uint Voltage { get; set; }

        public override string ToString()
        {
            return $"Status: {Status.ToString()} \nVoltage: {Voltage.ToString()}";
        }
    }
}
