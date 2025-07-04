using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AVGAbilityConfig"]
    /// [Ghostmon.BaseConfig]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000033U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 65, 98, 105, 108, 105, 116, 121, 67, 111, 110, 102, 105, 103])]


    // struct 0x10 System.UInt64 configID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "configID", "CONFIG_ID", IsReadOnly = false)]

    // class 0x18 System.String name
    [MonoCollectorSearchFieldAttribute(typeof(nint), "name", "NAME")]

    // class 0x20 System.String prefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"prefab", "PREFAB")]

    // class 0x28 System.String description
    [MonoCollectorSearchFieldAttribute(typeof(nint), "description", "DESCRIPTION")]

    // struct 0x30 System.Int32 power
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"power", "POWER")]

    // struct 0x34 System.Int32 hitRate
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"hitRate", "HIT_RATE")]

    // struct 0x38 System.Boolean definitelyHit
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"definitelyHit", "DEFINITELY_HIT")]

    // struct 0x3C System.Int32 attackType
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"attackType", "ATTACK_TYPE")]

    // struct 0x40 System.Int32 mpCost
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"mpCost", "MP_COST")]

    // struct 0x44 System.Int32 skillType
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"skillType", "SKILL_TYPE")]

    // class 0x48 System.String CSScript
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"CSScript", "CS_SCRIPT")]

    // class 0x50 System.String parameter
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"parameter", "PARAMETER")]

    // enum 0x58 AVGAttributeType attributeType
    // [MonoCollectorSearchFieldAttribute(typeof(AVGAttributeType),"attributeType", "ATTRIBUTE_TYPE")]

    // struct 0x5C System.Int32 studyLevel
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"studyLevel", "STUDY_LEVEL")]

    // class 0x60 System.String buffId
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buffId", "BUFF_ID")]

    // class 0x68 System.Collections.Generic.List<AVGBuffConfig> buffConfigs
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buffConfigs", "BUFF_CONFIGS")]

    // class 0x70 System.Collections.Generic.List<System.Single> buffChanceList
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buffChanceList", "BUFF_CHANCE_LIST")]

    // class 0x78 System.Collections.Generic.List<System.Int32> buffTarget
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buffTarget", "BUFF_TARGET")]

    // class 0x80 System.String buffChance
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buffChance", "BUFF_CHANCE")]

    // struct 0x88 System.Int32 crit
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"crit", "CRIT")]

    // struct 0x8C System.Int32 tag
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"tag", "TAG")]

    // class 0x90 System.Collections.Generic.List<System.String> effNames
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"effNames", "EFF_NAMES")]

    // class 0x98 System.Collections.Generic.List<System.Int32> effTarget
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"effTarget", "EFF_TARGET")]

    // struct 0xA0 System.Int32 continusCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"continusCount", "CONTINUS_COUNT")]
    public partial class _AVGAbilityConfig
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGAbilityConfig";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 65, 98, 105, 108, 105, 116, 121, 67, 111, 110, 102, 105, 103];

        //public const uint Const_TypeToken = 0x02000033U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr__AVGAbilityConfig(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr__AVGAbilityConfig(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr__AVGAbilityConfig obj) => obj._ptr;
            public static implicit operator bool(Ptr__AVGAbilityConfig obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGAbilityConfig"]
    /// </summary>
    public partial class _AVGAbilityConfig
    {





        /// <summary>
        ///   System.Void .ctor(System.Int32 attributeType, System.String buffId, System.String buffChance, System.String buffTarget, System.String eff, System.String effTarget)
        /// </summary>
        /// <param name="attributeType">struct System.Int32</param>
        /// <param name="buffId">class System.String</param>
        /// <param name="buffChance">class System.String</param>
        /// <param name="buffTarget">class System.String</param>
        /// <param name="eff">class System.String</param>
        /// <param name="effTarget">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGAbilityConfig))]
        ///  extern void .CTOR_00 (System.Int32 attributeType, nint buffId, nint buffChance, nint buffTarget, nint eff, nint effTarget);


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGAbilityConfig))]
        ///  extern void .CTOR_01 ();


        /// public static partial class Search_AVGAbilityConfig
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(System.Int32 attributeType, System.String buffId, System.String buffChance, System.String buffTarget, System.String eff, System.String effTarget)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.String", "System.String", "System.String", "System.String", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}