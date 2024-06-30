using System.Runtime.CompilerServices;
using static Maple.Ghostmon.Awaiter_MonsterObject;

namespace Maple.Ghostmon
{


    /// <summary>
    /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask`1"]
    /// 
    /// </summary>
    public partial class UniTask_MonsterObject
    {






        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ref_UniTask_MonsterObject
        {

            /// const string Name_Field_source = "source";
            /// <summary>
            /// interface 0x10 Cysharp.Threading.Tasks.IUniTaskSource<MonsterObject> source
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            public readonly nint source;


            /// const string Name_Field_result = "result";
            /// <summary>
            /// class 0x18 MonsterObject result
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            public readonly nint result;


            /// const string Name_Field_token = "token";
            /// <summary>
            /// struct 0x20 System.Int16 token
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I2)]
            public readonly System.Int16 token;

            public Awaiter_MonsterObject.Ref_Awaiter_MonsterObject GET_AWAITER()
            {
                return new Ref_Awaiter_MonsterObject(in this);
            }
        }

    }

    /// <summary>
    /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask`1"]
    /// 
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], 0x02000049U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115], [85, 110, 105, 84, 97, 115, 107, 96, 49])]


    // interface 0x10 Cysharp.Threading.Tasks.IUniTaskSource<MonsterObject> source
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"source", "SOURCE")]

    // class 0x18 MonsterObject result
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"result", "RESULT")]

    // struct 0x20 System.Int16 token
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int16),"token", "TOKEN")]
    public partial class UniTask_MonsterObject
    {
        //public const string Const_ImageName = "UniTask.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108];

        //public const string Const_Namespace = "Cysharp.Threading.Tasks";
        //public static byte[] Static_Namespace { get; } = [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115];

        //public const string Const_ClassName = "UniTask`1";
        //public static byte[] Static_ClassName { get; } = [85, 110, 105, 84, 97, 115, 107, 96, 49];

        //public const uint Const_TypeToken = 0x02000049U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UniTask_MonsterObject(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UniTask_MonsterObject(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UniTask_MonsterObject obj) => obj._ptr;
            public static implicit operator bool(Ptr_UniTask_MonsterObject obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;


            public unsafe ref UniTask_MonsterObject.Ref_UniTask_MonsterObject AsRef()
            {
                return ref Unsafe.AsRef<UniTask_MonsterObject.Ref_UniTask_MonsterObject>(_ptr.ToPointer());
            }

        }

    }

    /// <summary>
    /// ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask`1"]
    /// </summary>
    public partial class UniTask_MonsterObject
    {



        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask AsUniTask()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AsUniTask")]
        ///  extern Cysharp.Threading.Tasks.UniTask AS_UNI_TASK ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTaskStatus get_Status()
        /// </summary>
        /// <returns>enum Cysharp.Threading.Tasks.UniTaskStatus</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Status")]
        extern UniTaskStatus GET_STATUS();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask.Awaiter<MonsterObject> GetAwaiter()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask.Awaiter<MonsterObject></returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAwaiter")]
        extern Awaiter_MonsterObject.Ref_Awaiter_MonsterObject GET_AWAITER();


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask op_Implicit(Cysharp.Threading.Tasks.UniTask<MonsterObject> self)
        /// </summary>
        /// <param name="self">struct Cysharp.Threading.Tasks.UniTask<MonsterObject></param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
        /// static extern Cysharp.Threading.Tasks.UniTask OP_IMPLICIT (Cysharp.Threading.Tasks.UniTask<MonsterObject> self);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();



        /// <summary>
        ///   System.Void .ctor(MonsterObject result)
        /// </summary>
        /// <param name="result">class MonsterObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UniTaskGeneric))]
        ///  extern void .CTOR_00 (nint result);


        /// <summary>
        ///   System.Void .ctor(Cysharp.Threading.Tasks.IUniTaskSource<MonsterObject> source, System.Int16 token)
        /// </summary>
        /// <param name="source">interface Cysharp.Threading.Tasks.IUniTaskSource<MonsterObject></param>
        /// <param name="token">struct System.Int16</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UniTaskGeneric))]
        ///  extern void .CTOR_01 (nint source, System.Int16 token);


        /// public static partial class Search_UniTaskGeneric
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(MonsterObject result)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "MonsterObject");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(Cysharp.Threading.Tasks.IUniTaskSource<MonsterObject> source, System.Int16 token)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Cysharp.Threading.Tasks.IUniTaskSource<MonsterObject>", "System.Int16");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    partial class UniTask_MonsterObject(Maple.MonoGameAssistant.Core.MonoCollectorContext collectorContext, Maple.MonoGameAssistant.MonoCollector.MonoCollectorClassInfo classInfo) : Maple.MonoGameAssistant.Core.MonoCollectorMember(collectorContext, classInfo)
    {



        readonly unsafe partial struct Ptr_Func_GET_STATUS(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject, Maple.Ghostmon.UniTaskStatus> _func = (delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject, Maple.Ghostmon.UniTaskStatus>)ptr;

            public static implicit operator Ptr_Func_GET_STATUS(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.Ghostmon.UniTaskStatus Invoke(Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject __this__) => _func(__this__);
        }

        static Ptr_Func_GET_STATUS Func_GET_STATUS;

        readonly unsafe partial struct Ptr_UniTask_MonsterObject
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.Ghostmon.UniTaskStatus GET_STATUS() => Func_GET_STATUS.Invoke(this);
        }

        internal readonly unsafe partial struct Ptr_Func_GET_AWAITER(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject, out Maple.Ghostmon.Awaiter_MonsterObject.Ref_Awaiter_MonsterObject, Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject> _func = (delegate* unmanaged[SuppressGCTransition]<Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject, out Maple.Ghostmon.Awaiter_MonsterObject.Ref_Awaiter_MonsterObject, Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject>)ptr;

            public static implicit operator Ptr_Func_GET_AWAITER(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject Invoke(Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject __this__, out Maple.Ghostmon.Awaiter_MonsterObject.Ref_Awaiter_MonsterObject ref_Awaiter_Monster) => _func(__this__, out ref_Awaiter_Monster);
        }

        internal static Ptr_Func_GET_AWAITER Func_GET_AWAITER;

        readonly unsafe partial struct Ptr_UniTask_MonsterObject
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.Ghostmon.Awaiter_MonsterObject.Ptr_Awaiter_MonsterObject GET_AWAITER(out Maple.Ghostmon.Awaiter_MonsterObject.Ref_Awaiter_MonsterObject ref_Awaiter_Monster) => Func_GET_AWAITER.Invoke(this, out ref_Awaiter_Monster);
        }






        protected sealed override void InitMember()
        {

            Func_GET_STATUS = GetMethodPointer("get_Status");

            Func_GET_AWAITER = GetMethodPointer("GetAwaiter");


        }


        public Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject New(bool execDefCtor)
            => New<Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject>(execDefCtor);

        public Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject Ctor()
            => Ctor<Maple.Ghostmon.UniTask_MonsterObject.Ptr_UniTask_MonsterObject>();
    }
}