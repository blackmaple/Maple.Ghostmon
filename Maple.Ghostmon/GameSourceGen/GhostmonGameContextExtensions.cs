using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Maple.Ghostmon.GhostmonGameContextExtensions;

namespace Maple.Ghostmon
{


    internal static class GhostmonGameContextExtensions
    {
        #region props+const
        const string MonsterAvaterUIAtlas = "MonsterAvaterUIAtlas";
        const string MonsterAvaterUIAtlas_Suffix = "_Head";

        const string Skill_Suffix = "_Skill";

        const string AbilityBookUIAtlas = "AbilityBookUIAtlas";

        const string MaterialUIAtlas = "MaterialUIAtlas";
        const string Icon_Prefix = "icon_";

        const string CharmItemUIAtlas = "CharmItemUIAtlas";

        public static GameConfigStoreDTO GameConfigStore { get; } = new GameConfigStoreDTO();

        #endregion

        #region LOAD CONFIG

        static bool AllowLoadConfig(ReadOnlySpan<char> keyName, out EnumSheetName sheetName)
        {
            if (Enum.TryParse(keyName, out sheetName))
            {
                return (int)sheetName < (int)EnumSheetName.MaxLoadConfig;
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
                var val = dic.Value;
                if (false == val.Valid())
                {
                    continue;
                }
                var keyName = dic.Key.AsReadOnlySpan();
                if (false == AllowLoadConfig(keyName, out var enumSheetName))
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
                    var json = kVal.TO_STRING_00().AsReadOnlySpan();
                    GameConfigStore.AddConfig(json, enumSheetName);
                }
            }

