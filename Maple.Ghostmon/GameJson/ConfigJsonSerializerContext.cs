using System.Text.Json;
using System.Text.Json.Serialization;
using GameConfigJson = System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>;

namespace Maple.Ghostmon
{
    [JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
    [JsonSerializable(typeof(GameConfigJson))]
    [JsonSerializable(typeof(Dictionary<string, Dictionary<ulong, GameConfigJson>>))]
    public partial class ConfigJsonSerializerContext : JsonSerializerContext
    {

    }
}
