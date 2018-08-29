using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Product
{
    public class SmartGateway
    {
        [JsonProperty("rgb")]
        private int RgbValue { get; set; }

        [JsonProperty("illumination")]
        private int Illumination { get; set; }

        [JsonProperty("proto_version")]
        private string ProtoVersion { get; set; }

        [JsonProperty("mid")]
        private int MusicId { get; set; }

        [JsonProperty("join_permission")]
        private string JoinPermission { get; set; }

        [JsonProperty("remove_device")]
        private string DeviceIdToRemove { get; set; }
    }
}
