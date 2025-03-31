
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."GoodsData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200025AU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [71, 111, 111, 100, 115, 68, 97, 116, 97])]
    
                
    // struct 0x10 System.UInt64 configID
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"configID", "CONFIG_ID")]
            
    // struct 0x18 System.Int32 currentNum
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentNum", "CURRENT_NUM")]
            
    // struct 0x1C System.Int32 type
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"type", "TYPE")]
    public partial class GoodsData
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "GoodsData";
        //public static byte[] Static_ClassName { get; } = [71, 111, 111, 100, 115, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x0200025AU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GoodsData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GoodsData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GoodsData obj) => obj._ptr;
            public static implicit operator bool(Ptr_GoodsData obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Ghostmon"."GoodsData"]
        /// </summary>
        public partial class GoodsData
        { 

            
            
            /// <summary>
            ///   System.Void .ctor(Ghostmon.GoodsConfig config)
            /// </summary>
            /// <param name="config">class Ghostmon.GoodsConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR (nint config);
            
            

            
            /// public static partial class Search_GoodsData
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}