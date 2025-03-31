
using Maple.MonoGameAssistant.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."MainUI"]
    /// [Ghostmon.UI.UICanvas]=>[Ghostmon.UI.UIBase]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000223U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [77, 97, 105, 110, 85, 73])]

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

    // class 0x40 UnityEngine.Canvas canvas
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"canvas", "CANVAS")]

    // class 0x48 System.Action clickMask
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"clickMask", "CLICK_MASK")]

    // struct 0x50 System.Single maskAlpha
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"maskAlpha", "MASK_ALPHA")]

    // struct 0x54 System.Boolean haveMask
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"haveMask", "HAVE_MASK")]

    // struct 0x55 System.Boolean ignoreHide
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"ignoreHide", "IGNORE_HIDE")]

    // struct 0x56 System.Boolean hideUIBelow
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"hideUIBelow", "HIDE_UI_BELOW")]

    // struct 0x57 System.Boolean stopTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"stopTime", "STOP_TIME")]

    // class 0x58 System.Collections.Generic.Dictionary<UnityEngine.KeyCode,System.Action> KeyBoardDownEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"KeyBoardDownEvent", "KEY_BOARD_DOWN_EVENT")]

    // class 0x60 Ghostmon.UI.UIHoverButton btn_bag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_bag", "BTN_BAG")]

    // class 0x68 Ghostmon.UI.UIHoverButton btn_ill
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_ill", "BTN_ILL")]

    // class 0x70 Ghostmon.UI.UIHoverButton btn_map
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_map", "BTN_MAP")]

    // class 0x78 Ghostmon.UI.UIHoverButton btn_charm
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_charm", "BTN_CHARM")]

    // class 0x80 Ghostmon.UI.UIHoverButton btn_task
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_task", "BTN_TASK")]

    // class 0x88 Ghostmon.UI.UIHoverButton btn_scan
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_scan", "BTN_SCAN")]

    // class 0x90 UnityEngine.UI.Button btn_100percent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_100percent", "BTN_100PERCENT")]

    // class 0x98 UnityEngine.UI.Button btn_75percent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_75percent", "BTN_75PERCENT")]

    // class 0xA0 UnityEngine.UI.Button btn_50percent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_50percent", "BTN_50PERCENT")]

    // class 0xA8 UnityEngine.UI.Button btn_25percent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_25percent", "BTN_25PERCENT")]

    // class 0xB0 UnityEngine.UI.Button btn_0percent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_0percent", "BTN_0PERCENT")]

    // class 0xB8 UnityEngine.UI.Button btn_anima
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_anima", "BTN_ANIMA")]

    // class 0xC0 UnityEngine.UI.Button btn_miniMap_in
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_miniMap_in", "BTN_MINI_MAP_IN")]

    // class 0xC8 UnityEngine.UI.Button btn_miniMap_out
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_miniMap_out", "BTN_MINI_MAP_OUT")]

    // class 0xD0 UnityEngine.UI.Button btn_alternative
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_alternative", "BTN_ALTERNATIVE")]

    // class 0xD8 UnityEngine.UI.Button btn_miniMap
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_miniMap", "BTN_MINI_MAP")]

    // class 0xE0 UnityEngine.UI.Button btn_1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_1", "BTN_1")]

    // class 0xE8 UnityEngine.UI.Button btn_2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_2", "BTN_2")]

    // class 0xF0 UnityEngine.UI.Button btn_3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btn_3", "BTN_3")]

    // class 0xF8 UnityEngine.RectTransform bar_animaback
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"bar_animaback", "BAR_ANIMABACK")]

    // class 0x100 UnityEngine.RectTransform actionTip_content
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"actionTip_content", "ACTION_TIP_CONTENT")]

    // class 0x108 UnityEngine.RectTransform monster_content
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"monster_content", "MONSTER_CONTENT")]

    // class 0x110 UnityEngine.RectTransform bar_anima
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"bar_anima", "BAR_ANIMA")]

    // class 0x118 UnityEngine.RectTransform function_node
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"function_node", "FUNCTION_NODE")]

    // class 0x120 UnityEngine.RectTransform taskDirBone
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"taskDirBone", "TASK_DIR_BONE")]

    // class 0x128 UnityEngine.RectTransform StaticHud
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"StaticHud", "STATIC_HUD")]

    // class 0x130 UnityEngine.RectTransform taskNode
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"taskNode", "TASK_NODE")]

    // class 0x138 UnityEngine.RectTransform weather_node
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"weather_node", "WEATHER_NODE")]

    // class 0x140 UnityEngine.RectTransform reiki_node
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"reiki_node", "REIKI_NODE")]

    // class 0x148 UnityEngine.RectTransform cuisineContent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"cuisineContent", "CUISINE_CONTENT")]

    // class 0x150 UnityEngine.RectTransform rankNode
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rankNode", "RANK_NODE")]

    // class 0x158 UnityEngine.RectTransform taskDirNode
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"taskDirNode", "TASK_DIR_NODE")]

    // class 0x160 UnityEngine.RectTransform rect_taskArrow
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rect_taskArrow", "RECT_TASK_ARROW")]

    // class 0x168 UnityEngine.RectTransform icon_scanTip
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_scanTip", "ICON_SCAN_TIP")]

    // class 0x170 UnityEngine.RectTransform miniMap_mask
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"miniMap_mask", "MINI_MAP_MASK")]

    // class 0x178 UnityEngine.RectTransform charmNode_1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charmNode_1", "CHARM_NODE_1")]

    // class 0x180 UnityEngine.RectTransform charmNode_2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charmNode_2", "CHARM_NODE_2")]

    // class 0x188 UnityEngine.RectTransform charmNode_3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charmNode_3", "CHARM_NODE_3")]

    // class 0x190 UnityEngine.RectTransform btnQTip
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btnQTip", "BTN_Q_TIP")]

    // class 0x198 UnityEngine.RectTransform btnETip
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"btnETip", "BTN_E_TIP")]

    // class 0x1A0 UnityEngine.RectTransform switchCharmBagNode
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"switchCharmBagNode", "SWITCH_CHARM_BAG_NODE")]

    // class 0x1A8 UnityEngine.RectTransform miniMap_node
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"miniMap_node", "MINI_MAP_NODE")]

    // class 0x1B0 UnityEngine.RectTransform releaseCharmNode
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"releaseCharmNode", "RELEASE_CHARM_NODE")]

    // class 0x1B8 UnityEngine.RectTransform taskEffect
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"taskEffect", "TASK_EFFECT")]

    // class 0x1C0 UnityEngine.UI.Image bar_anima1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"bar_anima1", "BAR_ANIMA1")]

    // class 0x1C8 UnityEngine.UI.Image slider_endu_back
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"slider_endu_back", "SLIDER_ENDU_BACK")]

    // class 0x1D0 UnityEngine.UI.Image slider_endu_val
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"slider_endu_val", "SLIDER_ENDU_VAL")]

    // class 0x1D8 UnityEngine.UI.Image icon_percent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_percent", "ICON_PERCENT")]

    // class 0x1E0 UnityEngine.UI.Image icon_progress
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_progress", "ICON_PROGRESS")]

    // class 0x1E8 UnityEngine.UI.Image task_point
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"task_point", "TASK_POINT")]

    // class 0x1F0 UnityEngine.UI.Image icon_scan
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_scan", "ICON_SCAN")]

    // class 0x1F8 UnityEngine.UI.Image icon_weather
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_weather", "ICON_WEATHER")]

    // class 0x200 UnityEngine.UI.Image icon_1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_1", "ICON_1")]

    // class 0x208 UnityEngine.UI.Image icon_2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_2", "ICON_2")]

    // class 0x210 UnityEngine.UI.Image icon_3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_3", "ICON_3")]

    // class 0x218 UnityEngine.UI.Image icon_charm1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_charm1", "ICON_CHARM1")]

    // class 0x220 UnityEngine.UI.Image icon_charm2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_charm2", "ICON_CHARM2")]

    // class 0x228 UnityEngine.UI.Image icon_charm3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_charm3", "ICON_CHARM3")]

    // class 0x230 UnityEngine.UI.Image icon_charmSlot1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_charmSlot1", "ICON_CHARM_SLOT1")]

    // class 0x238 UnityEngine.UI.Image icon_charmSlot2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_charmSlot2", "ICON_CHARM_SLOT2")]

    // class 0x240 UnityEngine.UI.Image icon_charmSlot3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon_charmSlot3", "ICON_CHARM_SLOT3")]

    // class 0x248 TMPro.TextMeshProUGUI text_time
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_time", "TEXT_TIME")]

    // class 0x250 TMPro.TextMeshProUGUI text_AnimaProcess
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_AnimaProcess", "TEXT_ANIMA_PROCESS")]

    // class 0x258 TMPro.TextMeshProUGUI text_percent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_percent", "TEXT_PERCENT")]

    // class 0x260 TMPro.TextMeshProUGUI text_coinNum
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_coinNum", "TEXT_COIN_NUM")]

    // class 0x268 TMPro.TextMeshProUGUI text_spiritStoneNum
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_spiritStoneNum", "TEXT_SPIRIT_STONE_NUM")]

    // class 0x270 TMPro.TextMeshProUGUI text_taskName
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_taskName", "TEXT_TASK_NAME")]

    // class 0x278 TMPro.TextMeshProUGUI text_taskDesc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_taskDesc", "TEXT_TASK_DESC")]

    // class 0x280 TMPro.TextMeshProUGUI text_scanTime
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_scanTime", "TEXT_SCAN_TIME")]

    // class 0x288 TMPro.TextMeshProUGUI text_rankValue
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_rankValue", "TEXT_RANK_VALUE")]

    // class 0x290 TMPro.TextMeshProUGUI text_rank
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_rank", "TEXT_RANK")]

    // class 0x298 TMPro.TextMeshProUGUI text_taskDis
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_taskDis", "TEXT_TASK_DIS")]

    // class 0x2A0 TMPro.TextMeshProUGUI text_num1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_num1", "TEXT_NUM1")]

    // class 0x2A8 TMPro.TextMeshProUGUI text_num2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_num2", "TEXT_NUM2")]

    // class 0x2B0 TMPro.TextMeshProUGUI text_num3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"text_num3", "TEXT_NUM3")]

    // class 0x2B8 UnityEngine.CanvasGroup infoGroup
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"infoGroup", "INFO_GROUP")]

    // class 0x2C0 UnityEngine.CanvasGroup endu_slider
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"endu_slider", "ENDU_SLIDER")]

    // class 0x2C8 System.Collections.Generic.List<UnityEngine.RectTransform> charmNodes
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charmNodes", "CHARM_NODES")]

    // class 0x2D0 System.Collections.Generic.List<MainMonsterItem> mainMonsterItems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"mainMonsterItems", "MAIN_MONSTER_ITEMS")]

    // class 0x2D8 System.Collections.Generic.List<OperationTip> tipsList
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tipsList", "TIPS_LIST")]

    // class 0x2E0 System.Collections.Generic.List<System.UInt64> charms
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charms", "CHARMS")]

    // class 0x2E8 System.Collections.Generic.List<UnityEngine.Vector2> charmNodePos
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charmNodePos", "CHARM_NODE_POS")]

    // class 0x2F0 FunctionTipsNode funBtnTip
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"funBtnTip", "FUN_BTN_TIP")]

    // struct 0x2F8 UnityEngine.Vector2 taskArrowBone
    // [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector2),"taskArrowBone", "TASK_ARROW_BONE")]

    // struct 0x300 System.Boolean isForbidFunc
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isForbidFunc", "IS_FORBID_FUNC")]

    // struct 0x301 System.Boolean inPressTip
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inPressTip", "IN_PRESS_TIP")]

    // struct 0x308 System.Int64 pressTipID
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int64),"pressTipID", "PRESS_TIP_ID")]

    // class 0x310 InputBtnDownAndUp inputBtn
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"inputBtn", "INPUT_BTN")]

    // class 0x318 DG.Tweening.Sequence seq1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq1", "SEQ1")]

    // class 0x320 DG.Tweening.Sequence seq2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq2", "SEQ2")]

    // class 0x328 DG.Tweening.Sequence seq3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq3", "SEQ3")]

    // class 0x330 DG.Tweening.Sequence seq4
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq4", "SEQ4")]

    // class 0x338 DG.Tweening.Sequence seq5
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq5", "SEQ5")]

    // class 0x340 DG.Tweening.Sequence seq6
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq6", "SEQ6")]

    // class 0x348 DG.Tweening.Sequence seq7
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq7", "SEQ7")]

    // class 0x350 DG.Tweening.Sequence seq8
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq8", "SEQ8")]

    // class 0x358 DG.Tweening.Sequence seq9
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq9", "SEQ9")]

    // abstract class 0x360 DG.Tweening.Tween tween1
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tween1", "TWEEN1")]

    // abstract class 0x368 DG.Tweening.Tween tween2
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tween2", "TWEEN2")]

    // abstract class 0x370 DG.Tweening.Tween tween3
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tween3", "TWEEN3")]

    // abstract class 0x378 DG.Tweening.Tween tween4
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tween4", "TWEEN4")]

    // class 0x380 System.Action HideGuidance
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"HideGuidance", "HIDE_GUIDANCE")]

    // class 0x388 System.Action ShowGuidance
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ShowGuidance", "SHOW_GUIDANCE")]

    // struct 0x390 System.Int32 midCharm
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"midCharm", "MID_CHARM")]

    // struct 0x394 System.Int32 curCharmBag
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"curCharmBag", "CUR_CHARM_BAG")]

    // struct 0x398 System.Boolean inSwitchAni
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inSwitchAni", "IN_SWITCH_ANI")]

    // struct 0x39C System.Int32 currentCharm
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentCharm", "CURRENT_CHARM")]

    // struct 0x3A0 System.Single times
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"times", "TIMES")]

    // struct 0x3A4 System.Boolean isShowReiki
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isShowReiki", "IS_SHOW_REIKI")]

    // struct 0x3A5 System.Boolean isRecovered
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isRecovered", "IS_RECOVERED")]

    // struct 0x3A6 System.Boolean showEndu
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"showEndu", "SHOW_ENDU")]

    // struct 0x3A8 System.Single showEnduTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"showEnduTime", "SHOW_ENDU_TIME")]

    // class 0x3B0 CuisinePoint point
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"point", "POINT")]

    // class 0x3B8 SpecialEffectBase eff_flare
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"eff_flare", "EFF_FLARE")]

    // class 0x3C0 AreaTip areaTip
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"areaTip", "AREA_TIP")]

    // struct 0x3C8 System.Boolean isLoading
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isLoading", "IS_LOADING")]

    // struct 0x3CC System.Single radian
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"radian", "RADIAN")]

    // struct 0x3D0 System.Single curRadian
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"curRadian", "CUR_RADIAN")]

    // struct 0x3D4 System.Single radius
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"radius", "RADIUS")]

    // struct 0x3D8 System.Int32 curInteractIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"curInteractIndex", "CUR_INTERACT_INDEX")]

    // struct 0x3DC System.Boolean isCasting
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isCasting", "IS_CASTING")]

    // struct 0x3E0 System.Single scanTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"scanTime", "SCAN_TIME")]

    // class 0x3E8 DG.Tweening.Sequence seq10
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"seq10", "SEQ10")]
    public partial class MainUI
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "MainUI";
        //public static byte[] Static_ClassName { get; } = [77, 97, 105, 110, 85, 73];

        //public const uint Const_TypeToken = 0x02000223U;




        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";

        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_MainUI(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_MainUI(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_MainUI obj) => obj._ptr;
            public static implicit operator bool(Ptr_MainUI obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."MainUI"]
    /// </summary>
    public partial class MainUI
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void <CheckAutoRecover>b__191_0(System.Single x)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CheckAutoRecover>b__191_0")]
        ///  extern void <CHECK_AUTO_RECOVER>B__191_0 (System.Single x);


        /// <summary>
        ///   System.Void <CheckAutoRecover>b__191_1()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CheckAutoRecover>b__191_1")]
        ///  extern void <CHECK_AUTO_RECOVER>B__191_1 ();


        /// <summary>
        ///   System.Void <CheckAutoRecover>b__191_2(System.Single x)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CheckAutoRecover>b__191_2")]
        ///  extern void <CHECK_AUTO_RECOVER>B__191_2 (System.Single x);


        /// <summary>
        ///   System.Void <Init>b__104_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_0")]
        ///  extern void <INIT>B__104_0 ();


        /// <summary>
        ///   System.Void <Init>b__104_1()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_1")]
        ///  extern void <INIT>B__104_1 ();


        /// <summary>
        ///   System.Void <Init>b__104_10()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_10")]
        ///  extern void <INIT>B__104_10 ();


        /// <summary>
        ///   System.Void <Init>b__104_11()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_11")]
        ///  extern void <INIT>B__104_11 ();


        /// <summary>
        ///   System.Void <Init>b__104_12()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_12")]
        ///  extern void <INIT>B__104_12 ();


        /// <summary>
        ///   System.Void <Init>b__104_13()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_13")]
        ///  extern void <INIT>B__104_13 ();


        /// <summary>
        ///   System.Void <Init>b__104_2()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_2")]
        ///  extern void <INIT>B__104_2 ();


        /// <summary>
        ///   System.Void <Init>b__104_3()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_3")]
        ///  extern void <INIT>B__104_3 ();


        /// <summary>
        ///   System.Void <Init>b__104_4()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_4")]
        ///  extern void <INIT>B__104_4 ();


        /// <summary>
        ///   System.Void <Init>b__104_5()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_5")]
        ///  extern void <INIT>B__104_5 ();


        /// <summary>
        ///   System.Void <Init>b__104_6()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_6")]
        ///  extern void <INIT>B__104_6 ();


        /// <summary>
        ///   System.Void <Init>b__104_7()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_7")]
        ///  extern void <INIT>B__104_7 ();


        /// <summary>
        ///   System.Void <Init>b__104_8()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_8")]
        ///  extern void <INIT>B__104_8 ();


        /// <summary>
        ///   System.Void <Init>b__104_9()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__104_9")]
        ///  extern void <INIT>B__104_9 ();


        /// <summary>
        ///   System.Void <OnClickBtnMap>b__175_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<OnClickBtnMap>b__175_0")]
        ///  extern void <ON_CLICK_BTN_MAP>B__175_0 ();


        /// <summary>
        ///   System.Void <PlayIncreasingAni>b__142_0(System.Int32 x)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<PlayIncreasingAni>b__142_0")]
        ///  extern void <PLAY_INCREASING_ANI>B__142_0 (System.Int32 x);


        /// <summary>
        ///   System.Void <RecoverRikiAndHp>b__188_0(System.Single x)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RecoverRikiAndHp>b__188_0")]
        ///  extern void <RECOVER_RIKI_AND_HP>B__188_0 (System.Single x);


        /// <summary>
        ///   System.Void <RegisterKeyEvent>b__168_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RegisterKeyEvent>b__168_0")]
        ///  extern void <REGISTER_KEY_EVENT>B__168_0 ();


        /// <summary>
        ///   System.Void <RegisterKeyEvent>b__168_1()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RegisterKeyEvent>b__168_1")]
        ///  extern void <REGISTER_KEY_EVENT>B__168_1 ();


        /// <summary>
        ///   System.Void <RegisterKeyEvent>b__168_2()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RegisterKeyEvent>b__168_2")]
        ///  extern void <REGISTER_KEY_EVENT>B__168_2 ();


        /// <summary>
        ///   System.Void <RegisterKeyEvent>b__168_3()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RegisterKeyEvent>b__168_3")]
        ///  extern void <REGISTER_KEY_EVENT>B__168_3 ();


        /// <summary>
        ///   System.Void <RegisterKeyEvent>b__168_4()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RegisterKeyEvent>b__168_4")]
        ///  extern void <REGISTER_KEY_EVENT>B__168_4 ();


        /// <summary>
        ///   System.Void <RegisterKeyEvent>b__168_5()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RegisterKeyEvent>b__168_5")]
        ///  extern void <REGISTER_KEY_EVENT>B__168_5 ();


        /// <summary>
        ///   System.Void <ShowRecoverRiki>b__198_0(System.Single x)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ShowRecoverRiki>b__198_0")]
        ///  extern void <SHOW_RECOVER_RIKI>B__198_0 (System.Single x);


        /// <summary>
        ///   System.Void <SwitchNextCharm>b__121_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<SwitchNextCharm>b__121_0")]
        ///  extern void <SWITCH_NEXT_CHARM>B__121_0 ();


        /// <summary>
        ///   System.Void <SwitchPreCharm>b__118_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<SwitchPreCharm>b__118_0")]
        ///  extern void <SWITCH_PRE_CHARM>B__118_0 ();


        /// <summary>
        ///   System.Boolean <Update>b__126_0(OperationTip x)
        /// </summary>
        /// <param name="x">class OperationTip</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Update>b__126_0")]
        ///  extern System.Boolean <UPDATE>B__126_0 (nint x);


        /// <summary>
        ///   System.Boolean <Update>b__126_1(OperationTip x)
        /// </summary>
        /// <param name="x">class OperationTip</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Update>b__126_1")]
        ///  extern System.Boolean <UPDATE>B__126_1 (nint x);


        /// <summary>
        ///   System.Void <UpRankTip>b__150_0(System.Int32 x)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<UpRankTip>b__150_0")]
        ///  extern void <UP_RANK_TIP>B__150_0 (System.Int32 x);


        /// <summary>
        ///   System.Void <UpRankTip>b__150_1(System.Single x)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<UpRankTip>b__150_1")]
        ///  extern void <UP_RANK_TIP>B__150_1 (System.Single x);


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
        ///   System.Void AddUIKeyBoardListener(UnityEngine.KeyCode keyCode, System.Action action)
        /// </summary>
        /// <param name="keyCode">enum UnityEngine.KeyCode</param>
        /// <param name="action">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIKeyBoardListener")]
        ///  extern void ADD_UI_KEY_BOARD_LISTENER (UnityEngine.KeyCode keyCode, nint action);


        /// <summary>
        ///   System.Void AlternativeEvents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AlternativeEvents")]
        ///  extern void ALTERNATIVE_EVENTS ();


        /// <summary>
        ///   System.Void AlternativeUpEvents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AlternativeUpEvents")]
        ///  extern void ALTERNATIVE_UP_EVENTS ();


        /// <summary>
        ///   System.Void CheckAutoRecover()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckAutoRecover")]
        ///  extern void CHECK_AUTO_RECOVER ();


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
        /// static  Cysharp.Threading.Tasks.UniTask<MainUI> CreateUI()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<MainUI></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateUI")]
        /// static extern Cysharp.Threading.Tasks.UniTask<MainUI> CREATE_UI ();


        /// <summary>
        ///   System.Void DealMask()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DealMask")]
        ///  extern void DEAL_MASK ();


        /// <summary>
        /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
        /// </summary>
        /// <param name="target">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DontDestroyOnLoad")]
        /// static extern void DONT_DESTROY_ON_LOAD (nint target);


        /// <summary>
        ///   System.Void EntryBuildingFunc()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("EntryBuildingFunc")]
        ///  extern void ENTRY_BUILDING_FUNC ();


        /// <summary>
        ///   System.Void EntryCasting(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("EntryCasting")]
        ///  extern void ENTRY_CASTING (System.Boolean value);


        /// <summary>
        ///   System.Boolean Equals(System.Object other)
        /// </summary>
        /// <param name="other">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
        ///  extern System.Boolean EQUALS (nint other);


        /// <summary>
        ///   System.Void ExitMapUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExitMapUI")]
        ///  extern void EXIT_MAP_UI ();


        /// <summary>
        ///   System.Void ExitScan()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExitScan")]
        ///  extern void EXIT_SCAN ();


        /// <summary>
        /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectFromInstanceID")]
        /// static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// <summary>
        ///   System.Void ForbidFuncBtn(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForbidFuncBtn")]
        ///  extern void FORBID_FUNC_BTN (System.Boolean value);


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
        ///   UnityEngine.Vector3 GetArrowPos()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetArrowPos")]
        ///  extern UnityEngine.Vector3 GET_ARROW_POS ();


        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
        ///  extern System.IntPtr GET_CACHED_PTR ();


        /// <summary>
        ///   UnityEngine.Canvas GetCanvas()
        /// </summary>
        /// <returns>class UnityEngine.Canvas</returns>
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
        ///   System.Void HideAllFunc()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideAllFunc")]
        ///  extern void HIDE_ALL_FUNC ();


        /// <summary>
        ///   System.Void HideAllTips()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideAllTips")]
        ///  extern void HIDE_ALL_TIPS ();


        /// <summary>
        ///   System.Void HideEnduSlider()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideEnduSlider")]
        ///  extern void HIDE_ENDU_SLIDER ();


        /// <summary>
        ///   System.Void HideFuncTips()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideFuncTips")]
        ///  extern void HIDE_FUNC_TIPS ();


        /// <summary>
        ///   System.Void HideMainUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideMainUI")]
        ///  extern void HIDE_MAIN_UI ();


        /// <summary>
        ///   System.Void HideMonsterRecover()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideMonsterRecover")]
        ///  extern void HIDE_MONSTER_RECOVER ();


        /// <summary>
        ///   System.Void HideReiki()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideReiki")]
        ///  extern void HIDE_REIKI ();


        /// <summary>
        ///   System.Void HideTipsInfo(System.Int64 ID)
        /// </summary>
        /// <param name="ID">struct System.Int64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideTipsInfo")]
        ///  extern void HIDE_TIPS_INFO (System.Int64 ID);


        /// <summary>
        ///   System.Void HideUIBelow(System.Boolean checkIgnoreHide)
        /// </summary>
        /// <param name="checkIgnoreHide">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideUIBelow")]
        ///  extern void HIDE_UI_BELOW (System.Boolean checkIgnoreHide);


        /// <summary>
        ///   System.Void InitCanvasRect()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitCanvasRect")]
        ///  extern void INIT_CANVAS_RECT ();


        /// <summary>
        ///   System.Void InitCharmNodePos()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitCharmNodePos")]
        ///  extern void INIT_CHARM_NODE_POS ();


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
        ///   System.Void LoadSwitchTaskEffect()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadSwitchTaskEffect")]
        ///  extern void LOAD_SWITCH_TASK_EFFECT ();


        /// <summary>
        ///   System.Void OnClickAlternative()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickAlternative")]
        ///  extern void ON_CLICK_ALTERNATIVE ();


        /// <summary>
        ///   System.Void OnClickBtnAnima()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickBtnAnima")]
        ///  extern void ON_CLICK_BTN_ANIMA ();


        /// <summary>
        ///   System.Void OnClickBtnBag()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickBtnBag")]
        ///  extern void ON_CLICK_BTN_BAG ();


        /// <summary>
        ///   System.Void OnClickBtnMap()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickBtnMap")]
        ///  extern void ON_CLICK_BTN_MAP ();


        /// <summary>
        ///   System.Void OnClickBtnTask()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickBtnTask")]
        ///  extern void ON_CLICK_BTN_TASK ();


        /// <summary>
        ///   System.Void OnClickEsc()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickEsc")]
        ///  extern void ON_CLICK_ESC ();


        /// <summary>
        ///   System.Void OnClickIllBtn()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickIllBtn")]
        ///  extern void ON_CLICK_ILL_BTN ();


        /// <summary>
        ///   System.Void OnClickMask()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickMask")]
        ///  extern void ON_CLICK_MASK ();


        /// <summary>
        ///   System.Void OnClickTakBtnCharm()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickTakBtnCharm")]
        ///  extern void ON_CLICK_TAK_BTN_CHARM ();


        /// <summary>
        ///   System.Void OnClickTakBtnScan()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClickTakBtnScan")]
        ///  extern void ON_CLICK_TAK_BTN_SCAN ();


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
        ///   System.Void PlayAreaTip(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayAreaTip")]
        ///  extern void PLAY_AREA_TIP (System.Int32 id);


        /// <summary>
        ///   System.Void PlayIncreasingAni(System.Int32 num)
        /// </summary>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayIncreasingAni")]
        ///  extern void PLAY_INCREASING_ANI (System.Int32 num);


        /// <summary>
        ///   System.Void PreLoadTips()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PreLoadTips")]
        ///  extern void PRE_LOAD_TIPS ();


        /// <summary>
        /// static  System.Void print(System.Object message)
        /// </summary>
        /// <param name="message">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("print")]
        /// static extern void PRINT (nint message);


        /// <summary>
        ///   System.Void RecoverRikiAndHp()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecoverRikiAndHp")]
        ///  extern void RECOVER_RIKI_AND_HP ();


        /// <summary>
        ///   System.Void RefreshBasicNode()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshBasicNode")]
        ///  extern void REFRESH_BASIC_NODE ();


        /// <summary>
        ///   System.Void RefreshChamsList()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshChamsList")]
        ///  extern void REFRESH_CHAMS_LIST ();


        /// <summary>
        ///   System.Void RefreshCharmBag(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCharmBag")]
        ///  extern void REFRESH_CHARM_BAG (System.Int32 index);


        /// <summary>
        ///   System.Void RefreshCharmBagBtn(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCharmBagBtn")]
        ///  extern void REFRESH_CHARM_BAG_BTN (System.Int32 index);


        /// <summary>
        ///   System.Void RefreshCharmNodePos()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCharmNodePos")]
        ///  extern void REFRESH_CHARM_NODE_POS ();


        /// <summary>
        ///   System.Void RefreshCharmNum()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCharmNum")]
        ///  extern void REFRESH_CHARM_NUM ();


        /// <summary>
        ///   System.Void RefreshCurrentCharms()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCurrentCharms")]
        ///  extern void REFRESH_CURRENT_CHARMS ();


        /// <summary>
        ///   System.Void RefreshEnduValue(System.Single val)
        /// </summary>
        /// <param name="val">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshEnduValue")]
        ///  extern void REFRESH_ENDU_VALUE (System.Single val);


        /// <summary>
        ///   System.Void RefreshExpAmount(System.Int32[] value)
        /// </summary>
        /// <param name="value">class System.Int32[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshExpAmount")]
        ///  extern void REFRESH_EXP_AMOUNT (nint value);


        /// <summary>
        ///   System.Void RefreshFunction()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshFunction")]
        ///  extern void REFRESH_FUNCTION ();


        /// <summary>
        ///   System.Void RefreshHpFillAmount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshHpFillAmount")]
        extern void REFRESH_HP_FILL_AMOUNT();


        /// <summary>
        ///   System.Void RefreshMonster(System.Boolean isNpc)
        /// </summary>
        /// <param name="isNpc">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshMonster")]
        ///  extern void REFRESH_MONSTER (System.Boolean isNpc);


        /// <summary>
        ///   System.Void RefreshMonsterTeam()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshMonsterTeam")]
        ///  extern void REFRESH_MONSTER_TEAM ();


        /// <summary>
        ///   System.Void RefreshReiki()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshReiki")]
        ///  extern void REFRESH_REIKI ();


        /// <summary>
        ///   System.Void RefreshTaskNode()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshTaskNode")]
        ///  extern void REFRESH_TASK_NODE ();


        /// <summary>
        ///   System.Void RefreshTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshTime")]
        ///  extern void REFRESH_TIME ();


        /// <summary>
        ///   System.Void RefreshTipPos()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshTipPos")]
        ///  extern void REFRESH_TIP_POS ();


        /// <summary>
        ///   System.Void RefreshWeather(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshWeather")]
        ///  extern void REFRESH_WEATHER (System.Int32 index);


        /// <summary>
        ///   System.Void RegisterAlpahaKeyUpEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegisterAlpahaKeyUpEvent")]
        ///  extern void REGISTER_ALPAHA_KEY_UP_EVENT ();


        /// <summary>
        ///   System.Void RegisterKeyEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegisterKeyEvent")]
        ///  extern void REGISTER_KEY_EVENT ();


        /// <summary>
        ///   System.Void RegistNumEvent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegistNumEvent")]
        ///  extern void REGIST_NUM_EVENT (System.Int32 index);


        /// <summary>
        ///   System.Void RemoveAlpahaKeyUpEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAlpahaKeyUpEvent")]
        ///  extern void REMOVE_ALPAHA_KEY_UP_EVENT ();


        /// <summary>
        ///   System.Void RemoveNeedRecycledEffect(SpecialEffectBase obj)
        /// </summary>
        /// <param name="obj">class SpecialEffectBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNeedRecycledEffect")]
        ///  extern void REMOVE_NEED_RECYCLED_EFFECT (nint obj);


        /// <summary>
        ///   System.Void RemoveTopCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTopCanvas")]
        ///  extern void REMOVE_TOP_CANVAS ();


        /// <summary>
        ///   System.Void RemoveUIKeyBoardListener(UnityEngine.KeyCode keyCode, System.Action action)
        /// </summary>
        /// <param name="keyCode">enum UnityEngine.KeyCode</param>
        /// <param name="action">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIKeyBoardListener")]
        ///  extern void REMOVE_UI_KEY_BOARD_LISTENER (UnityEngine.KeyCode keyCode, nint action);


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
        ///   System.Void SetBtnPercentShow(UnityEngine.UI.Button btn, System.Int32 value)
        /// </summary>
        /// <param name="btn">class UnityEngine.UI.Button</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBtnPercentShow")]
        ///  extern void SET_BTN_PERCENT_SHOW (nint btn, System.Int32 value);


        /// <summary>
        ///   System.Void SetCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCanvas")]
        ///  extern void SET_CANVAS ();


        /// <summary>
        ///   System.Void SetCharmNodeInfo(System.Int32 index, System.UInt64 id)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCharmNodeInfo")]
        ///  extern void SET_CHARM_NODE_INFO (System.Int32 index, System.UInt64 id);


        /// <summary>
        ///   System.Void SetEnduRed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEnduRed")]
        ///  extern void SET_ENDU_RED ();


        /// <summary>
        ///   System.Void SetEnduWhite()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEnduWhite")]
        ///  extern void SET_ENDU_WHITE ();


        /// <summary>
        ///   System.Void SetIconPercent(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIconPercent")]
        ///  extern void SET_ICON_PERCENT (System.Int32 value);


        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
        /// static extern void SET_NAME (nint obj, nint name);


        /// <summary>
        ///   System.Void SetTimeStop()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTimeStop")]
        ///  extern void SET_TIME_STOP ();


        /// <summary>
        ///   System.Void Show()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Show")]
        ///  extern void SHOW ();


        /// <summary>
        ///   System.Void ShowAllFunc()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowAllFunc")]
        ///  extern void SHOW_ALL_FUNC ();


        /// <summary>
        ///   System.Void ShowAteCuisine()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowAteCuisine")]
        ///  extern void SHOW_ATE_CUISINE ();


        /// <summary>
        ///   System.Void ShowEnduSlider()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowEnduSlider")]
        ///  extern void SHOW_ENDU_SLIDER ();


        /// <summary>
        ///   System.Void ShowFuncTips(UnityEngine.UI.Button btn, BtnType type)
        /// </summary>
        /// <param name="btn">class UnityEngine.UI.Button</param>
        /// <param name="type">enum BtnType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowFuncTips")]
        ///  extern void SHOW_FUNC_TIPS (nint btn, BtnType type);


        /// <summary>
        ///   System.Void ShowGetReikiAni(UnityEngine.Vector3 wpos)
        /// </summary>
        /// <param name="wpos">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowGetReikiAni")]
        ///  extern void SHOW_GET_REIKI_ANI (UnityEngine.Vector3 wpos);


        /// <summary>
        ///   System.Void ShowMainUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowMainUI")]
        ///  extern void SHOW_MAIN_UI ();


        /// <summary>
        ///   System.Void ShowMapUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowMapUI")]
        ///  extern void SHOW_MAP_UI ();


        /// <summary>
        ///   System.Void ShowMonsterRecover()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowMonsterRecover")]
        ///  extern void SHOW_MONSTER_RECOVER ();


        /// <summary>
        ///   System.Void ShowRecoverRiki()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowRecoverRiki")]
        extern void SHOW_RECOVER_RIKI();


        /// <summary>
        ///   System.Void ShowReiki()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowReiki")]
        ///  extern void SHOW_REIKI ();


        /// <summary>
        ///   System.Void ShowSacnTip()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowSacnTip")]
        ///  extern void SHOW_SACN_TIP ();


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
        ///   System.Void SwitchNextCharm()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SwitchNextCharm")]
        ///  extern void SWITCH_NEXT_CHARM ();


        /// <summary>
        ///   System.Void SwitchPreCharm()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SwitchPreCharm")]
        ///  extern void SWITCH_PRE_CHARM ();


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
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainUI))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainUI))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainUI))]
        ///  extern void .CTOR_02 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainUI))]
        ///  extern void .CTOR_03 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainUI))]
        ///  extern void .CTOR_04 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainUI))]
        ///  extern void .CTOR_05 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainUI))]
        ///  extern void .CTOR_06 ();


        /// <summary>
        ///   System.Void CancelInvoke()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_MainUI))]
        ///  extern void CANCEL_INVOKE_00 ();


        /// <summary>
        ///   System.Void CancelInvoke(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_MainUI))]
        ///  extern void CANCEL_INVOKE_01 (nint methodName);


        /// <summary>
        /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_MainUI))]
        /// static extern void CANCEL_INVOKE_02 (nint self, nint methodName);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_MainUI))]
        /// static extern void DESTROY_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_MainUI))]
        /// static extern void DESTROY_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_MainUI))]
        /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_MainUI))]
        /// static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_MainUI))]
        /// static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_MainUI))]
        /// static extern nint FIND_OBJECT_OF_TYPE_01 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_MainUI))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_MainUI))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_MainUI))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_MainUI))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENT_00 (nint type);


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENT_01 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_02 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t);


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENT_IN_PARENT_01 ();


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_MainUI))]
        ///  extern void GET_COMPONENTS_00 (nint type, nint results);


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_MainUI))]
        ///  extern void GET_COMPONENTS_01 (nint results);


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENTS_02 ();


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="result">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_MainUI))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_01 (System.Boolean includeInactive, nint result);


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_02 ();


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_MainUI))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_03 (nint results);


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_00 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_MainUI))]
        ///  extern void GET_COMPONENTS_IN_PARENT_01 (System.Boolean includeInactive, nint results);


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_MainUI))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_02 ();


        /// <summary>
        ///   UnityEngine.Vector3 GetTipPos()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTipPos", Search = typeof(Search_MainUI))]
        ///  extern UnityEngine.Vector3 GET_TIP_POS_00 ();


        /// <summary>
        ///   System.Collections.Generic.List<UnityEngine.Vector2> GetTipPos(System.Int32 num)
        /// </summary>
        /// <param name="num">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.List<UnityEngine.Vector2></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTipPos", Search = typeof(Search_MainUI))]
        ///  extern nint GET_TIP_POS_01 (System.Int32 num);


        /// <summary>
        ///   System.Void Init()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_MainUI))]
        ///  extern void INIT_00 ();


        /// <summary>
        ///   System.Void Init()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_MainUI))]
        ///  extern void INIT_01 ();


        /// <summary>
        ///   System.Void Init()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_MainUI))]
        ///  extern void INIT_02 ();


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_02 (nint original);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_03 (nint original, nint parent, System.Boolean instantiateInWorldSpace);


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_04 (nint original);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_05 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_07 (nint original, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_MainUI))]
        /// static extern nint INSTANTIATE_08 (nint original, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        ///   System.Boolean IsInvoking()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_MainUI))]
        ///  extern System.Boolean IS_INVOKING_00 ();


        /// <summary>
        ///   System.Boolean IsInvoking(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_MainUI))]
        ///  extern System.Boolean IS_INVOKING_01 (nint methodName);


        /// <summary>
        /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_MainUI))]
        /// static extern System.Boolean IS_INVOKING_02 (nint self, nint methodName);


        /// <summary>
        ///   System.Void OnBelow()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnBelow", Search = typeof(Search_MainUI))]
        ///  extern void ON_BELOW_00 ();


        /// <summary>
        ///   System.Void OnBelow()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnBelow", Search = typeof(Search_MainUI))]
        ///  extern void ON_BELOW_01 ();


        /// <summary>
        ///   System.Void OnReview()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnReview", Search = typeof(Search_MainUI))]
        ///  extern void ON_REVIEW_00 ();


        /// <summary>
        ///   System.Void OnReview()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnReview", Search = typeof(Search_MainUI))]
        ///  extern void ON_REVIEW_01 ();


        /// <summary>
        ///   System.Void RemoveSelf()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSelf", Search = typeof(Search_MainUI))]
        ///  extern void REMOVE_SELF_00 ();


        /// <summary>
        ///   System.Void RemoveSelf()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSelf", Search = typeof(Search_MainUI))]
        ///  extern void REMOVE_SELF_01 ();


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_MainUI))]
        ///  extern void SEND_MESSAGE_00 (nint methodName, nint value);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_MainUI))]
        ///  extern void SEND_MESSAGE_01 (nint methodName, nint value, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SetSortingOrder(System.Int32 newOrder)
        /// </summary>
        /// <param name="newOrder">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSortingOrder", Search = typeof(Search_MainUI))]
        ///  extern void SET_SORTING_ORDER_00 (System.Int32 newOrder);


        /// <summary>
        ///   System.Void SetSortingOrder(System.Int32 newOrder)
        /// </summary>
        /// <param name="newOrder">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSortingOrder", Search = typeof(Search_MainUI))]
        ///  extern void SET_SORTING_ORDER_01 (System.Int32 newOrder);


        /// <summary>
        ///   System.Void ShowTipsInfo(System.Collections.Generic.List<MapObject.MenuItemRegister> type, System.Action action)
        /// </summary>
        /// <param name="type">class System.Collections.Generic.List<MapObject.MenuItemRegister></param>
        /// <param name="action">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowTipsInfo", Search = typeof(Search_MainUI))]
        ///  extern void SHOW_TIPS_INFO_00 (nint type, nint action);


        /// <summary>
        ///   System.Void ShowTipsInfo(MapObject.MenuItemRegister reg, System.Action action)
        /// </summary>
        /// <param name="reg">class MapObject.MenuItemRegister</param>
        /// <param name="action">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowTipsInfo", Search = typeof(Search_MainUI))]
        ///  extern void SHOW_TIPS_INFO_01 (nint reg, nint action);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_MainUI))]
        ///  extern nint START_COROUTINE_00 (nint methodName);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_MainUI))]
        ///  extern nint START_COROUTINE_01 (nint methodName, nint value);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_MainUI))]
        ///  extern nint START_COROUTINE_02 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_MainUI))]
        ///  extern void STOP_COROUTINE_00 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
        /// </summary>
        /// <param name="routine">class UnityEngine.Coroutine</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_MainUI))]
        ///  extern void STOP_COROUTINE_01 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_MainUI))]
        ///  extern void STOP_COROUTINE_02 (nint methodName);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_MainUI))]
        ///  extern nint TO_STRING_00 ();


        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_MainUI))]
        /// static extern nint TO_STRING_01 (nint obj);


        /// public static partial class Search_MainUI
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
        ///   UnityEngine.Vector3 GetTipPos()
        /// </summary>
        /// public static bool GET_TIP_POS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTipPos");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Collections.Generic.List<UnityEngine.Vector2> GetTipPos(System.Int32 num)
        /// </summary>
        /// public static bool GET_TIP_POS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTipPos", "System.Int32");
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
        ///   System.Void OnBelow()
        /// </summary>
        /// public static bool ON_BELOW_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnBelow");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnBelow()
        /// </summary>
        /// public static bool ON_BELOW_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnBelow");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnReview()
        /// </summary>
        /// public static bool ON_REVIEW_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnReview");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnReview()
        /// </summary>
        /// public static bool ON_REVIEW_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnReview");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveSelf()
        /// </summary>
        /// public static bool REMOVE_SELF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveSelf");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveSelf()
        /// </summary>
        /// public static bool REMOVE_SELF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveSelf");
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
        ///   System.Void SetSortingOrder(System.Int32 newOrder)
        /// </summary>
        /// public static bool SET_SORTING_ORDER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetSortingOrder", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetSortingOrder(System.Int32 newOrder)
        /// </summary>
        /// public static bool SET_SORTING_ORDER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetSortingOrder", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ShowTipsInfo(System.Collections.Generic.List<MapObject.MenuItemRegister> type, System.Action action)
        /// </summary>
        /// public static bool SHOW_TIPS_INFO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ShowTipsInfo", "System.Collections.Generic.List<MapObject.MenuItemRegister>", "System.Action");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ShowTipsInfo(MapObject.MenuItemRegister reg, System.Action action)
        /// </summary>
        /// public static bool SHOW_TIPS_INFO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ShowTipsInfo", "MapObject.MenuItemRegister", "System.Action");
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

    /// <summary>
    /// ["Assembly-CSharp.dll".""."MainUI"]
    /// </summary>
    public partial class MainUI
    {



        /// <summary>
        ///   System.Void Update()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Update")]
        ///  extern void UPDATE ();


        /// <summary>
        ///   System.Void UpdateTaskArrow(UnityEngine.Vector2 pos, UnityEngine.Vector3 taskWPos)
        /// </summary>
        /// <param name="pos">struct UnityEngine.Vector2</param>
        /// <param name="taskWPos">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateTaskArrow")]
        ///  extern void UPDATE_TASK_ARROW (UnityEngine.Vector2 pos, UnityEngine.Vector3 taskWPos);


        /// <summary>
        ///   System.Void UpdateTaskPoint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateTaskPoint")]
        ///  extern void UPDATE_TASK_POINT ();


        /// <summary>
        ///   System.Void UpRankTip(System.Int32 exp)
        /// </summary>
        /// <param name="exp">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpRankTip")]
        ///  extern void UP_RANK_TIP (System.Int32 exp);




        /// public static partial class Search_MainUI
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}