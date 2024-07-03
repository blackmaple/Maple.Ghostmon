﻿using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maple.Ghostmon
{


    internal static class GhostmonGameContextExtensions
    {
        public static GameConfigStoreDTO GameConfigStore { get; } = new GameConfigStoreDTO();

        private static string[] SheetNames { get; } =
            [
        nameof(EnumSheetName.MaterialConfig)  ,
         nameof(EnumSheetName.CharmConfig ),

         nameof(EnumSheetName.RareConfig ),
         nameof(EnumSheetName.AbilityBookConfig),

         nameof(EnumSheetName.TreasureConfig ),
         nameof(EnumSheetName.ClothingConfig ),

         nameof(EnumSheetName.MenuConfig),
         nameof(EnumSheetName.EggConfig ),

         nameof(EnumSheetName.ItemRecipeConfig ),
         nameof(EnumSheetName.FishLureConfig ),


         nameof(EnumSheetName.BuffConfig ),
         nameof(EnumSheetName.IllustrationConfig ),

            ];

        static bool LikeConfig(ReadOnlySpan<char> keyName, out EnumSheetName sheetName)
        {
            foreach (var name in SheetNames)
            {
                if (name.AsSpan().Equals(keyName, StringComparison.OrdinalIgnoreCase))
                {
                    if (Enum.TryParse(name, out sheetName))
                    {
                        return true;
                    }
                }
            }
            sheetName = EnumSheetName.None;
            return false;
        }

        public static bool LoadGameConfigStore(this GhostmonGameContext @this)
        {

            if (false == SpinWait.SpinUntil(() => @this.ConfigDataStore.CFG_LOADED, 5000))
            {
                return default;
            }
            var dicConfig = @this.ConfigDataStore.CONFIG_STORE;
            if (false == dicConfig.Valid())
            {
                return default;
            }

            foreach (var dic in dicConfig.AsRefArray())
            {
                var keyName = dic.Key.AsReadOnlySpan();
                if (false == LikeConfig(keyName, out var enumSheetName))
                {
                    continue;
                }
                var val = dic.Value;
                if (false == val.Valid())
                {
                    continue;
                }

                foreach (var kvp in val.AsRefArray())
                {
                    var kVal = kvp.Value;
                    if (false == kVal.Valid())
                    {
                        continue;
                    }
                    var json = kvp.Value.TO_STRING_00().AsReadOnlySpan();
                    GameConfigStore.Add(json, enumSheetName);
                }
            }

            return true;
        }
        public static int LoadListMonsterConfig(this GhostmonGameContext @this)
        {
            var listIllustrationConfig = GameConfigStore.ListIllustrationConfig;
            foreach (var illustration in listIllustrationConfig)
            {
                var prefab = illustration.prefab;
                if (false == string.IsNullOrEmpty(prefab))
                {
                    var monsterName = @this.T(illustration.prefab!);
                    _ = ConfigDataStore.Ptr_ConfigDataStore.GET_MONSTER_CONFIG(out _, monsterName);
                }
            }
            //加个延迟等待task完成
            Thread.Sleep(2000);
            var monsterConfig = @this.ConfigDataStore.MONSTER_CFG_STORE;
            if (monsterConfig.Valid())
            {
                return monsterConfig.AsRef().Count - monsterConfig.AsRef().FreeCount;
            }
            return default;
        }


        [Description("对游戏UniTask的解析存在游戏崩溃的情况?")]
        public static IReadOnlyList<MonsterObject.Ptr_MonsterObject> GetListMonsterConfig(this GhostmonGameContext @this)
        {
            var listIllustrationConfig = GameConfigStore.ListIllustrationConfig;
            var count = listIllustrationConfig.Count;
            var uniTasks = (stackalloc Ref_UniTask<MonsterObject.Ptr_MonsterObject>[count]);
            for (int i = 0; i < count; ++i)
            {
                var monsterName = @this.T(listIllustrationConfig[i % count].prefab!);
                ref var uniTask = ref uniTasks[i % count];
                _ = ConfigDataStore.Ptr_ConfigDataStore.GET_MONSTER_CONFIG(out uniTask, monsterName);
            }
            //延迟2S等待异步完成
            Thread.Sleep(2000);
            List<MonsterObject.Ptr_MonsterObject> list = new(count);
            foreach (ref var uniTask in uniTasks)
            {
                var ret = uniTask.GetResult_State<Ref_LoadMonsterObjectArgs>();
                if (ret)
                {
                    list.Add(ret);
                }
            }


            return list;
        }

        [Description("对游戏UniTask的解析存在游戏崩溃的情况?")]
        public static IReadOnlyList<UnitySpriteData> LoadListMonsterAvater(this GhostmonGameContext @this, IReadOnlyList<MonsterObject.Ptr_MonsterObject> monsterObjects)
        {
            const string atlasName = "MonsterAvaterUIAtlas";
            const string spriteName_Suffix = "_Head";
            var pAtlasName = @this.T(atlasName);
            var count = monsterObjects.Count;
            List<UnitySpriteData> list = new(count);
            var uniTasks = (stackalloc Ref_UniTask<Sprite.Ptr_Sprite>[count]);
            for (int i = 0; i < count; ++i)
            {
                var prefab = monsterObjects[i % count].M_PREFAB.ToString();

                list.Add(new UnitySpriteData() { Category = "Monster", Name = prefab, });

                var spriteName = $"{prefab}{spriteName_Suffix}";
                var pSpriteName = @this.T(spriteName);
                ref var uniTask = ref uniTasks[i % count];
                _ = LoadUtils.Ptr_LoadUtils.LOAD_SPRITE_ASYNC(out uniTask, pAtlasName, pSpriteName);
            }

            Thread.Sleep(2000);
            for (int i = 0; i < count; ++i)
            {
                ref var uniTask = ref uniTasks[i % count];
                var ret = uniTask.GetResult_State<Ref_LoadSpriteArgs>();
                if (ret.Valid())
                {
                    list[i % count].Ptr_Sprite = ret;
                }
            }


            return list;
        }

        public static IEnumerable<UnitySpriteImageData> LoadListUnitySpriteImageData(this GhostmonGameContext @this, UnityEngineContext unityEngine, IReadOnlyList<UnitySpriteData> spriteDatas)
        {
            foreach (UnitySpriteData spriteData in spriteDatas)
            {
                if (false == spriteData.Ptr_Sprite.Valid())
                {
                    continue;
                }



                var pIconData = unityEngine.ReadSprite2Png2(spriteData.Ptr_Sprite);

                if (pIconData.Valid())
                {

                    yield return new UnitySpriteImageData()
                    {
                        Category = spriteData.Category,
                        Name = spriteData.Name,
                        ImageData = pIconData,
                    };
                }
                //yield break;
            }
        }


        public static bool TryGetMonsterObject(this GhostmonGameContext @this, string monsterName, out MonsterObject.Ptr_MonsterObject monsterObject)
        {
            Unsafe.SkipInit(out monsterObject);
            var pMonsterConfig = @this.ConfigDataStore.MONSTER_CFG_STORE;
            foreach (var monster in pMonsterConfig.AsRefArray())
            {
                @this.Logger.LogInformation("monster.Key:{key}", monster.Key.ToString());
                if (monster.Key.AsReadOnlySpan().StartsWith(monsterName))
                {
                    monsterObject = monster.Value;
                    return monsterObject;
                }
            }
            return default;
        }

        public static void Test(this GhostmonGameContext @this)
        {
            var userDataMgr = @this.UserDataManager.INSTANCE;
            if (userDataMgr)
            {
                @this.Logger.LogInformation("userDataMgr=>{userDataMgr}", userDataMgr);
                if (@this.TryGetMonsterObject("Monster_64_1", out var monsterObject))
                {
                    @this.Logger.LogInformation("Monster_64_1=>{Monster_64_1}", monsterObject);
                    var monsterData = @this.MonsterData.New(false);
                    monsterData.CTOR(monsterObject, 1, 0, false);
                    monsterData.GET_ABILITIES();

                    userDataMgr.SET_MONSTER_INFO(monsterData);
                    userDataMgr.ADD_MONSTER(monsterData);
                    monsterData.SET_SHINER(monsterObject);
                    monsterData.U_VARI_COLOR = true;
                }
                else
                {
                    @this.Logger.LogInformation("err Monster_64_1=>{err}", 0);

                }
            }


        }


        //public static void AddBubblingPopUp(this GhostmonGameContext @this, string? msg)
        //{
        //    if (string.IsNullOrEmpty(msg))
        //    {
        //        return;
        //    }
        //    var p = @this.UIMsgControl.INSTANCE;
        //    if (p)
        //    {
        //        var txt = @this.T(msg);
        //        p.ADD_BUBBLING_POP_UP(txt, 0);
        //    }
        //}

        public static void PlayMessage(this GhostmonGameContext @this, string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            var p = @this.UIMsgControl.INSTANCE;
            if (p)
            {
                var txt = @this.T(msg);
                p.PLAY_MESSAGE(txt, 0);
            }
        }
        public static UserDataManager.Ptr_UserDataManager GetUserDataManager(this GhostmonGameContext @this)
        {
            var userDataManager = @this.UserDataManager.INSTANCE;
            if (false == userDataManager)
            {
               return GameException.Throw<UserDataManager.Ptr_UserDataManager>("Please enter the game first (0)");
            }
            return userDataManager;
        }

        public static UserData.Ptr_UserData GetUserData(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager)
        {
            var userData = userDataManager.USER_DATA;
            if (false == userData)
            {
                GameException.Throw<UserDataManager.Ptr_UserDataManager>("Please enter the game first (1)");
            }
            return userData;
        }

        public static GameCurrencyDisplayDTO[] GetListCurrencyDisplay(this GhostmonGameContext @this)
        {
            return [
            new GameCurrencyDisplayDTO()
            {
                ObjectId  = EnumSheetName.GEM.ToString(),
                DisplayCategory= EnumSheetName.GEM.ToString(),
                DisplayName= "灵石".ToString(),
                DisplayDesc= "灵石由特殊的矿石加工而成，比金币更加稀有，具有特殊的力量，可在修行台吸收，也可在特殊商店处交易物品。",

            },
            new GameCurrencyDisplayDTO()
            {   ObjectId  = EnumSheetName.COIN.ToString(),
                DisplayCategory= EnumSheetName.COIN.ToString(),
                DisplayName= "金币".ToString(),
                DisplayDesc= "金币由特殊的矿石加工而成，作为通用的货币，可在所有商人处购买物品。",
            },
            new GameCurrencyDisplayDTO()
            {   ObjectId  = EnumSheetName.REIKI.ToString(),
                DisplayCategory= EnumSheetName.REIKI.ToString(),
                DisplayName= "灵气".ToString(),
                DisplayDesc= "战斗结束后，出战妖精损失的生命将通过御妖师的灵气进行补充。灵龛和野外神像都可恢复灵气。灵气上限随御妖师等阶提升而上升。",
            }
            ];
        }
        public static GameCurrencyInfoDTO GetCurrencyInfo(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCurrencyObjectDTO currencyObjectDTO)
        {

            var userData = @this.GetUserData(userDataManager);

            if (currencyObjectDTO.CurrencyObject == EnumSheetName.GEM.ToString())
            {
                return new GameCurrencyInfoDTO() { ObjectId = currencyObjectDTO.CurrencyObject, DisplayValue = userData.GEM_NUM.ToString() };
            }
            if (currencyObjectDTO.CurrencyObject == EnumSheetName.COIN.ToString())
            {
                return new GameCurrencyInfoDTO() { ObjectId = currencyObjectDTO.CurrencyObject, DisplayValue = userData.COIN_NUM.ToString() };
            }
            if (currencyObjectDTO.CurrencyObject == EnumSheetName.REIKI.ToString())
            {
                return new GameCurrencyInfoDTO() { ObjectId = currencyObjectDTO.CurrencyObject, DisplayValue = userData.REIKI.ToString() };
            }
            return GameException.Throw<GameCurrencyInfoDTO>($"{currencyObjectDTO.CurrencyObject} NOT FOUND");

        }
        public static GameCurrencyInfoDTO UpdateCurrencyInfo(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCurrencyModifyDTO currencyModifyDTO)
        {
            var userData = @this.GetUserData(userDataManager);

            if (currencyModifyDTO.CurrencyObject == EnumSheetName.GEM.ToString())
            {
                if (int.TryParse(currencyModifyDTO.NewValue, out var result))
                {
                    userData.GEM_NUM = result;
                }
                return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, DisplayValue = userData.GEM_NUM.ToString() };
            }
            if (currencyModifyDTO.CurrencyObject == EnumSheetName.COIN.ToString())
            {
                if (int.TryParse(currencyModifyDTO.NewValue, out var result))
                {
                    userData.COIN_NUM = result;
                }
                return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, DisplayValue = userData.COIN_NUM.ToString() };
            }
            if (currencyModifyDTO.CurrencyObject == EnumSheetName.REIKI.ToString())
            {
                if (float.TryParse(currencyModifyDTO.NewValue, out var result))
                {
                    userData.REIKI = result;
                }
                return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, DisplayValue = userData.REIKI.ToString() };
            }
            return GameException.Throw<GameCurrencyInfoDTO>($"{currencyModifyDTO.CurrencyObject} NOT FOUND");

        }



        public static IEnumerable<GameInventoryDisplayDTO> GetListInventoryDisplay(this GhostmonGameContext @this)
        {
            foreach (var config in GameConfigStore.ListMaterialConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.MaterialConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.makeTime), CanPreview = true, DisplayName = nameof(config.makeTime), DisplayValue = config.makeTime.ToString() },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListCharmConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.CharmConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.cooldown), CanPreview = true, DisplayName = nameof(config.cooldown), DisplayValue = config.cooldown.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.rank), CanPreview = true, DisplayName = nameof(config.rank), DisplayValue = config.rank.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.type), CanPreview = true, DisplayName = nameof(config.type), DisplayValue = config.type.ToString() },

                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListRareConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.RareConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.favorability), CanPreview = true, DisplayName = nameof(config.favorability), DisplayValue = config.favorability.ToString() },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListAbilityBookConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.AbilityBookConfig.ToString(),
                    DisplayDesc = config.abilityDesc,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.rank), CanPreview = true, DisplayName = nameof(config.rank), DisplayValue = config.rank.ToString() },
                //    new GameValueInfoDTO() { ObjectId = nameof(config.abilityDesc), CanPreview = true, DisplayName = nameof(config.abilityDesc), DisplayValue = config.abilityDesc },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListTreasureConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.TreasureConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.exp), CanPreview = true, DisplayName = nameof(config.exp), DisplayValue = config.exp.ToString() },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListClothingConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.ClothingConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
                    new GameValueInfoDTO() { ObjectId = nameof(config.type), CanPreview = true, DisplayName = nameof(config.type), DisplayValue = config.type.ToString() },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListMenuConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.MenuConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
       //             new GameValueInfoDTO() { ObjectId = nameof(config.unlock), CanPreview = true, DisplayName = nameof(config.unlock), DisplayValue = config.unlock.ToString() },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListEggConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.EggConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
           //         new GameValueInfoDTO() { ObjectId = nameof(config.monster), CanPreview = true, DisplayName = nameof(config.monster), DisplayValue = config.monster.ToString() },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListItemRecipeConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.ItemRecipeConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [
                    new GameValueInfoDTO() { ObjectId = nameof(config.itemID), CanPreview = true, DisplayName = nameof(config.itemID), DisplayValue = config.itemID.ToString() },
                    ]
                };
                yield return data;
            }

            foreach (var config in GameConfigStore.ListFishLureConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.FishLureConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [

                    new GameValueInfoDTO() { ObjectId = nameof(config.material), CanPreview = true, DisplayName = nameof(config.material), DisplayValue = config.material },
                    new GameValueInfoDTO() { ObjectId = nameof(config.price), CanPreview = true, DisplayName = nameof(config.price), DisplayValue = config.price.ToString() },
                    ]
                };
                yield return data;
            }

        }

        public static GameInventoryInfoDTO GetInventoryInfo(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameInventoryObjectDTO inventoryObjectDTO)
        {
            var userData = @this.GetUserData(userDataManager);
            if (false == Enum.TryParse<EnumSheetName>(inventoryObjectDTO.InventoryCategory, out var result))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryCategory}");
            }
            if (false == ulong.TryParse(inventoryObjectDTO.InventoryObject, out var configId))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryObject}");
            }

            var count = 0;
            if (result == EnumSheetName.MaterialConfig)
            {

                foreach (var data in userData.TOTAL_MATERIALS)
                {
                    if (data.CONFIG_ID == configId)
                    {
                        count = data.COUNT;
                        break;
                    }
                }
            }
            else if (result == EnumSheetName.CharmConfig)
            {

                foreach (var data in userData.TOTAL_CHARMS.AsRefArray())
                {
                    if (data.Key == configId && data.Value.Valid())
                    {
                        count = data.Value.NUM;
                        break;
                    }
                }
            }
            else if (result == EnumSheetName.RareConfig)
            {
                foreach (var data in userData.TOTAL_RARE)
                {
                    if (data.CONFIG_ID == configId)
                    {
                        count = data.NUM;
                        break;
                    }
                }
            }
            else if (result == EnumSheetName.AbilityBookConfig)
            {
                foreach (var data in userData.TOTAL_ABILITY_BOOKS.AsRefArray())
                {
                    if (data.Key == configId && data.Value.Valid())
                    {
                        count = data.Value.NUM;
                    }
                }
            }
            else if (result == EnumSheetName.TreasureConfig)
            {
                foreach (var data in userData.TOTAL_TREASURE)
                {
                    if (data.CONFIG_ID == configId)
                    {
                        count = data.NUM;
                    }
                }
            }
            else if (result == EnumSheetName.ClothingConfig)
            {
                foreach (var data in userData.TOTAL_CLOTHING)
                {
                    if (data == configId)
                    {
                        count = 1;
                        break;
                    }
                }
            }
            else if (result == EnumSheetName.MenuConfig)
            {

                foreach (var data in userData.TOTAL_MENU.AsRefArray())
                {
                    if (data.Value == configId)
                    {
                        count = 1;
                        break;
                    }
                }
            }
            else if (result == EnumSheetName.EggConfig)
            {
                foreach (var data in userData.TOTAL_EGG.AsRefArray())
                {
                    var egg = data.Value;
                    if (egg.Valid() && egg.CONFIG_ID == configId)
                    {
                        count++;
                    }
                }
            }
            else if (result == EnumSheetName.ItemRecipeConfig)
            {

                foreach (var data in userData.TOTAL_ITEM_RECIPE.AsRefArray())
                {
                    if (data.Key == configId)
                    {
                        count = 1;
                    }
                }
            }
            else if (result == EnumSheetName.FishLureConfig)
            {
                foreach (var data in userData.TOTAL_FISH_LURE.AsRefArray())
                {
                    if (data.Key == configId && data.Value)
                    {
                        count = data.Value.NUM;
                    }
                }
            }
            else
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryObject}");
            }

            return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject, InventoryCount = count };

        }

        public static GameInventoryInfoDTO UpdateInventoryInfo(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameInventoryModifyDTO inventoryModifyDTO)
        {
            var userData = @this.GetUserData(userDataManager);
            if (false == Enum.TryParse<EnumSheetName>(inventoryModifyDTO.InventoryCategory, out var result))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryCategory}");
            }
            if (false == ulong.TryParse(inventoryModifyDTO.InventoryObject, out var configId))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryObject}");
            }

            var count = inventoryModifyDTO.InventoryCount;

            if (result == EnumSheetName.EggConfig)
            {
                var eggCount = 0;
                foreach (var data in userData.TOTAL_EGG.AsRefArray())
                {
                    var egg = data.Value;
                    if (egg.Valid() && egg.CONFIG_ID == configId)
                    {
                        eggCount++;
                    }
                }
                count -= eggCount;
            }

            if (count < 0)
            {
                return GameException.Throw<GameInventoryInfoDTO>($"REMOVE ERROR {inventoryModifyDTO.InventoryCategory}");
            }

            userDataManager.GAIN_ITEM((int)result, configId, count);

            return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = count };

        }



    }


}
