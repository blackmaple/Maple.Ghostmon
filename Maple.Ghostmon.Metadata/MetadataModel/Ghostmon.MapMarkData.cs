
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ref_V2(float xx, float zz)
    {



        /// const string Name_Field_x = "x";
        /// <summary>
        /// struct 0x10 System.Single x
        /// </summary>
        [MarshalAs(UnmanagedType.R4)]
        public readonly System.Single x = xx;


        /// const string Name_Field_z = "z";
        /// <summary>
        /// struct 0x14 System.Single z
        /// </summary>
        [MarshalAs(UnmanagedType.R4)]
        public readonly System.Single z = zz;

    }

    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."MapMarkData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020002D0U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [77, 97, 112, 77, 97, 114, 107, 68, 97, 116, 97])]


    // struct 0x10 System.Int32 markType
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"markType", "MARK_TYPE")]

    // struct 0x14 Ghostmon.V2 markPos
    [MonoCollectorSearchFieldAttribute(typeof(Ref_V2), "markPos", "MARK_POS")]
    public partial class MapMarkData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "MapMarkData";
        //public static byte[] Static_ClassName { get; } = [77, 97, 112, 77, 97, 114, 107, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020002D0U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_MapMarkData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_MapMarkData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_MapMarkData obj) => obj._ptr;
            public static implicit operator bool(Ptr_MapMarkData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."MapMarkData"]
    /// </summary>
    public partial class MapMarkData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();




        /// public static partial class Search_MapMarkData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}