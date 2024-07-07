
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
    /// class ["Assembly-CSharp.dll".""."JudgeControl"]
    /// [System.Object]
    /// [Ghostmon.ITicker]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000F4U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [74, 117, 100, 103, 101, 67, 111, 110, 116, 114, 111, 108])]


    // struct 0x10 System.Boolean activeSelf
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"activeSelf", "ACTIVE_SELF")]

    // struct 0x14 System.Int32 kill_num
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"kill_num", "KILL_NUM")]

    // class 0x18 System.Collections.Generic.Dictionary<System.UInt32,BUnit> total_unit_dic
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_unit_dic", "TOTAL_UNIT_DIC")]

    // class 0x20 System.Collections.Generic.Dictionary<System.UInt32,MonsterData> total_enemy
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"total_enemy", "TOTAL_ENEMY")]

    // class 0x28 System.Collections.Generic.Stack<Ghostmon.BHitOutput> hit_stack
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"hit_stack", "HIT_STACK")]

    // struct 0x30 System.Single time
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"time", "TIME")]

    // struct 0x34 System.Int32 maxDeployNum
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxDeployNum", "MAX_DEPLOY_NUM")]

    // class 0x38 BJudgeRule judgeRule
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"judgeRule", "JUDGE_RULE")]

    // struct 0x40 System.UInt32 unitIncreaseID
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"unitIncreaseID", "UNIT_INCREASE_ID")]

    // struct 0x44 System.Boolean endTime_trigger
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"endTime_trigger", "END_TIME_TRIGGER")]

    // struct 0x45 System.Boolean death_in_tick
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"death_in_tick", "DEATH_IN_TICK")]

    // class 0x48 System.Text.StringBuilder battle_log
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battle_log", "BATTLE_LOG")]

    // class 0x50 System.Collections.Generic.List<BForceField> forceFields
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"forceFields", "FORCE_FIELDS")]

    // class 0x58 System.Collections.Generic.List<BAura> auras
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"auras", "AURAS")]
    public partial class JudgeControl
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "JudgeControl";
        //public static byte[] Static_ClassName { get; } = [74, 117, 100, 103, 101, 67, 111, 110, 116, 114, 111, 108];

        //public const uint Const_TypeToken = 0x020000F4U;




        /// <summary>
        /// struct System.Int32 MAX_REMAP_LEVEL "11"
        /// </summary>
        /// public const System.Int32 MAX_REMAP_LEVEL=>"11";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_JudgeControl(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_JudgeControl(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_JudgeControl obj) => obj._ptr;
            public static implicit operator bool(Ptr_JudgeControl obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."JudgeControl"]
    /// </summary>
    public partial class JudgeControl
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Void AddAura(BAura ba)
        /// </summary>
        /// <param name="ba">class BAura</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAura")]
        ///  extern void ADD_AURA (nint ba);


        /// <summary>
        ///   System.Void AddForceField(BForceField ff)
        /// </summary>
        /// <param name="ff">class BForceField</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddForceField")]
        ///  extern void ADD_FORCE_FIELD (nint ff);


        /// <summary>
        ///   System.Void BattleOver(System.Boolean result)
        /// </summary>
        /// <param name="result">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BattleOver")]
        ///  extern void BATTLE_OVER (System.Boolean result);


        /// <summary>
        ///   System.Void BattleStart()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BattleStart")]
        ///  extern void BATTLE_START ();


        /// <summary>
        ///   System.Boolean CheckMaxDeploy()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckMaxDeploy")]
        ///  extern System.Boolean CHECK_MAX_DEPLOY ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask<BUnit> CreateBUnit(MonsterData data, UnityEngine.Vector3 pos, System.Boolean isEnemy, System.Boolean useCopy, System.Boolean isSummons)
        /// </summary>
        /// <param name="data">class MonsterData</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="isEnemy">struct System.Boolean</param>
        /// <param name="useCopy">struct System.Boolean</param>
        /// <param name="isSummons">struct System.Boolean</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<BUnit></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateBUnit")]
        ///  extern Cysharp.Threading.Tasks.UniTask<BUnit> CREATE_B_UNIT (nint data, UnityEngine.Vector3 pos, System.Boolean isEnemy, System.Boolean useCopy, System.Boolean isSummons);


        /// <summary>
        ///   System.Void CreateEnemy(MonsterData fData)
        /// </summary>
        /// <param name="fData">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateEnemy")]
        ///  extern void CREATE_ENEMY (nint fData);


        /// <summary>
        ///   System.Void Dispose()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Dispose")]
        ///  extern void DISPOSE ();


        /// <summary>
        ///   System.Boolean get_ActiveSelf()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ActiveSelf")]
        ///  extern System.Boolean GET_ACTIVE_SELF ();


        /// <summary>
        ///   System.Collections.Generic.List<BUnit> GetUnitsByCondition(System.Predicate<BUnit> predicate)
        /// </summary>
        /// <param name="predicate">class System.Predicate<BUnit></param>
        /// <returns>class System.Collections.Generic.List<BUnit></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetUnitsByCondition")]
        ///  extern nint GET_UNITS_BY_CONDITION (nint predicate);


        /// <summary>
        ///   BUnit GetUnitsByDataID(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>class BUnit</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetUnitsByDataID")]
        ///  extern nint GET_UNITS_BY_DATA_ID (System.UInt64 id);


        /// <summary>
        ///   System.Collections.Generic.List<BUnit> GetUnitsByFaction(System.Boolean isEnemy)
        /// </summary>
        /// <param name="isEnemy">struct System.Boolean</param>
        /// <returns>class System.Collections.Generic.List<BUnit></returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetUnitsByFaction")]
        extern PMonoList_S<BUnit.Ptr_BUnit> GET_UNITS_BY_FACTION(System.Boolean isEnemy);


        /// <summary>
        ///   BUnit GetUnitsByUnit(System.UInt32 id)
        /// </summary>
        /// <param name="id">struct System.UInt32</param>
        /// <returns>class BUnit</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetUnitsByUnit")]
        ///  extern nint GET_UNITS_BY_UNIT (System.UInt32 id);


        /// <summary>
        ///   System.Void InitBattleRule(System.String script)
        /// </summary>
        /// <param name="script">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitBattleRule")]
        ///  extern void INIT_BATTLE_RULE (nint script);


        /// <summary>
        ///   System.Void InitMine()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitMine")]
        ///  extern void INIT_MINE ();


        /// <summary>
        ///   System.Void RemoveAura(BAura ba)
        /// </summary>
        /// <param name="ba">class BAura</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAura")]
        ///  extern void REMOVE_AURA (nint ba);


        /// <summary>
        ///   System.Void RemoveBUnit(System.UInt32 unitId, System.Boolean isEnemy, System.Boolean isSummons)
        /// </summary>
        /// <param name="unitId">struct System.UInt32</param>
        /// <param name="isEnemy">struct System.Boolean</param>
        /// <param name="isSummons">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBUnit")]
        ///  extern void REMOVE_B_UNIT (System.UInt32 unitId, System.Boolean isEnemy, System.Boolean isSummons);


        /// <summary>
        ///   System.Void RemoveForceField(BForceField ff)
        /// </summary>
        /// <param name="ff">class BForceField</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveForceField")]
        ///  extern void REMOVE_FORCE_FIELD (nint ff);


        /// <summary>
        ///   System.Void UnitDead(BUnit u)
        /// </summary>
        /// <param name="u">class BUnit</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnitDead")]
        ///  extern void UNIT_DEAD (nint u);


        /// <summary>
        ///   System.Void WorkTick(System.Single deltaTime)
        /// </summary>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("WorkTick")]
        ///  extern void WORK_TICK (System.Single deltaTime);



        /// <summary>
        ///   System.Void InitEnemy(MonsterData data)
        /// </summary>
        /// <param name="data">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitEnemy", Search = typeof(Search_JudgeControl))]
        ///  extern void INIT_ENEMY_00 (nint data);


        /// <summary>
        ///   System.Void InitEnemy(Ghostmon.TaskBattleConfig bConfig)
        /// </summary>
        /// <param name="bConfig">class Ghostmon.TaskBattleConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitEnemy", Search = typeof(Search_JudgeControl))]
        ///  extern void INIT_ENEMY_01 (nint bConfig);


        /// public static partial class Search_JudgeControl
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void InitEnemy(MonsterData data)
        /// </summary>
        /// public static bool INIT_ENEMY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InitEnemy", "MonsterData");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InitEnemy(Ghostmon.TaskBattleConfig bConfig)
        /// </summary>
        /// public static bool INIT_ENEMY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InitEnemy", "Ghostmon.TaskBattleConfig");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}