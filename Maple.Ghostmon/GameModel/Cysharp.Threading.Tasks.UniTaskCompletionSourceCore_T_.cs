
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTaskCompletionSourceCore`1"]
    /// 
    /// </summary>
    public partial class UniTaskCompletionSourceCoreGeneric
    {






        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ref_UniTaskCompletionSourceCoreGeneric<T_OBJECT>
        {



            /// const string Name_Field_result = "result";
            /// <summary>
            /// class 0x10 T result
            /// </summary>
            //      [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly T_OBJECT result;


            /// const string Name_Field_error = "error";
            /// <summary>
            /// class 0x18 System.Object error
            /// </summary>
            //      [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            public readonly nint error;


            /// const string Name_Field_version = "version";
            /// <summary>
            /// struct 0x20 System.Int16 version
            /// </summary>
            //         [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I2)]
            public readonly System.Int16 version;


            /// const string Name_Field_hasUnhandledError = "hasUnhandledError";
            /// <summary>
            /// struct 0x22 System.Boolean hasUnhandledError
            /// </summary>
            //         [System.Runtime.InteropServices.FieldOffsetAttribute(0x12)]
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.U1)]
            public readonly System.Boolean hasUnhandledError;


            /// const string Name_Field_completedCount = "completedCount";
            /// <summary>
            /// struct 0x24 System.Int32 completedCount
            /// </summary>
            //         [System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I4)]
            public readonly System.Int32 completedCount;


            /// const string Name_Field_continuation = "continuation";
            /// <summary>
            /// class 0x28 System.Action<System.Object> continuation
            /// </summary>
            //       [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            public readonly nint continuation;


            /// const string Name_Field_continuationState = "continuationState";
            /// <summary>
            /// class 0x30 System.Object continuationState
            /// </summary>
            //       [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            public readonly nint continuationState;

        }

    }

    /// <summary>
    /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTaskCompletionSourceCore`1"]
    /// 
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], 0x0200004CU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115], [85, 110, 105, 84, 97, 115, 107, 67, 111, 109, 112, 108, 101, 116, 105, 111, 110, 83, 111, 117, 114, 99, 101, 67, 111, 114, 101, 96, 49])]


    // class 0x10 T result
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"result", "RESULT")]

    // class 0x18 System.Object error
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"error", "ERROR")]

    // struct 0x20 System.Int16 version
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int16),"version", "VERSION")]

    // struct 0x22 System.Boolean hasUnhandledError
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"hasUnhandledError", "HAS_UNHANDLED_ERROR")]

    // struct 0x24 System.Int32 completedCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"completedCount", "COMPLETED_COUNT")]

    // class 0x28 System.Action<System.Object> continuation
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"continuation", "CONTINUATION")]

    // class 0x30 System.Object continuationState
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"continuationState", "CONTINUATION_STATE")]
    public partial class UniTaskCompletionSourceCoreGeneric
    {
        //public const string Const_ImageName = "UniTask.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108];

        //public const string Const_Namespace = "Cysharp.Threading.Tasks";
        //public static byte[] Static_Namespace { get; } = [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115];

        //public const string Const_ClassName = "UniTaskCompletionSourceCore`1";
        //public static byte[] Static_ClassName { get; } = [85, 110, 105, 84, 97, 115, 107, 67, 111, 109, 112, 108, 101, 116, 105, 111, 110, 83, 111, 117, 114, 99, 101, 67, 111, 114, 101, 96, 49];

        //public const uint Const_TypeToken = 0x0200004CU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UniTaskCompletionSourceCoreGeneric(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UniTaskCompletionSourceCoreGeneric(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UniTaskCompletionSourceCoreGeneric obj) => obj._ptr;
            public static implicit operator bool(Ptr_UniTaskCompletionSourceCoreGeneric obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTaskCompletionSourceCore`1"]
    /// </summary>
    public partial class UniTaskCompletionSourceCoreGeneric
    {



        /// <summary>
        ///   System.Int16 get_Version()
        /// </summary>
        /// <returns>struct System.Int16</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Version")]
        ///  extern System.Int16 GET_VERSION ();


        /// <summary>
        ///   T GetResult(System.Int16 token)
        /// </summary>
        /// <param name="token">struct System.Int16</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetResult")]
        ///  extern nint GET_RESULT (System.Int16 token);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTaskStatus GetStatus(System.Int16 token)
        /// </summary>
        /// <param name="token">struct System.Int16</param>
        /// <returns>enum Cysharp.Threading.Tasks.UniTaskStatus</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStatus")]
        ///  extern Cysharp.Threading.Tasks.UniTaskStatus GET_STATUS (System.Int16 token);


        /// <summary>
        ///   System.Void OnCompleted(System.Action<System.Object> continuation, System.Object state, System.Int16 token)
        /// </summary>
        /// <param name="continuation">class System.Action<System.Object></param>
        /// <param name="state">class System.Object</param>
        /// <param name="token">struct System.Int16</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCompleted")]
        ///  extern void ON_COMPLETED (nint continuation, nint state, System.Int16 token);


        /// <summary>
        ///   System.Void ReportUnhandledError()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReportUnhandledError")]
        ///  extern void REPORT_UNHANDLED_ERROR ();


        /// <summary>
        ///   System.Void Reset()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reset")]
        ///  extern void RESET ();


        /// <summary>
        ///   System.Boolean TrySetCanceled(System.Threading.CancellationToken cancellationToken)
        /// </summary>
        /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrySetCanceled")]
        ///  extern System.Boolean TRY_SET_CANCELED (System.Threading.CancellationToken cancellationToken);


        /// <summary>
        ///   System.Boolean TrySetException(System.Exception error)
        /// </summary>
        /// <param name="error">class System.Exception</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrySetException")]
        ///  extern System.Boolean TRY_SET_EXCEPTION (nint error);


        /// <summary>
        ///   System.Boolean TrySetResult(T result)
        /// </summary>
        /// <param name="result">class T</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrySetResult")]
        ///  extern System.Boolean TRY_SET_RESULT (nint result);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus()
        /// </summary>
        /// <returns>enum Cysharp.Threading.Tasks.UniTaskStatus</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnsafeGetStatus")]
        ///  extern Cysharp.Threading.Tasks.UniTaskStatus UNSAFE_GET_STATUS ();


        /// <summary>
        ///   System.Void ValidateToken(System.Int16 token)
        /// </summary>
        /// <param name="token">struct System.Int16</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ValidateToken")]
        ///  extern void VALIDATE_TOKEN (System.Int16 token);




        /// public static partial class Search_UniTaskCompletionSourceCoreGeneric
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}