            return true;
        }
        public static int LoadListMonsterInfo(this GhostmonGameContext @this)
        {
            var listIllustrationConfig = GameConfigStore.ListIllustrationConfig;
            var suffix = @this.T(Skill_Suffix);
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
            Thread.Sleep(3000);
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
        #endregion

        #region help

        public static bool TryGetSkillObject<T_SKILL_OBJECT>(this GhostmonGameContext @this, ReadOnlySpan<char> name, out T_SKILL_OBJECT ptr_Skill)
        {
            Unsafe.SkipInit(out ptr_Skill);
            foreach (var skill in @this.ConfigDataStore.SKILL_CFG_STORE.AsRefArray())
            {
                //name_skill
                if (skill.Key.AsReadOnlySpan()[..^6].SequenceEqual(name))
                {
                    var skillObject = skill.Value;
                    ptr_Skill = Unsafe.As<SkillObject.Ptr_SkillObject, T_SKILL_OBJECT>(ref skillObject);
                    return skillObject.Valid();
                }
            }
            return default;
        }
        public static bool TryGetSkillObject<T_SKILL_OBJECT>(this GhostmonGameContext @this, PMonoString name, out T_SKILL_OBJECT ptr_Skill)
            where T_SKILL_OBJECT : unmanaged
            => @this.TryGetSkillObject(name.AsReadOnlySpan(), out ptr_Skill);
        public static bool TryGetMonsterObject(this GhostmonGameContext @this, ReadOnlySpan<char> name, out MonsterObject.Ptr_MonsterObject ptr_MonsterObject)
        {
            Unsafe.SkipInit(out ptr_MonsterObject);
            foreach (var monster in @this.ConfigDataStore.MONSTER_CFG_STORE.AsRefArray())
            {
                var monsterObj = monster.Value;
                if (monsterObj.M_PREFAB.AsReadOnlySpan().SequenceEqual(name))
                {
                    ptr_MonsterObject = monster.Value;
                    return ptr_MonsterObject.Valid();
                }
            }
            return default;
        }
        public static bool TryGetMonsterObject(this GhostmonGameContext @this, PMonoString name, out MonsterObject.Ptr_MonsterObject ptr_MonsterObject)
            => @this.TryGetMonsterObject(name.AsReadOnlySpan(), out ptr_MonsterObject);
        #endregion

        #region TEST
        public class GameImageData
        {
            public required string Category { set; get; }
            public required string ObjectId { set; get; }

            public required string AtlasName { set; get; }
            public required string SpriteName { set; get; }

            public Sprite.Ptr_Sprite Ptr_Sprite { set; get; }

            public Ref_UniTask<Sprite.Ptr_Sprite> _Ref_UniTask;
        }

        static IEnumerable<GameImageData> InitListGameImageData(this GhostmonGameContext @this)
        {
            const string RareItemUIAtlas = "RareItemUIAtlas";
            const string TreasureUIAtlas = "TreasureUIAtlas";
            const string ClothingUIAtlas = "ClothingUIAtlas";
            //   const string MenuUIAtlas = "MenuUIAtlas";
            const string EggUIAtlas = "EggUIAtlas";
            //     const string ItemRecipeUIAtlas = "ItemRecipeUIAtlas";
            const string BuffUIAtlas = "BuffUIAtlas";
            //    const string ItemUIAtlas = "ItemUIAtlas";
            //     const string TravelUIAtlas = "TravelUIAtlas";
            foreach (var monster in @this.ConfigDataStore.MONSTER_CFG_STORE.AsRefArray())
            {
                var monsterObj = monster.Value;
                if (monsterObj)
                {
                    var prefab = monsterObj.M_PREFAB.ToString();
                    if (string.IsNullOrEmpty(prefab) == false)
                    {
                        yield return new GameImageData()
                        {
                            Category = EnumSheetName.Monster.ToString(),
                            ObjectId = prefab,
                            AtlasName = MonsterAvaterUIAtlas,
                            SpriteName = $"{prefab}{MonsterAvaterUIAtlas_Suffix}",
                            Ptr_Sprite = nint.Zero
                        };
                    }

                }
            }

            foreach (var material in GameConfigStore.ListMaterialConfig)
            {
                var prefab = material.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.MaterialConfig.ToString(),
                        ObjectId = material.configID.ToString(),
                        AtlasName = MaterialUIAtlas,
                        SpriteName = $"{Icon_Prefix}{prefab}",
                        Ptr_Sprite = nint.Zero
                    };
                }

            }
            foreach (var charm in GameConfigStore.ListCharmConfig)
            {
                var prefab = charm.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.CharmConfig.ToString(),
                        ObjectId = charm.configID.ToString(),
                        AtlasName = CharmItemUIAtlas,
                        SpriteName = prefab,
                        Ptr_Sprite = nint.Zero
                    };
                }

            }
            foreach (var rare in GameConfigStore.ListRareConfig)
            {
                var prefab = rare.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.RareConfig.ToString(),
                        ObjectId = rare.configID.ToString(),
                        AtlasName = RareItemUIAtlas,
                        SpriteName = $"{Icon_Prefix}{prefab}",
                        Ptr_Sprite = nint.Zero
                    };
                }

            }
            foreach (var skill in GameConfigStore.ListAbilityBookConfig)
            {
                var prefab = skill.prefab;

                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.AbilityBookConfig.ToString(),
                        ObjectId = skill.configID.ToString(),
                        AtlasName = MaterialUIAtlas,
                        SpriteName = prefab,
                        Ptr_Sprite = nint.Zero
                    };
                }
            }
            foreach (var treasure in GameConfigStore.ListTreasureConfig)
            {
                var prefab = treasure.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.TreasureConfig.ToString(),
                        ObjectId = treasure.configID.ToString(),
                        AtlasName = TreasureUIAtlas,
                        SpriteName = prefab,
                        Ptr_Sprite = nint.Zero
                    };
                }

            }

            foreach (var clothing in GameConfigStore.ListClothingConfig)
            {
                var prefab = clothing.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.ClothingConfig.ToString(),
                        ObjectId = clothing.configID.ToString(),
                        AtlasName = ClothingUIAtlas,
                        SpriteName = prefab,
                        Ptr_Sprite = nint.Zero
                    };
                }

            }
            foreach (var menu in GameConfigStore.ListMenuConfig)
            {
                var prefab = menu.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.MenuConfig.ToString(),
                        ObjectId = menu.configID.ToString(),
                        AtlasName = MaterialUIAtlas,
                        SpriteName = prefab,
                        Ptr_Sprite = nint.Zero
                    };
                }

            }
            foreach (var egg in GameConfigStore.ListEggConfig)
            {
                var prefab = egg.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.EggConfig.ToString(),
                        ObjectId = egg.configID.ToString(),
                        AtlasName = EggUIAtlas,
                        SpriteName = $"{Icon_Prefix}{prefab}",
                        Ptr_Sprite = nint.Zero
                    };
                }

            }
            foreach (var itemRecipe in GameConfigStore.ListItemRecipeConfig)
            {
                var prefab = itemRecipe.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.ItemRecipeConfig.ToString(),
                        ObjectId = itemRecipe.configID.ToString(),
                        AtlasName = MaterialUIAtlas,
                        SpriteName = prefab,
                        Ptr_Sprite = nint.Zero
                    };
                }

            }
            foreach (var fishLure in GameConfigStore.ListFishLureConfig)
            {
                var prefab = fishLure.prefab;
                if (string.IsNullOrEmpty(prefab) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.FishLureConfig.ToString(),
                        ObjectId = fishLure.configID.ToString(),
                        AtlasName = MaterialUIAtlas,
                        SpriteName = $"{Icon_Prefix}{prefab}",
                        Ptr_Sprite = nint.Zero
                    };
                }

            }

            foreach (var buff in GameConfigStore.ListBuffConfig)
            {
                var prefab = buff.prefab;
                if (string.IsNullOrEmpty(prefab) == false && string.IsNullOrEmpty(buff.icon) == false)
                {
                    yield return new GameImageData()
                    {
                        Category = EnumSheetName.BuffConfig.ToString(),
                        ObjectId = buff.configID.ToString(),
                        AtlasName = BuffUIAtlas,
                        SpriteName = buff.icon,
                        Ptr_Sprite = nint.Zero
                    };
                }

            }

            yield return new GameImageData()
            {
                Category = EnumSheetName.GEM.ToString(),
                ObjectId = EnumSheetName.GEM.ToString(),
                AtlasName = MaterialUIAtlas,
                SpriteName = "icon_largeGem",
                Ptr_Sprite = nint.Zero
            };
            yield return new GameImageData()
            {
                Category = EnumSheetName.COIN.ToString(),
                ObjectId = EnumSheetName.COIN.ToString(),
                AtlasName = MaterialUIAtlas,
                SpriteName = "icon_largeCoin",
                Ptr_Sprite = nint.Zero
            };
            yield return new GameImageData()
            {
                Category = EnumSheetName.HeartStone.ToString(),
                ObjectId = EnumSheetName.HeartStone.ToString(),
                AtlasName = MaterialUIAtlas,
                SpriteName = "icon_bigHeart",
                Ptr_Sprite = nint.Zero
            };
            yield return new GameImageData()
            {
                Category = EnumSheetName.REIKI.ToString(),
                ObjectId = EnumSheetName.REIKI.ToString(),
                AtlasName = CharmItemUIAtlas,
                SpriteName = "icon_blue",
                Ptr_Sprite = nint.Zero
            };
        }

        //public static IReadOnlyList<MonsterObject.Ptr_MonsterObject> GetListMonsterConfig(this GhostmonGameContext @this)
        //{
        //    var listIllustrationConfig = GameConfigStore.ListIllustrationConfig;
        //    var count = listIllustrationConfig.Count;
        //    var uniTasks = (stackalloc Ref_UniTask<MonsterObject.Ptr_MonsterObject>[count]);
        //    for (int i = 0; i < count; ++i)
        //    {
        //        var monsterName = @this.T(listIllustrationConfig[i % count].prefab!);
        //        ref var uniTask = ref uniTasks[i % count];
        //        _ = ConfigDataStore.Ptr_ConfigDataStore.GET_MONSTER_CONFIG(out uniTask, monsterName);
        //    }
        //    //延迟2S等待异步完成
        //    Thread.Sleep(2000);
        //    List<MonsterObject.Ptr_MonsterObject> list = new(count);
        //    foreach (ref var uniTask in uniTasks)
        //    {
        //        var ret = uniTask.GetResult_State<Ref_LoadMonsterObjectArgs>();
        //        if (ret)
        //        {
        //            list.Add(ret);
        //        }
        //    }


        //    return list;
        //}
        //public static IReadOnlyList<UnitySpriteData> LoadListMonsterAvater(this GhostmonGameContext @this)
        //{
        //    //var pAtlasName = @this.T(MonsterAvaterUIAtlas);
        //    //var monsterObjects = @this.ConfigDataStore.MONSTER_CFG_STORE.AsRefArray();
        //    //var count = monsterObjects.Length;
        //    //List<UnitySpriteData> list = new(count);
        //    //var uniTasks = (stackalloc Ref_UniTask<Sprite.Ptr_Sprite>[count]);
        //    //for (int i = 0; i < count; ++i)
        //    //{
        //    //    var prefab = monsterObjects[i % count].Value.M_PREFAB.ToString();

        //    //    list.Add(new UnitySpriteData() { Category = EnumSheetName.Monster.ToString(), Name = prefab, });

        //    //    var spriteName = $"{prefab}{sMonsterAvaterUIAtlas_Suffix}";
        //    //    var pSpriteName = @this.T(spriteName);
        //    //    ref var uniTask = ref uniTasks[i % count];
        //    //    _ = LoadUtils.Ptr_LoadUtils.LOAD_SPRITE_ASYNC(out uniTask, pAtlasName, pSpriteName);
        //    //}

        //    //Thread.Sleep(2000);
        //    //for (int i = 0; i < count; ++i)
        //    //{
        //    //    ref var uniTask = ref uniTasks[i % count];
        //    //    var ret = uniTask.GetResult_State<Ref_LoadSpriteArgs>();
        //    //    if (ret.Valid())
        //    //    {
        //    //        list[i % count].Ptr_Sprite = ret;
        //    //    }
        //    //}


        //    //return list;
        //}

        public static GameImageData[] GetListGameImageData(this GhostmonGameContext @this)
        {
            var gameImageDatas = @this.InitListGameImageData().ToArray();
            foreach (var image in gameImageDatas)
            {
                var pAtlasName = @this.T(image.AtlasName);
                var pSpriteName = @this.T(image.SpriteName);
                ref var uniTask = ref image._Ref_UniTask;
                _ = LoadUtils.Ptr_LoadUtils.LOAD_SPRITE_ASYNC(out uniTask, pAtlasName, pSpriteName);
            }

            Thread.Sleep(10_000);
            foreach (var image in gameImageDatas.Reverse())
            {
                ref var uniTask = ref image._Ref_UniTask;
                var spriteData = uniTask.GetResult_State<Ref_LoadSpriteArgs>();
                image.Ptr_Sprite = spriteData;
            }
            return gameImageDatas;


        }
        public static IEnumerable<UnitySpriteImageData> GetListUnitySpriteImageData(this GhostmonGameContext @this, UnityEngineContext unityEngine, GameImageData[] spriteDatas)
        {
            foreach (var spriteData in spriteDatas)
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
                        Name = spriteData.ObjectId,
                        ImageData = pIconData,
                    };
                }
                //yield break;
            }
        }
        #endregion

        #region  Game DATA
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


        static bool CanPlayGame(this GhostmonGameContext @this)
        {
            var regionManager = @this.RegionManager.INSTANCE;
            return regionManager;
        }
        public static UserDataManager.Ptr_UserDataManager GetUserDataManager(this GhostmonGameContext @this)
        {
            if (false == @this.CanPlayGame())
            {
                return GameException.Throw<UserDataManager.Ptr_UserDataManager>("Please enter the game first");
            }
            var userDataManager = @this.UserDataManager.INSTANCE;
            if (false == userDataManager)
            {
                return GameException.Throw<UserDataManager.Ptr_UserDataManager>("Error UserDataManager");
            }
            return userDataManager;
        }
        public static UserData.Ptr_UserData GetUserData(this UserDataManager.Ptr_UserDataManager userDataManager)
        {
            var userData = userDataManager.USER_DATA;
            if (false == userData)
            {
                GameException.Throw<UserDataManager.Ptr_UserDataManager>("Error UserData");
            }
            return userData;
        }
        public static JudgeControl.Ptr_JudgeControl GetJudgeControl(this GhostmonGameContext @this, BattlePhase battlePhase)
        {
            var battle = @this.BattleCore.INSTANCE;
            if (false == battle)
            {
                return GameException.Throw<JudgeControl.Ptr_JudgeControl>("Please enter the battle first (0)");
            }
            if (battle.PHASE != battlePhase)
            {
                return GameException.Throw<JudgeControl.Ptr_JudgeControl>($"Please enter the battle first ({battle.PHASE})");
            }
            var judge = battle.JUDGE_CONTROL;
            if (false == judge)
            {
                return GameException.Throw<JudgeControl.Ptr_JudgeControl>("Please enter the battle first (1)");
            }

            return judge;

        }


        #endregion

        #region Currency

        public static GameCurrencyDisplayDTO[] GetListCurrencyDisplay(this GhostmonGameContext @this)
        {
            return [
            new GameCurrencyDisplayDTO()
            {
                ObjectId  = EnumSheetName.GEM.ToString(),
                DisplayCategory= EnumSheetName.GEM.ToString(),
                DisplayName= "灵石" ,
                DisplayDesc= "灵石由特殊的矿石加工而成，比金币更加稀有，具有特殊的力量，可在修行台吸收，也可在特殊商店处交易物品。",

            },
            new GameCurrencyDisplayDTO()
            {   ObjectId  = EnumSheetName.COIN.ToString(),
                DisplayCategory= EnumSheetName.COIN.ToString(),
                DisplayName= "金币" ,
                DisplayDesc= "金币由特殊的矿石加工而成，作为通用的货币，可在所有商人处购买物品。",
            },
            new GameCurrencyDisplayDTO()
            {   ObjectId  = EnumSheetName.HeartStone.ToString(),
                DisplayCategory= EnumSheetName.HeartStone.ToString(),
                DisplayName= "同心石" ,
                DisplayDesc= "与玉树神像互动，消耗同心石即可进行祈福，祈福会获得石材，天赋玉，妖灵蛋等物品。提升妖灵的好感度会获得同心石。",
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
            else if (obj == EnumSheetName.HeartStone)
            {
                count = userData.HEART_STONE_NUM.ToString();
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
            else if (obj == EnumSheetName.HeartStone)
            {
                userData.HEART_STONE_NUM = currencyModifyDTO.IntValue;
            }

            //        @this.PlayMessage($"{obj}:{currencyModifyDTO.NewValue}");

            return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, DisplayValue = currencyModifyDTO.NewValue };

        }
        #endregion

        #region Inventory

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

            foreach (var config in GameConfigStore.ListEvoMaterialConfig)
            {
                var data = new GameInventoryDisplayDTO
                {
                    ObjectId = config.configID.ToString(),
                    DisplayCategory = EnumSheetName.EvoMaterialConfig.ToString(),
                    DisplayDesc = config.description,
                    DisplayName = config.name,
                    ItemAttributes = [

                    new GameValueInfoDTO() { ObjectId = nameof(config.type), CanPreview = true, DisplayName = nameof(config.type), DisplayValue = config.type.ToString() },
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
            else if (category == EnumSheetName.EvoMaterialConfig)
            {
                foreach (var data in userData.TOTAL_EVO_MATERIALS.AsRefArray())
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
            //       @this.PlayMessage($"{category}:{inventoryModifyDTO.NewValue}");
            return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = newCount };

        }
        #endregion

        #region Character

        static List<GameValueInfoDTO> MonsterRanks { get; } =
 [

     new GameValueInfoDTO{ ObjectId = EnumMonsterRank.Rank1.ToString(), DisplayName =EnumMonsterRank.Rank1.ToString(),IntValue =(int)EnumMonsterRank.Rank1   },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterRank.Rank2.ToString(), DisplayName =EnumMonsterRank.Rank2.ToString(),IntValue =(int)EnumMonsterRank.Rank2   },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterRank.Rank3.ToString(), DisplayName =EnumMonsterRank.Rank3.ToString(),IntValue =(int)EnumMonsterRank.Rank3   },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterRank.Rank4.ToString(), DisplayName =EnumMonsterRank.Rank4.ToString(),IntValue =(int)EnumMonsterRank.Rank4   },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterRank.Rank5.ToString(), DisplayName =EnumMonsterRank.Rank5.ToString(),IntValue =(int)EnumMonsterRank.Rank5   },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterRank.Rank6.ToString(), DisplayName =EnumMonsterRank.Rank6.ToString(),IntValue =(int)EnumMonsterRank.Rank6   },

                ];
        static List<GameValueInfoDTO> MonsterResists { get; } =
            [
            new GameValueInfoDTO{ ObjectId = EnumMonsterResist.易感.ToString(), DisplayName =EnumMonsterResist.易感.ToString(),IntValue =(int)EnumMonsterResist.易感  },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterResist.普通.ToString(), DisplayName =EnumMonsterResist.普通.ToString(),IntValue =(int)EnumMonsterResist.普通  },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterResist.免疫.ToString(), DisplayName =EnumMonsterResist.免疫.ToString(),IntValue =(int)EnumMonsterResist.免疫  },

                    ];
        static List<GameValueInfoDTO> MonsterTypes { get; } =
            [
            new GameValueInfoDTO{ ObjectId = EnumMonsterType.普通.ToString(), DisplayName =EnumMonsterType.普通.ToString(),IntValue = (int)EnumMonsterType.普通   },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterType.首领.ToString(), DisplayName =EnumMonsterType.首领.ToString(),IntValue = (int)EnumMonsterType.首领   },
                    new GameValueInfoDTO{ ObjectId = EnumMonsterType.邪魔.ToString(), DisplayName =EnumMonsterType.邪魔.ToString(),IntValue = (int)EnumMonsterType.邪魔   },
                    ];

        static List<GameValueInfoDTO> MonsterWeight { get; } =
            [
            new GameValueInfoDTO{ ObjectId =EnumMonsterWeight.迷你.ToString(), DisplayName =EnumMonsterWeight.迷你.ToString(),IntValue = (int)EnumMonsterWeight.迷你   },
            new GameValueInfoDTO{ ObjectId =EnumMonsterWeight.超小.ToString(), DisplayName =EnumMonsterWeight.超小.ToString(),IntValue = (int)EnumMonsterWeight.超小   },
            new GameValueInfoDTO{ ObjectId =EnumMonsterWeight.小.ToString(), DisplayName =EnumMonsterWeight.小.ToString(),IntValue = (int)EnumMonsterWeight.小   },
            new GameValueInfoDTO{ ObjectId =EnumMonsterWeight.中.ToString(), DisplayName =EnumMonsterWeight.中.ToString(),IntValue = (int)EnumMonsterWeight.中   },
            new GameValueInfoDTO{ ObjectId =EnumMonsterWeight.大.ToString(), DisplayName =EnumMonsterWeight.大.ToString(),IntValue = (int)EnumMonsterWeight.大   },
            new GameValueInfoDTO{ ObjectId =EnumMonsterWeight.超大.ToString(), DisplayName =EnumMonsterWeight.超大.ToString(),IntValue = (int)EnumMonsterWeight.超大   },
            new GameValueInfoDTO{ ObjectId =EnumMonsterWeight.巨大.ToString(), DisplayName =EnumMonsterWeight.巨大.ToString(),IntValue = (int)EnumMonsterWeight.巨大   },

            ];
        static List<GameValueInfoDTO> MonsterAtkForces { get; } =
    [
            new GameValueInfoDTO{ ObjectId = EnumMonsterAtkForce.超弱.ToString(), DisplayName =EnumMonsterAtkForce.超弱.ToString(),IntValue = (int)EnumMonsterAtkForce.超弱   },
            new GameValueInfoDTO{ ObjectId = EnumMonsterAtkForce.弱.ToString(), DisplayName =EnumMonsterAtkForce.弱.ToString(),IntValue = (int)EnumMonsterAtkForce.弱   },
            new GameValueInfoDTO{ ObjectId = EnumMonsterAtkForce.中.ToString(), DisplayName =EnumMonsterAtkForce.中.ToString(),IntValue = (int)EnumMonsterAtkForce.中   },
            new GameValueInfoDTO{ ObjectId = EnumMonsterAtkForce.强.ToString(), DisplayName =EnumMonsterAtkForce.强.ToString(),IntValue = (int)EnumMonsterAtkForce.强   },

    ];

        static List<GameValueInfoDTO> MonsterYINGYANGs { get; } =
    [
            new GameValueInfoDTO{ ObjectId = EnumMonsterYINGYANG.阴.ToString(), DisplayName =EnumMonsterYINGYANG.阴.ToString(),IntValue = (int)EnumMonsterYINGYANG.阴   },
            new GameValueInfoDTO{ ObjectId = EnumMonsterYINGYANG.阳.ToString(), DisplayName =EnumMonsterYINGYANG.阳.ToString(),IntValue = (int)EnumMonsterYINGYANG.阳   },

    ];

        static List<GameValueInfoDTO> MonsterArkType { get; } =
    [
            new GameValueInfoDTO{ ObjectId = BattleDamageType.震荡.ToString(), DisplayName =BattleDamageType.震荡.ToString(),IntValue = (int)BattleDamageType.震荡   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.穿刺.ToString(), DisplayName =BattleDamageType.穿刺.ToString(),IntValue = (int)BattleDamageType.穿刺   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.撕开.ToString(), DisplayName =BattleDamageType.撕开.ToString(),IntValue = (int)BattleDamageType.撕开   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.火焰.ToString(), DisplayName =BattleDamageType.火焰.ToString(),IntValue = (int)BattleDamageType.火焰   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.冰霜.ToString(), DisplayName =BattleDamageType.冰霜.ToString(),IntValue = (int)BattleDamageType.冰霜   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.雷电.ToString(), DisplayName =BattleDamageType.雷电.ToString(),IntValue = (int)BattleDamageType.雷电   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.狂风.ToString(), DisplayName =BattleDamageType.狂风.ToString(),IntValue = (int)BattleDamageType.狂风   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.毒药.ToString(), DisplayName =BattleDamageType.毒药.ToString(),IntValue = (int)BattleDamageType.毒药   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.黑暗.ToString(), DisplayName =BattleDamageType.黑暗.ToString(),IntValue = (int)BattleDamageType.黑暗   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.固定.ToString(), DisplayName =BattleDamageType.固定.ToString(),IntValue = (int)BattleDamageType.固定   },
            new GameValueInfoDTO{ ObjectId = BattleDamageType.治疗.ToString(), DisplayName =BattleDamageType.治疗.ToString(),IntValue = (int)BattleDamageType.治疗   },

    ];


        public static IEnumerable<GameCharacterDisplayDTO> GetListCharacterDisplay(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager)
        {
            var userData = userDataManager.GetUserData();
            var playerName = userData.PLAYER_NAME.ToString() ?? "???";
            yield return new GameCharacterDisplayDTO()
            {
                ObjectId = EnumSheetName.Player.ToString(),
                DisplayCategory = EnumSheetName.Player.ToString(),
                DisplayName = playerName,
                DisplayDesc = playerName,
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
                    DisplayImage = monster.U_PREFAB.ToString(),
                    CharacterAttributes = [
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_VARI_COLOR),DisplayName =  "属性*异色",DisplayValue = monster.U_VARI_COLOR.ToString()  },
                         new GameValueInfoDTO(){ObjectId = nameof(monster.U_FLASH),DisplayName = "属性*闪光",DisplayValue = monster.U_FLASH.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_LEVEL),DisplayName =  "属性*等级",DisplayValue = monster.U_LEVEL.ToString(),CanPreview = true,  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_EXP),DisplayName = "属性*当前经验",DisplayValue = monster.U_EXP.ToString() ,CanWrite = true },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_TOTAL_EXP),DisplayName =  "属性*累计经验",DisplayValue = monster.U_TOTAL_EXP.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_FAVORABILITY),DisplayName =  "属性*亲密",DisplayValue = monster.U_FAVORABILITY.ToString(),CanWrite= true },





                        ]
                };
            }

        }
        //public static IEnumerable<GameCharacterDisplayDTO> RemoveCharacterMember(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCharacterObjectDTO characterObjectDTO)
        //{ 

        //}

        private static GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO, MonsterData.Ptr_MonsterData monster)
        {
            return new GameCharacterStatusDTO()
            {
                ObjectId = characterObjectDTO.CharacterId,
                CharacterAttributes = [
                           new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_VARI_COLOR),DisplayName =  "属性*异色",ContentValue = monster.U_VARI_COLOR.ToString() ,UIType = (int)EnumGameSwitchUIType.Switches },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_FLASH),DisplayName =  "属性*闪光",ContentValue = monster.U_FLASH.ToString()  ,UIType = (int)EnumGameSwitchUIType.Switches},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_LUCK),DisplayName =  "属性*幸运",ContentValue = monster.U_LUCK.ToString() ,UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_EXP),DisplayName =  "属性*经验",ContentValue = monster.U_EXP.ToString() ,UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_FAVORABILITY),DisplayName =  "属性*亲密",ContentValue = monster.U_FAVORABILITY.ToString() ,UIType = (int)EnumGameSwitchUIType.TextEditor},

                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_YING_YANG),DisplayName =  "属性*阴阳",ContentValue = monster.U_YING_YANG.ToString(),SelectedContents = MonsterYINGYANGs ,UIType = (int)EnumGameSwitchUIType.Selects},



                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_TYPE),DisplayName =  "属性*类型",ContentValue = monster.U_TYPE.ToString() ,SelectedContents =MonsterTypes ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_ATK_FORCE),DisplayName =  "属性*力量",ContentValue = monster.U_ATK_FORCE.ToString() ,SelectedContents =MonsterAtkForces ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_WEIGHT),DisplayName =  "属性*体型",ContentValue = monster.U_WEIGHT.ToString() ,SelectedContents =MonsterWeight ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_ATK_TYPE),DisplayName =  "攻击*方式",ContentValue = monster.U_ATK_TYPE.ToString(),SelectedContents = MonsterArkType ,UIType = (int)EnumGameSwitchUIType.Selects},

                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.GROWTH_ATK),DisplayName =  "成长*攻击",ContentValue = monster.GROWTH_ATK.ToString(),UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.GROWTH_DEF),DisplayName =  "成长*防御",ContentValue = monster.GROWTH_DEF.ToString(),UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.GROWTH_HP),DisplayName =  "成长*生命",ContentValue = monster.GROWTH_HP.ToString(),UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.GROWTH_WP),DisplayName =  "成长*意志",ContentValue = monster.GROWTH_WP.ToString() ,UIType = (int)EnumGameSwitchUIType.TextEditor},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.GROWTH_MAGIC),DisplayName =  "成长*妖术",ContentValue = monster.GROWTH_MAGIC.ToString() ,UIType = (int)EnumGameSwitchUIType.TextEditor},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.GROWTH_CRIT),DisplayName =  "成长*会心",ContentValue = monster.GROWTH_CRIT.ToString(),UIType = (int)EnumGameSwitchUIType.TextEditor },

                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.RANK_ATK),DisplayName =  "级别*攻击",ContentValue = monster.RANK_ATK.ToString() ,SelectedContents =MonsterRanks ,UIType = (int)EnumGameSwitchUIType.Selects },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.RANK_DEF),DisplayName =  "级别*防御",ContentValue = monster.RANK_DEF.ToString(),SelectedContents =MonsterRanks ,UIType = (int)EnumGameSwitchUIType.Selects },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.RANK_HP),DisplayName =  "级别*生命",ContentValue = monster.RANK_HP.ToString(),SelectedContents =MonsterRanks  ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.RANK_WP),DisplayName =  "级别*意志",ContentValue = monster.RANK_WP.ToString() ,SelectedContents =MonsterRanks ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.RANK_MAGIC),DisplayName =  "级别*妖术",ContentValue = monster.RANK_MAGIC.ToString() ,SelectedContents =MonsterRanks ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.RANK_CRIT),DisplayName =  "级别*会心",ContentValue = monster.RANK_CRIT.ToString() ,SelectedContents =MonsterRanks ,UIType = (int)EnumGameSwitchUIType.Selects},


                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_FIRE_RESIST),DisplayName =  "抵抗*火焰",ContentValue = monster.U_FIRE_RESIST.ToString() ,SelectedContents =MonsterResists,UIType = (int)EnumGameSwitchUIType.Selects },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_COLD_RESIST),DisplayName =  "抵抗*冰霜",ContentValue = monster.U_COLD_RESIST.ToString() ,SelectedContents =MonsterResists ,UIType = (int)EnumGameSwitchUIType.Selects },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_LTNG_RESIST),DisplayName =  "抵抗*雷电",ContentValue = monster.U_LTNG_RESIST.ToString(),SelectedContents =MonsterResists  ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_WIND_RESIST),DisplayName =  "抵抗*狂风",ContentValue = monster.U_WIND_RESIST.ToString() ,SelectedContents =MonsterResists,UIType = (int)EnumGameSwitchUIType.Selects },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_POISON_RESIST),DisplayName =  "抵抗*剧毒",ContentValue = monster.U_POISON_RESIST.ToString() ,SelectedContents =MonsterResists ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_DARK_RESIST),DisplayName =  "抵抗*黑暗",ContentValue = monster.U_DARK_RESIST.ToString() ,SelectedContents =MonsterResists ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_PUNCTURE_RESIST),DisplayName =  "抵抗*穿刺",ContentValue = monster.U_PUNCTURE_RESIST.ToString() ,SelectedContents =MonsterResists ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_SHOCK_RESIST),DisplayName =  "抵抗*震荡",ContentValue = monster.U_SHOCK_RESIST.ToString() ,SelectedContents =MonsterResists ,UIType = (int)EnumGameSwitchUIType.Selects},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_TEAR_RESIST),DisplayName =  "抵抗*撕裂",ContentValue = monster.U_TEAR_RESIST.ToString() ,SelectedContents =MonsterResists ,UIType = (int)EnumGameSwitchUIType.Selects},
                        //new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_DEBUFF_RESIST),DisplayName =  "抵抗*减益",ContentValue = monster.U_DEBUFF_RESIST.ToString(),SelectedContents =MonsterResists  },


                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_COOK),DisplayName =  "技艺*厨艺",ContentValue = monster.U_COOK.ToString()  ,UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_DRAW),DisplayName =  "技艺*符咒",ContentValue = monster.U_DRAW.ToString()  ,UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_PLANT),DisplayName =  "技艺*种植",ContentValue = monster.U_PLANT.ToString() ,UIType = (int)EnumGameSwitchUIType.TextEditor  },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_EXPLOIT),DisplayName =  "技艺*开采",ContentValue = monster.U_EXPLOIT.ToString()   ,UIType = (int)EnumGameSwitchUIType.TextEditor},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_UNDERSTANDING),DisplayName =  "技艺*悟性",ContentValue = monster.U_UNDERSTANDING.ToString()  ,UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_GUARD),DisplayName =  "技艺*护卫",ContentValue = monster.U_GUARD.ToString()   ,UIType = (int)EnumGameSwitchUIType.TextEditor},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_TRADE),DisplayName =  "技艺*游商",ContentValue = monster.U_TRADE.ToString()  ,UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(monster.U_HUNT),DisplayName =  "技艺*狩猎",ContentValue = monster.U_HUNT.ToString()  ,UIType = (int)EnumGameSwitchUIType.TextEditor },

                        ]
            };
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
                        new GameSwitchDisplayDTO(){ObjectId = nameof(userData.LEV_RANK),DisplayName =  nameof(userData.LEV_RANK),ContentValue = userData.LEV_RANK.ToString()  },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(userData.RANK_VALUE),DisplayName =  nameof(userData.RANK_VALUE),ContentValue = userData.RANK_VALUE.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(userData.TOTAL_RANK_VALUE),DisplayName =  nameof(userData.TOTAL_RANK_VALUE),ContentValue = userData.TOTAL_RANK_VALUE.ToString(), },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(userData.LEV_SEAL),DisplayName =  nameof(userData.LEV_SEAL),ContentValue = userData.LEV_SEAL.ToString(), },
                        ]
                };
            }
            else
            {


                foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
                {
                    if (total.Key == characterObjectDTO.UCharacterId && total.Value.Valid())
                    {


                        return GetCharacterStatus(characterObjectDTO, total.Value);


                    }
                }
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
        }
        public static GameCharacterStatusDTO UpdateCharacterStatus(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCharacterModifyDTO characterModifyDTO)
        {
            var userData = userDataManager.GetUserData();
            if (characterModifyDTO.CharacterId == EnumSheetName.Player.ToString())
            {
                if (characterModifyDTO.ModifyObject == nameof(userData.RANK_VALUE))
                {
                    userData.RANK_VALUE = characterModifyDTO.IntValue;
                    return new GameCharacterStatusDTO()
                    {
                        ObjectId = characterModifyDTO.CharacterId,
                        CharacterAttributes = [
                         new GameSwitchDisplayDTO(){ObjectId = nameof(userData.LEV_RANK),DisplayName =  nameof(userData.LEV_RANK),ContentValue = userData.LEV_RANK.ToString()  },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(userData.RANK_VALUE),DisplayName =  nameof(userData.RANK_VALUE),ContentValue = userData.RANK_VALUE.ToString() , UIType = (int)EnumGameSwitchUIType.TextEditor},
                        new GameSwitchDisplayDTO(){ObjectId = nameof(userData.TOTAL_RANK_VALUE),DisplayName =  nameof(userData.TOTAL_RANK_VALUE),ContentValue = userData.TOTAL_RANK_VALUE.ToString(), },
                        new GameSwitchDisplayDTO(){ObjectId = nameof(userData.LEV_SEAL),DisplayName =  nameof(userData.LEV_SEAL),ContentValue = userData.LEV_SEAL.ToString(), },
                        ]
                    };
                }
            }
            else
            {
                foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
                {
                    if (total.Key == characterModifyDTO.UCharacterId && total.Value.Valid())
                    {

                        var monster = total.Value;
                        if (false == @this.TryGetMonsterObject(monster.U_PREFAB, out var monsterObj))
                        {
                            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterModifyDTO.CharacterId}");
                        }

                        if (characterModifyDTO.ModifyObject == nameof(monster.U_EXP))
                        {
                            monster.U_EXP = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_FAVORABILITY))
                        {
                            monster.U_FAVORABILITY = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_LUCK))
                        {
                            monster.U_LUCK = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_YING_YANG))
                        {
                            monster.U_YING_YANG = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_TYPE))
                        {
                            monster.U_TYPE = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_ATK_FORCE))
                        {
                            monster.U_ATK_FORCE = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_WEIGHT))
                        {
                            monster.U_WEIGHT = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_ATK_TYPE))
                        {
                            monster.U_ATK_TYPE = characterModifyDTO.IntValue;
                        }


                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_ATK))
                        {
                            monster.GROWTH_ATK = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_DEF))
                        {
                            monster.GROWTH_DEF = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_HP))
                        {
                            monster.GROWTH_HP = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_WP))
                        {
                            monster.GROWTH_WP = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_MAGIC))
                        {
                            monster.GROWTH_MAGIC = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_CRIT))
                        {
                            monster.GROWTH_CRIT = characterModifyDTO.IntValue;
                        }

                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_ATK))
                        {
                            monster.RANK_ATK = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_DEF))
                        {
                            monster.RANK_DEF = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_HP))
                        {
                            monster.RANK_HP = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_WP))
                        {
                            monster.RANK_WP = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_MAGIC))
                        {
                            monster.RANK_MAGIC = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_CRIT))
                        {
                            monster.RANK_CRIT = characterModifyDTO.IntValue;
                        }

                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_FIRE_RESIST))
                        {
                            monster.U_FIRE_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_COLD_RESIST))
                        {
                            monster.U_COLD_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_LTNG_RESIST))
                        {
                            monster.U_LTNG_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_WIND_RESIST))
                        {
                            monster.U_WIND_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_POISON_RESIST))
                        {
                            monster.U_POISON_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_DARK_RESIST))
                        {
                            monster.U_DARK_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_PUNCTURE_RESIST))
                        {
                            monster.U_PUNCTURE_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_SHOCK_RESIST))
                        {
                            monster.U_SHOCK_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_TEAR_RESIST))
                        {
                            monster.U_TEAR_RESIST = characterModifyDTO.IntValue;
                        }

                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_COOK))
                        {
                            monster.U_COOK = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_DRAW))
                        {
                            monster.U_DRAW = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_PLANT))
                        {
                            monster.U_PLANT = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_EXPLOIT))
                        {
                            monster.U_EXPLOIT = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_UNDERSTANDING))
                        {
                            monster.U_UNDERSTANDING = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_GUARD))
                        {
                            monster.U_GUARD = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_TRADE))
                        {
                            monster.U_TRADE = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_HUNT))
                        {
                            monster.U_HUNT = characterModifyDTO.IntValue;
                        }

                        var rank = 0;
                        var upRank = characterModifyDTO.BoolValue ?? false;
                        if (characterModifyDTO.ModifyObject == nameof(monster.U_FLASH))
                        {
                            monster.U_FLASH = upRank;
                            rank = 6;
                        }
                        if (characterModifyDTO.ModifyObject == nameof(monster.U_VARI_COLOR))
                        {
                            monster.U_VARI_COLOR = upRank;
                            rank = 3;
                        }
                        if (rank > 0)
                        {
                            if (upRank)
                            {
                                monster.ORDER_GROWTH_VALUE(rank, monsterObj.GROWTH_ATK, (int)EnumMonsterGrowthType.GROWTH_ATK);
                                monster.ORDER_GROWTH_VALUE(rank, monsterObj.GROWTH_DEF, (int)EnumMonsterGrowthType.GROWTH_DEF);
                                monster.ORDER_GROWTH_VALUE(rank, monsterObj.GROWTH_HP, (int)EnumMonsterGrowthType.GROWTH_HP);
                                monster.ORDER_GROWTH_VALUE(rank, monsterObj.GROWTH_MAGIC, (int)EnumMonsterGrowthType.GROWTH_MAGIC);
                                monster.ORDER_GROWTH_VALUE(rank, monsterObj.GROWTH_WP, (int)EnumMonsterGrowthType.GROWTH_WP);
                                monster.ORDER_GROWTH_VALUE(rank, monsterObj.GROWTH_CRIT, (int)EnumMonsterGrowthType.GROWTH_CRIT);

                            }
                            else
                            {
                                var growth_atk = monster.GET_GROWTH_VALUE(monsterObj.GROWTH_ATK);
                                monster.RANK_ATK = (int)growth_atk[0];
                                monster.GROWTH_ATK = growth_atk[1];
                                //
                                var growth_def = monster.GET_GROWTH_VALUE(monsterObj.GROWTH_DEF);
                                monster.RANK_DEF = (int)growth_def[0];
                                monster.GROWTH_DEF = growth_def[1];
                                //
                                var growth_hp = monster.GET_GROWTH_VALUE(monsterObj.GROWTH_HP);
                                monster.RANK_HP = (int)growth_hp[0];
                                monster.GROWTH_HP = growth_hp[1];
                                //
                                var growth_magic = monster.GET_GROWTH_VALUE(monsterObj.GROWTH_MAGIC);
                                monster.RANK_MAGIC = (int)growth_magic[0];
                                monster.GROWTH_MAGIC = growth_magic[1];
                                //
                                var growth_wp = monster.GET_GROWTH_VALUE(monsterObj.GROWTH_WP);
                                monster.RANK_WP = (int)growth_wp[0];
                                monster.GROWTH_WP = growth_wp[1];
                                //
                                var growth_crit = monster.GET_GROWTH_VALUE(monsterObj.GROWTH_CRIT);
                                monster.RANK_CRIT = (int)growth_crit[0];
                                monster.GROWTH_CRIT = growth_wp[1];

                            }
                        }

                        //基础属性重新计算
                        monster.GetCurrentBasicProperty(monsterObj);





                        return GetCharacterStatus(characterModifyDTO, total.Value);



                    }
                }
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterModifyDTO.UCharacterId}:{characterModifyDTO.ModifyObject}");
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

        }
        static GameSkillInfoDTO[] GetListSkill(GhostmonGameContext @this, MonsterData.Ptr_MonsterData monsterData)
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

                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    //new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},
                    //new (){ ObjectId = ability,DisplayCategory = ability,CanWrite =true},

                ];


            if (@this.TryGetSkillObject<USkillObject.Ptr_USkillObject>(monsterData.U_PREFAB, out var skillObject))
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
                        var skillInfo = skillInfos.ElementAtOrDefault(abilityIndex);
                        if (skillInfo is null)
                        {
                            break;
                        }
                        skillInfo.ObjectId = skill.configID.ToString();
                        skillInfo.DisplayName = skill.name;
                        skillInfo.DisplayDesc = skill.description;
                        ++abilityIndex;
                    }
                }
            }

            return skillInfos;
        }
        public static GameCharacterSkillDTO UpdateCharacterSkill(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameCharacterModifyDTO characterModifyDTO)
        {

            if (false == ulong.TryParse(characterModifyDTO.ModifyObject, out var removeSkillId) && string.IsNullOrEmpty(characterModifyDTO.NewValue))
            {
                return GameException.Throw<GameCharacterSkillDTO>("ERROR");
            }
            var userData = userDataManager.GetUserData();
            foreach (var total in userData.TOTAL_MONSTERS.AsRefArray())
            {
                if (total.Key == characterModifyDTO.UCharacterId && total.Value.Valid())
                {


                    var monsterData = total.Value;
                    var addSkillId = characterModifyDTO.ULongValue;

                    //fix skill
                    IEnumerable<ulong> skills;
                    //if (monsterData.U_ABILITIES.Size > 4)
                    //{
                    //    skills = [];
                    //}
                    //else
                    if (addSkillId == 0LU)
                    {
                        skills = RemoveTheSkill(monsterData, removeSkillId);
                    }
                    else
                    {
                        skills = AddTheSkill(monsterData, addSkillId, removeSkillId);
                    }
                    var strSkill = string.Join(',', skills);
                    var monoString = @this.T(strSkill);
                    var ptrSkills = GameBasicUtil.Ptr_GameBasicUtil.STRING_TO_LONG_ARRAY(monoString, ',');


                    using var gchandle = @this.RuntimeContext.CreateMonoGCHandle(ptrSkills, true);
                    var newPtrSkills = gchandle.GetTarget<PMonoArray<UInt64>>();
                    monsterData.U_ABILITIES = newPtrSkills;


                    return new GameCharacterSkillDTO()
                    {
                        ObjectId = characterModifyDTO.CharacterId,
                        SkillInfos = GetListSkill(@this, monsterData),
                    };
                }
            }
            return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.CharacterId}");

            IEnumerable<ulong> RemoveTheSkill(MonsterData.Ptr_MonsterData monsterData, ulong removeSkill)
            {
                //只移除一个
                if (monsterData.U_ABILITIES.Valid())
                {
                    foreach (var item in monsterData.U_ABILITIES)
                    {
                        if (item == removeSkill)
                        {
                            removeSkill = 0;
                        }
                        else
                        {
                            yield return item;
                        }
                    }
                }
            }
            IEnumerable<ulong> AddTheSkill(MonsterData.Ptr_MonsterData monsterData, ulong AddSkill, ulong removeSkill = 0)
            {
                yield return AddSkill;
                if (monsterData.U_ABILITIES.Valid())
                {
                    foreach (var item in monsterData.U_ABILITIES)
                    {
                        //只移除一个
                        if (item == removeSkill)
                        {
                            removeSkill = 0;
                        }
                        else
                        {
                            yield return item;
                        }
                    }
                }
            }



        }


        #endregion

        #region Monster

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
                    name = prefab.EndsWith("Demon") ? $"{name} Demon" : name;
                    yield return new GameMonsterDisplayDTO()
                    {
                        ObjectId = prefab,
                        DisplayName = name,
                        DisplayCategory = category,
                        DisplayDesc = name,
                        MonsterAttributes = [
                            new (){ ObjectId = nameof(monster.M_RANK), DisplayName= "等级",DisplayValue = monster.M_RANK.ToString(),CanPreview = true },
                            new (){ ObjectId = nameof(monster.BASE_CRIT), DisplayName= "基础*会心",DisplayValue = monster.BASE_CRIT.ToString(),CanPreview = true },
                            new (){ ObjectId = nameof(monster.LEVEL_RANGE), DisplayName= "等级*范围",DisplayValue = $"{monster.LEVEL_RANGE.m_X}~{monster.LEVEL_RANGE.m_Y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_HP), DisplayName= "成长*生命",DisplayValue = $"{monster.GROWTH_HP.x}~{monster.GROWTH_HP.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_WP), DisplayName= "成长*意志",DisplayValue = $"{monster.GROWTH_WP.x}~{monster.GROWTH_WP.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_ATK), DisplayName= "成长*攻击",DisplayValue = $"{monster.GROWTH_ATK.x}~{monster.GROWTH_ATK.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_DEF), DisplayName= "成长*防御",DisplayValue = $"{monster.GROWTH_DEF.x}~{monster.GROWTH_DEF.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_MAGIC), DisplayName= "成长*妖力",DisplayValue = $"{monster.GROWTH_MAGIC.x}~{monster.GROWTH_MAGIC.y}",CanPreview = false },
                            new (){ ObjectId = nameof(monster.GROWTH_CRIT), DisplayName= "成长*会心",DisplayValue = $"{monster.GROWTH_CRIT.x}~{monster.GROWTH_CRIT.y}",CanPreview = false },


                            ],
                        SkillInfos = [GetSkillInfo(monster)]
                    };
                }

            }

            GameSkillInfoDTO GetSkillInfo(MonsterObject.Ptr_MonsterObject monsterObject)
            {
                var skillId = EnumSheetName.Skill.ToString();
                string? skillName;
                string? skillDesc;
                if (@this.TryGetSkillObject<USkillObject.Ptr_USkillObject>(monsterObject.M_PREFAB, out var skillObject))
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
        public static GameCharacterSkillDTO AddMonsterMember(this GhostmonGameContext @this, UserDataManager.Ptr_UserDataManager userDataManager, GameMonsterObjectDTO monsterObjectDTO)
        {
            if (false == @this.TryGetMonsterObject(monsterObjectDTO.MonsterObject, out var monsterObject))
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {monsterObjectDTO.MonsterObject}");
            }
            var monsterData = @this.MonsterData.New(false);
            monsterData.CTOR(monsterObject, 1, 0, true);
            monsterData.GET_ABILITIES();
            userDataManager.SET_MONSTER_INFO(monsterData);
            userDataManager.ADD_MONSTER(monsterData);
            return new GameCharacterSkillDTO()
            {
                ObjectId = monsterData.DATA_ID.ToString(),
                SkillInfos = GetListSkill(@this, monsterData),

            };
        }


        #endregion

        #region Skill

        public static IEnumerable<GameSkillDisplayDTO> GetListGameSkillDisplay(this GhostmonGameContext @this)
        {
            foreach (var skill in GameConfigStore.ListCuisineConfig)
            {
                yield return new GameSkillDisplayDTO()
                {
                    ObjectId = skill.configID.ToString(),
                    DisplayName = skill.name,
                    DisplayDesc = skill.description,
                    DisplayCategory = EnumSheetName.CuisineConfig.ToString(),
                    CanUse = true,
                    SkillAttributes = [
                        new GameValueInfoDTO(){  ObjectId =nameof(CuisineConfig.lifeTime),DisplayName = nameof(CuisineConfig.lifeTime), DisplayValue = skill.lifeTime.ToString()  },
                        ]
                };
            }

            foreach (var skill in GameConfigStore.ListAbilityConfig)
            {
                yield return new GameSkillDisplayDTO()
                {
                    ObjectId = skill.configID.ToString(),
                    DisplayName = skill.name,
                    DisplayDesc = skill.description,
                    DisplayCategory = EnumSheetName.AbilityConfig.ToString(),
                    SkillAttributes = [
                         new GameValueInfoDTO(){  ObjectId = nameof(AbilityConfig.rank),DisplayName = nameof(AbilityConfig.rank), DisplayValue = skill.rank.ToString(),CanPreview = true},
                         new GameValueInfoDTO(){  ObjectId = nameof(AbilityConfig.cooldown),DisplayName = nameof(AbilityConfig.cooldown), DisplayValue = skill.cooldown.ToString(),CanPreview = true},
                       ]
                };
            }

            foreach (var skill in GameConfigStore.ListBuffConfig)
            {
                yield return new GameSkillDisplayDTO()
                {
                    ObjectId = skill.configID.ToString(),
                    DisplayName = skill.name,
                    DisplayDesc = skill.description,
                    DisplayCategory = EnumSheetName.BuffConfig.ToString(),
                    SkillAttributes = [
                        new GameValueInfoDTO(){  ObjectId =nameof(BuffConfig.buffType),DisplayName = nameof(BuffConfig.buffType), DisplayValue = skill.buffType.ToString()  },
                        new GameValueInfoDTO(){  ObjectId =nameof(BuffConfig.duration),DisplayName = nameof(BuffConfig.duration), DisplayValue = skill.duration.ToString()  },
                        ]
                };
            }


        }

        public static GameSkillDisplayDTO AddSkillDisplay(this GhostmonGameContext @this, GameSkillObjectDTO gameSkillObject)
        {
            var skillId = gameSkillObject.ULongSkill;
            var skillObj = GameConfigStore.ListCuisineConfig.Find(p => p.configID == skillId);
            if (skillObj is null)
            {
                return GameException.Throw<GameSkillDisplayDTO>($"NOT FOUND {gameSkillObject.SkillObject}");
            }
            return new GameSkillDisplayDTO()
            {
                ObjectId = skillObj.configID.ToString(),
                DisplayName = skillObj.name,
                DisplayDesc = skillObj.description,
                DisplayCategory = EnumSheetName.CuisineConfig.ToString(),
                CanUse = true,
                SkillAttributes = [
                       new GameValueInfoDTO(){  ObjectId =nameof(CuisineConfig.lifeTime),DisplayName = nameof(CuisineConfig.lifeTime), DisplayValue = skillObj.lifeTime.ToString()  },
                        ]
            };

        }
        #endregion

        #region switch
        public static string SetBuff2Character(this GhostmonGameContext @this)
        {
            var judge = @this.GetJudgeControl(BattlePhase.Deploy);

            var listBuff = GameConfigStore.ListBuffConfig.Where(p => p.buffType != (int)EnumBattleBuffType.减益).ToArray();
            if (listBuff.Length == 0)
            {
                return string.Empty;
            }
            Random.Shared.Shuffle(listBuff);
            var buff = listBuff[0];
            foreach (var unit in judge.GET_UNITS_BY_FACTION(false))
            {
                unit.ADD_BUFF_ITEM(buff.configID, unit);
            }
            return buff.name!;
            //     @this.PlayMessage($"Add Buff:{buff.name}");
        }
        public static string SetDeBuff2Enemy(this GhostmonGameContext @this)
        {
            var judge = @this.GetJudgeControl(BattlePhase.Deploy);

            var listBuff = GameConfigStore.ListBuffConfig.Where(p => p.buffType == (int)EnumBattleBuffType.减益).ToArray();
            if (listBuff.Length == 0)
            {
                return string.Empty;
            }
            Random.Shared.Shuffle(listBuff);
            var buff = listBuff[0];
            foreach (var unit in judge.GET_UNITS_BY_FACTION(true))
            {
                unit.ADD_BUFF_ITEM(buff.configID, unit);
            }
            return buff.name!;
            //  @this.PlayMessage($"Add DeBuff:{buff.name}");

        }


        public static MapWeather SetMapWeather(this GhostmonGameContext @this, MapWeather mapWeather)
        {
            var regionManager = @this.RegionManager.INSTANCE;
            if (!regionManager)
            {
                return GameException.Throw<MapWeather>("Please enter the game first (0)");
            }
            var environmentCtrl = regionManager.ENVIRONMENT_CTRL;
            if (!environmentCtrl)
            {
                return GameException.Throw<MapWeather>("Please enter the game first (1)");
            }
            environmentCtrl.SET_WEATHER(mapWeather, true);
            return mapWeather;
        }


        public static void ChangelayerDoubleMoveSpeed(
            this GhostmonGameContext @this,
            UserDataManager.Ptr_UserDataManager userDataManager,
            GameSwitchDisplayDTO gameSwitchDisplay, bool on)
        {
            var player = userDataManager.PLAYER_PROPERTY;
            if (false == player.Valid())
            {
                GameException.Throw<MapWeather>("Please enter the game first (1)");
            }
            else
            {
                if (on)
                {
                    var old = player.P_MOVE_SPEED_SCALE;
                    gameSwitchDisplay.FloatCache = old;
                    player.P_MOVE_SPEED_SCALE = old * 2f;
                }
                else
                {
                    var val = Math.Min(gameSwitchDisplay.FloatCache, 1F);
                    player.P_MOVE_SPEED_SCALE = val;
                }
            }

        }


        public static void ChangeMonsterDoubleExp(
            this GhostmonGameContext @this,
            UserDataManager.Ptr_UserDataManager userDataManager,
            GameSwitchDisplayDTO gameSwitchDisplay,
            bool on)
        {
            var player = userDataManager.PLAYER_PROPERTY;
            if (false == player.Valid())
            {
                GameException.Throw<MapWeather>("Please enter the game first (1)");
            }
            else
            {
                if (on)
                {
                    var old = player.P_EXP_SCALE;
                    gameSwitchDisplay.FloatCache = old;
                    player.P_EXP_SCALE = old * 2f;
                }
                else
                {

                    var val = Math.Min(gameSwitchDisplay.FloatCache, 1f);
                    player.P_EXP_SCALE = val;
                }
            }

        }


        public static void ChangeMonsterFlash(
            this GhostmonGameContext @this,
            UserDataManager.Ptr_UserDataManager userDataManager,
            GameSwitchDisplayDTO gameSwitchDisplay,
            bool on)
        {
            var player = userDataManager.PLAYER_PROPERTY;
            if (false == player.Valid())
            {
                GameException.Throw<MapWeather>("Please enter the game first (1)");
            }
            else
            {
                if (on)
                {
                    var old = player.P_FLASH_SCALE;
                    gameSwitchDisplay.FloatCache = old;
                    player.P_FLASH_SCALE = 1000F;
                }
                else
                {

                    var val = Math.Min(gameSwitchDisplay.FloatCache, 1f);
                    player.P_FLASH_SCALE = val;
                }
            }

        }
        public static void ChangeMonsterColor(
    this GhostmonGameContext @this,
    UserDataManager.Ptr_UserDataManager userDataManager,
    GameSwitchDisplayDTO gameSwitchDisplay,
    bool on)
        {
            var player = userDataManager.PLAYER_PROPERTY;
            if (false == player.Valid())
            {
                GameException.Throw<MapWeather>("Please enter the game first (1)");
            }
            else
            {
                if (on)
                {
                    var old = player.P_COLORFUL_SCALE;
                    gameSwitchDisplay.FloatCache = old;
                    player.P_COLORFUL_SCALE = 500F;
                }
                else
                {

                    var val = Math.Min(gameSwitchDisplay.FloatCache, 1f);
                    player.P_COLORFUL_SCALE = val;
                }
            }

        }
        public static CharacterCore.Ptr_CharacterCore GetScanMode(this GhostmonGameContext @this)
        {
            var characterCore = @this.CharacterCore.INSTANCE;
            if (characterCore.Valid() == false)
            {
                return GameException.Throw<CharacterCore.Ptr_CharacterCore>("Please enter the game first (3)");

            }
            if (characterCore.IS_LOCKED)
            {
                return GameException.Throw<CharacterCore.Ptr_CharacterCore>("Error game character status");
            }
            return characterCore;
        }

        public static void ChangeScanMode(
            this GhostmonGameContext @this,
            UserData.Ptr_UserData userData,
            CharacterCore.Ptr_CharacterCore characterCore,
            bool on)
        {


            if (!on)
            {
                characterCore.EXIT_SCAN_MODE();
                return;
            }



            var func = userData.SYSTEM_FUNCTION;
            try
            {
                //临时开启游戏功能
                if ((func & (int)EnumGameSystemFunction.ScanMode) != (int)EnumGameSystemFunction.ScanMode)
                {
                    userData.SYSTEM_FUNCTION |= (int)EnumGameSystemFunction.ScanMode;
                }


                characterCore.ENRTY_SCAN_MODE();

                //CD清空  可能存在精度问题? 改-1f?
                characterCore.SS_CD = -1f;
                //储蓄时间60
                characterCore.SS_DURATION = 60F;
            }
            finally
            {
                //恢复游戏功能
                userData.SYSTEM_FUNCTION = func;
            }

        }

        #endregion
    }

    enum EnumMonsterGrowthType
    {
        GROWTH_ATK = 0,
        GROWTH_MAGIC = 1,
        GROWTH_DEF = 2,
        GROWTH_WP = 3,
        GROWTH_HP = 4,
        GROWTH_CRIT = 5,
    }
}
