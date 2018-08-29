using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Status
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurtainStatus
    {
        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "close")]
        Close,

        [EnumMember(Value = "stop")]
        Stop,

        [EnumMember(Value = "auto")]
        Auto
    }
}
