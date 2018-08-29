using Newtonsoft.Json;
using RiceCooker.Core.Model.Status;

namespace RiceCooker.Core.Model.Product
{
    public class WindowSensor
    {
        [JsonProperty("status")]
        public WindowStatus Status { get; set; }

        [JsonProperty("voltage")] 
        public uint Voltage { get; set; }
    }
}
