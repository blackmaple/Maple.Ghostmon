using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Maple.Ghostmon
{


    internal static class GhostmonGameContextExtensions
    {
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

        public static GameConfigStoreDTO GetGameConfigStore(this GhostmonGameContext @this)
        {
            try
            {
                GameConfigStoreDTO gameConfigStoreDTO = new();
                if (@this.ConfigDataStore.CFG_LOADED)
                {
                    var dicConfig = @this.ConfigDataStore.CONFIG_STORE;
                    if (dicConfig.Valid())
                    {
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
                                //  @this.Logger.LogInformation("key:{k}//json=>{json}", keyName.ToString(), json.ToString());
                                gameConfigStoreDTO.Add(json, enumSheetName);
                            }
                        }
                    }

                }
                return gameConfigStoreDTO;
            }
            catch (Exception ex)
            {
                @this.Logger.Error(ex);
            }
            return default!;
        }
        public static IReadOnlyList<MonsterObject.Ptr_MonsterObject> LoadListMonsterConfig(this GhostmonGameContext @this, GameConfigStoreDTO gameConfigStore)
        {
            var count = gameConfigStore.ListIllustrationConfig.Count;
            var uniTasks = (stackalloc Ref_UniTask<MonsterObject.Ptr_MonsterObject>[count]);
            for (int i = 0; i < count; ++i)
            {
                var monsterName = @this.T(gameConfigStore.ListIllustrationConfig[i % count].prefab!);
                ref var uniTask = ref uniTasks[i % count];
                _ = ConfigDataStore.Ptr_ConfigDataStore.GET_MONSTER_CONFIG(out uniTask, monsterName);
            }

            List<MonsterObject.Ptr_MonsterObject> list = new(count);
            foreach (var uniTask in uniTasks)
            {
                @this.Logger.LogInformation("unitask=>{source}", uniTask.SOURCE.ToString());
                var ret = uniTask.GetResult<Ref_LoadMonsterObjectArgs>();
                if (ret)
                {
                    list.Add(ret);
                }
            }

         
            return list;
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

        public static UserDataManager.Ptr_UserDataManager GetUserDataManager(this GhostmonGameContext @this)
        {
            return @this.UserDataManager.INSTANCE;
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
            var userData = userDataManager.USER_DATA;
            if (userData.Valid() == false)
            {
                return GameException.Throw<GameCurrencyInfoDTO>("USER_DATA IS NULL");
            }
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
            var userData = userDataManager.USER_DATA;
            if (userData.Valid() == false)
            {
                return GameException.Throw<GameCurrencyInfoDTO>("USER_DATA IS NULL");
            }
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
    }


}
