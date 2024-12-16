using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Maple.Ghostmon.Awaiter_MonsterObject;
using static Maple.Ghostmon.MonsterObject;
using static Maple.Ghostmon.UniTask;

namespace Maple.Ghostmon.Metadata.MetadataModel.UniTask
{



    /// <summary>
    /// struct ["Assembly-CSharp.dll".""."<GetMonsterConfig>d__13"]
    /// [System.Runtime.CompilerServices.IAsyncStateMachine]
    /// </summary>
    public partial class GetMonsterConfig_AsyncStateMachine
    {






        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_GetMonsterConfig_d__13
        {



            /// const string Name_Field_<>1__state = "<>1__state";
            /// <summary>
            /// struct 0x10 System.Int32 <>1__state
            /// </summary>
            [FieldOffset(0x0)]
            public readonly int state;


            /// const string Name_Field_<>t__builder = "<>t__builder";
            /// <summary>
            /// struct 0x18 Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<MonsterObject> <>t__builder
            /// </summary>
            [FieldOffset(0x8)]
            public readonly nint t__builder1;
            [FieldOffset(0x10)]
            public readonly nint t__builder2;
            [FieldOffset(0x18)]
            public readonly nint t__builder3;



            /// const string Name_Field_name = "name";
            /// <summary>
            /// class 0x30 System.String name
            /// </summary>
            [FieldOffset(0x20)]
            public readonly nint name;


            /// const string Name_Field_<key>5__2 = "<key>5__2";
            /// <summary>
            /// class 0x38 System.String <key>5__2
            /// </summary>
            [FieldOffset(0x28)]
            public readonly nint key5__2;


            /// const string Name_Field_<>u__1 = "<>u__1";
            /// <summary>
            /// struct 0x40 Cysharp.Threading.Tasks.UniTask.Awaiter<MonsterObject> <>u__1
            /// </summary>
            [FieldOffset(0x30)]
            public readonly Ref_Awaiter_MonsterObject u__1;

        }

    }

    /// <summary>
    /// struct ["Assembly-CSharp.dll".""."<GetMonsterConfig>d__13"]
    /// 
    /// [System.Runtime.CompilerServices.IAsyncStateMachine]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000367U)]
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [60, 71, 101, 116, 77, 111, 110, 115, 116, 101, 114, 67, 111, 110, 102, 105, 103, 62, 100, 95, 95, 49, 51])]


    // struct 0x10 System.Int32 <>1__state
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<>1__state", "<>1__STATE")]

    // struct 0x18 Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<MonsterObject> <>t__builder
    // [MonoCollectorSearchFieldAttribute(typeof(Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<MonsterObject>),"<>t__builder", "<>T__BUILDER")]

    // class 0x30 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x38 System.String <key>5__2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<key>5__2", "<KEY>5__2")]

    // struct 0x40 Cysharp.Threading.Tasks.UniTask.Awaiter<MonsterObject> <>u__1
    // [MonoCollectorSearchFieldAttribute(typeof(Cysharp.Threading.Tasks.UniTask.Awaiter<MonsterObject>),"<>u__1", "<>U__1")]
    //public partial class GetMonsterConfig_d__13
    //{ 
    //    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //    //public const string Const_Namespace = "";
    //    //public static byte[] Static_Namespace { get; } = [];

    //    //public const string Const_ClassName = "<GetMonsterConfig>d__13";
    //    //public static byte[] Static_ClassName { get; } = [60, 71, 101, 116, 77, 111, 110, 115, 116, 101, 114, 67, 111, 110, 102, 105, 103, 62, 100, 95, 95, 49, 51];

    //    //public const uint Const_TypeToken = 0x02000367U;








    //    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    //    public readonly unsafe partial struct Ptr_<GetMonsterConfig>d__13(nint ptr)
    //    {

    //        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
    //        readonly nint _ptr = ptr;
    //        public static implicit operator Ptr_<GetMonsterConfig>d__13(nint ptr) => new(ptr);
    //        public static implicit operator nint(Ptr_<GetMonsterConfig>d__13 obj) => obj._ptr;
    //        public static implicit operator bool(Ptr_<GetMonsterConfig>d__13 obj)=> obj.Valid();

    //        public override string ToString()
    //        {
    //            return _ptr.ToString("X8");
    //        }

    //        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    //        public bool Valid() => _ptr != nint.Zero;



    //    }

    //}

    //    /// <summary>
    //    /// ["Assembly-CSharp.dll".""."<GetMonsterConfig>d__13"]
    //    /// </summary>
    //    public partial class <GetMonsterConfig>d__13
    //    { 



    //        /// <summary>
    //        ///   System.Void MoveNext()
    //        /// </summary>
    //        /// <returns>struct System.Void</returns>
    //        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MoveNext")]
    //        ///  extern void MOVE_NEXT ();


    //        /// <summary>
    //        ///   System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
    //        /// </summary>
    //        /// <param name="stateMachine">interface System.Runtime.CompilerServices.IAsyncStateMachine</param>
    //        /// <returns>struct System.Void</returns>
    //        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetStateMachine")]
    //        ///  extern void SET_STATE_MACHINE (nint stateMachine);




    //        /// public static partial class Search_<GetMonsterConfig>d__13
    //        /// {
    //        /// 
    //        ///     
    //        /// 
    //        /// }

    //    }


}