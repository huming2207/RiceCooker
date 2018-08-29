using Newtonsoft.Json;
using RiceCooker.Core.Model.Status;

namespace RiceCooker.Core.Model.Product
{
    public class HumanMotionSensor : IProduct
    {
        [JsonProperty("status")]
        public MotionStatus Status { get; set; }

        [JsonProperty("voltage")]
        public uint Voltage { get; set; }

        public override string ToString()
        {
            return $"Status: {Status.ToString()}, Voltage: {Voltage.ToString()}";
        }
    }
}
