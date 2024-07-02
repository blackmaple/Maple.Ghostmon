using Maple.MonoGameAssistant.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_AsyncUniTaskMethodBuilder<T_DATA>
        where T_DATA : unmanaged
    {
        /// <summary>
        /// IStateMachineRunnerPromise<T> runnerPromise
        /// </summary>
        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint RUNNER_PROMISE;

        /// <summary>
        /// Exception ex
        /// </summary>
        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint EX;

        /// <summary>
        /// T_DATA result;
        /// </summary>
        public readonly T_DATA RESULT;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_AsyncStateMachine<T_DATA, T_ARGS>
        where T_DATA : unmanaged
        where T_ARGS : struct
    {
        /// const string Name_Field_<>1__state = "<>1__state";
        /// <summary>
        /// struct 0x10 System.Int32 <>1__state
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public readonly System.Int32 STATE;


        /// const string Name_Field_<>t__builder = "<>t__builder";
        /// <summary>
        /// struct 0x18 Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<MonsterObject> <>t__builder
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly Ref_AsyncUniTaskMethodBuilder<T_DATA> BUILDER;


        ///// const string Name_Field_name = "name";
        ///// <summary>
        ///// class 0x30 System.String name
        ///// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
        //public readonly nint name;
        ///// const string Name_Field_<key>5__2 = "<key>5__2";
        ///// <summary>
        ///// class 0x38 System.String <key>5__2
        ///// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
        //public readonly nint key5__2;
        public readonly T_ARGS ARGS;


        /// const string Name_Field_<>u__1 = "<>u__1";
        /// <summary>
        /// struct 0x40 Cysharp.Threading.Tasks.UniTask.Awaiter<MonsterObject> <>u__1
        /// </summary>
        public readonly Ref_Awaiter<T_DATA> AWAITE;

    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_AsyncStateMachine<T_DATA>
    where T_DATA : unmanaged
    {
        /// const string Name_Field_<>1__state = "<>1__state";
        /// <summary>
        /// struct 0x10 System.Int32 <>1__state
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public readonly System.Int32 STATE;


        /// const string Name_Field_<>t__builder = "<>t__builder";
        /// <summary>
        /// struct 0x18 Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<MonsterObject> <>t__builder
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly Ref_AsyncUniTaskMethodBuilder<T_DATA> BUILDER;


        /// const string Name_Field_<>u__1 = "<>u__1";
        /// <summary>
        /// struct 0x40 Cysharp.Threading.Tasks.UniTask.Awaiter<MonsterObject> <>u__1
        /// </summary>
        public readonly Ref_Awaiter<T_DATA> AWAITE;

    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_UniTask(nint source, short token)
    {
        /// const string Name_Field_source = "source";
        /// <summary>
        /// interface 0x10 Cysharp.Threading.Tasks.IUniTaskSource source
        /// </summary>
        public readonly Ptr_AsyncUniTask SOURCE = source;

        /// const string Name_Field_token = "token";
        /// <summary>
        /// struct 0x20 System.Int16 token
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I2)]
        public readonly System.Int16 TOKEN = token;
    }

    /// <summary>
    /// SizeOf<>()=0x18
    /// </summary>
    /// <typeparam name="T_DATA"></typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_UniTask<T_DATA> where T_DATA : unmanaged
    {
        public static implicit operator Ref_UniTask(Ref_UniTask<T_DATA> obj) => new(obj.SOURCE, obj.TOKEN);

        /// const string Name_Field_source = "source";
        /// <summary>
        /// interface 0x10 Cysharp.Threading.Tasks.IUniTaskSource<MonsterObject> source
        /// </summary>
        /// [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly Ptr_AsyncUniTask<T_DATA> SOURCE;


        /// const string Name_Field_result = "result";
        /// <summary>
        /// class 0x18 MonsterObject result
        /// </summary>
        ///[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Struct)]
        public readonly T_DATA RESULT;


        /// const string Name_Field_token = "token";
        /// <summary>
        /// struct 0x20 System.Int16 token
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I2)]
        public readonly System.Int16 TOKEN;

        [Obsolete("USE GetResult_State")]
        public T_DATA GetResult<T_ARGS>() where T_ARGS : struct
        {
            if (SOURCE.Valid())
            {

                (Ptr_AsyncUniTask<T_DATA> Source, Int16 Token) = (SOURCE, TOKEN);
                if (SpinWait.SpinUntil(() => Source.UNSAFE_GET_STATUS<T_ARGS>(Token) > UniTaskStatus.Pending, 5000))
                {
                    return SOURCE.UNSAFE_GET_RESULT<T_ARGS>();
                }
            }
            else
            {
                return RESULT;
            }

            return default;
        }
        public T_DATA GetResult_State<T_ARGS>(int state = -2) where T_ARGS : struct
        {
            if (SOURCE.Valid())
            {
                if (SOURCE.UNSAFE_IS_COMPLETED<T_ARGS>(state) && SOURCE.UNSAFE_GET_STATUS<T_ARGS>(TOKEN) > UniTaskStatus.Pending)
                {
                    return SOURCE.UNSAFE_GET_RESULT<T_ARGS>();
                }
            }
            else
            {
                return RESULT;
            }

            return default;
        }

    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_UniTask<T_DATA>(nint ptr)
        where T_DATA : unmanaged
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_UniTask<T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_UniTask<T_DATA> obj) => obj._ptr;
        public static implicit operator bool(Ptr_UniTask<T_DATA> obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        public unsafe ref Ref_UniTask<T_DATA> AsRef()
        {
            return ref Unsafe.AsRef<Ref_UniTask<T_DATA>>(_ptr.ToPointer());
        }

        public T_DATA GetResult<T_ARGS>()
            where T_ARGS : struct
        {
            return this.AsRef().GetResult<T_ARGS>();
        }


    }

    /// <summary>
    /// SizeOf<>()=0x18
    /// </summary>
    /// <typeparam name="T_DATA"></typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_Awaiter<T_DATA> where T_DATA : unmanaged
    {

        /// const string Name_Field_task = "task";
        /// <summary>
        /// struct 0x10 Cysharp.Threading.Tasks.UniTask<MonsterObject> task
        /// </summary>
        public readonly Ref_UniTask<T_DATA> Task;

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(LayoutKind.Sequential)]
    public readonly unsafe partial struct Ref_UniTaskCompletionSourceCore<T_DATA>
        where T_DATA : unmanaged
    {



        /// const string Name_Field_result = "result";
        /// <summary>
        /// class 0x10 T result
        /// </summary>
        //      [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly T_DATA RESULT;


        /// const string Name_Field_error = "error";
        /// <summary>
        /// class 0x18 System.Object error
        /// </summary>
        //      [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint ERROR;


        /// const string Name_Field_version = "version";
        /// <summary>
        /// struct 0x20 System.Int16 version
        /// </summary>
        //         [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I2)]
        public readonly System.Int16 VERSION;


        /// const string Name_Field_hasUnhandledError = "hasUnhandledError";
        /// <summary>
        /// struct 0x22 System.Boolean hasUnhandledError
        /// </summary>
        //         [System.Runtime.InteropServices.FieldOffsetAttribute(0x12)]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.U1)]
        public readonly System.Boolean HAS_UNHANDLED_ERROR;


        /// const string Name_Field_completedCount = "completedCount";
        /// <summary>
        /// struct 0x24 System.Int32 completedCount
        /// </summary>
        //         [System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I4)]
        public readonly System.Int32 COMPLETED_COUNT;


        /// const string Name_Field_continuation = "continuation";
        /// <summary>
        /// class 0x28 System.Action<System.Object> continuation
        /// </summary>
        //       [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint CONTINUATION;


        /// const string Name_Field_continuationState = "continuationState";
        /// <summary>
        /// class 0x30 System.Object continuationState
        /// </summary>
        //       [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint CONTINUATION_STATE;

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(LayoutKind.Sequential)]
    public unsafe partial struct Ref_AsyncUniTask<T_DATA, T_ARGS>
        where T_DATA : unmanaged
        where T_ARGS : struct
    {
        public readonly REF_MONO_OBJECT OBJECT;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint RETURN_DELEGATE;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint NEXT_NODE;

        public Ref_AsyncStateMachine<T_DATA, T_ARGS> ASYNC_STATE_MACHINE;

        public Ref_UniTaskCompletionSourceCore<T_DATA> CORE;

        //[MarshalAs(UnmanagedType.SysInt)]
        //public readonly nint MOVE_NEXT;

    }

    [Description("error")]
    [System.Runtime.InteropServices.StructLayoutAttribute(LayoutKind.Sequential)]
    public readonly unsafe partial struct Ref_AsyncUniTask<T_DATA>
    where T_DATA : unmanaged
    {
        public readonly REF_MONO_OBJECT OBJECT;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint RETURN_DELEGATE;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint NEXT_NODE;

        public readonly Ref_AsyncStateMachine<T_DATA> ASYNC_STATE_MACHINE;

        public readonly Ref_UniTaskCompletionSourceCore<T_DATA> CORE;

        //[MarshalAs(UnmanagedType.SysInt)]
        //public readonly nint MOVE_NEXT;

    }

    [Description("error")]
    [System.Runtime.InteropServices.StructLayoutAttribute(LayoutKind.Sequential)]
    public readonly unsafe partial struct Interface_AsyncUniTask<T_DATA, T_AsyncStateMachine>
    where T_DATA : unmanaged
    where T_AsyncStateMachine : struct
    {
        public readonly REF_MONO_OBJECT OBJECT;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint RETURN_DELEGATE;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint NEXT_NODE;

        public readonly T_AsyncStateMachine ASYNC_STATE_MACHINE;

        public readonly Ref_UniTaskCompletionSourceCore<T_DATA> CORE;

        //[MarshalAs(UnmanagedType.SysInt)]
        //public readonly nint MOVE_NEXT;

    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_AsyncUniTask<T_DATA>(nint ptr)
    where T_DATA : unmanaged
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_AsyncUniTask<T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_AsyncUniTask<T_DATA> obj) => obj._ptr;
        public static implicit operator bool(Ptr_AsyncUniTask<T_DATA> obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        //public unsafe ref Ref_AsyncUniTask<T_DATA> AsRef()
        //{
        //    return ref Unsafe.AsRef<Ref_AsyncUniTask<T_DATA>>(_ptr.ToPointer());
        //}

        public unsafe ref Ref_AsyncUniTask<T_DATA, T_ARGS> AsRef<T_ARGS>()
            where T_ARGS : struct
        {
            return ref Unsafe.AsRef<Ref_AsyncUniTask<T_DATA, T_ARGS>>(_ptr.ToPointer());
        }

        public bool UNSAFE_IS_COMPLETED<T_ARGS>(int state) where T_ARGS : struct
        {
            ref var ref_Source = ref AsRef<T_ARGS>();
            ref var ref_State = ref ref_Source.ASYNC_STATE_MACHINE;
            return ref_State.STATE == state;
        }

        public unsafe T_DATA UNSAFE_GET_RESULT<T_ARGS>() where T_ARGS : struct
        {
            ref var ref_Source = ref AsRef<T_ARGS>();
            ref var ref_Core = ref ref_Source.CORE;

            return ref_Core.RESULT;
        }

        public UniTaskStatus UNSAFE_GET_STATUS<T_ARGS>(int token) where T_ARGS : struct
        {
            ref var ref_Source = ref AsRef<T_ARGS>();
            ref var ref_Core = ref ref_Source.CORE;
            if (ref_Core.VERSION != token)
            {
                //???
                return UniTaskStatus.Faulted;
            }
            if (ref_Core.CONTINUATION == nint.Zero || ref_Core.COMPLETED_COUNT == 0)
            {
                return UniTaskStatus.Pending;
            }
            if (ref_Core.ERROR == nint.Zero)
            {
                return UniTaskStatus.Succeeded;
            }

            return UniTaskStatus.Faulted;
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ptr_AsyncUniTask(nint ptr)
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_AsyncUniTask(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_AsyncUniTask obj) => obj._ptr;
        public static implicit operator bool(Ptr_AsyncUniTask obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_LoadMonsterObjectArgs
    {
        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint NAME;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint KEY;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly partial struct Ref_LoadSpriteArgs
    {
        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint ATLAS_NAME;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint SPRITE_NAME;
    }
}
