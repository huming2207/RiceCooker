using Newtonsoft.Json;
using RiceCooker.Core.Model.Status;

namespace RiceCooker.Core.Model.Product
{
    public class SmartPlug : IProduct
    {
        [JsonProperty("status")]
        public SwitchStatus Status { get; set; }

        [JsonProperty("load_voltage")]
        public uint Voltage { get; set; }

        [JsonProperty("load_power")]
        public double LoadPower { get; set; }

        [JsonProperty("power_consumed")]
        public uint PowerConsumed { get; set; }

        public override string ToString()
        {
            return
                $"Status: {Status.ToString()} \n" +
                $"Voltage (mV): {Voltage.ToString()} \n" +
                $"Load power (W): {LoadPower.ToString()} \n" +
                $"Power consumed (Wh): {PowerConsumed.ToString()}";
        }
    }
}
