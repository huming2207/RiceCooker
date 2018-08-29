using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Query
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryType
    {
        [EnumMember(Value = "whois")]
        FindGateway,

        [EnumMember(Value = "get_id_list")]
        GetDeviceIdList,

        [EnumMember(Value = "read")]
        ReadDevice
    }
}
