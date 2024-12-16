
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."CuisineData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000275U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [67, 117, 105, 115, 105, 110, 101, 68, 97, 116, 97])]
    
                
    // struct 0x10 System.Single lifeTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"lifeTime", "LIFE_TIME")]
            
    // class 0x18 System.Collections.Generic.Dictionary<PlayerPropertyType,System.Single> adjust
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"adjust", "ADJUST")]
            
    // class 0x20 Ghostmon.CuisineConfig config
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"config", "CONFIG")]
    public partial class CuisineData
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "CuisineData";
        //public static byte[] Static_ClassName { get; } = [67, 117, 105, 115, 105, 110, 101, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000275U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CuisineData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CuisineData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CuisineData obj) => obj._ptr;
            public static implicit operator bool(Ptr_CuisineData obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Ghostmon"."CuisineData"]
        /// </summary>
        public partial class CuisineData
        { 

            
            
            /// <summary>
            ///   System.Void .ctor(Ghostmon.CuisineConfig config)
            /// </summary>
            /// <param name="config">class Ghostmon.CuisineConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR (nint config);
            
            

            
            /// public static partial class Search_CuisineData
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}