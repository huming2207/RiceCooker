using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiceCooker.Core.Model.Response
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseType
    {
        [EnumMember(Value = "iam")]
        GatewayResponse,
        
        [EnumMember(Value = "get_id_list_ack")]
        GetDeviceIdListAck,
       
        [EnumMember(Value = "read_ack")]
        ReadDeviceAck
    }
}