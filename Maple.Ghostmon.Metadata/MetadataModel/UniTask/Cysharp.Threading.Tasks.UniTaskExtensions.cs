
//using Maple.MonoGameAssistant.Core;
//using Maple.MonoGameAssistant.MonoCollectorDataV2;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Maple.Ghostmon
//{


//    /// <summary>
//    /// static class ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTaskExtensions"]
//    /// [System.Object]
//    /// 
//    /// </summary>
//    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], 0x02000053U)]
//    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115], [85, 110, 105, 84, 97, 115, 107, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115])]


//    public partial class UniTaskExtensions
//    {
//        //public const string Const_ImageName = "UniTask.dll";
//        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108];

//        //public const string Const_Namespace = "Cysharp.Threading.Tasks";
//        //public static byte[] Static_Namespace { get; } = [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115];

//        //public const string Const_ClassName = "UniTaskExtensions";
//        //public static byte[] Static_ClassName { get; } = [85, 110, 105, 84, 97, 115, 107, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115];

//        //public const uint Const_TypeToken = 0x02000053U;








//        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//        public readonly unsafe partial struct Ptr_UniTaskExtensions(nint ptr)
//        {

//            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
//            readonly nint _ptr = ptr;
//            public static implicit operator Ptr_UniTaskExtensions(nint ptr) => new(ptr);
//            public static implicit operator nint(Ptr_UniTaskExtensions obj) => obj._ptr;
//            public static implicit operator bool(Ptr_UniTaskExtensions obj) => obj.Valid();

//            public override string ToString()
//            {
//                return _ptr.ToString("X8");
//            }

//            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
//            public bool Valid() => _ptr != nint.Zero;



//        }

//    }

//    /// <summary>
//    /// ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTaskExtensions"]
//    /// </summary>
//    public partial class UniTaskExtensions
//    {



//        /// <summary>
//        /// static  System.Void Forget(Cysharp.Threading.Tasks.UniTask task)
//        /// </summary>
//        /// <param name="task">struct Cysharp.Threading.Tasks.UniTask</param>
//        /// <returns>struct System.Void</returns>
//        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Forget")]
//        static extern void FORGET(Ref_UniTask task);




//        /// public static partial class Search_UniTaskExtensions
//        /// {
//        /// 
//        ///     
//        /// 
//        /// }

//    }


//}