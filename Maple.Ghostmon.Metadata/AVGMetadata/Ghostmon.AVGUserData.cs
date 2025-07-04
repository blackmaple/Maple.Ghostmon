using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."AVGUserData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000442U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [65, 86, 71, 85, 115, 101, 114, 68, 97, 116, 97])]


    // class 0x10 System.String curAvgMapName
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"curAvgMapName", "CUR_AVG_MAP_NAME")]

    // struct 0x18 System.Single playTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"playTime", "PLAY_TIME")]

    // struct 0x1C Ghostmon.V2 savePos
    // [MonoCollectorSearchFieldAttribute(typeof(Ghostmon.V2),"savePos", "SAVE_POS")]

    // class 0x28 System.Collections.Generic.Dictionary<System.UInt64,AVGMonsterData> total_monsters
    //[MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<UInt64, AVGMonsterData.Ptr_AVGMonsterData>), "total_monsters", "TOTAL_MONSTERS")]

    // class 0x30 System.Collections.Generic.List<AVGMonsterData> take_monsters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<AVGMonsterData.Ptr_AVGMonsterData>), "take_monsters", "TAKE_MONSTERS")]

    // class 0x38 System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<AVGMonsterData>> save_monsters
    //   [MonoCollectorSearchFieldAttribute(typeof(nint),"save_monsters", "SAVE_MONSTERS")]

    // class 0x40 System.Collections.Generic.List<AVGBagItemData> total_items
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<AVGBagItemData.Ptr_AVGBagItemData>), "total_items", "TOTAL_ITEMS")]

    // struct 0x48 System.Boolean isBattle
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isBattle", "IS_BATTLE")]

    // class 0x50 Ghostmon.AVGTaskData task_data
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"task_data", "TASK_DATA")]

    // struct 0x58 System.Int32 gold
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "gold", "GOLD", IsReadOnly = false)]

    // class 0x60 System.Collections.Generic.List<System.UInt64> alreadyFinishNpcBattle
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"alreadyFinishNpcBattle", "ALREADY_FINISH_NPC_BATTLE")]

    // class 0x68 System.Collections.Generic.List<System.UInt64> alreadyOpenChestIds
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"alreadyOpenChestIds", "ALREADY_OPEN_CHEST_IDS")]

    // class 0x70 System.Collections.Generic.List<System.UInt64> collectionHandBookIds
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"collectionHandBookIds", "COLLECTION_HAND_BOOK_IDS")]

    // struct 0x78 System.Boolean isOpenCollider
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isOpenCollider", "IS_OPEN_COLLIDER")]

    // struct 0x79 System.Boolean isMeetEnemy
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isMeetEnemy", "IS_MEET_ENEMY")]

    // struct 0x7A System.Boolean isBattleMonsterData
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isBattleMonsterData", "IS_BATTLE_MONSTER_DATA")]
    public partial class AVGUserData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "AVGUserData";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 85, 115, 101, 114, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000442U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGUserData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGUserData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGUserData obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGUserData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."AVGUserData"]
    /// </summary>
    public partial class AVGUserData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Void RefreshLanguage()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshLanguage")]
        ///  extern void REFRESH_LANGUAGE ();




        /// public static partial class Search_AVGUserData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}