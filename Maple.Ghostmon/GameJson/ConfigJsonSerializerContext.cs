using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using GameConfigJsonElement = System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>;

namespace Maple.Ghostmon
{
    using GameConfigStore = System.Collections.Generic.Dictionary<string, Dictionary<ulong, GameConfigJsonElement>>;

    [JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
    [JsonSerializable(typeof(GameConfigJsonElement))]
    [JsonSerializable(typeof(GameConfigStore))]
    public partial class ConfigJsonSerializerContext : JsonSerializerContext
    {


        public static string? GameConfigJsonElementSerialize(GameConfigJsonElement obj)
        {
            return System.Text.Json.JsonSerializer.Serialize(obj, Default.DictionaryStringJsonElement);
        }
        //public static GameConfigJsonElement? GameConfigJsonElementDeserialize(string str)
        //{
        //    return System.Text.Json.JsonSerializer.Deserialize(str, Default.DictionaryStringJsonElement);
        //}
        public static GameConfigJsonElement? GameConfigJsonElementDeserialize(ReadOnlySpan<char> str)
        {
            return System.Text.Json.JsonSerializer.Deserialize(str, Default.DictionaryStringJsonElement);
        }
 
        public static string? GameConfigStoreSerialize(GameConfigStore obj)
        {
            return System.Text.Json.JsonSerializer.Serialize(obj, Default.DictionaryStringDictionaryUInt64DictionaryStringJsonElement);
        }
        public static GameConfigStore? GameConfigStoreDeserialize(string str)
        {
            return System.Text.Json.JsonSerializer.Deserialize(str, Default.DictionaryStringDictionaryUInt64DictionaryStringJsonElement);
        }
    }
}
