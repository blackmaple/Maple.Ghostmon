using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."AVGServiceManager"]
    /// [Ghostmon.Framework.Singleton<Ghostmon.AVGServiceManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000440U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [65, 86, 71, 83, 101, 114, 118, 105, 99, 101, 77, 97, 110, 97, 103, 101, 114])]

    //  class static Ghostmon.AVGServiceManager instance
    [MonoCollectorSearchFieldAttribute(typeof(AVGServiceManager.Ptr_AVGServiceManager), "instance", "INSTANCE", true)]

    // class 0x10 Ghostmon.AVGItemService avgItemService
    [MonoCollectorSearchFieldAttribute(typeof(AVGItemService.Ptr_AVGItemService), "avgItemService", "AVG_ITEM_SERVICE")]

    // class 0x18 Ghostmon.AVGMonsterService avgMonsterService
    [MonoCollectorSearchFieldAttribute(typeof(AVGMonsterService.Ptr_AVGMonsterService), "avgMonsterService", "AVG_MONSTER_SERVICE")]
    public partial class AVGServiceManager
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "AVGServiceManager";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 83, 101, 114, 118, 105, 99, 101, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x02000440U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGServiceManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGServiceManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGServiceManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGServiceManager obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."AVGServiceManager"]
    /// </summary>
    public partial class AVGServiceManager
    {



        /// <summary>
        /// static  Ghostmon.AVGServiceManager CreateInstance()
        /// </summary>
        /// <returns>class Ghostmon.AVGServiceManager</returns>
        //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInstance")]
        //static extern AVGServiceManager.Ptr_AVGServiceManager CREATE_INSTANCE();


        /// <summary>
        /// static  Ghostmon.AVGServiceManager get_Instance()
        /// </summary>
        /// <returns>class Ghostmon.AVGServiceManager</returns>
        //   [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
        //    static extern nint GET_INSTANCE();


        /// <summary>
        /// static  System.Boolean IsActive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
        /// static extern System.Boolean IS_ACTIVE ();


        /// <summary>
        ///   System.Void Remove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
        ///  extern void REMOVE ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGServiceManager))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGServiceManager))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_AVGServiceManager))]
        ///  extern void ON_INIT_00 ();


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_AVGServiceManager))]
        ///  extern void ON_INIT_01 ();


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove", Search = typeof(Search_AVGServiceManager))]
        ///  extern void ON_REMOVE_00 ();


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove", Search = typeof(Search_AVGServiceManager))]
        ///  extern void ON_REMOVE_01 ();


        /// public static partial class Search_AVGServiceManager
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
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


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// public static bool ON_INIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// public static bool ON_INIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// public static bool ON_REMOVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnRemove");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// public static bool ON_REMOVE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnRemove");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}