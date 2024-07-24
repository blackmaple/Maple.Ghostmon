
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{

    [Flags]
    public enum EnumGameSystemFunction
    {
        ReleaseCharm = 1,
        ScanMode = 2,
    }

    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."UserData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200028FU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [85, 115, 101, 114, 68, 97, 116, 97])]

    #region 0.95c
    // class 0x10 System.String appVer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"appVer", "APP_VER")]

    // class 0x18 System.String playerName
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"playerName", "PLAYER_NAME")]

    // struct 0x20 System.Single playTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"playTime", "PLAY_TIME")]

    // struct 0x24 System.UInt32 gameTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"gameTime", "GAME_TIME")]

    // struct 0x28 Ghostmon.V2 savePos
    // [MonoCollectorSearchFieldAttribute(typeof(Ghostmon.V2),"savePos", "SAVE_POS")]

    // struct 0x30 System.Int32 systemFunction
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"systemFunction", "SYSTEM_FUNCTION")]

    // class 0x38 System.Collections.Generic.List<System.UInt64> completedAchievements
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"completedAchievements", "COMPLETED_ACHIEVEMENTS")]

    // struct 0x40 System.Int32 lev_rank
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"lev_rank", "LEV_RANK")]

    // struct 0x44 System.Int32 rank_value
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"rank_value", "RANK_VALUE")]

    // struct 0x48 System.Int32 total_rankValue
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"total_rankValue", "TOTAL_RANK_VALUE")]

    // struct 0x4C System.Int32 lev_seal
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"lev_seal", "LEV_SEAL")]

    // struct 0x50 System.UInt64 monster_ID_Index
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"monster_ID_Index", "MONSTER_ID_INDEX")]

    // struct 0x58 System.UInt64 egg_ID_Index
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"egg_ID_Index", "EGG_ID_INDEX")]

    // struct 0x60 System.Int32 coin_num
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"coin_num", "COIN_NUM")]

    // struct 0x64 System.Int32 gem_num
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"gem_num", "GEM_NUM")]

    // struct 0x68 System.Int32 heartStone_num
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"heartStone_num", "HEART_STONE_NUM")]

    // struct 0x6C System.Single reiki
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"reiki", "REIKI")]

    // struct 0x70 System.Single max_reiki
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"max_reiki", "MAX_REIKI")]

    // struct 0x74 System.Int32 auto_recover_level
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"auto_recover_level", "AUTO_RECOVER_LEVEL")]

    // class 0x78 System.Collections.Generic.List<Ghostmon.TaskData> currentTasks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"currentTasks", "CURRENT_TASKS")]

    // class 0x80 System.Collections.Generic.List<System.UInt64> completedTasks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"completedTasks", "COMPLETED_TASKS")]

    // class 0x88 System.Collections.Generic.List<System.UInt64> unreceivedTasks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unreceivedTasks", "UNRECEIVED_TASKS")]

    // class 0x90 System.Collections.Generic.List<System.UInt64> completedFight
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"completedFight", "COMPLETED_FIGHT")]

    // struct 0x98 System.Int32 max_takeMonster
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"max_takeMonster", "MAX_TAKE_MONSTER")]

    // struct 0x9C System.Int32 max_deployMonster
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"max_deployMonster", "MAX_DEPLOY_MONSTER")]

    // struct 0xA0 System.UInt64 accompany_monster
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"accompany_monster", "ACCOMPANY_MONSTER")]

    // class 0xA8 System.Collections.Generic.List<Ghostmon.IllustrationData> firstSeal_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"firstSeal_monsters", "FIRST_SEAL_MONSTERS")]

    // class 0xB0 System.Collections.Generic.List<System.String> meet_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"meet_monsters", "MEET_MONSTERS")]

    // class 0xB8 System.Collections.Generic.List<System.UInt64> take_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"take_monsters", "TAKE_MONSTERS")]

    // class 0xC0 System.Collections.Generic.List<System.UInt64> battle_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_monsters", "BATTLE_MONSTERS")]

    // class 0xC8 System.Collections.Generic.List<Ghostmon.V2> battle_positions
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_positions", "BATTLE_POSITIONS")]

    // class 0xD0 System.Collections.Generic.List<System.UInt64> battle_monsters_npc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_monsters_npc", "BATTLE_MONSTERS_NPC")]

    // class 0xD8 System.Collections.Generic.List<Ghostmon.V2> battle_positions_npc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_positions_npc", "BATTLE_POSITIONS_NPC")]

    // class 0xE0 System.Collections.Generic.List<System.Collections.Generic.List<System.UInt64>> take_charms
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"take_charms", "TAKE_CHARMS")]

    // struct 0xE8 System.Int32 current_charmBag
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"current_charmBag", "CURRENT_CHARM_BAG")]

    // struct 0xEC System.Int32 current_charmIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"current_charmIndex", "CURRENT_CHARM_INDEX")]

    // class 0xF0 System.Collections.Generic.List<System.UInt64> unlock_shelter
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_shelter", "UNLOCK_SHELTER")]

    // class 0xF8 System.Collections.Generic.List<System.Int32> unlock_area
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_area", "UNLOCK_AREA")]

    // class 0x100 System.Collections.Generic.Dictionary<System.UInt64,MonsterData> total_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_monsters", "TOTAL_MONSTERS")]

    // class 0x108 System.Collections.Generic.List<MonsterData> seal_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seal_monsters", "SEAL_MONSTERS")]

    // class 0x110 System.Collections.Generic.List<Ghostmon.MaterialData> total_materials
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_materials", "TOTAL_MATERIALS")]

    // class 0x118 System.Collections.Generic.List<Ghostmon.RareData> total_rare
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_rare", "TOTAL_RARE")]

    // class 0x120 System.Collections.Generic.List<Ghostmon.TreasureData> total_treasure
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_treasure", "TOTAL_TREASURE")]

    // class 0x128 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.CharmData> total_charms
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_charms", "TOTAL_CHARMS")]

    // class 0x130 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.EvoMaterialData> total_evoMaterials
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, EvoMaterialData.Ptr_EvoMaterialData>), "total_evoMaterials", "TOTAL_EVO_MATERIALS")]

    // class 0x138 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.AbilityBookData> total_abilityBooks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_abilityBooks", "TOTAL_ABILITY_BOOKS")]

    // class 0x140 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.FishLureItemData> total_fishLure
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_fishLure", "TOTAL_FISH_LURE")]

    // class 0x148 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.EggData> total_egg
    //[MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, EggData.Ptr_EggData>), "total_egg", "TOTAL_EGG")]

    // class 0x150 System.Collections.Generic.List<System.UInt64> total_menu
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_menu", "TOTAL_MENU")]

    // class 0x158 System.Collections.Generic.List<System.UInt64> total_clothing
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_clothing", "TOTAL_CLOTHING")]

    // class 0x160 System.Collections.Generic.List<System.UInt64> total_itemRecipe
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_itemRecipe", "TOTAL_ITEM_RECIPE")]

    // class 0x168 System.Collections.Generic.List<System.UInt64> makable_fishLure
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"makable_fishLure", "MAKABLE_FISH_LURE")]

    // class 0x170 System.Collections.Generic.List<System.UInt64> reserched_menu
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"reserched_menu", "RESERCHED_MENU")]

    // class 0x178 System.Collections.Generic.List<System.UInt64> makable_charms
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"makable_charms", "MAKABLE_CHARMS")]

    // class 0x180 System.Collections.Generic.List<System.Int64> triggered_mapEvents
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"triggered_mapEvents", "TRIGGERED_MAP_EVENTS")]

    // class 0x188 System.Collections.Generic.List<System.Int64> collect_chest_IDs
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"collect_chest_IDs", "COLLECT_CHEST_I_DS")]

    // class 0x190 System.Collections.Generic.Dictionary<System.Int64,System.UInt32> ts_map_res
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ts_map_res", "TS_MAP_RES")]

    // class 0x198 System.Collections.Generic.Dictionary<System.UInt64,System.UInt32> ts_map_demon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ts_map_demon", "TS_MAP_DEMON")]

    // class 0x1A0 System.Collections.Generic.List<Ghostmon.MapMarkData> mapMarkers
     [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<MapMarkData.Ptr_MapMarkData>),"mapMarkers", "MAP_MARKERS")]

    // class 0x1A8 System.Collections.Generic.Dictionary<System.UInt64,System.Collections.Generic.List<Ghostmon.CommonData>> shop_goods
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"shop_goods", "SHOP_GOODS")]

    // class 0x1B0 Ghostmon.TownData town_data
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"town_data", "TOWN_DATA")]

    // class 0x1B8 Ghostmon.TimeData timeData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"timeData", "TIME_DATA")]

    // class 0x1C0 System.Collections.Generic.List<System.UInt64> unLockGuide
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unLockGuide", "UN_LOCK_GUIDE")]

    // class 0x1C8 Ghostmon.CharacterClothings characterClothings
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"characterClothings", "CHARACTER_CLOTHINGS")]
    #endregion
    // class 0x10 System.String playerName
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "playerName", "PLAYER_NAME")]

    // struct 0x18 System.Single playTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"playTime", "PLAY_TIME")]

    // struct 0x1C System.UInt32 gameTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"gameTime", "GAME_TIME")]

    // struct 0x20 Ghostmon.V2 savePos
    // [MonoCollectorSearchFieldAttribute(typeof(Ghostmon.V2),"savePos", "SAVE_POS")]

    // struct 0x28 System.Int32 systemFunction
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "systemFunction", "SYSTEM_FUNCTION", IsReadOnly = false)]

    // struct 0x2C System.Int32 lev_rank
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "lev_rank", "LEV_RANK")]

    // struct 0x30 System.Int32 monster_maxLev
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"monster_maxLev", "MONSTER_MAX_LEV")]

    // struct 0x34 System.Int32 rank_value
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "rank_value", "RANK_VALUE", IsReadOnly = false)]

    // struct 0x38 System.Int32 total_rankValue
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "total_rankValue", "TOTAL_RANK_VALUE")]

    // struct 0x3C System.Int32 lev_seal
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "lev_seal", "LEV_SEAL")]

    // struct 0x40 System.UInt64 monster_ID_Index
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"monster_ID_Index", "MONSTER_ID_INDEX")]

    // struct 0x48 System.UInt64 menu_ID_Index
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"menu_ID_Index", "MENU_ID_INDEX")]

    // struct 0x50 System.UInt64 egg_ID_Index
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"egg_ID_Index", "EGG_ID_INDEX")]

    // struct 0x58 System.Int32 coin_num
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "coin_num", "COIN_NUM", IsReadOnly = false)]

    // struct 0x5C System.Int32 gem_num
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "gem_num", "GEM_NUM", IsReadOnly = false)]

    //0.95追加 同心石
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "heartStone_num", "HEART_STONE_NUM", IsReadOnly = false)]

    // struct 0x60 System.Single reiki
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "reiki", "REIKI", IsReadOnly = false)]

    // struct 0x64 System.Single max_reiki
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "max_reiki", "MAX_REIKI")]

    // struct 0x68 System.Int32 auto_recover_level
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"auto_recover_level", "AUTO_RECOVER_LEVEL")]

    // struct 0x6C System.Int32 max_takeMonster
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"max_takeMonster", "MAX_TAKE_MONSTER")]

    // class 0x70 System.Collections.Generic.List<Ghostmon.TaskData> currentTasks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"currentTasks", "CURRENT_TASKS")]

    // class 0x78 System.Collections.Generic.List<System.UInt64> completedTasks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"completedTasks", "COMPLETED_TASKS")]

    // class 0x80 System.Collections.Generic.List<System.UInt64> unreceivedTasks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unreceivedTasks", "UNRECEIVED_TASKS")]

    // class 0x88 System.Collections.Generic.List<System.UInt64> completedFight
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"completedFight", "COMPLETED_FIGHT")]

    // struct 0x90 System.UInt64 accompany_monster
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"accompany_monster", "ACCOMPANY_MONSTER")]

    // class 0x98 System.Collections.Generic.List<Ghostmon.IllustrationData> firstSeal_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"firstSeal_monsters", "FIRST_SEAL_MONSTERS")]

    // class 0xA0 System.Collections.Generic.List<System.String> meet_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"meet_monsters", "MEET_MONSTERS")]

    // class 0xA8 System.Collections.Generic.List<System.UInt64> take_monsters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<UInt64>), "take_monsters", "TAKE_MONSTERS")]

    // class 0xB0 System.Collections.Generic.List<System.UInt64> battle_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_monsters", "BATTLE_MONSTERS")]

    // class 0xB8 System.Collections.Generic.List<Ghostmon.V2> battle_positions
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_positions", "BATTLE_POSITIONS")]

    // class 0xC0 System.Collections.Generic.List<System.UInt64> battle_monsters_npc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_monsters_npc", "BATTLE_MONSTERS_NPC")]

    // class 0xC8 System.Collections.Generic.List<Ghostmon.V2> battle_positions_npc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_positions_npc", "BATTLE_POSITIONS_NPC")]

    // struct 0xD0 System.Int32 current_charmBag
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"current_charmBag", "CURRENT_CHARM_BAG")]

    // struct 0xD4 System.Int32 current_charmIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"current_charmIndex", "CURRENT_CHARM_INDEX")]

    // class 0xD8 System.Collections.Generic.List<System.Collections.Generic.List<System.UInt64>> take_charms
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"take_charms", "TAKE_CHARMS")]

    // class 0xE0 System.Collections.Generic.List<System.UInt64> makable_charms
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"makable_charms", "MAKABLE_CHARMS")]

    // class 0xE8 System.Collections.Generic.List<System.UInt64> unlock_shelter
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_shelter", "UNLOCK_SHELTER")]

    // class 0xF0 System.Collections.Generic.List<System.Int32> unlock_area
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_area", "UNLOCK_AREA")]

    // class 0xF8 System.Collections.Generic.Dictionary<System.UInt64,MonsterData> total_monsters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, MonsterData.Ptr_MonsterData>), "total_monsters", "TOTAL_MONSTERS")]

    // class 0x100 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.CharmData> total_charms
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, CharmData.Ptr_CharmData>), "total_charms", "TOTAL_CHARMS")]

    // class 0x108 System.Collections.Generic.List<Ghostmon.MaterialData> total_materials
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<MaterialData.Ptr_MaterialData>), "total_materials", "TOTAL_MATERIALS")]

    // class 0x110 System.Collections.Generic.List<Ghostmon.RareData> total_rare
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<RareData.Ptr_RareData>), "total_rare", "TOTAL_RARE")]

    // class 0x118 System.Collections.Generic.List<Ghostmon.TreasureData> total_treasure
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<TreasureData.Ptr_TreasureData>), "total_treasure", "TOTAL_TREASURE")]

    // class 0x120 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.AbilityBookData> total_abilityBooks
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, AbilityBookData.Ptr_AbilityBookData>), "total_abilityBooks", "TOTAL_ABILITY_BOOKS")]

    // class 0x128 System.Collections.Generic.Dictionary<System.UInt64,System.UInt64> total_menu
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, UInt64>), "total_menu", "TOTAL_MENU")]

    // class 0x130 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.EggData> total_egg
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, EggData.Ptr_EggData>), "total_egg", "TOTAL_EGG")]

    // class 0x138 System.Collections.Generic.List<System.UInt64> total_clothing
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<UInt64>), "total_clothing", "TOTAL_CLOTHING")]

    // class 0x140 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.ItemRecipeData> total_itemRecipe
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, ItemRecipeData.Ptr_ItemRecipeData>), "total_itemRecipe", "TOTAL_ITEM_RECIPE")]

    // class 0x148 System.Collections.Generic.Dictionary<System.UInt64,Ghostmon.FishLureItemData> total_fishLure
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, FishLureItemData.Ptr_FishLureItemData>), "total_fishLure", "TOTAL_FISH_LURE")]

    // class 0x150 System.Collections.Generic.List<System.UInt64> makable_fishLure
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"makable_fishLure", "MAKABLE_FISH_LURE")]

    // class 0x158 System.Collections.Generic.List<System.Int64> triggered_mapEvents
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"triggered_mapEvents", "TRIGGERED_MAP_EVENTS")]

    // class 0x160 System.Collections.Generic.List<System.Int64> collect_chest_IDs
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"collect_chest_IDs", "COLLECT_CHEST_I_DS")]

    // class 0x168 System.Collections.Generic.Dictionary<System.Int64,System.UInt32> collect_map_res
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"collect_map_res", "COLLECT_MAP_RES")]

    // class 0x170 System.Collections.Generic.List<Ghostmon.MapMarkData> mapMarkers
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"mapMarkers", "MAP_MARKERS")]

    // class 0x178 Ghostmon.TravelStats travel_stats
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"travel_stats", "TRAVEL_STATS")]

    // class 0x180 Ghostmon.TownData town_data
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"town_data", "TOWN_DATA")]

    // class 0x188 Ghostmon.TimeData timeData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"timeData", "TIME_DATA")]

    // class 0x190 System.Collections.Generic.List<System.UInt64> unLockGuide
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unLockGuide", "UN_LOCK_GUIDE")]

    // class 0x198 Ghostmon.CharacterClothings characterClothings
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"characterClothings", "CHARACTER_CLOTHINGS")]
    public partial class UserData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "UserData";
        //public static byte[] Static_ClassName { get; } = [85, 115, 101, 114, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x0200028FU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UserData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UserData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UserData obj) => obj._ptr;
            public static implicit operator bool(Ptr_UserData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."UserData"]
    /// </summary>
    public partial class UserData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();




        /// public static partial class Search_UserData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}