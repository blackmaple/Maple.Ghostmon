
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon.UI"."UIMsgControl"]
    /// [Ghostmon.Framework.Singleton<Ghostmon.UI.UIMsgControl>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020002AAU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110, 46, 85, 73], [85, 73, 77, 115, 103, 67, 111, 110, 116, 114, 111, 108])]

    //  class static Ghostmon.UI.UIMsgControl instance
    [MonoCollectorSearchFieldAttribute(typeof(UIMsgControl.Ptr_UIMsgControl), "instance", "INSTANCE", true)]

    // class 0x10 System.Collections.Generic.List<UnityEngine.RectTransform> waitingMsgList
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"waitingMsgList", "WAITING_MSG_LIST")]

    // class 0x18 System.Collections.Generic.Queue<GainItemTopTip> crystalTips
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"crystalTips", "CRYSTAL_TIPS")]

    // struct 0x20 System.Boolean isPlayingCrystalTip
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isPlayingCrystalTip", "IS_PLAYING_CRYSTAL_TIP")]

    // class 0x28 System.Collections.Generic.Queue<MissionTip> missionTips
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"missionTips", "MISSION_TIPS")]

    // struct 0x30 System.Boolean isPlayingTaskTip
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isPlayingTaskTip", "IS_PLAYING_TASK_TIP")]

    // class 0x38 System.Collections.Generic.Queue<UnlockFormulaTip> unlockTips
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockTips", "UNLOCK_TIPS")]

    // struct 0x40 System.Boolean isPlayingUnlockTip
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isPlayingUnlockTip", "IS_PLAYING_UNLOCK_TIP")]
    public partial class UIMsgControl
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon.UI";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110, 46, 85, 73];

        //public const string Const_ClassName = "UIMsgControl";
        //public static byte[] Static_ClassName { get; } = [85, 73, 77, 115, 103, 67, 111, 110, 116, 114, 111, 108];

        //public const uint Const_TypeToken = 0x020002AAU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UIMsgControl(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UIMsgControl(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UIMsgControl obj) => obj._ptr;
            public static implicit operator bool(Ptr_UIMsgControl obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon.UI"."UIMsgControl"]
    /// </summary>
    public partial class UIMsgControl
    {



        /// <summary>
        ///   System.Void AddBubblingPopUp(System.String content, System.Int32 type)
        /// </summary>
        /// <param name="content">class System.String</param>
        /// <param name="type">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBubblingPopUp")]
        extern void ADD_BUBBLING_POP_UP(PMonoString content, System.Int32 type);


        /// <summary>
        ///   System.Void AddTowPopUpData(System.String content, System.String affirmTxt, System.String denyTxt, UnityEngine.Events.UnityAction affirmOnClick, UnityEngine.Events.UnityAction denyOnClick)
        /// </summary>
        /// <param name="content">class System.String</param>
        /// <param name="affirmTxt">class System.String</param>
        /// <param name="denyTxt">class System.String</param>
        /// <param name="affirmOnClick">class UnityEngine.Events.UnityAction</param>
        /// <param name="denyOnClick">class UnityEngine.Events.UnityAction</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTowPopUpData")]
        ///  extern void ADD_TOW_POP_UP_DATA (nint content, nint affirmTxt, nint denyTxt, nint affirmOnClick, nint denyOnClick);


        /// <summary>
        /// static  Ghostmon.UI.UIMsgControl CreateInstance()
        /// </summary>
        /// <returns>class Ghostmon.UI.UIMsgControl</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInstance")]
        /// static extern nint CREATE_INSTANCE ();


        /// <summary>
        ///   System.Void CrystalTipCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrystalTipCallback")]
        ///  extern void CRYSTAL_TIP_CALLBACK ();


        /// <summary>
        /// static  Ghostmon.UI.UIMsgControl get_Instance()
        /// </summary>
        /// <returns>class Ghostmon.UI.UIMsgControl</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
        /// static extern nint GET_INSTANCE ();


        /// <summary>
        /// static  System.Boolean IsActive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
        /// static extern System.Boolean IS_ACTIVE ();


        /// <summary>
        ///   System.Void MakeCharmSuccess(System.UInt64 id, System.Int32 num)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MakeCharmSuccess")]
        ///  extern void MAKE_CHARM_SUCCESS (System.UInt64 id, System.Int32 num);


        /// <summary>
        ///   System.Void MissionTipCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MissionTipCallback")]
        ///  extern void MISSION_TIP_CALLBACK ();


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit")]
        ///  extern void ON_INIT ();


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove")]
        ///  extern void ON_REMOVE ();


        /// <summary>
        ///   System.Void PlayGainItemTopTip(System.UInt64 ID, System.Int32 type, System.Int32 num)
        /// </summary>
        /// <param name="ID">struct System.UInt64</param>
        /// <param name="type">struct System.Int32</param>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayGainItemTopTip")]
        ///  extern void PLAY_GAIN_ITEM_TOP_TIP (System.UInt64 ID, System.Int32 type, System.Int32 num);


        /// <summary>
        ///   System.Void PlayGetMonsterTips(MonsterData monsterData)
        /// </summary>
        /// <param name="monsterData">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayGetMonsterTips")]
        ///  extern void PLAY_GET_MONSTER_TIPS (nint monsterData);


        /// <summary>
        ///   System.Void PlayMessage(System.String desc, System.Int32 type)
        /// </summary>
        /// <param name="desc">class System.String</param>
        /// <param name="type">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayMessage")]
        extern void PLAY_MESSAGE(PMonoString desc, System.Int32 type);


        /// <summary>
        ///   System.Void PlayNextCrystalTip()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayNextCrystalTip")]
        ///  extern void PLAY_NEXT_CRYSTAL_TIP ();


        /// <summary>
        ///   System.Void PlayNextMissionTip()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayNextMissionTip")]
        ///  extern void PLAY_NEXT_MISSION_TIP ();


        /// <summary>
        ///   System.Void PlayNextUnlockTip()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayNextUnlockTip")]
        ///  extern void PLAY_NEXT_UNLOCK_TIP ();


        /// <summary>
        ///   System.Void PlayTaskCompletedTip(System.String desc, System.Int32 index)
        /// </summary>
        /// <param name="desc">class System.String</param>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayTaskCompletedTip")]
        ///  extern void PLAY_TASK_COMPLETED_TIP (nint desc, System.Int32 index);


        /// <summary>
        ///   System.Void PlayUnlockFormula(System.Int32 type, System.UInt64 ID)
        /// </summary>
        /// <param name="type">struct System.Int32</param>
        /// <param name="ID">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayUnlockFormula")]
        ///  extern void PLAY_UNLOCK_FORMULA (System.Int32 type, System.UInt64 ID);


        /// <summary>
        ///   System.Void Remove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
        ///  extern void REMOVE ();


        /// <summary>
        ///   System.Void SealNewMonsterTips(System.String desc)
        /// </summary>
        /// <param name="desc">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SealNewMonsterTips")]
        ///  extern void SEAL_NEW_MONSTER_TIPS (nint desc);


        /// <summary>
        ///   System.Void ShowAwardConfirmUI(System.Collections.Generic.List<Ghostmon.CommonData> datas)
        /// </summary>
        /// <param name="datas">class System.Collections.Generic.List<Ghostmon.CommonData></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowAwardConfirmUI")]
        ///  extern void SHOW_AWARD_CONFIRM_UI (nint datas);


        /// <summary>
        ///   System.Void ShowGainItemTip(Ghostmon.CommonData commonData)
        /// </summary>
        /// <param name="commonData">class Ghostmon.CommonData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowGainItemTip")]
        ///  extern void SHOW_GAIN_ITEM_TIP (nint commonData);


        /// <summary>
        ///   System.Void ShowNormalAwardTip(System.Collections.Generic.List<Ghostmon.CommonData> datas)
        /// </summary>
        /// <param name="datas">class System.Collections.Generic.List<Ghostmon.CommonData></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowNormalAwardTip")]
        ///  extern void SHOW_NORMAL_AWARD_TIP (nint datas);


        /// <summary>
        ///   System.Void UnlockTipCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockTipCallback")]
        ///  extern void UNLOCK_TIP_CALLBACK ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UIMsgControl))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UIMsgControl))]
        ///  extern void .CTOR_01 ();


        /// public static partial class Search_UIMsgControl
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
        /// 
        /// }

    }


}