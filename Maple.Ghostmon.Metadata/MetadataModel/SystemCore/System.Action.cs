
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
    /// class ["mscorlib.dll"."System"."Action"]
    /// [System.MulticastDelegate]=>[System.Delegate]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([109, 115, 99, 111, 114, 108, 105, 98, 46, 100, 108, 108], 0x0200009DU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([109, 115, 99, 111, 114, 108, 105, 98, 46, 100, 108, 108], [83, 121, 115, 116, 101, 109], [65, 99, 116, 105, 111, 110])]
    
                
    // struct 0x10 System.IntPtr method_ptr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"method_ptr", "METHOD_PTR")]
            
    // struct 0x18 System.IntPtr invoke_impl
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"invoke_impl", "INVOKE_IMPL")]
            
    // class 0x20 System.Object m_target
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_target", "M_TARGET")]
            
    // struct 0x28 System.IntPtr method
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"method", "METHOD")]
            
    // struct 0x30 System.IntPtr delegate_trampoline
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"delegate_trampoline", "DELEGATE_TRAMPOLINE")]
            
    // struct 0x38 System.IntPtr extra_arg
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"extra_arg", "EXTRA_ARG")]
            
    // struct 0x40 System.IntPtr method_code
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"method_code", "METHOD_CODE")]
            
    // abstract class 0x48 System.Reflection.MethodInfo method_info
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"method_info", "METHOD_INFO")]
            
    // abstract class 0x50 System.Reflection.MethodInfo original_method_info
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"original_method_info", "ORIGINAL_METHOD_INFO")]
            
    // class 0x58 System.DelegateData data
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"data", "DATA")]
            
    // struct 0x60 System.Boolean method_is_virtual
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"method_is_virtual", "METHOD_IS_VIRTUAL")]
            
    // class 0x68 System.Delegate[] delegates
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"delegates", "DELEGATES")]
    public partial class SystemAction
    { 
        //public const string Const_ImageName = "mscorlib.dll";
        //public static byte[] Static_ImageName { get; } = [109, 115, 99, 111, 114, 108, 105, 98, 46, 100, 108, 108];

        //public const string Const_Namespace = "System";
        //public static byte[] Static_Namespace { get; } = [83, 121, 115, 116, 101, 109];

        //public const string Const_ClassName = "Action";
        //public static byte[] Static_ClassName { get; } = [65, 99, 116, 105, 111, 110];

        //public const uint Const_TypeToken = 0x0200009DU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SystemAction(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SystemAction(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SystemAction obj) => obj._ptr;
            public static implicit operator bool(Ptr_SystemAction obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["mscorlib.dll"."System"."Action"]
        /// </summary>
        public partial class SystemAction
    { 

            
            
            /// <summary>
            ///   System.Void .ctor(System.Object object, System.IntPtr method)
            /// </summary>
            /// <param name="object">class System.Object</param>
            /// <param name="method">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
             [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
              extern void CTOR (nint _object, System.IntPtr method);

            
            /// <summary>
            /// static  System.MulticastDelegate AllocDelegateLike_internal(System.Delegate d)
            /// </summary>
            /// <param name="d">abstract class System.Delegate</param>
            /// <returns>abstract class System.MulticastDelegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AllocDelegateLike_internal")]
            /// static extern nint ALLOC_DELEGATE_LIKE_INTERNAL (nint d);

            
            /// <summary>
            /// static  System.Boolean arg_type_match(System.Type delArgType, System.Type argType)
            /// </summary>
            /// <param name="delArgType">abstract class System.Type</param>
            /// <param name="argType">abstract class System.Type</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("arg_type_match")]
            /// static extern System.Boolean ARG_TYPE_MATCH (nint delArgType, nint argType);

            
            /// <summary>
            /// static  System.Boolean arg_type_match_this(System.Type delArgType, System.Type argType, System.Boolean boxedThis)
            /// </summary>
            /// <param name="delArgType">abstract class System.Type</param>
            /// <param name="argType">abstract class System.Type</param>
            /// <param name="boxedThis">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("arg_type_match_this")]
            /// static extern System.Boolean ARG_TYPE_MATCH_THIS (nint delArgType, nint argType, System.Boolean boxedThis);

            
            /// <summary>
            ///   System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
            /// </summary>
            /// <param name="callback">class System.AsyncCallback</param>
            /// <param name="object">class System.Object</param>
            /// <returns>interface System.IAsyncResult</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BeginInvoke")]
            ///  extern nint BEGIN_INVOKE (nint callback, nint object);

            
            /// <summary>
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
            ///  extern nint CLONE ();

            
            /// <summary>
            /// static  System.Delegate CreateDelegate_internal(System.Type type, System.Object target, System.Reflection.MethodInfo info, System.Boolean throwOnBindFailure)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="target">class System.Object</param>
            /// <param name="info">abstract class System.Reflection.MethodInfo</param>
            /// <param name="throwOnBindFailure">struct System.Boolean</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate_internal")]
            /// static extern nint CREATE_DELEGATE_INTERNAL (nint type, nint target, nint info, System.Boolean throwOnBindFailure);

            
            /// <summary>
            /// static  System.Delegate CreateDelegateNoSecurityCheck(System.RuntimeType type, System.Object firstArgument, System.Reflection.MethodInfo method)
            /// </summary>
            /// <param name="type">class System.RuntimeType</param>
            /// <param name="firstArgument">class System.Object</param>
            /// <param name="method">abstract class System.Reflection.MethodInfo</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegateNoSecurityCheck")]
            /// static extern nint CREATE_DELEGATE_NO_SECURITY_CHECK (nint type, nint firstArgument, nint method);

            
            /// <summary>
            ///   System.Object DynamicInvoke(System.Object[] args)
            /// </summary>
            /// <param name="args">class System.Object[]</param>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DynamicInvoke")]
            ///  extern nint DYNAMIC_INVOKE (nint args);

            
            /// <summary>
            ///   System.Void EndInvoke(System.IAsyncResult result)
            /// </summary>
            /// <param name="result">interface System.IAsyncResult</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EndInvoke")]
            ///  extern void END_INVOKE (nint result);

            
            /// <summary>
            ///   System.Reflection.MethodInfo get_Method()
            /// </summary>
            /// <returns>abstract class System.Reflection.MethodInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Method")]
            ///  extern nint GET_METHOD ();

            
            /// <summary>
            ///   System.Object get_Target()
            /// </summary>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Target")]
            ///  extern nint GET_TARGET ();

            
            /// <summary>
            /// static  System.Reflection.MethodInfo GetCandidateMethod(System.Type type, System.Type target, System.String method, System.Reflection.BindingFlags bflags, System.Boolean ignoreCase, System.Boolean throwOnBindFailure)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="target">abstract class System.Type</param>
            /// <param name="method">class System.String</param>
            /// <param name="bflags">enum System.Reflection.BindingFlags</param>
            /// <param name="ignoreCase">struct System.Boolean</param>
            /// <param name="throwOnBindFailure">struct System.Boolean</param>
            /// <returns>abstract class System.Reflection.MethodInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCandidateMethod")]
            /// static extern nint GET_CANDIDATE_METHOD (nint type, nint target, nint method, System.Reflection.BindingFlags bflags, System.Boolean ignoreCase, System.Boolean throwOnBindFailure);

            
            /// <summary>
            ///   System.Reflection.MethodInfo GetVirtualMethod_internal()
            /// </summary>
            /// <returns>abstract class System.Reflection.MethodInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetVirtualMethod_internal")]
            ///  extern nint GET_VIRTUAL_METHOD_INTERNAL ();

            
            /// <summary>
            ///   System.Void InitializeDelegateData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitializeDelegateData")]
            ///  extern void INITIALIZE_DELEGATE_DATA ();

            
            /// <summary>
            ///   System.Void Invoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Invoke")]
            ///  extern void INVOKE ();

            
            /// <summary>
            ///   System.Int32 LastIndexOf(System.Delegate[] haystack, System.Delegate[] needle)
            /// </summary>
            /// <param name="haystack">class System.Delegate[]</param>
            /// <param name="needle">class System.Delegate[]</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LastIndexOf")]
            ///  extern System.Int32 LAST_INDEX_OF (nint haystack, nint needle);

            
            /// <summary>
            /// static  System.Boolean op_Equality(System.Delegate d1, System.Delegate d2)
            /// </summary>
            /// <param name="d1">abstract class System.Delegate</param>
            /// <param name="d2">abstract class System.Delegate</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
            /// static extern System.Boolean OP_EQUALITY (nint d1, nint d2);

            
            /// <summary>
            /// static  System.Boolean op_Inequality(System.Delegate d1, System.Delegate d2)
            /// </summary>
            /// <param name="d1">abstract class System.Delegate</param>
            /// <param name="d2">abstract class System.Delegate</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
            /// static extern System.Boolean OP_INEQUALITY (nint d1, nint d2);

            
            /// <summary>
            /// static  System.Delegate Remove(System.Delegate source, System.Delegate value)
            /// </summary>
            /// <param name="source">abstract class System.Delegate</param>
            /// <param name="value">abstract class System.Delegate</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
            /// static extern nint REMOVE (nint source, nint value);

            
            /// <summary>
            /// static  System.Boolean return_type_match(System.Type delReturnType, System.Type returnType)
            /// </summary>
            /// <param name="delReturnType">abstract class System.Type</param>
            /// <param name="returnType">abstract class System.Type</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("return_type_match")]
            /// static extern System.Boolean RETURN_TYPE_MATCH (nint delReturnType, nint returnType);
            
            
            
            /// <summary>
            /// static  System.Delegate Combine(System.Delegate a, System.Delegate b)
            /// </summary>
            /// <param name="a">abstract class System.Delegate</param>
            /// <param name="b">abstract class System.Delegate</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Combine", Search = typeof(Search_Action))]
            /// static extern nint COMBINE_00 (nint a, nint b);

            
            /// <summary>
            /// static  System.Delegate Combine(System.Delegate[] delegates)
            /// </summary>
            /// <param name="delegates">class System.Delegate[]</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Combine", Search = typeof(Search_Action))]
            /// static extern nint COMBINE_01 (nint delegates);

            
            /// <summary>
            ///   System.Delegate CombineImpl(System.Delegate follow)
            /// </summary>
            /// <param name="follow">abstract class System.Delegate</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CombineImpl", Search = typeof(Search_Action))]
            ///  extern nint COMBINE_IMPL_00 (nint follow);

            
            /// <summary>
            ///   System.Delegate CombineImpl(System.Delegate d)
            /// </summary>
            /// <param name="d">abstract class System.Delegate</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CombineImpl", Search = typeof(Search_Action))]
            ///  extern nint COMBINE_IMPL_01 (nint d);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Object firstArgument, System.Reflection.MethodInfo method, System.Boolean throwOnBindFailure)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="firstArgument">class System.Object</param>
            /// <param name="method">abstract class System.Reflection.MethodInfo</param>
            /// <param name="throwOnBindFailure">struct System.Boolean</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_00 (nint type, nint firstArgument, nint method, System.Boolean throwOnBindFailure);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Object firstArgument, System.Reflection.MethodInfo method, System.Boolean throwOnBindFailure, System.Boolean allowClosed)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="firstArgument">class System.Object</param>
            /// <param name="method">abstract class System.Reflection.MethodInfo</param>
            /// <param name="throwOnBindFailure">struct System.Boolean</param>
            /// <param name="allowClosed">struct System.Boolean</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_01 (nint type, nint firstArgument, nint method, System.Boolean throwOnBindFailure, System.Boolean allowClosed);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Object firstArgument, System.Reflection.MethodInfo method)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="firstArgument">class System.Object</param>
            /// <param name="method">abstract class System.Reflection.MethodInfo</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_02 (nint type, nint firstArgument, nint method);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method, System.Boolean throwOnBindFailure)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="method">abstract class System.Reflection.MethodInfo</param>
            /// <param name="throwOnBindFailure">struct System.Boolean</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_03 (nint type, nint method, System.Boolean throwOnBindFailure);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="method">abstract class System.Reflection.MethodInfo</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_04 (nint type, nint method);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Object target, System.String method)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="target">class System.Object</param>
            /// <param name="method">class System.String</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_05 (nint type, nint target, nint method);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Type target, System.String method, System.Boolean ignoreCase, System.Boolean throwOnBindFailure)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="target">abstract class System.Type</param>
            /// <param name="method">class System.String</param>
            /// <param name="ignoreCase">struct System.Boolean</param>
            /// <param name="throwOnBindFailure">struct System.Boolean</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_06 (nint type, nint target, nint method, System.Boolean ignoreCase, System.Boolean throwOnBindFailure);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Type target, System.String method)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="target">abstract class System.Type</param>
            /// <param name="method">class System.String</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_07 (nint type, nint target, nint method);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Object target, System.String method, System.Boolean ignoreCase, System.Boolean throwOnBindFailure)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="target">class System.Object</param>
            /// <param name="method">class System.String</param>
            /// <param name="ignoreCase">struct System.Boolean</param>
            /// <param name="throwOnBindFailure">struct System.Boolean</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_08 (nint type, nint target, nint method, System.Boolean ignoreCase, System.Boolean throwOnBindFailure);

            
            /// <summary>
            /// static  System.Delegate CreateDelegate(System.Type type, System.Object target, System.String method, System.Boolean ignoreCase)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="target">class System.Object</param>
            /// <param name="method">class System.String</param>
            /// <param name="ignoreCase">struct System.Boolean</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDelegate", Search = typeof(Search_Action))]
            /// static extern nint CREATE_DELEGATE_09 (nint type, nint target, nint method, System.Boolean ignoreCase);

            
            /// <summary>
            ///   System.Object DynamicInvokeImpl(System.Object[] args)
            /// </summary>
            /// <param name="args">class System.Object[]</param>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DynamicInvokeImpl", Search = typeof(Search_Action))]
            ///  extern nint DYNAMIC_INVOKE_IMPL_00 (nint args);

            
            /// <summary>
            ///   System.Object DynamicInvokeImpl(System.Object[] args)
            /// </summary>
            /// <param name="args">class System.Object[]</param>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DynamicInvokeImpl", Search = typeof(Search_Action))]
            ///  extern nint DYNAMIC_INVOKE_IMPL_01 (nint args);

            
            /// <summary>
            ///   System.Boolean Equals(System.Object obj)
            /// </summary>
            /// <param name="obj">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_Action))]
            ///  extern System.Boolean EQUALS_00 (nint obj);

            
            /// <summary>
            ///   System.Boolean Equals(System.Object obj)
            /// </summary>
            /// <param name="obj">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_Action))]
            ///  extern System.Boolean EQUALS_01 (nint obj);

            
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode", Search = typeof(Search_Action))]
            ///  extern System.Int32 GET_HASH_CODE_00 ();

            
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode", Search = typeof(Search_Action))]
            ///  extern System.Int32 GET_HASH_CODE_01 ();

            
            /// <summary>
            ///   System.Delegate[] GetInvocationList()
            /// </summary>
            /// <returns>class System.Delegate[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInvocationList", Search = typeof(Search_Action))]
            ///  extern nint GET_INVOCATION_LIST_00 ();

            
            /// <summary>
            ///   System.Delegate[] GetInvocationList()
            /// </summary>
            /// <returns>class System.Delegate[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInvocationList", Search = typeof(Search_Action))]
            ///  extern nint GET_INVOCATION_LIST_01 ();

            
            /// <summary>
            ///   System.Reflection.MethodInfo GetMethodImpl()
            /// </summary>
            /// <returns>abstract class System.Reflection.MethodInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMethodImpl", Search = typeof(Search_Action))]
            ///  extern nint GET_METHOD_IMPL_00 ();

            
            /// <summary>
            ///   System.Reflection.MethodInfo GetMethodImpl()
            /// </summary>
            /// <returns>abstract class System.Reflection.MethodInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMethodImpl", Search = typeof(Search_Action))]
            ///  extern nint GET_METHOD_IMPL_01 ();

            
            /// <summary>
            ///   System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name="info">class System.Runtime.Serialization.SerializationInfo</param>
            /// <param name="context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetObjectData", Search = typeof(Search_Action))]
            ///  extern void GET_OBJECT_DATA_00 (nint info, System.Runtime.Serialization.StreamingContext context);

            
            /// <summary>
            ///   System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name="info">class System.Runtime.Serialization.SerializationInfo</param>
            /// <param name="context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetObjectData", Search = typeof(Search_Action))]
            ///  extern void GET_OBJECT_DATA_01 (nint info, System.Runtime.Serialization.StreamingContext context);

            
            /// <summary>
            ///   System.Delegate RemoveImpl(System.Delegate value)
            /// </summary>
            /// <param name="value">abstract class System.Delegate</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveImpl", Search = typeof(Search_Action))]
            ///  extern nint REMOVE_IMPL_00 (nint value);

            
            /// <summary>
            ///   System.Delegate RemoveImpl(System.Delegate d)
            /// </summary>
            /// <param name="d">abstract class System.Delegate</param>
            /// <returns>abstract class System.Delegate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveImpl", Search = typeof(Search_Action))]
            ///  extern nint REMOVE_IMPL_01 (nint d);

            
            /// public static partial class Search_Action
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    /// static  System.Delegate Combine(System.Delegate a, System.Delegate b)
                    /// </summary>
                    /// public static bool COMBINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Combine", "System.Delegate", "System.Delegate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate Combine(System.Delegate[] delegates)
                    /// </summary>
                    /// public static bool COMBINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Combine", "System.Delegate[]");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Delegate CombineImpl(System.Delegate follow)
                    /// </summary>
                    /// public static bool COMBINE_IMPL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CombineImpl", "System.Delegate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Delegate CombineImpl(System.Delegate d)
                    /// </summary>
                    /// public static bool COMBINE_IMPL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CombineImpl", "System.Delegate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Object firstArgument, System.Reflection.MethodInfo method, System.Boolean throwOnBindFailure)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Object", "System.Reflection.MethodInfo", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Object firstArgument, System.Reflection.MethodInfo method, System.Boolean throwOnBindFailure, System.Boolean allowClosed)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Object", "System.Reflection.MethodInfo", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Object firstArgument, System.Reflection.MethodInfo method)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Object", "System.Reflection.MethodInfo");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method, System.Boolean throwOnBindFailure)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Reflection.MethodInfo", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Reflection.MethodInfo");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Object target, System.String method)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Object", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Type target, System.String method, System.Boolean ignoreCase, System.Boolean throwOnBindFailure)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Type", "System.String", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Type target, System.String method)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Type", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Object target, System.String method, System.Boolean ignoreCase, System.Boolean throwOnBindFailure)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Object", "System.String", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Delegate CreateDelegate(System.Type type, System.Object target, System.String method, System.Boolean ignoreCase)
                    /// </summary>
                    /// public static bool CREATE_DELEGATE_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateDelegate", "System.Type", "System.Object", "System.String", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Object DynamicInvokeImpl(System.Object[] args)
                    /// </summary>
                    /// public static bool DYNAMIC_INVOKE_IMPL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DynamicInvokeImpl", "System.Object[]");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Object DynamicInvokeImpl(System.Object[] args)
                    /// </summary>
                    /// public static bool DYNAMIC_INVOKE_IMPL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DynamicInvokeImpl", "System.Object[]");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Equals(System.Object obj)
                    /// </summary>
                    /// public static bool EQUALS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Equals(System.Object obj)
                    /// </summary>
                    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Int32 GetHashCode()
                    /// </summary>
                    /// public static bool GET_HASH_CODE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetHashCode");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Int32 GetHashCode()
                    /// </summary>
                    /// public static bool GET_HASH_CODE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetHashCode");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Delegate[] GetInvocationList()
                    /// </summary>
                    /// public static bool GET_INVOCATION_LIST_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInvocationList");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Delegate[] GetInvocationList()
                    /// </summary>
                    /// public static bool GET_INVOCATION_LIST_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInvocationList");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Reflection.MethodInfo GetMethodImpl()
                    /// </summary>
                    /// public static bool GET_METHOD_IMPL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMethodImpl");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Reflection.MethodInfo GetMethodImpl()
                    /// </summary>
                    /// public static bool GET_METHOD_IMPL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMethodImpl");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
                    /// </summary>
                    /// public static bool GET_OBJECT_DATA_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetObjectData", "System.Runtime.Serialization.SerializationInfo", "System.Runtime.Serialization.StreamingContext");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
                    /// </summary>
                    /// public static bool GET_OBJECT_DATA_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetObjectData", "System.Runtime.Serialization.SerializationInfo", "System.Runtime.Serialization.StreamingContext");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Delegate RemoveImpl(System.Delegate value)
                    /// </summary>
                    /// public static bool REMOVE_IMPL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveImpl", "System.Delegate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Delegate RemoveImpl(System.Delegate d)
                    /// </summary>
                    /// public static bool REMOVE_IMPL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveImpl", "System.Delegate");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}