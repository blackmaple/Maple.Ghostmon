namespace Maple.Ghostmon
{
    public class GameConfigStoreDTO
    {
        public List<MaterialConfig> ListMaterialConfig { get; } = [];
        public List<CharmConfig> ListCharmConfig { get; } = [];

        public List<RareConfig> ListRareConfig { get; } = [];
        public List<AbilityBookConfig> ListAbilityBookConfig { get; } = [];
        public List<TreasureConfig> ListTreasureConfig { get; } = [];
        public List<ClothingConfig> ListClothingConfig { get; } = [];

        public List<MenuConfig> ListMenuConfig { get; } = [];
        public List<EggConfig> ListEggConfig { get; } = [];

        public List<ItemRecipeConfig> ListItemRecipeConfig { get; } = [];
        public List<FishLureConfig> ListFishLureConfig { get; } = [];


        public List<AbilityConfig> ListAbilityConfig { get; } = [];
        public List<BuffConfig> ListBuffConfig { get; } = [];
        public List<IllustrationConfig> ListIllustrationConfig { get; } = [];

        public void Add(ReadOnlySpan<char> json, EnumSheetName enumSheetName)
        {
            if (json.IsEmpty)
            {
                return;
            }

            if (enumSheetName == EnumSheetName.MaterialConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.MaterialConfig);
                if (data is not null)
                {
                    this.ListMaterialConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.CharmConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.CharmConfig);
                if (data is not null)
                {
                    this.ListCharmConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.RareConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.RareConfig);
                if (data is not null)
                {
                    this.ListRareConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.AbilityBookConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.AbilityBookConfig);
                if (data is not null)
                {
                    this.ListAbilityBookConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.TreasureConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.TreasureConfig);
                if (data is not null)
                {
                    this.ListTreasureConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.ClothingConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.ClothingConfig);
                if (data is not null)
                {
                    this.ListClothingConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.MenuConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.MenuConfig);
                if (data is not null)
                {
                    this.ListMenuConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.EggConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.EggConfig);
                if (data is not null)
                {
                    this.ListEggConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.ItemRecipeConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.ItemRecipeConfig);
                if (data is not null)
                {
                    this.ListItemRecipeConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.FishLureConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.FishLureConfig);
                if (data is not null)
                {
                    this.ListFishLureConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.BuffConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.BuffConfig);
                if (data is not null)
                {
                    this.ListBuffConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.IllustrationConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.IllustrationConfig);
                if (data is not null)
                {
                    this.ListIllustrationConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.AbilityConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.AbilityConfig);
                if (data is not null)
                {
                    this.ListAbilityConfig.Add(data);
                }
            }


        }
    }


}
