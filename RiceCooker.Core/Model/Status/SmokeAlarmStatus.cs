using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Status
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmokeAlarmStatus
    {
        [EnumMember(Value = "0")]
        Dismissed,

        [EnumMember(Value = "1")]
        Alarming,

        [EnumMember(Value = "2")]
        Simulating,

        [EnumMember(Value = "8")]
        BatteryFault,

        [EnumMember(Value = "64")]
        SensorFault,

        [EnumMember(Value = "32768")]
        IicFault
    }
}
