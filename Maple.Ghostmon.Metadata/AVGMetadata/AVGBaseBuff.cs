namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AVGBaseBuff"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000030U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 66, 97, 115, 101, 66, 117, 102, 102])]


    // class 0x10 AVGBuffConfig config
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"config", "CONFIG")]

    // struct 0x18 System.Int32 remainingTurns
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"remainingTurns", "REMAINING_TURNS")]
    public partial class AVGBaseBuff
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGBaseBuff";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 66, 97, 115, 101, 66, 117, 102, 102];

        //public const uint Const_TypeToken = 0x02000030U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGBaseBuff(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGBaseBuff(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGBaseBuff obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGBaseBuff obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGBaseBuff"]
    /// </summary>
    public partial class AVGBaseBuff
    {



        /// <summary>
        ///   System.Void .ctor(AVGBuffConfig config, System.Int32 remainingTurns)
        /// </summary>
        /// <param name="config">class AVGBuffConfig</param>
        /// <param name="remainingTurns">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (nint config, System.Int32 remainingTurns);


        /// <summary>
        ///   System.Void RefreshConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshConfig")]
        ///  extern void REFRESH_CONFIG ();




        /// public static partial class Search_AVGBaseBuff
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}