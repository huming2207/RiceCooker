using Newtonsoft.Json;
using RiceCooker.Core.Model.Status;

namespace RiceCooker.Core.Model.Product
{
    public class HumanMotionSensor
    {
        [JsonProperty("status")]
        public MotionStatus Status { get; set; }

        [JsonProperty("voltage")]
        public uint Voltage { get; set; }

    }
}
