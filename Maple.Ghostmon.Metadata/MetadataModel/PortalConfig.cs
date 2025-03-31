
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;


namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."PortalConfig"]
    /// [Ghostmon.BaseConfig]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000233U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [80, 111, 114, 116, 97, 108, 67, 111, 110, 102, 105, 103])]


    // struct 0x10 System.UInt64 configID
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"configID", "CONFIG_ID")]

    // class 0x18 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x20 System.String prefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"prefab", "PREFAB")]

    // class 0x28 System.String description
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"description", "DESCRIPTION")]

    // struct 0x30 UnityEngine.Vector3 worldPos
    [MonoCollectorSearchFieldAttribute(typeof(REF_MONO_VECTOR3), "worldPos", "WORLD_POS", IsReadOnly = false)]

    // struct 0x3C System.Boolean isTown
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isTown", "IS_TOWN")]

    // struct 0x3D System.Boolean isTravel
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "isTravel", "IS_TRAVEL", IsReadOnly = false)]
    public partial class GhostmonPortalConfig
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PortalConfig";
        //public static byte[] Static_ClassName { get; } = [80, 111, 114, 116, 97, 108, 67, 111, 110, 102, 105, 103];

        //public const uint Const_TypeToken = 0x02000233U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GhostmonPortalConfig(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GhostmonPortalConfig(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GhostmonPortalConfig obj) => obj._ptr;
            public static implicit operator bool(Ptr_GhostmonPortalConfig obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."PortalConfig"]
    /// </summary>
    public partial class GhostmonPortalConfig
    {





        /// <summary>
        ///   System.Void .ctor(System.String worldPos)
        /// </summary>
        /// <param name="worldPos">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PortalConfig))]
        ///  extern void .CTOR_00 (nint worldPos);


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PortalConfig))]
        ///  extern void .CTOR_01 ();


        /// public static partial class Search_PortalConfig
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(System.String worldPos)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.String");
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
        /// 
        /// }

    }


}