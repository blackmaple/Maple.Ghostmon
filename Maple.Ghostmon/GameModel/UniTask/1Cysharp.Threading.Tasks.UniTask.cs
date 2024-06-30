
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    ///// <summary>
    ///// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask"]
    ///// 
    ///// </summary>
    //public partial class UniTask
    //{






    //    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    //    public unsafe partial struct Ref_UniTask
    //    {



    //        /// const string Name_Field_source = "source";
    //        /// <summary>
    //        /// interface 0x10 Cysharp.Threading.Tasks.IUniTaskSource source
    //        /// </summary>
    //        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
    //        public nint source;


    //        /// const string Name_Field_token = "token";
    //        /// <summary>
    //        /// struct 0x18 System.Int16 token
    //        /// </summary>
    //        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
    //        public System.Int16 token;

    //    }

    //}

    ///// <summary>
    ///// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask"]
    ///// 
    ///// 
    ///// </summary>
    ////[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], 0x02000037U)]
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108], [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115], [85, 110, 105, 84, 97, 115, 107])]

    ////  struct static Cysharp.Threading.Tasks.UniTask CanceledUniTask
    ////  [MonoCollectorSearchFieldAttribute(typeof(Cysharp.Threading.Tasks.UniTask),"CanceledUniTask", "CANCELED_UNI_TASK", true)]

    ////  struct static Cysharp.Threading.Tasks.UniTask CompletedTask
    ////  [MonoCollectorSearchFieldAttribute(typeof(Cysharp.Threading.Tasks.UniTask),"CompletedTask", "COMPLETED_TASK", true)]

    //// interface 0x10 Cysharp.Threading.Tasks.IUniTaskSource source
    //// [MonoCollectorSearchFieldAttribute(typeof(nint),"source", "SOURCE")]

    //// struct 0x18 System.Int16 token
    //// [MonoCollectorSearchFieldAttribute(typeof(System.Int16),"token", "TOKEN")]
    //public partial class UniTask
    //{
    //    //public const string Const_ImageName = "UniTask.dll";
    //    //public static byte[] Static_ImageName { get; } = [85, 110, 105, 84, 97, 115, 107, 46, 100, 108, 108];

    //    //public const string Const_Namespace = "Cysharp.Threading.Tasks";
    //    //public static byte[] Static_Namespace { get; } = [67, 121, 115, 104, 97, 114, 112, 46, 84, 104, 114, 101, 97, 100, 105, 110, 103, 46, 84, 97, 115, 107, 115];

    //    //public const string Const_ClassName = "UniTask";
    //    //public static byte[] Static_ClassName { get; } = [85, 110, 105, 84, 97, 115, 107];

    //    //public const uint Const_TypeToken = 0x02000037U;








    //    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    //    public readonly unsafe partial struct Ptr_UniTask(nint ptr)
    //    {

    //        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
    //        readonly nint _ptr = ptr;
    //        public static implicit operator Ptr_UniTask(nint ptr) => new(ptr);
    //        public static implicit operator nint(Ptr_UniTask obj) => obj._ptr;
    //        public static implicit operator bool(Ptr_UniTask obj) => obj.Valid();

    //        public override string ToString()
    //        {
    //            return _ptr.ToString("X8");
    //        }

    //        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    //        public bool Valid() => _ptr != nint.Zero;



    //    }

    //}

    ///// <summary>
    ///// ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask"]
    ///// </summary>
    //public partial class UniTask
    //{



    //    /// <summary>
    //    /// static  System.Void .cctor()
    //    /// </summary>
    //    /// <returns>struct System.Void</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
    //    /// static extern void .CCTOR ();


    //    /// <summary>
    //    ///   System.Void .ctor(Cysharp.Threading.Tasks.IUniTaskSource source, System.Int16 token)
    //    /// </summary>
    //    /// <param name="source">interface Cysharp.Threading.Tasks.IUniTaskSource</param>
    //    /// <param name="token">struct System.Int16</param>
    //    /// <returns>struct System.Void</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    //    ///  extern void .CTOR (nint source, System.Int16 token);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask DelayFrame(System.Int32 delayFrameCount, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// <param name="delayFrameCount">struct System.Int32</param>
    //    /// <param name="delayTiming">enum Cysharp.Threading.Tasks.PlayerLoopTiming</param>
    //    /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DelayFrame")]
    //    /// static extern Cysharp.Threading.Tasks.UniTask DELAY_FRAME (System.Int32 delayFrameCount, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask<T> FromResult(T value)
    //    /// </summary>
    //    /// <param name="value">class T</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromResult")]
    //    /// static extern Cysharp.Threading.Tasks.UniTask<T> FROM_RESULT (nint value);


    //    /// <summary>
    //    ///   Cysharp.Threading.Tasks.UniTaskStatus get_Status()
    //    /// </summary>
    //    /// <returns>enum Cysharp.Threading.Tasks.UniTaskStatus</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Status")]
    //    ///  extern Cysharp.Threading.Tasks.UniTaskStatus GET_STATUS ();


    //    /// <summary>
    //    ///   Cysharp.Threading.Tasks.UniTask.Awaiter GetAwaiter()
    //    /// </summary>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask.Awaiter</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAwaiter")]
    //    ///  extern Cysharp.Threading.Tasks.UniTask.Awaiter GET_AWAITER ();


    //    /// <summary>
    //    ///   System.String ToString()
    //    /// </summary>
    //    /// <returns>class System.String</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
    //    ///  extern nint TO_STRING ();



    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask Delay(System.Int32 millisecondsDelay, System.Boolean ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// <param name="millisecondsDelay">struct System.Int32</param>
    //    /// <param name="ignoreTimeScale">struct System.Boolean</param>
    //    /// <param name="delayTiming">enum Cysharp.Threading.Tasks.PlayerLoopTiming</param>
    //    /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Delay", Search = typeof(Search_UniTask))]
    //    /// static extern Cysharp.Threading.Tasks.UniTask DELAY_00 (System.Int32 millisecondsDelay, System.Boolean ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, System.Boolean ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// <param name="delayTimeSpan">struct System.TimeSpan</param>
    //    /// <param name="ignoreTimeScale">struct System.Boolean</param>
    //    /// <param name="delayTiming">enum Cysharp.Threading.Tasks.PlayerLoopTiming</param>
    //    /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Delay", Search = typeof(Search_UniTask))]
    //    /// static extern Cysharp.Threading.Tasks.UniTask DELAY_01 (System.TimeSpan delayTimeSpan, System.Boolean ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// <param name="delayTimeSpan">struct System.TimeSpan</param>
    //    /// <param name="delayType">enum Cysharp.Threading.Tasks.DelayType</param>
    //    /// <param name="delayTiming">enum Cysharp.Threading.Tasks.PlayerLoopTiming</param>
    //    /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Delay", Search = typeof(Search_UniTask))]
    //    /// static extern Cysharp.Threading.Tasks.UniTask DELAY_02 (System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask FromCanceled(System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromCanceled", Search = typeof(Search_UniTask))]
    //    /// static extern Cysharp.Threading.Tasks.UniTask FROM_CANCELED_00 (System.Threading.CancellationToken cancellationToken);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask<T> FromCanceled(System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromCanceled", Search = typeof(Search_UniTask))]
    //    /// static extern Cysharp.Threading.Tasks.UniTask<T> FROM_CANCELED_01 (System.Threading.CancellationToken cancellationToken);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask FromException(System.Exception ex)
    //    /// </summary>
    //    /// <param name="ex">class System.Exception</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromException", Search = typeof(Search_UniTask))]
    //    /// static extern Cysharp.Threading.Tasks.UniTask FROM_EXCEPTION_00 (nint ex);


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask<T> FromException(System.Exception ex)
    //    /// </summary>
    //    /// <param name="ex">class System.Exception</param>
    //    /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
    //    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromException", Search = typeof(Search_UniTask))]
    //    /// static extern Cysharp.Threading.Tasks.UniTask<T> FROM_EXCEPTION_01 (nint ex);


    //    /// public static partial class Search_UniTask
    //    /// {
    //    /// 
    //    ///     

    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask Delay(System.Int32 millisecondsDelay, System.Boolean ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// public static bool DELAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Delay", "System.Int32", "System.Boolean", "Cysharp.Threading.Tasks.PlayerLoopTiming", "System.Threading.CancellationToken");
    //    ///     
    //    ///  
    //    /// 


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, System.Boolean ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// public static bool DELAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Delay", "System.TimeSpan", "System.Boolean", "Cysharp.Threading.Tasks.PlayerLoopTiming", "System.Threading.CancellationToken");
    //    ///     
    //    ///  
    //    /// 


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// public static bool DELAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Delay", "System.TimeSpan", "Cysharp.Threading.Tasks.DelayType", "Cysharp.Threading.Tasks.PlayerLoopTiming", "System.Threading.CancellationToken");
    //    ///     
    //    ///  
    //    /// 


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask FromCanceled(System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// public static bool FROM_CANCELED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromCanceled", "System.Threading.CancellationToken");
    //    ///     
    //    ///  
    //    /// 


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask<T> FromCanceled(System.Threading.CancellationToken cancellationToken)
    //    /// </summary>
    //    /// public static bool FROM_CANCELED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromCanceled", "System.Threading.CancellationToken");
    //    ///     
    //    ///  
    //    /// 


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask FromException(System.Exception ex)
    //    /// </summary>
    //    /// public static bool FROM_EXCEPTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromException", "System.Exception");
    //    ///     
    //    ///  
    //    /// 


    //    /// <summary>
    //    /// static  Cysharp.Threading.Tasks.UniTask<T> FromException(System.Exception ex)
    //    /// </summary>
    //    /// public static bool FROM_EXCEPTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromException", "System.Exception");
    //    ///     
    //    ///  
    //    /// 
    //    /// 
    //    /// }

    //}


}