
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
    /// class ["Assembly-CSharp.dll".""."BUnit"]
    /// [System.Object]
    /// [Ghostmon.ITicker]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000F1U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [66, 85, 110, 105, 116])]


    // struct 0x10 System.Boolean activeSelf
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"activeSelf", "ACTIVE_SELF")]

    // struct 0x14 System.UInt32 unitID
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"unitID", "UNIT_ID")]

    // struct 0x18 System.Boolean isManaFull
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isManaFull", "IS_MANA_FULL")]

    // struct 0x19 System.Boolean isEnemy
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isEnemy", "IS_ENEMY")]

    // struct 0x1A System.Boolean isDead
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isDead", "IS_DEAD")]

    // struct 0x1B System.Boolean isSummons
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isSummons", "IS_SUMMONS")]

    // struct 0x1C System.Boolean isWards
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isWards", "IS_WARDS")]

    // struct 0x20 System.Single mana
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"mana", "MANA")]

    // struct 0x24 System.Single shield
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"shield", "SHIELD")]

    // struct 0x28 System.Single lifeTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"lifeTime", "LIFE_TIME")]

    // struct 0x2C System.Single hateCorrection
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"hateCorrection", "HATE_CORRECTION")]

    // struct 0x30 System.Single extra_cost
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extra_cost", "EXTRA_COST")]

    // struct 0x34 System.Single extra_atk
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extra_atk", "EXTRA_ATK")]

    // struct 0x38 System.Single extra_mag
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extra_mag", "EXTRA_MAG")]

    // struct 0x3C System.Single extra_maxHp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extra_maxHp", "EXTRA_MAX_HP")]

    // struct 0x40 System.Single extra_wp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extra_wp", "EXTRA_WP")]

    // struct 0x44 System.Single extra_def
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extra_def", "EXTRA_DEF")]

    // struct 0x48 System.Single extra_crit
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extra_crit", "EXTRA_CRIT")]

    // struct 0x4C System.Single <accumulate_fire>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_fire>k__BackingField", "ACCUMULATE_FIRE")]

    // struct 0x50 System.Single <accumulate_cold>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_cold>k__BackingField", "ACCUMULATE_COLD")]

    // struct 0x54 System.Single <accumulate_ltng>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_ltng>k__BackingField", "ACCUMULATE_LTNG")]

    // struct 0x58 System.Single <accumulate_wind>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_wind>k__BackingField", "ACCUMULATE_WIND")]

    // struct 0x5C System.Single <accumulate_poison>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_poison>k__BackingField", "ACCUMULATE_POISON")]

    // struct 0x60 System.Single <accumulate_dark>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_dark>k__BackingField", "ACCUMULATE_DARK")]

    // struct 0x64 System.Single <accumulate_puncture>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_puncture>k__BackingField", "ACCUMULATE_PUNCTURE")]

    // struct 0x68 System.Single <accumulate_shock>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_shock>k__BackingField", "ACCUMULATE_SHOCK")]

    // struct 0x6C System.Single <accumulate_tear>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<accumulate_tear>k__BackingField", "ACCUMULATE_TEAR")]

    // class 0x70 UnityEngine.GameObject gameObject
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"gameObject", "GAME_OBJECT")]

    // class 0x78 UnityEngine.GameObject model
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"model", "MODEL")]

    // class 0x80 UnityEngine.Transform transform
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"transform", "TRANSFORM")]

    // class 0x88 USkillObject skill
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skill", "SKILL")]

    // class 0x90 Ghostmon.BUnitFightCtrl unitFightCtrl
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unitFightCtrl", "UNIT_FIGHT_CTRL")]

    // class 0x98 BUnitModelCtrl unitModelCtrl
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unitModelCtrl", "UNIT_MODEL_CTRL")]

    // class 0xA0 BattleUnitInfo unitInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unitInfo", "UNIT_INFO")]

    // class 0xA8 UnityEngine.BoxCollider col
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"col", "COL")]

    // class 0xB0 UnityEngine.AI.NavMeshAgent nma
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"nma", "NMA")]

    // class 0xB8 BSeekCtrl bsc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"bsc", "BSC")]

    // class 0xC0 UnityEngine.EventSystems.EventTrigger tri
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tri", "TRI")]

    // class 0xC8 UnityEngine.GameObject selectEffect
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"selectEffect", "SELECT_EFFECT")]

    // class 0xD0 System.Collections.Generic.List<Ghostmon.AbilityBase> abilities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"abilities", "ABILITIES")]

    // class 0xD8 System.Collections.Generic.List<BBuff> buffList
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buffList", "BUFF_LIST")]

    // class 0xE0 System.Collections.Generic.List<Ghostmon.BuffEffectType> effectList
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"effectList", "EFFECT_LIST")]

    // class 0xE8 MonsterData <m_Data>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<m_Data>k__BackingField", "M_DATA")]

    // class 0xF0 System.Collections.Generic.Dictionary<Ghostmon.AttributeType,System.Single> base_property
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"base_property", "BASE_PROPERTY")]

    // struct 0xF8 UnityEngine.Vector2 clickPos
    // [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector2),"clickPos", "CLICK_POS")]

    // struct 0x100 System.Boolean isDraging
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isDraging", "IS_DRAGING")]

    // struct 0x101 System.Boolean drag_pos_valid
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"drag_pos_valid", "DRAG_POS_VALID")]
    public partial class BUnit
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "BUnit";
        //public static byte[] Static_ClassName { get; } = [66, 85, 110, 105, 116];

        //public const uint Const_TypeToken = 0x020000F1U;




        /// <summary>
        /// struct System.Single ACCU_DRAIN_SPEED "2"
        /// </summary>
        /// public const System.Single ACCU_DRAIN_SPEED=>"2";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_BUnit(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_BUnit(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_BUnit obj) => obj._ptr;
            public static implicit operator bool(Ptr_BUnit obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."BUnit"]
    /// </summary>
    public partial class BUnit
    {



        /// <summary>
        ///   System.Void .ctor(MonsterData data)
        /// </summary>
        /// <param name="data">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (nint data);


        /// <summary>
        ///   System.Void AddBuffEffect(Ghostmon.BuffEffectType type)
        /// </summary>
        /// <param name="type">enum Ghostmon.BuffEffectType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffEffect")]
        ///  extern void ADD_BUFF_EFFECT (Ghostmon.BuffEffectType type);


        /// <summary>
        ///   BBuff AddBuffItem(System.UInt64 buffID, BUnit giver)
        /// </summary>
        /// <param name="buffID">struct System.UInt64</param>
        /// <param name="giver">class BUnit</param>
        /// <returns>class BBuff</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffItem")]
        extern nint ADD_BUFF_ITEM(System.UInt64 buffID, nint giver);


        /// <summary>
        ///   System.Void AddClickEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddClickEvent")]
        ///  extern void ADD_CLICK_EVENT ();


        /// <summary>
        ///   System.Void AfterCauseDamage(Ghostmon.BHitResult result)
        /// </summary>
        /// <param name="result">struct Ghostmon.BHitResult</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AfterCauseDamage")]
        ///  extern void AFTER_CAUSE_DAMAGE (Ghostmon.BHitResult result);


        /// <summary>
        ///   System.Void AfterGetDamage(Ghostmon.BHitResult result)
        /// </summary>
        /// <param name="result">struct Ghostmon.BHitResult</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AfterGetDamage")]
        ///  extern void AFTER_GET_DAMAGE (Ghostmon.BHitResult result);


        /// <summary>
        ///   System.Void CalcuDebuffAccumFromDmg(Ghostmon.BHitResult result)
        /// </summary>
        /// <param name="result">struct Ghostmon.BHitResult</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CalcuDebuffAccumFromDmg")]
        ///  extern void CALCU_DEBUFF_ACCUM_FROM_DMG (Ghostmon.BHitResult result);


        /// <summary>
        ///   System.Boolean CheckAbilityExist(System.String className)
        /// </summary>
        /// <param name="className">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckAbilityExist")]
        ///  extern System.Boolean CHECK_ABILITY_EXIST (nint className);


        /// <summary>
        ///   System.Boolean CheckBuffExist(System.UInt64 buffID)
        /// </summary>
        /// <param name="buffID">struct System.UInt64</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckBuffExist")]
        ///  extern System.Boolean CHECK_BUFF_EXIST (System.UInt64 buffID);


        /// <summary>
        ///   System.Boolean CheckEffectExist(Ghostmon.BuffEffectType effectType)
        /// </summary>
        /// <param name="effectType">enum Ghostmon.BuffEffectType</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckEffectExist")]
        ///  extern System.Boolean CHECK_EFFECT_EXIST (Ghostmon.BuffEffectType effectType);


        /// <summary>
        ///   System.Boolean CheckProjCollider(UnityEngine.Vector3 projPos, System.Single radius)
        /// </summary>
        /// <param name="projPos">struct UnityEngine.Vector3</param>
        /// <param name="radius">struct System.Single</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckProjCollider")]
        ///  extern System.Boolean CHECK_PROJ_COLLIDER (UnityEngine.Vector3 projPos, System.Single radius);


        /// <summary>
        ///   System.Void ClearAbility()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearAbility")]
        ///  extern void CLEAR_ABILITY ();


        /// <summary>
        ///   System.Void ClearBuff()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearBuff")]
        ///  extern void CLEAR_BUFF ();


        /// <summary>
        ///   System.Void ClearDebuffAccum()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearDebuffAccum")]
        ///  extern void CLEAR_DEBUFF_ACCUM ();


        /// <summary>
        ///   System.Void CloseNmaCollider()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseNmaCollider")]
        ///  extern void CLOSE_NMA_COLLIDER ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask CreateVisualObject(UnityEngine.Vector3 pos, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateVisualObject")]
        ///  extern Cysharp.Threading.Tasks.UniTask CREATE_VISUAL_OBJECT (UnityEngine.Vector3 pos, nint parent);


        /// <summary>
        ///   System.Void Die()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Die")]
        ///  extern void DIE ();


        /// <summary>
        ///   System.Int32 DispelAllBuff()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DispelAllBuff")]
        ///  extern System.Int32 DISPEL_ALL_BUFF ();


        /// <summary>
        ///   System.Void ForcedDie()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForcedDie")]
        ///  extern void FORCED_DIE ();


        /// <summary>
        ///   System.Void GainHPRecover(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainHPRecover")]
        ///  extern void GAIN_HP_RECOVER (System.Single value);


        /// <summary>
        ///   System.Void GainMana(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainMana")]
        ///  extern void GAIN_MANA (System.Single value);


        /// <summary>
        ///   System.Void GainShield(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainShield")]
        ///  extern void GAIN_SHIELD (System.Single value);


        /// <summary>
        ///   System.Single get_accumulate_cold()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_cold")]
        ///  extern System.Single GET_ACCUMULATE_COLD ();


        /// <summary>
        ///   System.Single get_accumulate_dark()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_dark")]
        ///  extern System.Single GET_ACCUMULATE_DARK ();


        /// <summary>
        ///   System.Single get_accumulate_fire()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_fire")]
        ///  extern System.Single GET_ACCUMULATE_FIRE ();


        /// <summary>
        ///   System.Single get_accumulate_ltng()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_ltng")]
        ///  extern System.Single GET_ACCUMULATE_LTNG ();


        /// <summary>
        ///   System.Single get_accumulate_poison()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_poison")]
        ///  extern System.Single GET_ACCUMULATE_POISON ();


        /// <summary>
        ///   System.Single get_accumulate_puncture()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_puncture")]
        ///  extern System.Single GET_ACCUMULATE_PUNCTURE ();


        /// <summary>
        ///   System.Single get_accumulate_shock()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_shock")]
        ///  extern System.Single GET_ACCUMULATE_SHOCK ();


        /// <summary>
        ///   System.Single get_accumulate_tear()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_tear")]
        ///  extern System.Single GET_ACCUMULATE_TEAR ();


        /// <summary>
        ///   System.Single get_accumulate_wind()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_accumulate_wind")]
        ///  extern System.Single GET_ACCUMULATE_WIND ();


        /// <summary>
        ///   System.Boolean get_ActiveSelf()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ActiveSelf")]
        ///  extern System.Boolean GET_ACTIVE_SELF ();


        /// <summary>
        ///   System.Single get_final_cost()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_final_cost")]
        ///  extern System.Single GET_FINAL_COST ();


        /// <summary>
        ///   MonsterData get_m_Data()
        /// </summary>
        /// <returns>class MonsterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_m_Data")]
        ///  extern nint GET_M_DATA ();


        /// <summary>
        ///   System.Single get_total_atk()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_total_atk")]
        ///  extern System.Single GET_TOTAL_ATK ();


        /// <summary>
        ///   System.Single get_total_crit()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_total_crit")]
        ///  extern System.Single GET_TOTAL_CRIT ();


        /// <summary>
        ///   System.Single get_total_def()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_total_def")]
        ///  extern System.Single GET_TOTAL_DEF ();


        /// <summary>
        ///   System.Single get_total_mag()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_total_mag")]
        ///  extern System.Single GET_TOTAL_MAG ();


        /// <summary>
        ///   System.Single get_total_maxHp()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_total_maxHp")]
        ///  extern System.Single GET_TOTAL_MAX_HP ();


        /// <summary>
        ///   System.Single get_total_wp()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_total_wp")]
        ///  extern System.Single GET_TOTAL_WP ();


        /// <summary>
        ///   Ghostmon.AbilityBase GetAbility(System.UInt64 abilityID)
        /// </summary>
        /// <param name="abilityID">struct System.UInt64</param>
        /// <returns>class Ghostmon.AbilityBase</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAbility")]
        ///  extern nint GET_ABILITY (System.UInt64 abilityID);


        /// <summary>
        ///   UnityEngine.Bounds GetColliderBound()
        /// </summary>
        /// <returns>struct UnityEngine.Bounds</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetColliderBound")]
        ///  extern UnityEngine.Bounds GET_COLLIDER_BOUND ();


        /// <summary>
        ///   Ghostmon.BUnitFightCtrl GetFightCtrl()
        /// </summary>
        /// <returns>class Ghostmon.BUnitFightCtrl</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFightCtrl")]
        ///  extern nint GET_FIGHT_CTRL ();


        /// <summary>
        ///   BUnitModelCtrl GetModelCtrl()
        /// </summary>
        /// <returns>class BUnitModelCtrl</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetModelCtrl")]
        ///  extern nint GET_MODEL_CTRL ();


        /// <summary>
        ///   UnityEngine.Bounds GetProjColliderBound()
        /// </summary>
        /// <returns>struct UnityEngine.Bounds</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetProjColliderBound")]
        ///  extern UnityEngine.Bounds GET_PROJ_COLLIDER_BOUND ();


        /// <summary>
        ///   BSeekCtrl GetSeekCtrl()
        /// </summary>
        /// <returns>class BSeekCtrl</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSeekCtrl")]
        ///  extern nint GET_SEEK_CTRL ();


        /// <summary>
        ///   System.Void Knockback(UnityEngine.Vector3 source, System.Single distance)
        /// </summary>
        /// <param name="source">struct UnityEngine.Vector3</param>
        /// <param name="distance">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Knockback")]
        ///  extern void KNOCKBACK (UnityEngine.Vector3 source, System.Single distance);


        /// <summary>
        ///   System.Void LifeOver()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LifeOver")]
        ///  extern void LIFE_OVER ();


        /// <summary>
        ///   System.Boolean LuckyDetection(System.Single val)
        /// </summary>
        /// <param name="val">struct System.Single</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LuckyDetection")]
        ///  extern System.Boolean LUCKY_DETECTION (System.Single val);


        /// <summary>
        ///   System.Void OnAttack(BUnit target)
        /// </summary>
        /// <param name="target">class BUnit</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnAttack")]
        ///  extern void ON_ATTACK (nint target);


        /// <summary>
        ///   System.Void OnBeginDrag(UnityEngine.EventSystems.BaseEventData eventData)
        /// </summary>
        /// <param name="eventData">class UnityEngine.EventSystems.BaseEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnBeginDrag")]
        ///  extern void ON_BEGIN_DRAG (nint eventData);


        /// <summary>
        ///   System.Void OnCast()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCast")]
        ///  extern void ON_CAST ();


        /// <summary>
        ///   System.Void OnCauseDamage(Ghostmon.BHitOutput output)
        /// </summary>
        /// <param name="output">class Ghostmon.BHitOutput</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCauseDamage")]
        ///  extern void ON_CAUSE_DAMAGE (nint output);


        /// <summary>
        ///   System.Void OnDrag(UnityEngine.EventSystems.BaseEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.BaseEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDrag")]
        ///  extern void ON_DRAG (nint data);


        /// <summary>
        ///   System.Void OnEndDrag(UnityEngine.EventSystems.BaseEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.BaseEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnEndDrag")]
        ///  extern void ON_END_DRAG (nint data);


        /// <summary>
        ///   System.Void OnEndSelected(UnityEngine.EventSystems.BaseEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.BaseEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnEndSelected")]
        ///  extern void ON_END_SELECTED (nint data);


        /// <summary>
        ///   System.Void OnGetDamage(Ghostmon.BHitOutput output)
        /// </summary>
        /// <param name="output">class Ghostmon.BHitOutput</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnGetDamage")]
        ///  extern void ON_GET_DAMAGE (nint output);


        /// <summary>
        ///   System.Void OnPointEnter(UnityEngine.EventSystems.BaseEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.BaseEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPointEnter")]
        ///  extern void ON_POINT_ENTER (nint data);


        /// <summary>
        ///   System.Void OnPointExit(UnityEngine.EventSystems.BaseEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.BaseEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPointExit")]
        ///  extern void ON_POINT_EXIT (nint data);


        /// <summary>
        ///   System.Void OnSelected(UnityEngine.EventSystems.BaseEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.BaseEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSelected")]
        ///  extern void ON_SELECTED (nint data);


        /// <summary>
        ///   System.Void OnSummon(BUnit& summoner)
        /// </summary>
        /// <param name="summoner">class BUnit&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSummon")]
        ///  extern void ON_SUMMON (nint summoner);


        /// <summary>
        ///   System.Void OnUnitDead(BUnit u)
        /// </summary>
        /// <param name="u">class BUnit</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnUnitDead")]
        ///  extern void ON_UNIT_DEAD (nint u);


        /// <summary>
        ///   System.Void OnVictory()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnVictory")]
        ///  extern void ON_VICTORY ();


        /// <summary>
        ///   System.Void OpenNmaCollider()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenNmaCollider")]
        ///  extern void OPEN_NMA_COLLIDER ();


        /// <summary>
        ///   System.Void PlayHPChange(Ghostmon.BHitResult res)
        /// </summary>
        /// <param name="res">struct Ghostmon.BHitResult</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayHPChange")]
        ///  extern void PLAY_HP_CHANGE (Ghostmon.BHitResult res);


        /// <summary>
        ///   System.Void PropertyAdjust(Ghostmon.AttributeType key, System.Single value)
        /// </summary>
        /// <param name="key">enum Ghostmon.AttributeType</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PropertyAdjust")]
        ///  extern void PROPERTY_ADJUST (Ghostmon.AttributeType key, System.Single value);


        /// <summary>
        ///   System.Int32 PurifyAllBuff()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PurifyAllBuff")]
        ///  extern System.Int32 PURIFY_ALL_BUFF ();


        /// <summary>
        ///   System.Void ReceiveDamage(Ghostmon.BHitResult result)
        /// </summary>
        /// <param name="result">struct Ghostmon.BHitResult</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReceiveDamage")]
        ///  extern void RECEIVE_DAMAGE (Ghostmon.BHitResult result);


        /// <summary>
        ///   System.Void ReceiveDebuffAccum(Ghostmon.BattleDamageType type, System.Single val)
        /// </summary>
        /// <param name="type">enum Ghostmon.BattleDamageType</param>
        /// <param name="val">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReceiveDebuffAccum")]
        ///  extern void RECEIVE_DEBUFF_ACCUM (Ghostmon.BattleDamageType type, System.Single val);


        /// <summary>
        ///   System.Void RefreshDragObjVaildState(System.Boolean force)
        /// </summary>
        /// <param name="force">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshDragObjVaildState")]
        ///  extern void REFRESH_DRAG_OBJ_VAILD_STATE (System.Boolean force);


        /// <summary>
        ///   System.Void RemoveAbility(System.UInt64 abilityID)
        /// </summary>
        /// <param name="abilityID">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAbility")]
        ///  extern void REMOVE_ABILITY (System.UInt64 abilityID);


        /// <summary>
        ///   System.Void RemoveBuffEffect(Ghostmon.BuffEffectType type)
        /// </summary>
        /// <param name="type">enum Ghostmon.BuffEffectType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffEffect")]
        ///  extern void REMOVE_BUFF_EFFECT (Ghostmon.BuffEffectType type);


        /// <summary>
        ///   System.Void RemoveBuffItem(System.UInt64 buffID)
        /// </summary>
        /// <param name="buffID">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffItem")]
        ///  extern void REMOVE_BUFF_ITEM (System.UInt64 buffID);


        /// <summary>
        ///   System.Void RemoveClickEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveClickEvent")]
        ///  extern void REMOVE_CLICK_EVENT ();


        /// <summary>
        ///   System.Void RemoveData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveData")]
        ///  extern void REMOVE_DATA ();


        /// <summary>
        ///   System.Void RemoveModel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveModel")]
        ///  extern void REMOVE_MODEL ();


        /// <summary>
        ///   System.Void RemoveSelf()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSelf")]
        ///  extern void REMOVE_SELF ();


        /// <summary>
        ///   BBuff SendBuffItem(System.UInt64 buffID, BUnit target)
        /// </summary>
        /// <param name="buffID">struct System.UInt64</param>
        /// <param name="target">class BUnit</param>
        /// <returns>class BBuff</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendBuffItem")]
        ///  extern nint SEND_BUFF_ITEM (System.UInt64 buffID, nint target);


        /// <summary>
        ///   System.Void set_accumulate_cold(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_cold")]
        ///  extern void SET_ACCUMULATE_COLD (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_dark(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_dark")]
        ///  extern void SET_ACCUMULATE_DARK (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_fire(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_fire")]
        ///  extern void SET_ACCUMULATE_FIRE (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_ltng(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_ltng")]
        ///  extern void SET_ACCUMULATE_LTNG (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_poison(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_poison")]
        ///  extern void SET_ACCUMULATE_POISON (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_puncture(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_puncture")]
        ///  extern void SET_ACCUMULATE_PUNCTURE (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_shock(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_shock")]
        ///  extern void SET_ACCUMULATE_SHOCK (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_tear(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_tear")]
        ///  extern void SET_ACCUMULATE_TEAR (System.Single value);


        /// <summary>
        ///   System.Void set_accumulate_wind(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_accumulate_wind")]
        ///  extern void SET_ACCUMULATE_WIND (System.Single value);


        /// <summary>
        ///   System.Void set_m_Data(MonsterData value)
        /// </summary>
        /// <param name="value">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_m_Data")]
        ///  extern void SET_M_DATA (nint value);


        /// <summary>
        ///   System.Void SetPosition(UnityEngine.Vector3 position)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPosition")]
        ///  extern void SET_POSITION (UnityEngine.Vector3 position);


        /// <summary>
        ///   System.Void SetSelectable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSelectable")]
        ///  extern void SET_SELECTABLE ();


        /// <summary>
        ///   System.Void SetUnitDefault()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnitDefault")]
        ///  extern void SET_UNIT_DEFAULT ();


        /// <summary>
        ///   System.Void SetUnitHighLight()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnitHighLight")]
        ///  extern void SET_UNIT_HIGH_LIGHT ();


        /// <summary>
        ///   System.Void SetUnselectabl()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnselectabl")]
        ///  extern void SET_UNSELECTABL ();


        /// <summary>
        ///   System.Void StartAttack()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartAttack")]
        ///  extern void START_ATTACK ();


        /// <summary>
        ///   System.Void StartCast()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCast")]
        ///  extern void START_CAST ();


        /// <summary>
        ///   T TryGetAbiltiyByClassName(System.String className)
        /// </summary>
        /// <param name="className">class System.String</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetAbiltiyByClassName")]
        ///  extern nint TRY_GET_ABILTIY_BY_CLASS_NAME (nint className);


        /// <summary>
        ///   System.Boolean TryGetBuffITem(System.UInt64 buffID, BBuff& buff)
        /// </summary>
        /// <param name="buffID">struct System.UInt64</param>
        /// <param name="buff">class BBuff&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetBuffITem")]
        ///  extern System.Boolean TRY_GET_BUFF_I_TEM (System.UInt64 buffID, nint buff);


        /// <summary>
        ///   System.Void WorkTick(System.Single deltaTime)
        /// </summary>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("WorkTick")]
        ///  extern void WORK_TICK (System.Single deltaTime);



        /// <summary>
        ///   System.Void AddAbility(System.UInt64 abilityID)
        /// </summary>
        /// <param name="abilityID">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAbility", Search = typeof(Search_BUnit))]
        ///  extern void ADD_ABILITY_00 (System.UInt64 abilityID);


        /// <summary>
        ///   System.Void AddAbility(System.String CSScript)
        /// </summary>
        /// <param name="CSScript">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAbility", Search = typeof(Search_BUnit))]
        ///  extern void ADD_ABILITY_01 (nint CSScript);


        /// <summary>
        ///   System.Void AddAbility(Ghostmon.AbilityBase a, System.String CSScript)
        /// </summary>
        /// <param name="a">class Ghostmon.AbilityBase</param>
        /// <param name="CSScript">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAbility", Search = typeof(Search_BUnit))]
        ///  extern void ADD_ABILITY_02 (nint a, nint CSScript);


        /// public static partial class Search_BUnit
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void AddAbility(System.UInt64 abilityID)
        /// </summary>
        /// public static bool ADD_ABILITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAbility", "System.UInt64");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAbility(System.String CSScript)
        /// </summary>
        /// public static bool ADD_ABILITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAbility", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAbility(Ghostmon.AbilityBase a, System.String CSScript)
        /// </summary>
        /// public static bool ADD_ABILITY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAbility", "Ghostmon.AbilityBase", "System.String");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}