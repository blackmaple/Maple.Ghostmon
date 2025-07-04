using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AVGPropConfig"]
    /// [Ghostmon.BaseConfig]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200002FU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 80, 114, 111, 112, 67, 111, 110, 102, 105, 103])]


    // struct 0x10 System.UInt64 configID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "configID", "CONFIG_ID", IsReadOnly = false)]

    // class 0x18 System.String name
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "name", "NAME")]

    // class 0x20 System.String prefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"prefab", "PREFAB")]

    // class 0x28 System.String description
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "description", "DESCRIPTION")]

    // class 0x30 System.String icon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon", "ICON")]

    // enum 0x38 AVGBagItemEffect type
    // [MonoCollectorSearchFieldAttribute(typeof(AVGBagItemEffect),"type", "TYPE")]

    // class 0x40 System.String effectParams
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"effectParams", "EFFECT_PARAMS")]

    // struct 0x48 System.UInt64 value
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"value", "VALUE")]

    // enum 0x50 AVGBagItemUsage inBattle
    // [MonoCollectorSearchFieldAttribute(typeof(AVGBagItemUsage),"inBattle", "IN_BATTLE")]

    // struct 0x54 System.Int32 buyPrice
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"buyPrice", "BUY_PRICE")]

    // struct 0x58 System.Boolean canBuy
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"canBuy", "CAN_BUY")]

    // struct 0x5C System.Int32 sellPrice
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"sellPrice", "SELL_PRICE")]

    // struct 0x60 System.Boolean canSell
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"canSell", "CAN_SELL")]
    public partial class _AVGPropConfig
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGPropConfig";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 80, 114, 111, 112, 67, 111, 110, 102, 105, 103];

        //public const uint Const_TypeToken = 0x0200002FU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr__AVGPropConfig(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr__AVGPropConfig(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr__AVGPropConfig obj) => obj._ptr;
            public static implicit operator bool(Ptr__AVGPropConfig obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGPropConfig"]
    /// </summary>
    public partial class _AVGPropConfig
    {





        /// <summary>
        ///   System.Void .ctor(System.Int32 type, System.Int32 inBattle, System.String effectParams)
        /// </summary>
        /// <param name="type">struct System.Int32</param>
        /// <param name="inBattle">struct System.Int32</param>
        /// <param name="effectParams">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGPropConfig))]
        ///  extern void .CTOR_00 (System.Int32 type, System.Int32 inBattle, nint effectParams);


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGPropConfig))]
        ///  extern void .CTOR_01 ();


        /// public static partial class Search_AVGPropConfig
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(System.Int32 type, System.Int32 inBattle, System.String effectParams)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.String");
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