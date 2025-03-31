using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."AbilityBookData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000272U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [65, 98, 105, 108, 105, 116, 121, 66, 111, 111, 107, 68, 97, 116, 97])]


    // struct 0x10 System.UInt64 configID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "configID", "CONFIG_ID")]

    // struct 0x18 System.Int32 num
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "num", "NUM")]
    public partial class AbilityBookData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "AbilityBookData";
        //public static byte[] Static_ClassName { get; } = [65, 98, 105, 108, 105, 116, 121, 66, 111, 111, 107, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000272U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AbilityBookData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AbilityBookData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AbilityBookData obj) => obj._ptr;
            public static implicit operator bool(Ptr_AbilityBookData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."AbilityBookData"]
    /// </summary>
    public partial class AbilityBookData
    {



        /// <summary>
        ///   System.Void .ctor(Ghostmon.AbilityBookConfig config)
        /// </summary>
        /// <param name="config">class Ghostmon.AbilityBookConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (nint config);




        /// public static partial class Search_AbilityBookData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}