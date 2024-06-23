
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."UserDataManager"]
    /// [Ghostmon.Framework.Singleton<Ghostmon.UserDataManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200029CU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [85, 115, 101, 114, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114])]
                
    //  class static Ghostmon.UserDataManager instance
      [MonoCollectorSearchFieldAttribute(typeof(UserDataManager.Ptr_UserDataManager),"instance", "INSTANCE", true)]
                
    // class 0x10 Ghostmon.UserData userData
     [MonoCollectorSearchFieldAttribute(typeof(UserData.Ptr_UserData),"userData", "USER_DATA")]
            
    // class 0x18 PlayerProperty playerProperty
   [MonoCollectorSearchFieldAttribute(typeof(PlayerProperty.Ptr_PlayerProperty),"playerProperty", "PLAYER_PROPERTY")]
            
    // class 0x20 Ghostmon.CuisineData eat_cuisines
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"eat_cuisines", "EAT_CUISINES")]
            
    // class 0x28 System.Collections.Generic.List<System.UInt64> up_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"up_monsters", "UP_MONSTERS")]
    public partial class UserDataManager
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "UserDataManager";
        //public static byte[] Static_ClassName { get; } = [85, 115, 101, 114, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x0200029CU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UserDataManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UserDataManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UserDataManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_UserDataManager obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Ghostmon"."UserDataManager"]
        /// </summary>
        public partial class UserDataManager
        { 

            
            
            /// <summary>
            /// static  System.Single <MonsterEvolve>g__ReMapNumber|57_0(System.Single value, UnityEngine.Vector2 a, UnityEngine.Vector2 b)
            /// </summary>
            /// <param name="value">struct System.Single</param>
            /// <param name="a">struct UnityEngine.Vector2</param>
            /// <param name="b">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<MonsterEvolve>g__ReMapNumber|57_0")]
            /// static extern System.Single <MONSTER_EVOLVE>G__RE_MAP_NUMBER|57_0 (System.Single value, UnityEngine.Vector2 a, UnityEngine.Vector2 b);

            
            /// <summary>
            ///   System.Int32[] <ProduceEgg>g__GetHighestIndex|76_0(MonsterData monsterData, Ghostmon.UserDataManager.<>c__DisplayClass76_0& )
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <param name="">struct Ghostmon.UserDataManager.<>c__DisplayClass76_0&</param>
            /// <returns>class System.Int32[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ProduceEgg>g__GetHighestIndex|76_0")]
            ///  extern nint <PRODUCE_EGG>G__GET_HIGHEST_INDEX|76_0 (nint monsterData, Ghostmon.UserDataManager.<>c__DisplayClass76_0& );

            
            /// <summary>
            /// static  System.Single <ProduceEgg>g__GetHighestValue|76_1(MonsterData monsterData, System.Int32 index)
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ProduceEgg>g__GetHighestValue|76_1")]
            /// static extern System.Single <PRODUCE_EGG>G__GET_HIGHEST_VALUE|76_1 (nint monsterData, System.Int32 index);

            
            /// <summary>
            ///   System.Boolean <RefreshEntrustTask>b__69_0(Newtonsoft.Json.Linq.JToken t)
            /// </summary>
            /// <param name="t">abstract class Newtonsoft.Json.Linq.JToken</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RefreshEntrustTask>b__69_0")]
            ///  extern System.Boolean <REFRESH_ENTRUST_TASK>B__69_0 (nint t);

            
            /// <summary>
            ///   System.Boolean <RoleUpLev>b__18_0(Newtonsoft.Json.Linq.JToken t)
            /// </summary>
            /// <param name="t">abstract class Newtonsoft.Json.Linq.JToken</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RoleUpLev>b__18_0")]
            ///  extern System.Boolean <ROLE_UP_LEV>B__18_0 (nint t);

            
            /// <summary>
            /// static  System.Int32 <SetMonsterPro>g__SetProValue|45_0(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<SetMonsterPro>g__SetProValue|45_0")]
            /// static extern System.Int32 <SET_MONSTER_PRO>G__SET_PRO_VALUE|45_0 (System.Int32 index);

            
            /// <summary>
            ///   System.Void AddCaravanData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCaravanData")]
            ///  extern void ADD_CARAVAN_DATA ();

            
            /// <summary>
            ///   System.Void AddCook(Ghostmon.WorkData workData)
            /// </summary>
            /// <param name="workData">class Ghostmon.WorkData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCook")]
            ///  extern void ADD_COOK (nint workData);

            
            /// <summary>
            ///   System.Void AddDrawItem(Ghostmon.WorkData farmData)
            /// </summary>
            /// <param name="farmData">class Ghostmon.WorkData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDrawItem")]
            ///  extern void ADD_DRAW_ITEM (nint farmData);

            
            /// <summary>
            ///   System.Void AddFood(MonsterData monsterData)
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFood")]
            ///  extern void ADD_FOOD (nint monsterData);

            
            /// <summary>
            ///   System.Void AddHunter(Ghostmon.WorkData farmData)
            /// </summary>
            /// <param name="farmData">class Ghostmon.WorkData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHunter")]
            ///  extern void ADD_HUNTER (nint farmData);

            
            /// <summary>
            ///   System.Void AddMeetMonster(System.String prefab)
            /// </summary>
            /// <param name="prefab">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMeetMonster")]
            ///  extern void ADD_MEET_MONSTER (nint prefab);

            
            /// <summary>
            ///   System.Void AddMiner(Ghostmon.WorkData data)
            /// </summary>
            /// <param name="data">class Ghostmon.WorkData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMiner")]
            ///  extern void ADD_MINER (nint data);

            
            /// <summary>
            ///   System.Void AddMonster(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonster")]
            ///  extern void ADD_MONSTER (nint monster);

            
            /// <summary>
            ///   System.Void AddPlanter(Ghostmon.WorkData farmData)
            /// </summary>
            /// <param name="farmData">class Ghostmon.WorkData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlanter")]
            ///  extern void ADD_PLANTER (nint farmData);

            
            /// <summary>
            ///   System.Void AddStone(MonsterData monsterData)
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStone")]
            ///  extern void ADD_STONE (nint monsterData);

            
            /// <summary>
            ///   System.Void AutoEquipCharm(System.UInt64 ID)
            /// </summary>
            /// <param name="ID">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AutoEquipCharm")]
            ///  extern void AUTO_EQUIP_CHARM (System.UInt64 ID);

            
            /// <summary>
            ///   System.Void BalanceCanteen()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BalanceCanteen")]
            ///  extern void BALANCE_CANTEEN ();

            
            /// <summary>
            ///   System.Void BattleMonsterGainFavority(System.Boolean isNPC)
            /// </summary>
            /// <param name="isNPC">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BattleMonsterGainFavority")]
            ///  extern void BATTLE_MONSTER_GAIN_FAVORITY (System.Boolean isNPC);

            
            /// <summary>
            ///   System.Void CaptureMonster(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CaptureMonster")]
            ///  extern void CAPTURE_MONSTER (nint monster);

            
            /// <summary>
            ///   System.Boolean CheckIsFull()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckIsFull")]
            ///  extern System.Boolean CHECK_IS_FULL ();

            
            /// <summary>
            ///   System.Boolean CheckMenuState(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckMenuState")]
            ///  extern System.Boolean CHECK_MENU_STATE (System.UInt64 id);

            
            /// <summary>
            ///   System.Boolean CheckPreyIsFull()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckPreyIsFull")]
            ///  extern System.Boolean CHECK_PREY_IS_FULL ();

            
            /// <summary>
            ///   System.Void CompleteTrade(System.Int32 coinNum, System.Int32 index)
            /// </summary>
            /// <param name="coinNum">struct System.Int32</param>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompleteTrade")]
            ///  extern void COMPLETE_TRADE (System.Int32 coinNum, System.Int32 index);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask CraeteFalseData()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CraeteFalseData")]
            ///  extern Cysharp.Threading.Tasks.UniTask CRAETE_FALSE_DATA ();

            
            /// <summary>
            /// static  Ghostmon.UserDataManager CreateInstance()
            /// </summary>
            /// <returns>class Ghostmon.UserDataManager</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInstance")]
            /// static extern nint CREATE_INSTANCE ();

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask CreateNewData()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateNewData")]
            ///  extern Cysharp.Threading.Tasks.UniTask CREATE_NEW_DATA ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Ghostmon.CommonData> DealDropData(System.UInt64 ID, System.Boolean value)
            /// </summary>
            /// <param name="ID">struct System.UInt64</param>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>class System.Collections.Generic.List<Ghostmon.CommonData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DealDropData")]
            ///  extern nint DEAL_DROP_DATA (System.UInt64 ID, System.Boolean value);

            
            /// <summary>
            ///   System.Void DealDrunkeryTime()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DealDrunkeryTime")]
            ///  extern void DEAL_DRUNKERY_TIME ();

            
            /// <summary>
            ///   System.Void DealIncubationTime()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DealIncubationTime")]
            ///  extern void DEAL_INCUBATION_TIME ();

            
            /// <summary>
            ///   System.Void DealLeaveShop()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DealLeaveShop")]
            ///  extern void DEAL_LEAVE_SHOP ();

            
            /// <summary>
            ///   System.Void DismissMonster(MonsterData m)
            /// </summary>
            /// <param name="m">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DismissMonster")]
            ///  extern void DISMISS_MONSTER (nint m);

            
            /// <summary>
            ///   System.Void EatCuisine(Ghostmon.CuisineConfig config)
            /// </summary>
            /// <param name="config">class Ghostmon.CuisineConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EatCuisine")]
            ///  extern void EAT_CUISINE (nint config);

            
            /// <summary>
            ///   System.Void EmployMonster(Ghostmon.EmployeeData data)
            /// </summary>
            /// <param name="data">class Ghostmon.EmployeeData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EmployMonster")]
            ///  extern void EMPLOY_MONSTER (nint data);

            
            /// <summary>
            ///   System.Void ExpectMonsterGainExp(MonsterData data, System.Int32 exp, System.Int32 currentExp, System.Int32 upLv, System.Int32& lev, System.Int32& addExp)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <param name="exp">struct System.Int32</param>
            /// <param name="currentExp">struct System.Int32</param>
            /// <param name="upLv">struct System.Int32</param>
            /// <param name="lev">struct System.Int32&</param>
            /// <param name="addExp">struct System.Int32&</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExpectMonsterGainExp")]
            ///  extern void EXPECT_MONSTER_GAIN_EXP (nint data, System.Int32 exp, System.Int32 currentExp, System.Int32 upLv, System.Int32& lev, System.Int32& addExp);

            
            /// <summary>
            ///   System.Void GainAbilityBook(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainAbilityBook")]
            ///  extern void GAIN_ABILITY_BOOK (System.UInt64 id);

            
            /// <summary>
            ///   System.Void GainCoins(System.Int32 num)
            /// </summary>
            /// <param name="num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainCoins")]
            ///  extern void GAIN_COINS (System.Int32 num);

            
            /// <summary>
            ///   System.Void GainCUisine(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainCUisine")]
            ///  extern void GAIN_C_UISINE (System.UInt64 id);

            
            /// <summary>
            ///   System.Void GainEgg()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainEgg")]
            ///  extern void GAIN_EGG ();

            
            /// <summary>
            ///   System.Void GainExpAfterBattle(System.Int32 value, System.Boolean isNpc)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <param name="isNpc">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainExpAfterBattle")]
            ///  extern void GAIN_EXP_AFTER_BATTLE (System.Int32 value, System.Boolean isNpc);

            
            /// <summary>
            ///   System.Void GainExpAfterMapSeal(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainExpAfterMapSeal")]
            ///  extern void GAIN_EXP_AFTER_MAP_SEAL (System.Int32 value);

            
            /// <summary>
            ///   System.Void GainFishLure(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainFishLure")]
            ///  extern void GAIN_FISH_LURE (System.UInt64 id);

            
            /// <summary>
            ///   System.Void GainGem(System.Int32 num)
            /// </summary>
            /// <param name="num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainGem")]
            ///  extern void GAIN_GEM (System.Int32 num);

            
            /// <summary>
            ///   System.Void GainItem(System.Int32 type, System.UInt64 id, System.Int32 num)
            /// </summary>
            /// <param name="type">struct System.Int32</param>
            /// <param name="id">struct System.UInt64</param>
            /// <param name="num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainItem")]
            ///  extern void GAIN_ITEM (System.Int32 type, System.UInt64 id, System.Int32 num);

            
            /// <summary>
            ///   System.Void GainMenu(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainMenu")]
            ///  extern void GAIN_MENU (System.UInt64 id);

            
            /// <summary>
            ///   System.Void GainMonsterFromEgg(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainMonsterFromEgg")]
            ///  extern void GAIN_MONSTER_FROM_EGG (System.UInt64 id);

            
            /// <summary>
            ///   System.Int32 GainMonsterMaxExp(MonsterData data)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainMonsterMaxExp")]
            ///  extern System.Int32 GAIN_MONSTER_MAX_EXP (nint data);

            
            /// <summary>
            /// static  Ghostmon.UserDataManager get_Instance()
            /// </summary>
            /// <returns>class Ghostmon.UserDataManager</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
            /// static extern nint GET_INSTANCE ();

            
            /// <summary>
            ///   System.Int32 GetBuildingLv(System.Int32 type)
            /// </summary>
            /// <param name="type">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBuildingLv")]
            ///  extern System.Int32 GET_BUILDING_LV (System.Int32 type);

            
            /// <summary>
            ///   System.Collections.Generic.List<Ghostmon.GoodsData> GetGemShopGoods(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>class System.Collections.Generic.List<Ghostmon.GoodsData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGemShopGoods")]
            ///  extern nint GET_GEM_SHOP_GOODS (System.UInt64 id);

            
            /// <summary>
            ///   System.Void GetIncubationTime(Ghostmon.EggData eggData)
            /// </summary>
            /// <param name="eggData">class Ghostmon.EggData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIncubationTime")]
            ///  extern void GET_INCUBATION_TIME (nint eggData);

            
            /// <summary>
            ///   System.Single GetRateOfReturn(System.UInt64 id, System.Int32 jobValue)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <param name="jobValue">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRateOfReturn")]
            ///  extern System.Single GET_RATE_OF_RETURN (System.UInt64 id, System.Int32 jobValue);

            
            /// <summary>
            ///   System.Collections.Generic.List<Ghostmon.GoodsData> GetTraderGoods(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>class System.Collections.Generic.List<Ghostmon.GoodsData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTraderGoods")]
            ///  extern nint GET_TRADER_GOODS (System.UInt64 id);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask InitUserData()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitUserData")]
            ///  extern Cysharp.Threading.Tasks.UniTask INIT_USER_DATA ();

            
            /// <summary>
            /// static  System.Boolean IsActive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
            /// static extern System.Boolean IS_ACTIVE ();

            
            /// <summary>
            ///   System.Void LoadAuto()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAuto")]
            ///  extern void LOAD_AUTO ();

            
            /// <summary>
            ///   System.Void LoadManual(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadManual")]
            ///  extern void LOAD_MANUAL (System.Int32 index);

            
            /// <summary>
            ///   System.Void MakeCharm(System.Collections.Generic.Dictionary<System.UInt64,System.Int32> materials, System.Int32 currentMakableNum, Ghostmon.CharmConfig charmConfig)
            /// </summary>
            /// <param name="materials">class System.Collections.Generic.Dictionary<System.UInt64,System.Int32></param>
            /// <param name="currentMakableNum">struct System.Int32</param>
            /// <param name="charmConfig">class Ghostmon.CharmConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MakeCharm")]
            ///  extern void MAKE_CHARM (nint materials, System.Int32 currentMakableNum, nint charmConfig);

            
            /// <summary>
            ///   System.Void MonsterAttributeAdjust(MonsterData m, Ghostmon.AttributeType key, System.Single value)
            /// </summary>
            /// <param name="m">class MonsterData</param>
            /// <param name="key">enum Ghostmon.AttributeType</param>
            /// <param name="value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterAttributeAdjust")]
            ///  extern void MONSTER_ATTRIBUTE_ADJUST (nint m, Ghostmon.AttributeType key, System.Single value);

            
            /// <summary>
            ///   System.Void MonsterEvolve(MonsterData preData, System.String evoName)
            /// </summary>
            /// <param name="preData">class MonsterData</param>
            /// <param name="evoName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterEvolve")]
            ///  extern void MONSTER_EVOLVE (nint preData, nint evoName);

            
            /// <summary>
            ///   System.Void MonsterGainFavority(MonsterData data)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterGainFavority")]
            ///  extern void MONSTER_GAIN_FAVORITY (nint data);

            
            /// <summary>
            ///   System.Void MonsterGainsExp(MonsterData data, System.Int32 exp)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <param name="exp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterGainsExp")]
            ///  extern void MONSTER_GAINS_EXP (nint data, System.Int32 exp);

            
            /// <summary>
            ///   System.Void MonsterLevelUp(MonsterData data)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterLevelUp")]
            ///  extern void MONSTER_LEVEL_UP (nint data);

            
            /// <summary>
            ///   System.Void MonsterUpTip(MonsterData monsterData)
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterUpTip")]
            ///  extern void MONSTER_UP_TIP (nint monsterData);

            
            /// <summary>
            ///   System.Void OnRemove()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove")]
            ///  extern void ON_REMOVE ();

            
            /// <summary>
            ///   System.Void OrderMonster(MonsterData monsterData, System.Int32 index)
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OrderMonster")]
            ///  extern void ORDER_MONSTER (nint monsterData, System.Int32 index);

            
            /// <summary>
            ///   System.Void OrderMonsterPro(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OrderMonsterPro")]
            ///  extern void ORDER_MONSTER_PRO (nint monster);

            
            /// <summary>
            ///   System.Void ProduceEgg(Ghostmon.BlendData blendData)
            /// </summary>
            /// <param name="blendData">class Ghostmon.BlendData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ProduceEgg")]
            ///  extern void PRODUCE_EGG (nint blendData);

            
            /// <summary>
            ///   System.Int32 PropertyRank(System.Single data_1, UnityEngine.Vector2 data_2)
            /// </summary>
            /// <param name="data_1">struct System.Single</param>
            /// <param name="data_2">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PropertyRank")]
            ///  extern System.Int32 PROPERTY_RANK (System.Single data_1, UnityEngine.Vector2 data_2);

            
            /// <summary>
            ///   System.Void ReduceCharmNum(System.UInt64 id, System.Int32 num)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <param name="num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReduceCharmNum")]
            ///  extern void REDUCE_CHARM_NUM (System.UInt64 id, System.Int32 num);

            
            /// <summary>
            ///   System.Void ReduceItem(System.Int32 type, System.UInt64 id, System.Int32 num)
            /// </summary>
            /// <param name="type">struct System.Int32</param>
            /// <param name="id">struct System.UInt64</param>
            /// <param name="num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReduceItem")]
            ///  extern void REDUCE_ITEM (System.Int32 type, System.UInt64 id, System.Int32 num);

            
            /// <summary>
            ///   System.Void ReduceMat(System.Collections.Generic.Dictionary<System.UInt64,System.Int32> materials, System.Int32 currentMakableNum)
            /// </summary>
            /// <param name="materials">class System.Collections.Generic.Dictionary<System.UInt64,System.Int32></param>
            /// <param name="currentMakableNum">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReduceMat")]
            ///  extern void REDUCE_MAT (nint materials, System.Int32 currentMakableNum);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask RefreshEmployees()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshEmployees")]
            ///  extern Cysharp.Threading.Tasks.UniTask REFRESH_EMPLOYEES ();

            
            /// <summary>
            ///   System.Void RefreshEntrustTask()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshEntrustTask")]
            ///  extern void REFRESH_ENTRUST_TASK ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Ghostmon.GoodsData> RefreshGemGoods(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>class System.Collections.Generic.List<Ghostmon.GoodsData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshGemGoods")]
            ///  extern nint REFRESH_GEM_GOODS (System.UInt64 id);

            
            /// <summary>
            ///   System.Void RefreshGoods()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshGoods")]
            ///  extern void REFRESH_GOODS ();

            
            /// <summary>
            ///   System.Void RefreshShopGoods()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshShopGoods")]
            ///  extern void REFRESH_SHOP_GOODS ();

            
            /// <summary>
            ///   System.Void Remove()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
            ///  extern void REMOVE ();

            
            /// <summary>
            ///   System.Void RemovePlayerEffected()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerEffected")]
            ///  extern void REMOVE_PLAYER_EFFECTED ();

            
            /// <summary>
            ///   System.Void ReturnCharmMat(Ghostmon.WorkData data)
            /// </summary>
            /// <param name="data">class Ghostmon.WorkData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReturnCharmMat")]
            ///  extern void RETURN_CHARM_MAT (nint data);

            
            /// <summary>
            ///   System.Void ReturnPlantMat(Ghostmon.WorkData data)
            /// </summary>
            /// <param name="data">class Ghostmon.WorkData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReturnPlantMat")]
            ///  extern void RETURN_PLANT_MAT (nint data);

            
            /// <summary>
            ///   System.Boolean RoleGainExp(System.Int32 exp)
            /// </summary>
            /// <param name="exp">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RoleGainExp")]
            ///  extern System.Boolean ROLE_GAIN_EXP (System.Int32 exp);

            
            /// <summary>
            ///   System.Void RoleUpLev()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RoleUpLev")]
            ///  extern void ROLE_UP_LEV ();

            
            /// <summary>
            ///   System.Void SavaAuto()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SavaAuto")]
            ///  extern void SAVA_AUTO ();

            
            /// <summary>
            ///   System.Void SaveManual(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SaveManual")]
            ///  extern void SAVE_MANUAL (System.Int32 index);

            
            /// <summary>
            ///   System.Void SetMonsterInfo(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterInfo")]
            ///  extern void SET_MONSTER_INFO (nint monster);

            
            /// <summary>
            ///   System.Void SetMonsterName(MonsterData monsterData)
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterName")]
            ///  extern void SET_MONSTER_NAME (nint monsterData);

            
            /// <summary>
            ///   System.Void SetMonsterPro(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterPro")]
            ///  extern void SET_MONSTER_PRO (nint monster);

            
            /// <summary>
            ///   System.Void SetPlayerEffected()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPlayerEffected")]
            ///  extern void SET_PLAYER_EFFECTED ();

            
            /// <summary>
            ///   System.Void UnlockIllustration(MonsterData data, System.Boolean showTip)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <param name="showTip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockIllustration")]
            ///  extern void UNLOCK_ILLUSTRATION (nint data, System.Boolean showTip);

            
            /// <summary>
            ///   System.Void UpBuilding(System.Int32 type)
            /// </summary>
            /// <param name="type">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpBuilding")]
            ///  extern void UP_BUILDING (System.Int32 type);

            
            /// <summary>
            ///   System.Void UpdateCuisineTime(System.Single deltaTime)
            /// </summary>
            /// <param name="deltaTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateCuisineTime")]
            ///  extern void UPDATE_CUISINE_TIME (System.Single deltaTime);

            
            /// <summary>
            ///   System.Void UpdateRealTime(System.Single deltaTime)
            /// </summary>
            /// <param name="deltaTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateRealTime")]
            ///  extern void UPDATE_REAL_TIME (System.Single deltaTime);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UserDataManager))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UserDataManager))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void GainMonsterEgg(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainMonsterEgg", Search = typeof(Search_UserDataManager))]
            ///  extern void GAIN_MONSTER_EGG_00 (System.UInt64 id);

            
            /// <summary>
            ///   System.Void GainMonsterEgg(System.String monster, System.UInt64[] ablity, System.Single[] property, System.Int32 propertyRank, System.Int32 damageType)
            /// </summary>
            /// <param name="monster">class System.String</param>
            /// <param name="ablity">class System.UInt64[]</param>
            /// <param name="property">class System.Single[]</param>
            /// <param name="propertyRank">struct System.Int32</param>
            /// <param name="damageType">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainMonsterEgg", Search = typeof(Search_UserDataManager))]
            ///  extern void GAIN_MONSTER_EGG_01 (nint monster, nint ablity, nint property, System.Int32 propertyRank, System.Int32 damageType);

            
            /// <summary>
            ///   System.Void OnInit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_UserDataManager))]
            ///  extern void ON_INIT_00 ();

            
            /// <summary>
            ///   System.Void OnInit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_UserDataManager))]
            ///  extern void ON_INIT_01 ();

            
            /// public static partial class Search_UserDataManager
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GainMonsterEgg(System.UInt64 id)
                    /// </summary>
                    /// public static bool GAIN_MONSTER_EGG_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GainMonsterEgg", "System.UInt64");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GainMonsterEgg(System.String monster, System.UInt64[] ablity, System.Single[] property, System.Int32 propertyRank, System.Int32 damageType)
                    /// </summary>
                    /// public static bool GAIN_MONSTER_EGG_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GainMonsterEgg", "System.String", "System.UInt64[]", "System.Single[]", "System.Int32", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnInit()
                    /// </summary>
                    /// public static bool ON_INIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnInit()
                    /// </summary>
                    /// public static bool ON_INIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}