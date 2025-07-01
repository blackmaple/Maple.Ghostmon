using Maple.Ghostmon.Metadata.GameJson;
using System.Linq;

namespace Maple.Ghostmon.Metadata.MetadataContext
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
        public List<TaskMonsterConfig> ListTaskMonsterConfig { get; } = new(512);


        public List<CuisineConfig> ListCuisineConfig { get; } = new(512);
        public List<EvoMaterialConfig> ListEvoMaterialConfig { get; } = new(512);


        public List<AVGAbilityConfig> ListAVGAbilityConfig { get; } = new(512);
        public List<AVGMonsterConfig> ListAVGMonsterConfig { get; } = new(512);
        public List<AVGPropConfig> ListAVGPropConfig { get; } = new(512);

        public List<HarnessConfig> ListHarnessConfig { get; } = new(512);
        public List<OrnamentConfig> ListOrnamentConfig { get; } = new(512);
        public List<CustomGroundConfig> ListCustomGroundConfig { get; } = new(512);
        public List<CustomItemConfig> ListCustomItemConfig { get; } = new(512);
        public List<CustomPackageConfig> ListCustomPackageConfig { get; } = new(512);



        public GameConfigStoreDTO()
        {

            ListIllustrationConfig.AddRange([
               //     new IllustrationConfig(){ prefab = "Monster_JQR" }  ,
                    new IllustrationConfig(){ prefab = "Monster_HeiYueCanQu" }  ,
                    new IllustrationConfig(){ prefab = "Monster_HeiYue" }  ,



                    new IllustrationConfig(){ prefab = "Monster_100_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_101_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_102_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_103_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_104_TheBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_89_FinalBoss" }  ,
                    new IllustrationConfig(){ prefab = "Monster_110_FinalBoss" }  ,

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
                    ListMaterialConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.CharmConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.CharmConfig);
                if (data is not null)
                {
                    ListCharmConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.RareConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.RareConfig);
                if (data is not null)
                {
                    ListRareConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.AbilityBookConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.AbilityBookConfig);
                if (data is not null)
                {
                    ListAbilityBookConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.TreasureConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.TreasureConfig);
                if (data is not null)
                {
                    ListTreasureConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.EvoMaterialConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.EvoMaterialConfig);
                if (data is not null)
                {
                    ListEvoMaterialConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.ClothingConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.ClothingConfig);
                if (data is not null)
                {
                    ListClothingConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.MenuConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.MenuConfig);
                if (data is not null)
                {
                    ListMenuConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.EggConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.EggConfig);
                if (data is not null)
                {
                    ListEggConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.ItemRecipeConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.ItemRecipeConfig);
                if (data is not null)
                {
                    ListItemRecipeConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.FishLureConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.FishLureConfig);
                if (data is not null)
                {
                    ListFishLureConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.BuffConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.BuffConfig);
                if (data is not null)
                {
                    ListBuffConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.IllustrationConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.IllustrationConfig);
                if (data is not null)
                {
                    ListIllustrationConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.AbilityConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.AbilityConfig);
                if (data is not null)
                {
                    ListAbilityConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.CuisineConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.CuisineConfig);
                if (data is not null)
                {
                    ListCuisineConfig.Add(data);
                }
            }

            else if (enumSheetName == EnumSheetName.OrnamentConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.OrnamentConfig);
                if (data is not null)
                {
                    ListOrnamentConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.HarnessConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.HarnessConfig);
                if (data is not null)
                {
                    ListHarnessConfig.Add(data);
                }
            }


            //else if (enumSheetName == EnumSheetName.CustomItemConfig)
            //{
            //    var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.CustomItemConfig);
            //    if (data is not null)
            //    {
            //        ListCustomItemConfig.Add(data);
            //    }
            //}
            //else if (enumSheetName == EnumSheetName.CustomPackageConfig)
            //{
            //    var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.CustomPackageConfig);
            //    if (data is not null)
            //    {
            //        ListCustomPackageConfig.Add(data);
            //    }
            //}
            //else if (enumSheetName == EnumSheetName.CustomGroundConfig)
            //{
            //    var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.CustomGroundConfig);
            //    if (data is not null)
            //    {
            //        ListCustomGroundConfig.Add(data);
            //    }
            //}


            else if (enumSheetName == EnumSheetName.AVGAbilityConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.AVGAbilityConfig);
                if (data is not null)
                {
                    ListAVGAbilityConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.AVGMonsterConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.AVGMonsterConfig);
                if (data is not null)
                {
                    ListAVGMonsterConfig.Add(data);
                }
            }
            else if (enumSheetName == EnumSheetName.AVGPropConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.AVGPropConfig);
                if (data is not null)
                {
                    ListAVGPropConfig.Add(data);
                }
            }


            else if (enumSheetName == EnumSheetName.TaskMonsterConfig)
            {
                var data = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.TaskMonsterConfig);
                if (data is not null)
                {
                    ListTaskMonsterConfig.Add(data);
                }
            }

        }


        //public void UpdateMonsterList()
        //{
        //    foreach (var monster in this.ListTaskMonsterConfig)
        //    {
        //        var config = this.ListIllustrationConfig.Find(p => p.prefab == monster.prefab);
        //        if (config is null)
        //        {
        //            this.ListIllustrationConfig.Add(new IllustrationConfig() { prefab = monster.prefab });
        //        }
        //    }
        //}
    }


}
