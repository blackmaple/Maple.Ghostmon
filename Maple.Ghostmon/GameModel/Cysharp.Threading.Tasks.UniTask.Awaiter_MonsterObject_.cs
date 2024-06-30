
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
    /// struct ["UniTask.dll".""."Awaiter"]
    /// [System.Runtime.CompilerServices.ICriticalNotifyCompletion]=>[System.Runtime.CompilerServices.INotifyCompletion]
    /// </summary>
    public partial class Awaiter_MonsterObject
    {






        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe partial struct Ref_Awaiter_MonsterObject(in UniTask_MonsterObject.Ref_UniTask_MonsterObject t)
        {

            /// const string Name_Field_task = "task";
            /// <summary>
            /// struct 0x10 Cysharp.Threading.Tasks.UniTask<MonsterObject> task
            /// </summary>
            public UniTask_MonsterObject.Ref_UniTask_MonsterObject task = t;

        }

    }

    /// <summary>
    /// struct ["UniTask.dll".""."Awaiter"]
    /// 
    /// [System.Runtime.CompilerServices.ICriticalNotifyCompletion]=>[System.Runtime.CompilerServices.INotifyCompletion]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], 0x0200004AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], [], [65, 119, 97, 105, 116, 101, 114])]


    // struct 0x10 Cysharp.Threading.Tasks.UniTask<MonsterObject> task
    // [MonoCollectorSearchFieldAttribute(typeof(Cysharp.Threading.Tasks.UniTask<MonsterObject>),"task", "TASK")]
    public partial class Awaiter_MonsterObject
    {
        //public const string Const_ImageName = "UniTask.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Awaiter";
        //public static byte[] Static_ClassName { get; } = [65, 119, 97, 105, 116, 101, 114];

        //public const uint Const_TypeToken = 0x0200004AU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Awaiter_MonsterObject(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Awaiter_MonsterObject(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Awaiter_MonsterObject obj) => obj._ptr;
            public static implicit operator bool(Ptr_Awaiter_MonsterObject obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }



    }

    /// <summary>
    /// ["UniTask.dll".""."Awaiter"]
    /// </summary>
    public partial class Awaiter_MonsterObject
    {



        /// <summary>
        ///   System.Void .ctor(Cysharp.Threading.Tasks.UniTask<MonsterObject>& task)
        /// </summary>
        /// <param name="task">struct Cysharp.Threading.Tasks.UniTask<MonsterObject>&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (Cysharp.Threading.Tasks.UniTask<MonsterObject>& task);


        /// <summary>
        ///   System.Boolean get_IsCompleted()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsCompleted")]
        extern System.Boolean GET_IS_COMPLETED();


        /// <summary>
        ///   MonsterObject GetResult()
        /// </summary>
        /// <returns>class MonsterObject</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetResult")]
        extern MonsterObject.Ptr_MonsterObject GET_RESULT();


        /// <summary>
        ///   System.Void OnCompleted(System.Action continuation)
        /// </summary>
        /// <param name="continuation">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCompleted")]
        ///  extern void ON_COMPLETED (nint continuation);


        /// <summary>
        ///   System.Void UnsafeOnCompleted(System.Action continuation)
        /// </summary>
        /// <param name="continuation">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnsafeOnCompleted")]
        ///  extern void UNSAFE_ON_COMPLETED (nint continuation);




        /// public static partial class Search_Awaiter
        /// {
        /// 
        ///     
        /// 
        /// }

    }

    partial class Awaiter_MonsterObject(Maple.MonoGameAssistant.Core.MonoCollectorContext collectorContext, Maple.MonoGameAssistant.MonoCollector.MonoCollectorClassInfo classInfo) : Maple.MonoGameAssistant.Core.MonoCollectorMember(collectorContext, classInfo)
    {



        internal readonly unsafe partial struct Ptr_Func_GET_IS_COMPLETED(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject, bool> _func = (delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject, bool>)ptr;

            public static implicit operator Ptr_Func_GET_IS_COMPLETED(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Invoke(Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject __this__) => _func(__this__);
        }

        internal static Ptr_Func_GET_IS_COMPLETED Func_GET_IS_COMPLETED;

        readonly unsafe partial struct Ptr_Awaiter_MonsterObject
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool GET_IS_COMPLETED() => Func_GET_IS_COMPLETED.Invoke(this);
        }

        internal readonly unsafe partial struct Ptr_Func_GET_RESULT(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject, Maple.Ghostmon.MonsterObject.Ptr_MonsterObject> _func = (delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject, Maple.Ghostmon.MonsterObject.Ptr_MonsterObject>)ptr;

            public static implicit operator Ptr_Func_GET_RESULT(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.Ghostmon.MonsterObject.Ptr_MonsterObject Invoke(Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject __this__) => _func(__this__);
        }

        internal static Ptr_Func_GET_RESULT Func_GET_RESULT;

        readonly unsafe partial struct Ptr_Awaiter_MonsterObject
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.Ghostmon.MonsterObject.Ptr_MonsterObject GET_RESULT() => Func_GET_RESULT.Invoke(this);
        }






        protected sealed override void InitMember()
        {

            Func_GET_IS_COMPLETED = GetMethodPointer("get_IsCompleted");

            Func_GET_RESULT = GetMethodPointer("GetResult");


        }


        public Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject New(bool execDefCtor)
            => New<Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject>(execDefCtor);

        public Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject Ctor()
            => Ctor<Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject>();
    }
}