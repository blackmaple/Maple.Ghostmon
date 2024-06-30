
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["UniTask.dll"."Cysharp.Threading.Tasks.CompilerServices"."AsyncUniTask`2"]
    /// [System.Object]
    /// [Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T>]=>[Cysharp.Threading.Tasks.IUniTaskSource<T>]=>[Cysharp.Threading.Tasks.IUniTaskSource]=>[Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine,T>>]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], 0x0200010BU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115, 46, 67, 111, 109, 112, 105, 108, 101, 114, 83, 101, 114, 118, 105, 99, 101, 115], [65, 115, 121, 110, 99, 85, 110, 105, 84, 97, 115, 107, 96, 50])]

    //  struct static Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine,T>> pool
    //  [MonoCollectorSearchFieldAttribute(typeof(Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine,T>>),"pool", "POOL", true)]

    // class 0x0 System.Action returnDelegate
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"returnDelegate", "RETURN_DELEGATE")]

    // class 0x0 System.Action <MoveNext>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<MoveNext>k__BackingField", "MOVE_NEXT")]

    // class 0x0 TStateMachine stateMachine
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"stateMachine", "STATE_MACHINE")]

    // struct 0x0 Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T> core
    // [MonoCollectorSearchFieldAttribute(typeof(Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T>),"core", "CORE")]

    // class 0x0 Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine,T> nextNode
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"nextNode", "NEXT_NODE")]
    public partial class AsyncUniTaskGeneric
    {
        //public const string Const_ImageName = "UniTask.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108];

        //public const string Const_Namespace = "Cysharp.Threading.Tasks.CompilerServices";
        //public static byte[] Static_Namespace { get; } = [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115, 46, 67, 111, 109, 112, 105, 108, 101, 114, 83, 101, 114, 118, 105, 99, 101, 115];

        //public const string Const_ClassName = "AsyncUniTask`2";
        //public static byte[] Static_ClassName { get; } = [65, 115, 121, 110, 99, 85, 110, 105, 84, 97, 115, 107, 96, 50];

        //public const uint Const_TypeToken = 0x0200010BU;


        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct Ref_AsyncUniTaskGeneric<T_STATE_MACHINE, T_OBJECT>
        {

            public REF_MONO_OBJECT obj;


            public T_STATE_MACHINE STATE_MACHINE;

            public nint RETURN_DELEGATE;
            public nint MOVE_NEXT;
            public nint NEXT_NODE;

            public UniTaskCompletionSourceCoreGeneric.Ref_UniTaskCompletionSourceCoreGeneric<T_OBJECT> CORE;



        }





        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AsyncUniTaskGeneric(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AsyncUniTaskGeneric(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AsyncUniTaskGeneric obj) => obj._ptr;
            public static implicit operator bool(Ptr_AsyncUniTaskGeneric obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            public ref Ref_AsyncUniTaskGeneric<T_STATE_MACHINE, T_OBJECT> AsRef<T_STATE_MACHINE, T_OBJECT>()
            {
                return ref Unsafe.AsRef<Ref_AsyncUniTaskGeneric<T_STATE_MACHINE, T_OBJECT>>(_ptr.ToPointer());
            }

        }

    }

    /// <summary>
    /// ["UniTask.dll"."Cysharp.Threading.Tasks.CompilerServices"."AsyncUniTask`2"]
    /// </summary>
    public partial class AsyncUniTaskGeneric
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(System.Int16 token)
        /// </summary>
        /// <param name="token">struct System.Int16</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Cysharp.Threading.Tasks.IUniTaskSource.GetResult")]
        ///  extern void CYSHARP.THREADING.TASKS.I_UNI_TASK_SOURCE.GET_RESULT (System.Int16 token);


        /// <summary>
        ///   System.Action get_MoveNext()
        /// </summary>
        /// <returns>class System.Action</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MoveNext")]
        ///  extern nint GET_MOVE_NEXT ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine,T>& get_NextNode()
        /// </summary>
        /// <returns>class Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine,T>&</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NextNode")]
        ///  extern nint GET_NEXT_NODE ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask<T> get_Task()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Task")]
        ///  extern Cysharp.Threading.Tasks.UniTask<T> GET_TASK ();


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
        ///   System.Void Return()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Return")]
        ///  extern void RETURN ();


        /// <summary>
        ///   System.Void Run()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Run")]
        ///  extern void RUN ();


        /// <summary>
        ///   System.Void SetException(System.Exception exception)
        /// </summary>
        /// <param name="exception">class System.Exception</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetException")]
        ///  extern void SET_EXCEPTION (nint exception);


        /// <summary>
        ///   System.Void SetResult(T result)
        /// </summary>
        /// <param name="result">class T</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetResult")]
        ///  extern void SET_RESULT (nint result);


        /// <summary>
        /// static  System.Void SetStateMachine(TStateMachine& stateMachine, Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T>& runnerPromiseFieldRef)
        /// </summary>
        /// <param name="stateMachine">class TStateMachine&</param>
        /// <param name="runnerPromiseFieldRef">interface Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T>&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetStateMachine")]
        /// static extern void SET_STATE_MACHINE (nint stateMachine, nint runnerPromiseFieldRef);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus()
        /// </summary>
        /// <returns>enum Cysharp.Threading.Tasks.UniTaskStatus</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnsafeGetStatus")]
        ///  extern Cysharp.Threading.Tasks.UniTaskStatus UNSAFE_GET_STATUS ();




        /// public static partial class Search_AsyncUniTaskGeneric
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}