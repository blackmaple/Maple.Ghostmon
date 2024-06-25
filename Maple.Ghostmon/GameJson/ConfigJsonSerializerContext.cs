using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Maple.Ghostmon
{

    [JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
    [JsonSerializable(typeof(GameConfigStoreDTO))]
    [JsonSerializable(typeof(GameConfigStoreDTO[]))]
    public partial class ConfigJsonSerializerContext : JsonSerializerContext
    {

        public static string GetGameConfigStoreJson(GameConfigStoreDTO[] gameConfigStores)
        {
            return System.Text.Json.JsonSerializer.Serialize(gameConfigStores, Default.GameConfigStoreDTOArray);
        }
        public static void SerializeGameConfigStore(Stream stream, GameConfigStoreDTO[] configStoreDTOs)
        {
            System.Text.Json.JsonSerializer.Serialize(stream, configStoreDTOs, ConfigJsonSerializerContext.Default.GameConfigStoreDTOArray);
        }


    }
}
