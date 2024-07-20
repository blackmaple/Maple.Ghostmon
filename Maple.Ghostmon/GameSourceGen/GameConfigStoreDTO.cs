namespace Maple.Ghostmon
{
    public class GameConfigStoreDTO
    {
        public List<MaterialConfig> ListMaterialConfig { get; } = new(512);
        public List<CharmConfig> ListCharmConfig { get; } = new(512);

        public List<RareConfig> ListRareConfig { get; } = new(512);
        public List<AbilityBookConfig> ListAbilityBookConfig { get; } = new(512);
        public List<TreasureConfig> ListTreasureConfig { get; } = new(512);
        public List<ClothingConfig> ListClothingConfig { get; } = new(512);

        public List<MenuConfig> ListMenuConfig { get; } = new(512);
        public List<EggConfig> ListEggConfig { get; } = new(512);

        public List<ItemRecipeConfig> ListItemRecipeConfig { get; } = new(512);
        public List<FishLureConfig> ListFishLureConfig { get; } = new(512);


        public List<AbilityConfig> ListAbilityConfig { get; } = new(512);
        public List<BuffConfig> ListBuffConfig { get; } = new(512);
        public List<IllustrationConfig> ListIllustrationConfig { get; } = new(512);


        public List<CuisineConfig> ListCuisineConfig { get; } = new(512);
        public List<EvoMaterialConfig> ListEvoMaterialConfig { get; } = new(512);

        public GameConfigStoreDTO()
        {

            this.ListIllustrationConfig.AddRange([
                    new IllustrationConfig(){ prefab = "Monster_JQR" }  ,
                    new IllustrationConfig(){ prefab = "Monster_100_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_101_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_102_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_103_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_104_TheBoss" }  ,

                ]);
        }

        public void AddConfig(ReadOnlySpan<char> json, EnumSheetName enumSheetName)
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
            else if (enumSheetName == EnumSheetName.EvoMaterialConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.EvoMaterialConfig);
                if (data is not null)
                {
                    this.ListEvoMaterialConfig.Add(data);
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
            else if (enumSheetName == EnumSheetName.CuisineConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.CuisineConfig);
                if (data is not null)
                {
                    this.ListCuisineConfig.Add(data);
                }
            }


        }
    }


}
