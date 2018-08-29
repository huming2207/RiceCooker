using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Status
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WaterLeakStatus
    {
        [EnumMember(Value = "leak")]
        Leak,

        [EnumMember(Value = "no_leak")]
        NoLeak
    }
}
