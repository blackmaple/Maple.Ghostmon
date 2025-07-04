using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AVGMonsterData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200004BU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 77, 111, 110, 115, 116, 101, 114, 68, 97, 116, 97])]


    // class 0x10 System.String uuid
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "uuid", "UUID")]

    // struct 0x18 System.Int32 level
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "level", "LEVEL", IsReadOnly = false)]

    // struct 0x1C System.Single hp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "hp", "HP", IsReadOnly = false)]

    // struct 0x20 System.Single maxhp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "maxhp", "MAXHP", IsReadOnly = false)]

    // struct 0x24 System.Single mp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "mp", "MP", IsReadOnly = false)]

    // struct 0x28 System.Single maxmp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "maxmp", "MAXMP", IsReadOnly = false)]

    // struct 0x2C System.Single exp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "exp", "EXP", IsReadOnly = false)]

    // struct 0x30 System.Single maxexp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "maxexp", "MAXEXP", IsReadOnly = false)]

    // struct 0x34 System.Single patk
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "patk", "PATK", IsReadOnly = false)]

    // struct 0x38 System.Single pdef
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "pdef", "PDEF", IsReadOnly = false)]

    // struct 0x3C System.Single mdef
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "mdef", "MDEF", IsReadOnly = false)]

    // struct 0x40 System.Single matk
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "matk", "MATK", IsReadOnly = false)]

    // struct 0x44 System.Single speed
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "speed", "SPEED", IsReadOnly = false)]

    // struct 0x48 System.Int32 criticalLevel
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "criticalLevel", "CRITICAL_LEVEL", IsReadOnly = false)]

    // struct 0x4C System.Single critical
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "critical", "CRITICAL", IsReadOnly = false)]

    // struct 0x50 System.Single dodge
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "dodge", "DODGE", IsReadOnly = false)]

    // struct 0x54 System.Single hit
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "hit", "HIT", IsReadOnly = false)]

    // class 0x58 System.Collections.Generic.List<System.Int32> quality
    // [MonoCollectorSearchFieldAttribute(typeof(nint), "quality", "QUALITY")]

    // struct 0x60 System.Boolean isMarked
    //[MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "isMarked", "IS_MARKED")]

    // struct 0x64 System.Int32 spaceDetailPos
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"spaceDetailPos", "SPACE_DETAIL_POS")]

    // struct 0x68 System.Single extraHp
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "extraHp", "EXTRA_HP", IsReadOnly = false)]

    // struct 0x6C System.Single originalPAttack
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "originalPAttack", "ORIGINAL_P_ATTACK")]

    //// struct 0x70 System.Single originalPDefence
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "originalPDefence", "ORIGINAL_P_DEFENCE")]

    //// struct 0x74 System.Single originalMAttack
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "originalMAttack", "ORIGINAL_M_ATTACK")]

    //// struct 0x78 System.Single originalMDefence
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "originalMDefence", "ORIGINAL_M_DEFENCE")]

    //// struct 0x7C System.Single originalSpeed
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "originalSpeed", "ORIGINAL_SPEED")]

    //// struct 0x80 System.Single originalMaxMp
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "originalMaxMp", "ORIGINAL_MAX_MP")]

    // struct 0x84 System.Single metalSkillChangeRate
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "metalSkillChangeRate", "METAL_SKILL_CHANGE_RATE")]

    //// struct 0x88 System.Single woodSkillChangeRate
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "woodSkillChangeRate", "WOOD_SKILL_CHANGE_RATE")]

    //// struct 0x8C System.Single waterSkillChangeRate
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "waterSkillChangeRate", "WATER_SKILL_CHANGE_RATE")]

    //// struct 0x90 System.Single fireSkillChangeRate
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "fireSkillChangeRate", "FIRE_SKILL_CHANGE_RATE")]

    //// struct 0x94 System.Single earthSkillChangeRate
    //[MonoCollectorSearchFieldAttribute(typeof(System.Single), "earthSkillChangeRate", "EARTH_SKILL_CHANGE_RATE")]

    // class 0x98 AVGMonsterConfig config
    [MonoCollectorSearchFieldAttribute(typeof(_AVGMonsterConfig.Ptr__AVGMonsterConfig), "config", "CONFIG")]

    // class 0xA0 System.Collections.Generic.List<AVGBaseSkill> skills
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<AVGBaseSkill.Ptr_AVGBaseSkill>), "skills", "SKILLS", IsReadOnly = false)]

    // class 0xA8 System.Collections.Generic.List<AVGBaseBuff> buffs
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<AVGBaseBuff.Ptr_AVGBaseBuff>), "buffs", "BUFFS", IsReadOnly = false)]

    // class 0xB0 System.Collections.Generic.List<AVGBaseSkill> skillPool
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<AVGBaseSkill.Ptr_AVGBaseSkill>), "skillPool", "SKILL_POOL", IsReadOnly = false)]

    // class 0xB8 MonsterStatusEffects <StatusEffects>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<StatusEffects>k__BackingField", "STATUS_EFFECTS")]
    public partial class AVGMonsterData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGMonsterData";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 77, 111, 110, 115, 116, 101, 114, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x0200004BU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGMonsterData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGMonsterData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGMonsterData obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGMonsterData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGMonsterData"]
    /// </summary>
    public partial class AVGMonsterData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   AVGMonsterData Clone()
        /// </summary>
        /// <returns>class AVGMonsterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();


        /// <summary>
        ///   System.Boolean get_IsDead()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsDead")]
        ///  extern System.Boolean GET_IS_DEAD ();


        /// <summary>
        ///   MonsterStatusEffects get_StatusEffects()
        /// </summary>
        /// <returns>class MonsterStatusEffects</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StatusEffects")]
        ///  extern nint GET_STATUS_EFFECTS ();


        /// <summary>
        ///   System.Void RecordOriginData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecordOriginData")]
        ///  extern void RECORD_ORIGIN_DATA ();


        /// <summary>
        ///   System.Void RefreshConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshConfig")]
        ///  extern void REFRESH_CONFIG ();


        /// <summary>
        ///   System.Void ResetAttributes(System.Boolean isEnd)
        /// </summary>
        /// <param name="isEnd">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetAttributes")]
        ///  extern void RESET_ATTRIBUTES (System.Boolean isEnd);


        /// <summary>
        ///   System.Void ResetEffectStatus(System.Boolean isResetTemp)
        /// </summary>
        /// <param name="isResetTemp">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetEffectStatus")]
        ///  extern void RESET_EFFECT_STATUS (System.Boolean isResetTemp);


        /// <summary>
        ///   System.Void set_StatusEffects(MonsterStatusEffects value)
        /// </summary>
        /// <param name="value">class MonsterStatusEffects</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_StatusEffects")]
        ///  extern void SET_STATUS_EFFECTS (nint value);




        /// public static partial class Search_AVGMonsterData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}