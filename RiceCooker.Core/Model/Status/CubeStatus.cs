using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Status
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CubeStatus
    {
        [EnumMember(Value = "flip90")]
        Fiip90,

        [EnumMember(Value = "flip180")]
        Filp180,

        [EnumMember(Value = "move")]
        Move,

        [EnumMember(Value = "tap_twice")]
        TapTwice,

        [EnumMember(Value = "shake_air")]
        ShakeAir,

        [EnumMember(Value = "swing")]
        Swing,

        [EnumMember(Value = "alert")]
        Alert,

        [EnumMember(Value = "free_fall")]
        FreeFall
    }
}
