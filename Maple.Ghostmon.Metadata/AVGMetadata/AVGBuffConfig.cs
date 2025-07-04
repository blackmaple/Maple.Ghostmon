using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AVGBuffConfig"]
    /// [Ghostmon.BaseConfig]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000031U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 66, 117, 102, 102, 67, 111, 110, 102, 105, 103])]


    // struct 0x10 System.UInt64 configID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "configID", "CONFIG_ID", IsReadOnly = false)]

    // class 0x18 System.String name
    [MonoCollectorSearchFieldAttribute(typeof(nint), "name", "NAME")]

    // class 0x20 System.String prefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"prefab", "PREFAB")]

    // class 0x28 System.String description
    [MonoCollectorSearchFieldAttribute(typeof(nint), "description", "DESCRIPTION")]

    // class 0x30 System.String icon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon", "ICON")]

    // enum 0x38 AVGPrimaryBuffType buffType
    // [MonoCollectorSearchFieldAttribute(typeof(AVGPrimaryBuffType),"buffType", "BUFF_TYPE")]

    // struct 0x3C System.Boolean dispelable
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"dispelable", "DISPELABLE")]

    // class 0x40 System.Collections.Generic.Dictionary<AVGMonsterBasePropChange,System.Int32> adjust
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"adjust", "ADJUST")]

    // enum 0x48 AVGBuffEffectType effect
    // [MonoCollectorSearchFieldAttribute(typeof(AVGBuffEffectType),"effect", "EFFECT")]

    // struct 0x4C System.Int32 ability
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"ability", "ABILITY")]

    // struct 0x50 System.Int32 duration
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"duration", "DURATION")]

    // struct 0x54 System.Boolean immune
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"immune", "IMMUNE")]

    // struct 0x55 System.Boolean useOverflow
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"useOverflow", "USE_OVERFLOW")]

    // struct 0x56 System.Boolean isShowBattleIcon
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isShowBattleIcon", "IS_SHOW_BATTLE_ICON")]
    public partial class _AVGBuffConfig
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGBuffConfig";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 66, 117, 102, 102, 67, 111, 110, 102, 105, 103];

        //public const uint Const_TypeToken = 0x02000031U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr__AVGBuffConfig(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr__AVGBuffConfig(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr__AVGBuffConfig obj) => obj._ptr;
            public static implicit operator bool(Ptr__AVGBuffConfig obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGBuffConfig"]
    /// </summary>
    public partial class _AVGBuffConfig
    {





        /// <summary>
        ///   System.Void .ctor(System.Int32 buffType, System.String adjust, System.String effect)
        /// </summary>
        /// <param name="buffType">struct System.Int32</param>
        /// <param name="adjust">class System.String</param>
        /// <param name="effect">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGBuffConfig))]
        ///  extern void .CTOR_00 (System.Int32 buffType, nint adjust, nint effect);


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGBuffConfig))]
        //extern void CTOR_01();


        //     public static partial class Search_AVGBuffConfig
        //     {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(System.Int32 buffType, System.String adjust, System.String effect)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.String", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        //        public static bool CTOR_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        //           => Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 
        /// 
        //   }

    }


}