using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AVGBagItemData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200002EU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 66, 97, 103, 73, 116, 101, 109, 68, 97, 116, 97])]


    // class 0x10 AVGPropConfig config
    [MonoCollectorSearchFieldAttribute(typeof(_AVGPropConfig.Ptr__AVGPropConfig), "config", "CONFIG")]

    // struct 0x18 System.Int32 count
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "count", "COUNT", IsReadOnly = false)]
    public partial class AVGBagItemData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGBagItemData";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 66, 97, 103, 73, 116, 101, 109, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x0200002EU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGBagItemData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGBagItemData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGBagItemData obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGBagItemData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGBagItemData"]
    /// </summary>
    public partial class AVGBagItemData
    {



        /// <summary>
        ///   System.Void .ctor(AVGPropConfig config, System.Int32 count)
        /// </summary>
        /// <param name="config">class AVGPropConfig</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        extern void CTOR(_AVGPropConfig.Ptr__AVGPropConfig config, System.Int32 count);


        /// <summary>
        ///   AVGBagItemData Clone(AVGPropConfig config, System.Int32 count)
        /// </summary>
        /// <param name="config">class AVGPropConfig</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>class AVGBagItemData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE (nint config, System.Int32 count);


        /// <summary>
        ///   System.Void RefreshConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshConfig")]
        extern void REFRESH_CONFIG();




        /// public static partial class Search_AVGBagItemData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}