
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."MonsterData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000124U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [77, 111, 110, 115, 116, 101, 114, 68, 97, 116, 97])]


    // struct 0x10 System.UInt64 dataID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "dataID", "DATA_ID")]

    // class 0x18 System.String u_name
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "u_name", "U_NAME")]

    // class 0x20 System.String u_prefab
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "u_prefab", "U_PREFAB")]

    // struct 0x28 System.UInt64 u_professional
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "u_professional", "U_PROFESSIONAL")]

    // struct 0x30 System.Int32 u_race
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_race", "U_RACE")]

    // struct 0x34 System.Int32 u_job
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_job", "U_JOB")]

    // struct 0x38 System.Int32 u_YingYang
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_YingYang", "U_YING_YANG")]

    // struct 0x3C System.Boolean u_flash
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "u_flash", "U_FLASH", IsReadOnly = false)]

    // struct 0x3D System.Boolean u_vari_color
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "u_vari_color", "U_VARI_COLOR", IsReadOnly = false)]

    // struct 0x40 System.Int32 u_exploit
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_exploit", "U_EXPLOIT")]

    // struct 0x44 System.Int32 u_plant
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_plant", "U_PLANT")]

    // struct 0x48 System.Int32 u_hunt
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_hunt", "U_HUNT")]

    // struct 0x4C System.Int32 u_cook
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_cook", "U_COOK")]

    // struct 0x50 System.Int32 u_understanding
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_understanding", "U_UNDERSTANDING")]

    // struct 0x54 System.Int32 u_draw
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_draw", "U_DRAW")]

    // struct 0x58 System.Int32 u_guard
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_guard", "U_GUARD")]

    // struct 0x5C System.Int32 u_trade
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_trade", "U_TRADE")]

    // enum 0x60 MonsterJob monsterJob
    // [MonoCollectorSearchFieldAttribute(typeof(MonsterJob),"monsterJob", "MONSTER_JOB")]

    // struct 0x64 System.Single u_capture_prob
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_capture_prob", "U_CAPTURE_PROB")]

    // struct 0x68 System.Int32 u_type
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_type", "U_TYPE")]

    // class 0x70 System.String[] u_friends
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"u_friends", "U_FRIENDS")]

    // struct 0x78 System.Int32 u_friends_num
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_friends_num", "U_FRIENDS_NUM")]

    // struct 0x7C System.Int32 u_level
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "u_level", "U_LEVEL")]

    // struct 0x80 System.Int32 u_exp
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "u_exp", "U_EXP", IsReadOnly = false)]

    // struct 0x84 System.Int32 u_total_exp
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "u_total_exp", "U_TOTAL_EXP")]

    // struct 0x88 System.Int32 pre_getAbilityLv
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"pre_getAbilityLv", "PRE_GET_ABILITY_LV")]

    // struct 0x8C System.Single u_favorability
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_favorability", "U_FAVORABILITY", IsReadOnly = false)]

    // struct 0x90 System.Int64 u_gainTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int64),"u_gainTime", "U_GAIN_TIME")]

    // class 0x98 System.Int32[] u_ability_tags
    [MonoCollectorSearchFieldAttribute(typeof(PMonoArray<Int32>), "u_ability_tags", "U_ABILITY_TAGS")]

    // class 0xA0 System.UInt64[] u_abilities
    [MonoCollectorSearchFieldAttribute(typeof(PMonoArray<UInt64>), "u_abilities", "U_ABILITIES", IsReadOnly = false)]

    // struct 0xA8 System.Single growth_atk
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "growth_atk", "GROWTH_ATK", IsReadOnly = false)]

    // struct 0xAC System.Single growth_magic
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "growth_magic", "GROWTH_MAGIC", IsReadOnly = false)]

    // struct 0xB0 System.Single growth_def
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "growth_def", "GROWTH_DEF", IsReadOnly = false)]

    // struct 0xB4 System.Single growth_wp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "growth_wp", "GROWTH_WP", IsReadOnly = false)]

    // struct 0xB8 System.Single growth_hp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "growth_hp", "GROWTH_HP", IsReadOnly = false)]

    // struct 0xBC System.Single growth_crit
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "growth_crit", "GROWTH_CRIT", IsReadOnly = false)]


    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "rank_atk", "RANK_ATK", IsReadOnly = false)]
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "rank_magic", "RANK_MAGIC", IsReadOnly = false)]
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "rank_def", "RANK_DEF", IsReadOnly = false)]
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "rank_wp", "RANK_WP", IsReadOnly = false)]
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "rank_hp", "RANK_HP", IsReadOnly = false)]
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "rank_crit", "RANK_CRIT", IsReadOnly = false)]



    // struct 0xC0 System.Int32 u_atk_type
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_atk_type", "U_ATK_TYPE")]

    // struct 0xC4 System.Single u_atk
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_atk", "U_ATK", IsReadOnly = false)]

    // struct 0xC8 System.Single u_magic
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_magic", "U_MAGIC", IsReadOnly = false)]

    // struct 0xCC System.Single u_def
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_def", "U_DEF", IsReadOnly = false)]

    // struct 0xD0 System.Single u_wp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_wp", "U_WP", IsReadOnly = false)]

    // struct 0xD4 System.Single u_maxHp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_maxHp", "U_MAX_HP", IsReadOnly = false)]

    // struct 0xD8 System.Int32 u_fire_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_fire_resist", "U_FIRE_RESIST")]

    // struct 0xDC System.Int32 u_cold_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_cold_resist", "U_COLD_RESIST")]

    // struct 0xE0 System.Int32 u_ltng_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_ltng_resist", "U_LTNG_RESIST")]

    // struct 0xE4 System.Int32 u_wind_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_wind_resist", "U_WIND_RESIST")]

    // struct 0xE8 System.Int32 u_poison_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_poison_resist", "U_POISON_RESIST")]

    // struct 0xEC System.Int32 u_dark_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_dark_resist", "U_DARK_RESIST")]

    // struct 0xF0 System.Int32 u_puncture_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_puncture_resist", "U_PUNCTURE_RESIST")]

    // struct 0xF4 System.Int32 u_shock_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_shock_resist", "U_SHOCK_RESIST")]

    // struct 0xF8 System.Int32 u_tear_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_tear_resist", "U_TEAR_RESIST")]

    // struct 0xFC System.Single u_fire_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_fire_increase", "U_FIRE_INCREASE")]

    // struct 0x100 System.Single u_cold_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_cold_increase", "U_COLD_INCREASE")]

    // struct 0x104 System.Single u_ltng_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_ltng_increase", "U_LTNG_INCREASE")]

    // struct 0x108 System.Single u_wind_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_wind_increase", "U_WIND_INCREASE")]

    // struct 0x10C System.Single u_poison_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_poison_increase", "U_POISON_INCREASE")]

    // struct 0x110 System.Single u_dark_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_dark_increase", "U_DARK_INCREASE")]

    // struct 0x114 System.Single u_puncture_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_puncture_increase", "U_PUNCTURE_INCREASE")]

    // struct 0x118 System.Single u_shock_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_shock_increase", "U_SHOCK_INCREASE")]

    // struct 0x11C System.Single u_tear_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_tear_increase", "U_TEAR_INCREASE")]

    // struct 0x120 System.Single u_hp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_hp", "U_HP", IsReadOnly = false)]

    // struct 0x124 System.Single u_crit
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "u_crit", "U_CRIT", IsReadOnly = false)]

    // struct 0x128 System.Single u_critDmg
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_critDmg", "U_CRIT_DMG")]

    // struct 0x12C System.Single u_luck
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_luck", "U_LUCK")]

    // struct 0x130 System.Single u_move_speed
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_move_speed", "U_MOVE_SPEED")]

    // struct 0x134 System.Single u_atk_speed_freq
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_atk_speed_freq", "U_ATK_SPEED_FREQ")]

    // struct 0x138 System.Single u_atk_speed
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_atk_speed", "U_ATK_SPEED")]

    // struct 0x13C System.Single u_atk_range
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_atk_range", "U_ATK_RANGE")]

    // struct 0x140 System.Single u_mana_gather
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_mana_gather", "U_MANA_GATHER")]

    // struct 0x144 System.Single u_hp_gather
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_hp_gather", "U_HP_GATHER")]

    // struct 0x148 System.Single u_skill_cost
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_skill_cost", "U_SKILL_COST")]

    // struct 0x14C System.Boolean u_atk_remote
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"u_atk_remote", "U_ATK_REMOTE")]

    // struct 0x150 System.Single u_drain_life
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_drain_life", "U_DRAIN_LIFE")]

    // struct 0x154 System.Int32 u_dmg_block
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_dmg_block", "U_DMG_BLOCK")]

    // struct 0x158 System.Int32 u_armor_penetration
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_armor_penetration", "U_ARMOR_PENETRATION")]

    // struct 0x15C System.Single u_treatment_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_treatment_increase", "U_TREATMENT_INCREASE")]

    // struct 0x160 System.Single u_recover_increase
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_recover_increase", "U_RECOVER_INCREASE")]

    // struct 0x164 System.Single u_ele_block_rate
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_ele_block_rate", "U_ELE_BLOCK_RATE")]

    // struct 0x168 System.Single u_debuff_resist
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_debuff_resist", "U_DEBUFF_RESIST")]

    // struct 0x170 System.UInt64 u_bullet_ID
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"u_bullet_ID", "U_BULLET_ID")]

    // class 0x178 System.String u_hit_effect
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"u_hit_effect", "U_HIT_EFFECT")]

    // class 0x180 System.String u_hit_sound
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"u_hit_sound", "U_HIT_SOUND")]

    // class 0x188 System.String u_atk_sound
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"u_atk_sound", "U_ATK_SOUND")]

    // class 0x190 System.String u_spell_sound
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"u_spell_sound", "U_SPELL_SOUND")]

    // class 0x198 System.String u_deploy_sound
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"u_deploy_sound", "U_DEPLOY_SOUND")]

    // struct 0x1A0 System.Single u_move_per
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_move_per", "U_MOVE_PER")]

    // struct 0x1A4 System.Single u_atk_preTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_atk_preTime", "U_ATK_PRE_TIME")]

    // struct 0x1A8 System.Single u_atk_aniTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_atk_aniTime", "U_ATK_ANI_TIME")]

    // struct 0x1AC System.Single u_spell_preTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_spell_preTime", "U_SPELL_PRE_TIME")]

    // struct 0x1B0 System.Single u_spell_aniTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_spell_aniTime", "U_SPELL_ANI_TIME")]

    // struct 0x1B4 System.Single u_radius
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"u_radius", "U_RADIUS")]

    // struct 0x1B8 System.Int32 u_weight
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_weight", "U_WEIGHT")]

    // struct 0x1BC System.Int32 u_atk_force
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"u_atk_force", "U_ATK_FORCE")]
    public partial class MonsterData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "MonsterData";
        //public static byte[] Static_ClassName { get; } = [77, 111, 110, 115, 116, 101, 114, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000124U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_MonsterData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_MonsterData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_MonsterData obj) => obj._ptr;
            public static implicit operator bool(Ptr_MonsterData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."MonsterData"]
    /// </summary>
    public partial class MonsterData
    {



        /// <summary>
        ///   System.Void .ctor(MonsterObject m, System.Int32 level, System.Int32 type, System.Boolean randomCheck)
        /// </summary>
        /// <param name="m">class MonsterObject</param>
        /// <param name="level">struct System.Int32</param>
        /// <param name="type">struct System.Int32</param>
        /// <param name="randomCheck">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        extern void CTOR(nint m, System.Int32 level, System.Int32 type, System.Boolean randomCheck);


        /// <summary>
        ///   System.Boolean <CheckUpConditions>b__98_0(Newtonsoft.Json.Linq.JToken t)
        /// </summary>
        /// <param name="t">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CheckUpConditions>b__98_0")]
        ///  extern System.Boolean <CHECK_UP_CONDITIONS>B__98_0 (nint t);


        /// <summary>
        ///   System.Void <SetShiner>g__SetMax|94_0(System.Int32 index, MonsterData.<>c__DisplayClass94_0& )
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="">struct MonsterData.<>c__DisplayClass94_0&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<SetShiner>g__SetMax|94_0")]
        ///  extern void <SET_SHINER>G__SET_MAX|94_0 (System.Int32 index, MonsterData.<>c__DisplayClass94_0& );


        /// <summary>
        /// static  System.Int32 CalculateTotalExp(System.Int32 lv)
        /// </summary>
        /// <param name="lv">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CalculateTotalExp")]
        /// static extern System.Int32 CALCULATE_TOTAL_EXP (System.Int32 lv);


        /// <summary>
        ///   System.Boolean CheckUpConditions(System.String& evolution)
        /// </summary>
        /// <param name="evolution">class System.String&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckUpConditions")]
        ///  extern System.Boolean CHECK_UP_CONDITIONS (nint evolution);


        /// <summary>
        /// static  MonsterData Clone(MonsterData data)
        /// </summary>
        /// <param name="data">class MonsterData</param>
        /// <returns>class MonsterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        /// static extern nint CLONE (nint data);


        /// <summary>
        ///   System.Void GetAbilities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAbilities")]
        extern void GET_ABILITIES();


        /// <summary>
        ///   System.Single GetGrowthValue(UnityEngine.Vector2 range)
        /// </summary>
        /// <param name="range">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Single</returns>
        
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGrowthValue")]
        // extern System.Single GET_GROWTH_VALUE(REF_MONO_VECTOR2 range);
        //add 0.95B
        extern PMonoArray<System.Single> GET_GROWTH_VALUE(REF_MONO_VECTOR2 range);

        //add 0.95B
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OrderGrowthValue")]
        extern void ORDER_GROWTH_VALUE(int rank, REF_MONO_VECTOR2 range, int type);


        //add 0.95B
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentBasicProperty")]
        extern void GetCurrentBasicProperty(MonsterObject.Ptr_MonsterObject m);
        /// <summary>
        ///   System.String GetProfessionalName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetProfessionalName")]
        ///  extern nint GET_PROFESSIONAL_NAME ();


        /// <summary>
        ///   System.Void InitRandomFeature(MonsterObject m)
        /// </summary>
        /// <param name="m">class MonsterObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitRandomFeature")]
        ///  extern void INIT_RANDOM_FEATURE (nint m);


        /// <summary>
        ///   System.Void OrderAbilityRank(System.Int32 num, System.Int32 rank)
        /// </summary>
        /// <param name="num">struct System.Int32</param>
        /// <param name="rank">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OrderAbilityRank")]
        ///  extern void ORDER_ABILITY_RANK (System.Int32 num, System.Int32 rank);


        /// <summary>
        ///   System.Single OrderGrowthValue(System.Int32 index, UnityEngine.Vector2 range)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="range">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OrderGrowthValue")]
        ///  extern System.Single ORDER_GROWTH_VALUE (System.Int32 index, UnityEngine.Vector2 range);


        /// <summary>
        ///   System.Void SetShiner(MonsterObject m)
        /// </summary>
        /// <param name="m">class MonsterObject</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetShiner")]
        extern void SET_SHINER(MonsterObject.Ptr_MonsterObject m);




        /// public static partial class Search_MonsterData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}