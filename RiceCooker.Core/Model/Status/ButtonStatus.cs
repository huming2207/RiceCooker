using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Status
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ButtonStatus
    {
        [EnumMember(Value = "click")]
        Click,

        [EnumMember(Value = "click")]
        DoubleClick,

        [EnumMember(Value = "click")]
        BothClick
    }
}
