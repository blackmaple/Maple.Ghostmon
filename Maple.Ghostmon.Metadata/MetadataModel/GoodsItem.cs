
using Maple.MonoGameAssistant.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."GoodsItem"]
    /// [Ghostmon.UI.UIComponent]=>[Ghostmon.UI.UIBase]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000188U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [71, 111, 111, 100, 115, 73, 116, 101, 109])]
                
    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT", true)]
                
    // struct 0x10 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]
            
    // class 0x18 System.Collections.Generic.List<Ghostmon.UI.UIBase> needRecycledUIBase
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"needRecycledUIBase", "NEED_RECYCLED_UI_BASE")]
            
    // class 0x20 System.Collections.Generic.List<UnityEngine.GameObject> needRecycledGo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"needRecycledGo", "NEED_RECYCLED_GO")]
            
    // class 0x28 System.Collections.Generic.List<SpecialEffectBase> needRecycledEffect
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"needRecycledEffect", "NEED_RECYCLED_EFFECT")]
            
    // struct 0x30 System.Boolean recycle
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"recycle", "RECYCLE")]
            
    // class 0x38 System.Collections.Generic.List<System.Action> extraCloseEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"extraCloseEvent", "EXTRA_CLOSE_EVENT")]
            
    // class 0x40 Ghostmon.UI.UICanvas canvas
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"canvas", "CANVAS")]
            
    // class 0x48 Ghostmon.UI.UIHoverButton btn_goods
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_goods", "BTN_GOODS")]
            
    // class 0x50 TMPro.TextMeshProUGUI text_num
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_num", "TEXT_NUM")]
            
    // class 0x58 UnityEngine.UI.Image icon_goods
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_goods", "ICON_GOODS")]
            
    // class 0x60 UnityEngine.UI.Image icon_selected
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_selected", "ICON_SELECTED")]
            
    // class 0x68 UnityEngine.CanvasGroup numNode
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"numNode", "NUM_NODE")]
            
    // class 0x70 UnityEngine.UI.Button btn_add
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_add", "BTN_ADD")]
            
    // class 0x78 UnityEngine.RectTransform parent_rect
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"parent_rect", "PARENT_RECT")]
            
    // class 0x80 System.Action<GoodsItem> AddGoods
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"AddGoods", "ADD_GOODS")]
            
    // class 0x88 System.Action<System.UInt64,System.Int32> ShowGoodsTip
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ShowGoodsTip", "SHOW_GOODS_TIP")]
            
    // class 0x90 System.Action HideGoodsTip
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"HideGoodsTip", "HIDE_GOODS_TIP")]
            
    // struct 0x98 System.UInt64 ID
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"ID", "ID")]
            
    // struct 0xA0 System.Int32 num
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"num", "NUM")]
            
    // struct 0xA4 System.Int32 index
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"index", "INDEX")]
    public partial class GoodsItem
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GoodsItem";
        //public static byte[] Static_ClassName { get; } = [71, 111, 111, 100, 115, 73, 116, 101, 109];

        //public const uint Const_TypeToken = 0x02000188U;



                    
        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";
            
        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GoodsItem(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GoodsItem(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GoodsItem obj) => obj._ptr;
            public static implicit operator bool(Ptr_GoodsItem obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."GoodsItem"]
        /// </summary>
        public partial class GoodsItem
        { 

            
            
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
            /// static extern void .CCTOR ();

            
            /// <summary>
            ///   System.Boolean <SetItemInfo>b__18_0(Ghostmon.RareData x)
            /// </summary>
            /// <param name="x">class Ghostmon.RareData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<SetItemInfo>b__18_0")]
            ///  extern System.Boolean <SET_ITEM_INFO>B__18_0 (nint x);

            
            /// <summary>
            ///   System.Void AddExtraCloseEvent(System.Action closeEvent)
            /// </summary>
            /// <param name="closeEvent">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExtraCloseEvent")]
            ///  extern void ADD_EXTRA_CLOSE_EVENT (nint closeEvent);

            
            /// <summary>
            ///   System.Void AddObj2NeedRecycledEffect(SpecialEffectBase obj)
            /// </summary>
            /// <param name="obj">class SpecialEffectBase</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddObj2NeedRecycledEffect")]
            ///  extern void ADD_OBJ2_NEED_RECYCLED_EFFECT (nint obj);

            
            /// <summary>
            ///   System.Void AddObj2NeedRecycledGo(UnityEngine.GameObject obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddObj2NeedRecycledGo")]
            ///  extern void ADD_OBJ2_NEED_RECYCLED_GO (nint obj);

            
            /// <summary>
            ///   System.Void AddObj2NeedRecycledUIBase(Ghostmon.UI.UIBase obj)
            /// </summary>
            /// <param name="obj">class Ghostmon.UI.UIBase</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddObj2NeedRecycledUIBase")]
            ///  extern void ADD_OBJ2_NEED_RECYCLED_UI_BASE (nint obj);

            
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name="arg">class System.Object</param>
            /// <param name="message">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
            /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);

            
            /// <summary>
            ///   System.Void Close()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Close")]
            ///  extern void CLOSE ();

            
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name="lhs">class UnityEngine.Object</param>
            /// <param name="rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareBaseObjects")]
            /// static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs, nint rhs);

            
            /// <summary>
            ///   System.Boolean CompareTag(System.String tag)
            /// </summary>
            /// <param name="tag">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTag")]
            ///  extern System.Boolean COMPARE_TAG (nint tag);

            
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<GoodsItem> CreateUI(UnityEngine.Transform parent, System.Action<System.UInt64,System.Int32> ShowGoodsTip, System.Action HideGoodsTip, System.Action<GoodsItem> AddGoods)
            /// </summary>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="ShowGoodsTip">class System.Action<System.UInt64,System.Int32></param>
            /// <param name="HideGoodsTip">class System.Action</param>
            /// <param name="AddGoods">class System.Action<GoodsItem></param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<GoodsItem></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateUI")]
            /// static extern Cysharp.Threading.Tasks.UniTask<GoodsItem> CREATE_UI (nint parent, nint ShowGoodsTip, nint HideGoodsTip, nint AddGoods);

            
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name="target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DontDestroyOnLoad")]
            /// static extern void DONT_DESTROY_ON_LOAD (nint target);

            
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name="other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
            ///  extern System.Boolean EQUALS (nint other);

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectFromInstanceID")]
            /// static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);

            
            /// <summary>
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enabled")]
            ///  extern System.Boolean GET_ENABLED ();

            
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameObject")]
            ///  extern nint GET_GAME_OBJECT ();

            
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hideFlags")]
            ///  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();

            
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isActiveAndEnabled")]
            ///  extern System.Boolean GET_IS_ACTIVE_AND_ENABLED ();

            
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
            ///  extern nint GET_NAME ();

            
            /// <summary>
            ///   System.String get_tag()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
            ///  extern nint GET_TAG ();

            
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
            ///  extern nint GET_TRANSFORM ();

            
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_useGUILayout")]
            ///  extern System.Boolean GET_USE_GUI_LAYOUT ();

            
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
            ///  extern System.IntPtr GET_CACHED_PTR ();

            
            /// <summary>
            ///   Ghostmon.UI.UICanvas GetCanvas()
            /// </summary>
            /// <returns>class Ghostmon.UI.UICanvas</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCanvas")]
            ///  extern nint GET_CANVAS ();

            
            /// <summary>
            ///   System.String GetClassName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetClassName")]
            ///  extern nint GET_CLASS_NAME ();

            
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentFastPath")]
            ///  extern void GET_COMPONENT_FAST_PATH (nint type, System.IntPtr oneFurtherThanResultValue);

            
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
            /// </summary>
            /// <param name="searchType">abstract class System.Type</param>
            /// <param name="resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsForListInternal")]
            ///  extern void GET_COMPONENTS_FOR_LIST_INTERNAL (nint searchType, nint resultList);

            
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
            ///  extern System.Int32 GET_HASH_CODE ();

            
            /// <summary>
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
            ///  extern System.Int32 GET_INSTANCE_ID ();

            
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
            /// static extern nint GET_NAME (nint obj);

            
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOffsetOfInstanceIDInCPlusPlusObject")]
            /// static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();

            
            /// <summary>
            ///   UnityEngine.CanvasGroup GetOrAddCanvasGroup()
            /// </summary>
            /// <returns>class UnityEngine.CanvasGroup</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOrAddCanvasGroup")]
            ///  extern nint GET_OR_ADD_CANVAS_GROUP ();

            
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetScriptClassName")]
            ///  extern nint GET_SCRIPT_CLASS_NAME ();

            
            /// <summary>
            ///   System.Int32 GetSortingOrder()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSortingOrder")]
            ///  extern System.Int32 GET_SORTING_ORDER ();

            
            /// <summary>
            ///   System.Void Hide()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Hide")]
            ///  extern void HIDE ();

            
            /// <summary>
            ///   System.Void HideTip()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideTip")]
            ///  extern void HIDE_TIP ();

            
            /// <summary>
            ///   System.Void InitByLoopSouce()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitByLoopSouce")]
            ///  extern void INIT_BY_LOOP_SOUCE ();

            
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CancelInvokeAll")]
            /// static extern void INTERNAL_CANCEL_INVOKE_ALL (nint self);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingle")]
            /// static extern nint INTERNAL_CLONE_SINGLE (nint data);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingleWithParent")]
            /// static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data, nint parent, System.Boolean worldPositionStays);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="pos">struct UnityEngine.Vector3</param>
            /// <param name="rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="pos">struct UnityEngine.Vector3&</param>
            /// <param name="rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle_Injected")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="pos">struct UnityEngine.Vector3</param>
            /// <param name="rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="pos">struct UnityEngine.Vector3&</param>
            /// <param name="rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent_Injected")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data, nint parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);

            
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_IsInvokingAll")]
            /// static extern System.Boolean INTERNAL_IS_INVOKING_ALL (nint self);

            
            /// <summary>
            ///   System.Void Invoke(System.String methodName, System.Single time)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Invoke")]
            ///  extern void INVOKE (nint methodName, System.Single time);

            
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeDelayed")]
            /// static extern void INVOKE_DELAYED (nint self, nint methodName, System.Single time, System.Single repeatRate);

            
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeRepeating")]
            ///  extern void INVOKE_REPEATING (nint methodName, System.Single time, System.Single repeatRate);

            
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name="o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNativeObjectAlive")]
            /// static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);

            
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsObjectMonoBehaviour")]
            /// static extern System.Boolean IS_OBJECT_MONO_BEHAVIOUR (nint obj);

            
            /// <summary>
            ///   System.Void OnClickBtnGoods()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickBtnGoods")]
            ///  extern void ON_CLICK_BTN_GOODS ();

            
            /// <summary>
            ///   System.Void OnClose()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClose")]
            ///  extern void ON_CLOSE ();

            
            /// <summary>
            ///   System.Void OnHide()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnHide")]
            ///  extern void ON_HIDE ();

            
            /// <summary>
            ///   System.Void OnInit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit")]
            ///  extern void ON_INIT ();

            
            /// <summary>
            ///   System.Void OnShow()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnShow")]
            ///  extern void ON_SHOW ();

            
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name="x">class UnityEngine.Object</param>
            /// <param name="y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
            /// static extern System.Boolean OP_EQUALITY (nint x, nint y);

            
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name="exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
            /// static extern System.Boolean OP_IMPLICIT (nint exists);

            
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name="x">class UnityEngine.Object</param>
            /// <param name="y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
            /// static extern System.Boolean OP_INEQUALITY (nint x, nint y);

            
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name="message">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("print")]
            /// static extern void PRINT (nint message);

            
            /// <summary>
            ///   System.Void RefreshNum()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshNum")]
            ///  extern void REFRESH_NUM ();

            
            /// <summary>
            ///   System.Void RemoveNeedRecycledEffect(SpecialEffectBase obj)
            /// </summary>
            /// <param name="obj">class SpecialEffectBase</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNeedRecycledEffect")]
            ///  extern void REMOVE_NEED_RECYCLED_EFFECT (nint obj);

            
            /// <summary>
            ///   System.Void RemoveSelf()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSelf")]
            ///  extern void REMOVE_SELF ();

            
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_enabled")]
            ///  extern void SET_ENABLED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name="value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hideFlags")]
            ///  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);

            
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_name")]
            ///  extern void SET_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_useGUILayout")]
            ///  extern void SET_USE_GUI_LAYOUT (System.Boolean value);

            
            /// <summary>
            ///   System.Void SetCanvas()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCanvas")]
            ///  extern void SET_CANVAS ();

            
            /// <summary>
            ///   System.Void SetItemInfo()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItemInfo")]
            ///  extern void SET_ITEM_INFO ();

            
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="name">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
            /// static extern void SET_NAME (nint obj, nint name);

            
            /// <summary>
            ///   System.Void SetSortingOrder(System.Int32 newOrder)
            /// </summary>
            /// <param name="newOrder">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSortingOrder")]
            ///  extern void SET_SORTING_ORDER (System.Int32 newOrder);

            
            /// <summary>
            ///   System.Void Show()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Show")]
            ///  extern void SHOW ();

            
            /// <summary>
            ///   System.Void ShowTip()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowTip")]
            ///  extern void SHOW_TIP ();

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine_Auto")]
            ///  extern nint START_COROUTINE_AUTO (nint routine);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged")]
            ///  extern nint START_COROUTINE_MANAGED (nint methodName, nint value);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name="enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged2")]
            ///  extern nint START_COROUTINE_MANAGED2 (nint enumerator);

            
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopAllCoroutines")]
            ///  extern void STOP_ALL_COROUTINES ();

            
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineFromEnumeratorManaged")]
            ///  extern void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineManaged")]
            ///  extern void STOP_COROUTINE_MANAGED (nint routine);

            
            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// <param name="component">class T&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent")]
            ///  extern System.Boolean TRY_GET_COMPONENT (nint component);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoodsItem))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoodsItem))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoodsItem))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoodsItem))]
            ///  extern void .CTOR_03 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoodsItem))]
            ///  extern void .CTOR_04 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoodsItem))]
            ///  extern void .CTOR_05 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoodsItem))]
            ///  extern void .CTOR_06 ();

            
            /// <summary>
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_GoodsItem))]
            ///  extern void CANCEL_INVOKE_00 ();

            
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_GoodsItem))]
            ///  extern void CANCEL_INVOKE_01 (nint methodName);

            
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_GoodsItem))]
            /// static extern void CANCEL_INVOKE_02 (nint self, nint methodName);

            
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_GoodsItem))]
            /// static extern void DESTROY_00 (nint obj, System.Single t);

            
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_GoodsItem))]
            /// static extern void DESTROY_01 (nint obj);

            
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_GoodsItem))]
            /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);

            
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_GoodsItem))]
            /// static extern void DESTROY_IMMEDIATE_01 (nint obj);

            
            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_GoodsItem))]
            /// static extern nint FIND_OBJECT_OF_TYPE_00 ();

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_GoodsItem))]
            /// static extern nint FIND_OBJECT_OF_TYPE_01 (nint type, System.Boolean includeInactive);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GoodsItem))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GoodsItem))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);

            
            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GoodsItem))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();

            
            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GoodsItem))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENT_00 (nint type);

            
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENT_01 ();

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   T GetComponentInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (System.Boolean includeInactive);

            
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_02 ();

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t);

            
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENT_IN_PARENT_01 ();

            
            /// <summary>
            ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_GoodsItem))]
            ///  extern void GET_COMPONENTS_00 (nint type, nint results);

            
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_GoodsItem))]
            ///  extern void GET_COMPONENTS_01 (nint results);

            
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENTS_02 ();

            
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (System.Boolean includeInactive);

            
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GoodsItem))]
            ///  extern void GET_COMPONENTS_IN_CHILDREN_01 (System.Boolean includeInactive, nint result);

            
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_02 ();

            
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GoodsItem))]
            ///  extern void GET_COMPONENTS_IN_CHILDREN_03 (nint results);

            
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_00 (System.Boolean includeInactive);

            
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GoodsItem))]
            ///  extern void GET_COMPONENTS_IN_PARENT_01 (System.Boolean includeInactive, nint results);

            
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GoodsItem))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_02 ();

            
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_GoodsItem))]
            ///  extern void INIT_00 ();

            
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_GoodsItem))]
            ///  extern void INIT_01 ();

            
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_GoodsItem))]
            ///  extern void INIT_02 ();

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_02 (nint original);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_03 (nint original, nint parent, System.Boolean instantiateInWorldSpace);

            
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name="original">class T</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_04 (nint original);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_05 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_07 (nint original, nint parent);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GoodsItem))]
            /// static extern nint INSTANTIATE_08 (nint original, nint parent, System.Boolean worldPositionStays);

            
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_GoodsItem))]
            ///  extern System.Boolean IS_INVOKING_00 ();

            
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_GoodsItem))]
            ///  extern System.Boolean IS_INVOKING_01 (nint methodName);

            
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_GoodsItem))]
            /// static extern System.Boolean IS_INVOKING_02 (nint self, nint methodName);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_GoodsItem))]
            ///  extern void SEND_MESSAGE_00 (nint methodName, nint value);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_GoodsItem))]
            ///  extern void SEND_MESSAGE_01 (nint methodName, nint value, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_GoodsItem))]
            ///  extern nint START_COROUTINE_00 (nint methodName);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_GoodsItem))]
            ///  extern nint START_COROUTINE_01 (nint methodName, nint value);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_GoodsItem))]
            ///  extern nint START_COROUTINE_02 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_GoodsItem))]
            ///  extern void STOP_COROUTINE_00 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_GoodsItem))]
            ///  extern void STOP_COROUTINE_01 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_GoodsItem))]
            ///  extern void STOP_COROUTINE_02 (nint methodName);

            
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_GoodsItem))]
            ///  extern nint TO_STRING_00 ();

            
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_GoodsItem))]
            /// static extern nint TO_STRING_01 (nint obj);

            
            /// public static partial class Search_GoodsItem
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke()
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke(System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
                    /// </summary>
                    /// public static bool DESTROY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void Destroy(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
                    /// </summary>
                    /// public static bool DESTROY_IMMEDIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_IMMEDIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindObjectOfType()
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsOfType()
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponent(System.Type type)
                    /// </summary>
                    /// public static bool GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInParent(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type", "System.Collections.Generic.List<UnityEngine.Component>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponents()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Init()
                    /// </summary>
                    /// public static bool INIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Init()
                    /// </summary>
                    /// public static bool INIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Init()
                    /// </summary>
                    /// public static bool INIT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
                    /// </summary>
                    /// public static bool INSTANTIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
                    /// </summary>
                    /// public static bool INSTANTIATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
                    /// </summary>
                    /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original)
                    /// </summary>
                    /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
                    /// </summary>
                    /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
                    /// </summary>
                    /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsInvoking()
                    /// </summary>
                    /// public static bool IS_INVOKING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsInvoking(System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool START_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool START_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool START_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "UnityEngine.Coroutine");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String ToString()
                    /// </summary>
                    /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String ToString(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}