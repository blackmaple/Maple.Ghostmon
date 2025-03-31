using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."CharmData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000273U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [67, 104, 97, 114, 109, 68, 97, 116, 97])]


    // struct 0x10 System.UInt64 dataID
   // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "dataID", "DATA_ID")]

    // struct 0x18 System.UInt64 configID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "configID", "CONFIG_ID")]

    // struct 0x20 System.Int32 num
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "num", "NUM")]
    public partial class CharmData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "CharmData";
        //public static byte[] Static_ClassName { get; } = [67, 104, 97, 114, 109, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000273U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CharmData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CharmData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CharmData obj) => obj._ptr;
            public static implicit operator bool(Ptr_CharmData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."CharmData"]
    /// </summary>
    public partial class CharmData
    {



        /// <summary>
        ///   System.Void .ctor(Ghostmon.CharmConfig config)
        /// </summary>
        /// <param name="config">class Ghostmon.CharmConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (nint config);




        /// public static partial class Search_CharmData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}