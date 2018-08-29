using Newtonsoft.Json;

namespace RiceCooker.Core.Model.Product
{
    public class SmartGateway : IProduct
    {
        [JsonProperty("rgb")]
        public uint RgbValue { get; set; }

        [JsonProperty("illumination")]
        public uint Illumination { get; set; }

        [JsonProperty("proto_version")]
        public string ProtoVersion { get; set; }

        [JsonProperty("mid")]
        public uint MusicId { get; set; }

        [JsonProperty("join_permission")]
        public string JoinPermission { get; set; }

        [JsonProperty("remove_device")]
        public string DeviceIdToRemove { get; set; }

        public override string ToString()
        {
            return $"RGB Color: {RgbValue:X}\n" + $"Brightness: {Illumination.ToString()}\n" +
                   $"Protocol version: {ProtoVersion}\n" + $"Current music ID: {MusicId.ToString()}\n" +
                   $"Able to join: {JoinPermission}\n";
        }
    }
}
