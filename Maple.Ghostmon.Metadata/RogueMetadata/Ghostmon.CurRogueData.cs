using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."CurRogueData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020003BFU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [67, 117, 114, 82, 111, 103, 117, 101, 68, 97, 116, 97])]


    // struct 0x10 System.Int32 max_reiki
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"max_reiki", "MAX_REIKI")]

    // struct 0x14 System.Int32 reiki
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "reiki", "REIKI", IsReadOnly = false)]

    // struct 0x18 System.Int32 shelterLv
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"shelterLv", "SHELTER_LV")]

    // struct 0x1C System.Int32 shelterExp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"shelterExp", "SHELTER_EXP")]

    // struct 0x20 System.Int32 max_shelterExp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"max_shelterExp", "MAX_SHELTER_EXP")]

    // struct 0x24 System.Int32 guardDays
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"guardDays", "GUARD_DAYS")]

    // struct 0x28 System.Int32 streakingDays
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"streakingDays", "STREAKING_DAYS")]

    // struct 0x2C System.Int32 maxStreaking
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxStreaking", "MAX_STREAKING")]

    // struct 0x30 System.Int32 coin_num
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "coin_num", "COIN_NUM", IsReadOnly = false)]

    // struct 0x34 System.Int32 seal_num
    //[MonoCollectorSearchFieldAttribute(typeof(System.Int32), "seal_num", "SEAL_NUM")]

    // class 0x38 System.Collections.Generic.List<MonsterData> seal_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seal_monsters", "SEAL_MONSTERS")]

    // struct 0x40 System.Int32 max_takeMonster
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"max_takeMonster", "MAX_TAKE_MONSTER")]

    // struct 0x44 System.Int32 max_deployMonster
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"max_deployMonster", "MAX_DEPLOY_MONSTER")]

    // class 0x48 System.Collections.Generic.List<System.UInt64> take_destiny
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"take_destiny", "TAKE_DESTINY")]

    // struct 0x50 System.UInt64 monster_ID_Index
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"monster_ID_Index", "MONSTER_ID_INDEX")]

    // class 0x58 System.Collections.Generic.List<MonsterData> take_monsters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<MonsterData.Ptr_MonsterData>), "take_monsters", "TAKE_MONSTERS")]

    // class 0x60 System.Collections.Generic.List<System.UInt64> battle_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_monsters", "BATTLE_MONSTERS")]

    // class 0x68 System.Collections.Generic.List<Ghostmon.V2> battle_positions
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_positions", "BATTLE_POSITIONS")]

    // class 0x70 System.Collections.Generic.List<Ghostmon.CharmData> total_charms
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<CharmData.Ptr_CharmData>), "total_charms", "TOTAL_CHARMS")]

    // class 0x78 System.Collections.Generic.List<System.UInt64> take_charms
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"take_charms", "TAKE_CHARMS")]

    // class 0x80 System.Collections.Generic.List<Ghostmon.EvoMaterialData> total_evoMaterials
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<EvoMaterialData.Ptr_EvoMaterialData>), "total_evoMaterials", "TOTAL_EVO_MATERIALS")]

    // class 0x88 System.Collections.Generic.List<Ghostmon.AbilityBookData> total_abilityBooks
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<AbilityBookData.Ptr_AbilityBookData>), "total_abilityBooks", "TOTAL_ABILITY_BOOKS")]

    // class 0x90 System.Collections.Generic.List<Ghostmon.CommonData> total_prop
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_prop", "TOTAL_PROP")]

    // class 0x98 System.Collections.Generic.List<Ghostmon.RoguePropData> propEffect
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"propEffect", "PROP_EFFECT")]

    // class 0xA0 Ghostmon.RandomDayEvent randomDayEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"randomDayEvent", "RANDOM_DAY_EVENT")]

    // class 0xA8 System.Collections.Generic.List<Ghostmon.RogueGoodsData> shop_goods
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"shop_goods", "SHOP_GOODS")]

    // class 0xB0 System.Collections.Generic.List<Ghostmon.CommonData> buy_goods
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buy_goods", "BUY_GOODS")]

    // struct 0xB8 System.UInt64 lastEnemyGroup
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"lastEnemyGroup", "LAST_ENEMY_GROUP")]

    // struct 0xC0 System.Int32 refreshShopIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"refreshShopIndex", "REFRESH_SHOP_INDEX")]

    // struct 0xC4 System.Int32 remainFreeShop
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"remainFreeShop", "REMAIN_FREE_SHOP")]

    // struct 0xC8 System.Boolean lockShop
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"lockShop", "LOCK_SHOP")]

    // class 0xD0 System.Collections.Generic.List<System.String> newMonsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"newMonsters", "NEW_MONSTERS")]

    // class 0xD8 System.Collections.Generic.List<System.UInt64> newDestinys
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"newDestinys", "NEW_DESTINYS")]

    // struct 0xE0 System.Int32 incomeLv
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "incomeLv", "INCOME_LV")]

    // struct 0xE4 System.Int32 shopLv
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "shopLv", "SHOP_LV")]
    public partial class CurRogueData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "CurRogueData";
        //public static byte[] Static_ClassName { get; } = [67, 117, 114, 82, 111, 103, 117, 101, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020003BFU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CurRogueData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CurRogueData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CurRogueData obj) => obj._ptr;
            public static implicit operator bool(Ptr_CurRogueData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."CurRogueData"]
    /// </summary>
    public partial class CurRogueData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();




        /// public static partial class Search_CurRogueData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}