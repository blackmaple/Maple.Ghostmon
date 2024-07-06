using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Maple.Ghostmon
{


    internal static class GhostmonGameContextExtensions
    {
        const string atlasName = "MonsterAvaterUIAtlas";
        const string spriteName_Suffix = "_Head";
        const string skill_Suffix = "_Skill";
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

         nameof(EnumSheetName.AbilityConfig ),

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
        public static int LoadListMonsterInfo(this GhostmonGameContext @this)
        {
            var listIllustrationConfig = GameConfigStore.ListIllustrationConfig;
            var suffix = @this.T(skill_Suffix);

            foreach (var illustration in listIllustrationConfig)
            {
                var prefab = illustration.prefab;
                if (false == string.IsNullOrEmpty(prefab))
                {
                    var monsterName = @this.T(prefab);
                    _ = ConfigDataStore.Ptr_ConfigDataStore.GET_MONSTER_CONFIG(out _, monsterName);
                    _ = ConfigDataStore.Ptr_ConfigDataStore.GET_SKILL_CONFIG(out _, monsterName, suffix);

                }
            }
            //加个延迟等待task完成
            Thread.Sleep(2000);
            var monsterConfig = @this.ConfigDataStore.MONSTER_CFG_STORE;
            var skillConfig = @this.ConfigDataStore.SKILL_CFG_STORE;
            var count = 0;
            if (monsterConfig.Valid())
            {
                count += monsterConfig.AsRef().Size;
            }
            if (skillConfig.Valid())
            {
                count += skillConfig.AsRef().Size;
            }
            return count;
        }
        //public static int LoadListSkillConfig(this GhostmonGameContext @this)
        //{ 

        //}
        public static T_SKILL_OBJECT GetSkillObject<T_SKILL_OBJECT>(this GhostmonGameContext @this, PMonoString name)
            where T_SKILL_OBJECT : unmanaged
        {
            foreach (var skill in @this.ConfigDataStore.SKILL_CFG_STORE.AsRefArray())
            {
                if (skill.Key.AsReadOnlySpan().StartsWith(name.AsReadOnlySpan()))
                {
                    var skillObject = skill.Value;
                    return Unsafe.As<SkillObject.Ptr_SkillObject, T_SKILL_OBJECT>(ref skillObject);
                }
            }
            return default;
            ////var suffix = @this.T(skill_Suffix);
            ////_ = ConfigDataStore.Ptr_ConfigDataStore.GET_SKILL_CONFIG(out var ref_UniTask, name, suffix);
            ////Thread.Sleep(1500);
            ////var skillObject = ref_UniTask.GetResult_State<Ref_LoadSkillArgs>();
            ////
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
        public static UserData.Ptr_UserData GetUserData(this UserDataManager.Ptr_UserDataManager userDataManager)
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

            var userData = userDataManager.GetUserData();
            if (false == Enum.TryParse<EnumSheetName>(currencyObjectDTO.CurrencyObject, out var obj))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {currencyObjectDTO.CurrencyObject}");
            }
            string count;
            if (obj == EnumSheetName.GEM)
            {
                count = userData.GEM_NUM.ToString();
            }
            else if (obj == EnumSheetName.COIN)
            {
                count = userData.COIN_NUM.ToString();
            }
            else if (obj == EnumSheetName.REIKI)
            {
                count = userData.REIKI.ToString();
            }
            else
            {
                count = string.Empty;
            }
            return new GameCurrencyInfoDTO() { ObjectId = currencyObjectDTO.CurrencyObject, DisplayValue = count };
        }
        public static GameCurrencyInfoDTO UpdateCurrencyInfo(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCurrencyModifyDTO currencyModifyDTO)
        {
            var userData = userDataManager.GetUserData();
            if (false == Enum.TryParse<EnumSheetName>(currencyModifyDTO.CurrencyObject, out var obj))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {currencyModifyDTO.CurrencyObject}");
            }

            if (obj == EnumSheetName.GEM)
            {
                userData.GEM_NUM = currencyModifyDTO.IntValue;
            }
            else if (obj == EnumSheetName.COIN)
            {
                userData.COIN_NUM = currencyModifyDTO.IntValue;
            }
            else if (obj == EnumSheetName.REIKI)
            {
                userData.REIKI = currencyModifyDTO.FloatValue;
            }

            @this.PlayMessage($"{obj}:{currencyModifyDTO.NewValue}");

            return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, DisplayValue = currencyModifyDTO.NewValue };

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
        private static int GetInventoryCount(UserData.Ptr_UserData userData, EnumSheetName category, ulong configId)
        {
            int count = 0;
            if (category == EnumSheetName.MaterialConfig)
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
            else if (category == EnumSheetName.CharmConfig)
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
            else if (category == EnumSheetName.RareConfig)
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
            else if (category == EnumSheetName.AbilityBookConfig)
            {
                foreach (var data in userData.TOTAL_ABILITY_BOOKS.AsRefArray())
                {
                    if (data.Key == configId && data.Value.Valid())
                    {
                        count = data.Value.NUM;
                    }
                }
            }
            else if (category == EnumSheetName.TreasureConfig)
            {
                foreach (var data in userData.TOTAL_TREASURE)
                {
                    if (data.CONFIG_ID == configId)
                    {
                        count = data.NUM;
                    }
                }
            }
            else if (category == EnumSheetName.ClothingConfig)
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
            else if (category == EnumSheetName.MenuConfig)
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
            else if (category == EnumSheetName.EggConfig)
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
            else if (category == EnumSheetName.ItemRecipeConfig)
            {

                foreach (var data in userData.TOTAL_ITEM_RECIPE.AsRefArray())
                {
                    if (data.Key == configId)
                    {
                        count = 1;
                    }
                }
            }
            else if (category == EnumSheetName.FishLureConfig)
            {
                foreach (var data in userData.TOTAL_FISH_LURE.AsRefArray())
                {
                    if (data.Key == configId && data.Value)
                    {
                        count = data.Value.NUM;
                    }
                }
            }
            return count;
        }
        public static GameInventoryInfoDTO GetInventoryInfo(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameInventoryObjectDTO inventoryObjectDTO)
        {
            if (false == Enum.TryParse<EnumSheetName>(inventoryObjectDTO.InventoryCategory, out var category))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryCategory}");
            }
            if (false == ulong.TryParse(inventoryObjectDTO.InventoryObject, out var configId))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryObject}");
            }

            var userData = userDataManager.GetUserData();
            var count = GetInventoryCount(userData, category, configId);
            return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject, InventoryCount = count };
        }
        public static GameInventoryInfoDTO UpdateInventoryInfo(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameInventoryModifyDTO inventoryModifyDTO)
        {
            if (false == Enum.TryParse<EnumSheetName>(inventoryModifyDTO.InventoryCategory, out var category))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryCategory}");
            }
            if (false == ulong.TryParse(inventoryModifyDTO.InventoryObject, out var configId))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryObject}");
            }
            var userData = userDataManager.GetUserData();
            var oldCount = GetInventoryCount(userData, category, configId);
            var newCount = inventoryModifyDTO.InventoryCount;
            var addCount = newCount - oldCount;
            if (addCount <= 0)
            {
                return GameException.Throw<GameInventoryInfoDTO>($"REMOVE ERROR {inventoryModifyDTO.InventoryCategory}");
            }
            userDataManager.GAIN_ITEM((int)category, configId, addCount);
            @this.PlayMessage($"{category}:{inventoryModifyDTO.NewValue}");
            return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = newCount };

        }


        public static IEnumerable<GameCharacterDisplayDTO> GetListCharacterDisplay(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager)
        {
            var userData = userDataManager.GetUserData();
            yield return new GameCharacterDisplayDTO()
            {
                ObjectId = EnumSheetName.Player.ToString(),
                DisplayCategory = EnumSheetName.Player.ToString(),
                DisplayName = userData.PLAYER_NAME.ToString(),
                DisplayDesc = userData.PLAYER_NAME.ToString(),
                CharacterAttributes = [
                        new GameValueInfoDTO(){ObjectId = nameof(userData.LEV_RANK),DisplayName =  nameof(userData.LEV_RANK),DisplayValue = userData.LEV_RANK.ToString() ,CanPreview = true, },
                        new GameValueInfoDTO(){ObjectId = nameof(userData.RANK_VALUE),DisplayName =  nameof(userData.RANK_VALUE),DisplayValue = userData.RANK_VALUE.ToString(),CanWrite = true },
                        new GameValueInfoDTO(){ObjectId = nameof(userData.TOTAL_RANK_VALUE),DisplayName =  nameof(userData.TOTAL_RANK_VALUE),DisplayValue = userData.TOTAL_RANK_VALUE.ToString(), },
                        new GameValueInfoDTO(){ObjectId = nameof(userData.LEV_SEAL),DisplayName =  nameof(userData.LEV_SEAL),DisplayValue = userData.LEV_SEAL.ToString(),CanPreview = true, },
                        ]
            };
            foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
            {
                var monster = total.Value;
                yield return new GameCharacterDisplayDTO()
                {
                    ObjectId = total.Key.ToString(),
                    DisplayCategory = EnumSheetName.Monster.ToString(),
                    DisplayName = monster.U_NAME.ToString(),
                    DisplayDesc = ConfigDataStore.Ptr_ConfigDataStore.GET_LANGUAGE_TEXT(monster.U_PROFESSIONAL).ToString(),
                    CharacterAttributes = [
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_VARI_COLOR),DisplayName =  nameof(monster.U_VARI_COLOR),DisplayValue = monster.U_VARI_COLOR.ToString()  },
                         new GameValueInfoDTO(){ObjectId = nameof(monster.U_FLASH),DisplayName =  nameof(monster.U_FLASH),DisplayValue = monster.U_FLASH.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_LEVEL),DisplayName =  nameof(monster.U_LEVEL),DisplayValue = monster.U_LEVEL.ToString(),CanPreview = true,  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_EXP),DisplayName =  nameof(monster.U_EXP),DisplayValue = monster.U_EXP.ToString() ,CanWrite = true },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_TOTAL_EXP),DisplayName =  nameof(monster.U_TOTAL_EXP),DisplayValue = monster.U_TOTAL_EXP.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_FAVORABILITY),DisplayName =  nameof(monster.U_FAVORABILITY),DisplayValue = monster.U_FAVORABILITY.ToString(),CanWrite= true },

                        ]
                };
            }

        }
        public static GameCharacterStatusDTO GetCharacterStatus(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCharacterObjectDTO characterObjectDTO)
        {
            var userData = userDataManager.GetUserData();
            if (characterObjectDTO.CharacterId == EnumSheetName.Player.ToString())
            {
                return new GameCharacterStatusDTO()
                {
                    ObjectId = characterObjectDTO.CharacterId,
                    CharacterAttributes = [
                        new GameValueInfoDTO(){ObjectId = nameof(userData.LEV_RANK),DisplayName =  nameof(userData.LEV_RANK),DisplayValue = userData.LEV_RANK.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(userData.RANK_VALUE),DisplayName =  nameof(userData.RANK_VALUE),DisplayValue = userData.RANK_VALUE.ToString(),CanWrite = true },
                        new GameValueInfoDTO(){ObjectId = nameof(userData.TOTAL_RANK_VALUE),DisplayName =  nameof(userData.TOTAL_RANK_VALUE),DisplayValue = userData.TOTAL_RANK_VALUE.ToString(), },
                        new GameValueInfoDTO(){ObjectId = nameof(userData.LEV_SEAL),DisplayName =  nameof(userData.LEV_SEAL),DisplayValue = userData.LEV_SEAL.ToString(), },
                        ]
                };
            }
            else
            {
                foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
                {
                    if (total.Key == characterObjectDTO.UCharacterId && total.Value.Valid())
                    {
                        var monster = total.Value;
                        return new GameCharacterStatusDTO()
                        {
                            ObjectId = characterObjectDTO.CharacterId,
                            CharacterAttributes = [
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_VARI_COLOR),DisplayName =  nameof(monster.U_VARI_COLOR),DisplayValue = monster.U_VARI_COLOR.ToString() ,CanWrite = true },
                         new GameValueInfoDTO(){ObjectId = nameof(monster.U_FLASH),DisplayName =  nameof(monster.U_FLASH),DisplayValue = monster.U_FLASH.ToString()  ,CanWrite = true},
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_LEVEL),DisplayName =  nameof(monster.U_LEVEL),DisplayValue = monster.U_LEVEL.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_EXP),DisplayName =  nameof(monster.U_EXP),DisplayValue = monster.U_EXP.ToString() ,CanWrite = true },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_TOTAL_EXP),DisplayName =  nameof(monster.U_TOTAL_EXP),DisplayValue = monster.U_TOTAL_EXP.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_FAVORABILITY),DisplayName =  nameof(monster.U_FAVORABILITY),DisplayValue = monster.U_FAVORABILITY.ToString(),CanWrite= true },

                        ]
                        };
                    }
                }
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
        }
        public static GameCharacterModifyDTO UpdateCharacterStatus(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCharacterModifyDTO characterModifyDTO)
        {
            var userData = userDataManager.GetUserData();
            if (characterModifyDTO.CharacterId == EnumSheetName.Player.ToString())
            {
                if (characterModifyDTO.ModifyObject == nameof(userData.RANK_VALUE))
                {
                    userData.RANK_VALUE = characterModifyDTO.IntValue;
                    return characterModifyDTO;
                }
            }
            else
            {
                foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
                {
                    if (total.Key == characterModifyDTO.UCharacterId && total.Value.Valid())
                    {
                        var monster = total.Value;
                        if (characterModifyDTO.ModifyObject == nameof(monster.U_EXP))
                        {
                            monster.U_EXP = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_FAVORABILITY))
                        {
                            monster.U_FAVORABILITY = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_FLASH))
                        {
                            var flash = characterModifyDTO.BoolValue ?? false;
                            if (flash)
                            {
                                monster.U_FLASH = true;
                            //    monster.gra
                            }
                            else
                            { 
                            
                            }
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_VARI_COLOR))
                        { 
                            
                        }
                        return characterModifyDTO;
                    }
                }
            }
            return GameException.Throw<GameCharacterModifyDTO>($"NOT FOUND {characterModifyDTO.UCharacterId}:{characterModifyDTO.ModifyObject}");
        }

        public static GameCharacterEquipmentDTO GetCharacterEquipment(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCharacterObjectDTO characterObjectDTO)
        {
            var userData = userDataManager.GetUserData();
            if (characterObjectDTO.CharacterId == EnumSheetName.Player.ToString())
            {
                return new GameCharacterEquipmentDTO()
                {
                    ObjectId = characterObjectDTO.CharacterId,
                    EquipmentInfos = [],
                };
            }
            else
            {
                foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
                {
                    if (total.Key == characterObjectDTO.UCharacterId)
                    {


                        return new GameCharacterEquipmentDTO()
                        {
                            ObjectId = characterObjectDTO.CharacterId,
                            EquipmentInfos = []
                        };
                    }
                }
            }
            return GameException.Throw<GameCharacterEquipmentDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");


        }
        public static GameCharacterSkillDTO GetCharacterSkill(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCharacterObjectDTO characterObjectDTO)
        {
            var userData = userDataManager.GetUserData();
            if (characterObjectDTO.CharacterId == EnumSheetName.Player.ToString())
            {
                return new GameCharacterSkillDTO()
                {
                    ObjectId = characterObjectDTO.CharacterId,
                    SkillInfos = [],
                };
            }
            else
            {
                foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
                {
                    if (total.Key == characterObjectDTO.UCharacterId && total.Value.Valid())
                    {
                        return new GameCharacterSkillDTO()
                        {
                            ObjectId = characterObjectDTO.CharacterId,
                            SkillInfos = GetListSkill(@this, total.Value),

                        };
                    }
                }
            }
            return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
            GameSkillInfoDTO[] GetListSkill(GhostmonGameContext @this, MonsterData.Ptr_MonsterData monsterData)
            {
                var skillId = EnumSheetName.Skill.ToString();
                var ability = EnumSheetName.AbilityConfig.ToString();
                GameSkillInfoDTO[] skillInfos =
                [
                    new (){ ObjectId = skillId,DisplayCategory = skillId},

                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},

                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},


                ];

                var skillObject = @this.GetSkillObject<USkillObject.Ptr_USkillObject>(monsterData.U_PREFAB);
                if (skillObject)
                {
                    var name = ConfigDataStore.Ptr_ConfigDataStore.GET_LANGUAGE_TEXT(skillObject.S_NAME);
                    var desc = ConfigDataStore.Ptr_ConfigDataStore.GET_LANGUAGE_TEXT(skillObject.S_DESCRIPTION);

                    skillInfos[0].DisplayName = name.ToString();
                    skillInfos[0].DisplayDesc = desc.ToString();
                }
                else
                {

                    skillInfos[0].DisplayName = "???";
                    skillInfos[0].DisplayDesc = "???";
                }

                int abilityIndex = 1;
                if (monsterData.U_ABILITIES.Valid())
                {
                    foreach (var item in monsterData.U_ABILITIES)
                    {
                        var skill = GameConfigStore.ListAbilityConfig.Find(p => p.configID == item);
                        if (skill is not null)
                        {
                            var skillInfo = skillInfos[abilityIndex];
                            skillInfo.ObjectId = skill.configID.ToString();
                            skillInfo.DisplayName = skill.name;
                            skillInfo.DisplayDesc = skill.description;
                            ++abilityIndex;
                        }
                    }
                }

                return skillInfos;
            }

        }


        public static IEnumerable<GameMonsterDisplayDTO> GetListMonsterDisplay(this GhostmonGameContext @this)
        {
            var category = EnumSheetName.Monster.ToString();
            foreach (var monsterData in @this.ConfigDataStore.MONSTER_CFG_STORE.AsRefArray())
            {
                var monster = monsterData.Value;
                var prefab = monster.M_PREFAB.ToString();
                if (false == string.IsNullOrEmpty(prefab))
                {
                    var skillId = EnumSheetName.Skill.ToString();
                    var name = ConfigDataStore.Ptr_ConfigDataStore.GET_LANGUAGE_TEXT(monster.M_TITLE).ToString();
                    yield return new GameMonsterDisplayDTO()
                    {
                        ObjectId = prefab,
                        DisplayName = name,
                        DisplayCategory = category,
                        DisplayDesc = name,
                        MonsterAttributes = [
                            new (){ ObjectId = nameof(monster.M_RANK), DisplayName= nameof(monster.M_RANK),DisplayValue = monster.M_RANK.ToString(),CanPreview = true },
                            new (){ ObjectId = nameof(monster.BASE_CRIT), DisplayName= nameof(monster.BASE_CRIT),DisplayValue = monster.BASE_CRIT.ToString(),CanPreview = true },
                            new (){ ObjectId = nameof(monster.LEVEL_RANGE), DisplayName= nameof(monster.LEVEL_RANGE),DisplayValue = $"{monster.LEVEL_RANGE.m_X}~{monster.LEVEL_RANGE.m_Y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_HP), DisplayName= nameof(monster.GROWTH_HP),DisplayValue = $"{monster.GROWTH_HP.x}~{monster.GROWTH_HP.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_WP), DisplayName= nameof(monster.GROWTH_WP),DisplayValue = $"{monster.GROWTH_WP.x}~{monster.GROWTH_WP.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_ATK), DisplayName= nameof(monster.GROWTH_ATK),DisplayValue = $"{monster.GROWTH_ATK.x}~{monster.GROWTH_ATK.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_DEF), DisplayName= nameof(monster.GROWTH_DEF),DisplayValue = $"{monster.GROWTH_DEF.x}~{monster.GROWTH_DEF.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_MAGIC), DisplayName= nameof(monster.GROWTH_MAGIC),DisplayValue = $"{monster.GROWTH_MAGIC.x}~{monster.GROWTH_MAGIC.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_CRIT), DisplayName= nameof(monster.GROWTH_CRIT),DisplayValue = $"{monster.GROWTH_CRIT.x}~{monster.GROWTH_CRIT.y}",CanPreview = false },


                            ],
                        SkillInfos = [GetSkillInfo(monster)]
                    };
                }

            }

            GameSkillInfoDTO GetSkillInfo(MonsterObject.Ptr_MonsterObject monsterObject)
            {
                var skillId = EnumSheetName.Skill.ToString();
                var skillObject = @this.GetSkillObject<USkillObject.Ptr_USkillObject>(monsterObject.M_PREFAB);
                string? skillName;
                string? skillDesc;
                if (skillObject)
                {
                    skillName = ConfigDataStore.Ptr_ConfigDataStore.GET_LANGUAGE_TEXT(skillObject.S_NAME).ToString();
                    skillDesc = ConfigDataStore.Ptr_ConfigDataStore.GET_LANGUAGE_TEXT(skillObject.S_DESCRIPTION).ToString();

                }
                else
                {
                    skillName = "???";
                    skillDesc = "???";
                }
                return new GameSkillInfoDTO() { ObjectId = skillId, DisplayCategory = skillId, DisplayDesc = skillDesc, DisplayName = skillName };
            }
        }

        
    }


}
