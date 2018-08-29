using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Status
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MotionStatus
    {
        [EnumMember(Value = "motion")]
        Motion,

        [EnumMember(Value = "unknown")]
        Unknown
    }
}
