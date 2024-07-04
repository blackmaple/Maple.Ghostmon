using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Maple.Ghostmon
{

    [JsonSourceGenerationOptions(
        PropertyNameCaseInsensitive = true,
        IncludeFields = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        Converters = [typeof(StringNumberConverter)])]

    [JsonSerializable(typeof(MaterialConfig))]
    [JsonSerializable(typeof(CharmConfig))]


    [JsonSerializable(typeof(RareConfig))]
    [JsonSerializable(typeof(AbilityBookConfig))]

    [JsonSerializable(typeof(TreasureConfig))]
    [JsonSerializable(typeof(ClothingConfig))]

    [JsonSerializable(typeof(MenuConfig))]
    [JsonSerializable(typeof(EggConfig))]

    [JsonSerializable(typeof(ItemRecipeConfig))]
    [JsonSerializable(typeof(FishLureConfig))]

    [JsonSerializable(typeof(BuffConfig))]
    [JsonSerializable(typeof(IllustrationConfig))]

    [JsonSerializable(typeof(AbilityConfig))]

    
    public partial class ConfigJsonSerializerContext : JsonSerializerContext
    {



    }

    internal sealed partial class StringNumberConverter : JsonConverter<string?>
    {
        public sealed override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetUInt64().ToString();
            }
            return reader.GetString();
        }

        public sealed override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
