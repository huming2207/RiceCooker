using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Status
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SwitchStatus
    {
        [EnumMember(Value = "on")]
        On,

        [EnumMember(Value = "off")]
        Off,

        [EnumMember(Value = "unknown")]
        Unknown
    }
}
