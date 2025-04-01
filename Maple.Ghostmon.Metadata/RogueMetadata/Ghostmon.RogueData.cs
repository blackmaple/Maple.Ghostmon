using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."RogueData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020003BEU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [82, 111, 103, 117, 101, 68, 97, 116, 97])]


    // struct 0x10 System.Int32 rogueLv
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"rogueLv", "ROGUE_LV")]

    // struct 0x14 System.Int32 rogueExp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"rogueExp", "ROGUE_EXP")]

    // struct 0x18 System.Int32 maxRogueExp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxRogueExp", "MAX_ROGUE_EXP")]

    // class 0x20 System.Collections.Generic.List<System.UInt64> unlock_destiny
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_destiny", "UNLOCK_DESTINY")]

    // class 0x28 System.Collections.Generic.List<MonsterData> unlock_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_monsters", "UNLOCK_MONSTERS")]

    // class 0x30 System.Collections.Generic.List<Ghostmon.RogueRecord> rogueRecords
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rogueRecords", "ROGUE_RECORDS")]

    // class 0x38 System.Collections.Generic.List<System.UInt64> topRecords
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"topRecords", "TOP_RECORDS")]

    // class 0x40 Ghostmon.CurRogueData curRogueData
    [MonoCollectorSearchFieldAttribute(typeof(CurRogueData.Ptr_CurRogueData), "curRogueData", "CUR_ROGUE_DATA")]

    // struct 0x48 System.UInt64 record_index
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"record_index", "RECORD_INDEX")]

    // struct 0x50 System.Int32 sortRecord
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"sortRecord", "SORT_RECORD")]

    // class 0x58 System.Collections.Generic.List<System.UInt64> unlock_challenges
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_challenges", "UNLOCK_CHALLENGES")]

    // class 0x60 System.Collections.Generic.List<System.UInt64> challenges
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"challenges", "CHALLENGES")]

    // class 0x68 System.Collections.Generic.List<System.UInt64> unlock_Plot
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlock_Plot", "UNLOCK_PLOT")]

    // class 0x70 System.Collections.Generic.List<System.UInt64> completedAchievements
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"completedAchievements", "COMPLETED_ACHIEVEMENTS")]

    // class 0x78 System.Collections.Generic.List<System.UInt64> completedGuide
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"completedGuide", "COMPLETED_GUIDE")]
    public partial class RogueData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "RogueData";
        //public static byte[] Static_ClassName { get; } = [82, 111, 103, 117, 101, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020003BEU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RogueData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RogueData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RogueData obj) => obj._ptr;
            public static implicit operator bool(Ptr_RogueData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."RogueData"]
    /// </summary>
    public partial class RogueData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();




        /// public static partial class Search_RogueData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}