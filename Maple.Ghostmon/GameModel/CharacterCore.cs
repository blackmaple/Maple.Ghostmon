
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
    /// class ["Assembly-CSharp.dll".""."CharacterCore"]
    /// [Ghostmon.Framework.Singleton<CharacterCore>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200012AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [67, 104, 97, 114, 97, 99, 116, 101, 114, 67, 111, 114, 101])]

    //  class static CharacterCore instance
    [MonoCollectorSearchFieldAttribute(typeof(CharacterCore.Ptr_CharacterCore), "instance", "INSTANCE", true)]

    // class 0x10 CharacterCtrl c_ctrl
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"c_ctrl", "C_CTRL")]

    // class 0x18 CharacterTrigger c_trigger
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"c_trigger", "C_TRIGGER")]

    // class 0x20 UnityEngine.GameObject character
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"character", "CHARACTER")]

    // class 0x28 Spine.Unity.MixAndMatchSkins mixSkin
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"mixSkin", "MIX_SKIN")]

    // class 0x30 CharacterCompanion companion
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"companion", "COMPANION")]

    // struct 0x38 FMOD.Studio.EventInstance state_instance
    // [MonoCollectorSearchFieldAttribute(typeof(FMOD.Studio.EventInstance),"state_instance", "STATE_INSTANCE")]

    // struct 0x40 System.UInt64 clothing
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"clothing", "CLOTHING")]

    // struct 0x48 System.UInt64 weapon
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"weapon", "WEAPON")]

    // struct 0x50 System.UInt64 hair
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"hair", "HAIR")]

    // struct 0x58 System.UInt32 hairColor
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"hairColor", "HAIR_COLOR")]

    // struct 0x5C System.Boolean <isLocked>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "<isLocked>k__BackingField", "IS_LOCKED")]

    // struct 0x5D System.Boolean <isInEvilChase>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<isInEvilChase>k__BackingField", "IS_IN_EVIL_CHASE")]

    // struct 0x5E System.Boolean <isInChase>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<isInChase>k__BackingField", "IS_IN_CHASE")]

    // struct 0x5F System.Boolean <isNonhostility>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<isNonhostility>k__BackingField", "IS_NONHOSTILITY")]

    // struct 0x60 System.Boolean <inBattle>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<inBattle>k__BackingField", "IN_BATTLE")]

    // class 0x68 SceneScanVolume ssvolume
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ssvolume", "SSVOLUME")]

    // abstract class 0x70 UnityEngine.Rendering.Universal.ScriptableRendererFeature srf
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"srf", "SRF")]

    // struct 0x78 System.Boolean ss_active
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "ss_active", "SS_ACTIVE")]

    // struct 0x7C System.Single ss_cd
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "ss_cd", "SS_CD", IsReadOnly = false)]

    // struct 0x80 System.Single ss_range
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"ss_range", "SS_RANGE")]

    // struct 0x84 System.Single ss_duration
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "ss_duration", "SS_DURATION", IsReadOnly = false)]

    // class 0x88 System.Collections.Generic.List<MapMonster> ss_monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ss_monsters", "SS_MONSTERS")]

    // struct 0x90 System.Int32 lockedNum
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"lockedNum", "LOCKED_NUM")]

    // struct 0x94 System.Int32 chaseNum
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"chaseNum", "CHASE_NUM")]

    // struct 0x98 System.Int32 hostilityNum
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"hostilityNum", "HOSTILITY_NUM")]
    public partial class CharacterCore
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "CharacterCore";
        //public static byte[] Static_ClassName { get; } = [67, 104, 97, 114, 97, 99, 116, 101, 114, 67, 111, 114, 101];

        //public const uint Const_TypeToken = 0x0200012AU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CharacterCore(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CharacterCore(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CharacterCore obj) => obj._ptr;
            public static implicit operator bool(Ptr_CharacterCore obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."CharacterCore"]
    /// </summary>
    public partial class CharacterCore
    {



        /// <summary>
        ///   System.Void <EnrtyScanMode>b__39_0(System.Single x)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<EnrtyScanMode>b__39_0")]
        ///  extern void <ENRTY_SCAN_MODE>B__39_0 (System.Single x);


        /// <summary>
        ///   System.Void <ExitScanMode>b__40_0(System.Single x)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ExitScanMode>b__40_0")]
        ///  extern void <EXIT_SCAN_MODE>B__40_0 (System.Single x);


        /// <summary>
        ///   System.Void <ExitScanMode>b__40_1()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ExitScanMode>b__40_1")]
        ///  extern void <EXIT_SCAN_MODE>B__40_1 ();


        /// <summary>
        ///   System.Void AddChaseNum(System.Boolean evil)
        /// </summary>
        /// <param name="evil">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddChaseNum")]
        ///  extern void ADD_CHASE_NUM (System.Boolean evil);


        /// <summary>
        ///   System.Void CharacterStop()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CharacterStop")]
        ///  extern void CHARACTER_STOP ();


        /// <summary>
        ///   System.Void CheckIsRefreshSkin()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckIsRefreshSkin")]
        ///  extern void CHECK_IS_REFRESH_SKIN ();


        /// <summary>
        ///   System.Void ClearChaseNum()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearChaseNum")]
        ///  extern void CLEAR_CHASE_NUM ();


        /// <summary>
        ///   System.Void CloseHostility()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseHostility")]
        ///  extern void CLOSE_HOSTILITY ();


        /// <summary>
        ///   System.Void CloseModelAndTrigger()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseModelAndTrigger")]
        ///  extern void CLOSE_MODEL_AND_TRIGGER ();


        /// <summary>
        /// static  CharacterCore CreateInstance()
        /// </summary>
        /// <returns>class CharacterCore</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInstance")]
        /// static extern nint CREATE_INSTANCE ();


        /// <summary>
        ///   System.Void EnrtyScanMode()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnrtyScanMode")]
        extern void ENRTY_SCAN_MODE();


        /// <summary>
        ///   System.Void ExitBattle()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExitBattle")]
        ///  extern void EXIT_BATTLE ();


        /// <summary>
        ///   System.Void ExitScanMode()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExitScanMode")]
        extern void EXIT_SCAN_MODE();


        /// <summary>
        ///   System.Boolean get_inBattle()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inBattle")]
        ///  extern System.Boolean GET_IN_BATTLE ();


        /// <summary>
        /// static  CharacterCore get_Instance()
        /// </summary>
        /// <returns>class CharacterCore</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
        /// static extern nint GET_INSTANCE ();


        /// <summary>
        ///   System.Boolean get_isInChase()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInChase")]
        ///  extern System.Boolean GET_IS_IN_CHASE ();


        /// <summary>
        ///   System.Boolean get_isInEvilChase()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInEvilChase")]
        ///  extern System.Boolean GET_IS_IN_EVIL_CHASE ();


        /// <summary>
        ///   System.Boolean get_isLocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isLocked")]
        ///  extern System.Boolean GET_IS_LOCKED ();


        /// <summary>
        ///   System.Boolean get_isNonhostility()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isNonhostility")]
        ///  extern System.Boolean GET_IS_NONHOSTILITY ();


        /// <summary>
        ///   System.Void InitMainCharacter(UnityEngine.GameObject go)
        /// </summary>
        /// <param name="go">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitMainCharacter")]
        ///  extern void INIT_MAIN_CHARACTER (nint go);


        /// <summary>
        /// static  System.Boolean IsActive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
        /// static extern System.Boolean IS_ACTIVE ();


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit")]
        ///  extern void ON_INIT ();


        /// <summary>
        ///   System.Void OpenHostility()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenHostility")]
        ///  extern void OPEN_HOSTILITY ();


        /// <summary>
        ///   System.Void OpenModelAndTrigger()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenModelAndTrigger")]
        ///  extern void OPEN_MODEL_AND_TRIGGER ();


        /// <summary>
        ///   System.Void PrecessUpdate()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PrecessUpdate")]
        ///  extern void PRECESS_UPDATE ();


        /// <summary>
        ///   System.Void ReduceChaseNum()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReduceChaseNum")]
        ///  extern void REDUCE_CHASE_NUM ();


        /// <summary>
        ///   System.Void Remove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
        ///  extern void REMOVE ();


        /// <summary>
        ///   System.Void set_inBattle(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_inBattle")]
        ///  extern void SET_IN_BATTLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInChase(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInChase")]
        ///  extern void SET_IS_IN_CHASE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInEvilChase(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInEvilChase")]
        ///  extern void SET_IS_IN_EVIL_CHASE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isLocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isLocked")]
        ///  extern void SET_IS_LOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isNonhostility(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isNonhostility")]
        ///  extern void SET_IS_NONHOSTILITY (System.Boolean value);


        /// <summary>
        ///   System.Void Set3x3BlockMonsterLvOn()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Set3x3BlockMonsterLvOn")]
        ///  extern void SET3X3_BLOCK_MONSTER_LV_ON ();


        /// <summary>
        ///   System.Void SetCharacterState(CharacterCore.CharacterState state)
        /// </summary>
        /// <param name="state">enum CharacterCore.CharacterState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCharacterState")]
        ///  extern void SET_CHARACTER_STATE (CharacterCore.CharacterState state);


        /// <summary>
        ///   System.Void SetFree()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFree")]
        ///  extern void SET_FREE ();


        /// <summary>
        ///   System.Void SetLevelOff()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLevelOff")]
        ///  extern void SET_LEVEL_OFF ();


        /// <summary>
        ///   System.Void SetLocked()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocked")]
        ///  extern void SET_LOCKED ();


        /// <summary>
        ///   System.Void TriggerBattle()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TriggerBattle")]
        ///  extern void TRIGGER_BATTLE ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_CharacterCore))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_CharacterCore))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove", Search = typeof(Search_CharacterCore))]
        ///  extern void ON_REMOVE_00 ();


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove", Search = typeof(Search_CharacterCore))]
        ///  extern void ON_REMOVE_01 ();


        /// <summary>
        ///   System.Void RefreshCompanion(System.UInt64 mId)
        /// </summary>
        /// <param name="mId">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCompanion", Search = typeof(Search_CharacterCore))]
        ///  extern void REFRESH_COMPANION_00 (System.UInt64 mId);


        /// <summary>
        ///   System.Void RefreshCompanion()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCompanion", Search = typeof(Search_CharacterCore))]
        ///  extern void REFRESH_COMPANION_01 ();


        /// public static partial class Search_CharacterCore
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
        ///   System.Void OnRemove()
        /// </summary>
        /// public static bool ON_REMOVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnRemove");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// public static bool ON_REMOVE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnRemove");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RefreshCompanion(System.UInt64 mId)
        /// </summary>
        /// public static bool REFRESH_COMPANION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RefreshCompanion", "System.UInt64");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RefreshCompanion()
        /// </summary>
        /// public static bool REFRESH_COMPANION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RefreshCompanion");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}