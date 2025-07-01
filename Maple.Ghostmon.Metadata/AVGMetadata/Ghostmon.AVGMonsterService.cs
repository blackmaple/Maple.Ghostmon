namespace Maple.Ghostmon.Metadata
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."AVGMonsterService"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200043FU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [65, 86, 71, 77, 111, 110, 115, 116, 101, 114, 83, 101, 114, 118, 105, 99, 101])]
    
    
    public partial class AVGMonsterService
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "AVGMonsterService";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 77, 111, 110, 115, 116, 101, 114, 83, 101, 114, 118, 105, 99, 101];

        //public const uint Const_TypeToken = 0x0200043FU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGMonsterService(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGMonsterService(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGMonsterService obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGMonsterService obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Ghostmon"."AVGMonsterService"]
        /// </summary>
        public partial class AVGMonsterService
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   System.Boolean AddHandBookId(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHandBookId")]
            ///  extern System.Boolean ADD_HAND_BOOK_ID (System.UInt64 id);

            
            /// <summary>
            ///   System.Void AddMonster(AVGMonsterData monster, System.Boolean isKickOut)
            /// </summary>
            /// <param name="monster">class AVGMonsterData</param>
            /// <param name="isKickOut">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonster")]
            ///  extern void ADD_MONSTER (nint monster, System.Boolean isKickOut);

            
            /// <summary>
            ///   System.Void CalculateMonsterStats(AVGMonsterData monster, System.Boolean isNeedUpdate)
            /// </summary>
            /// <param name="monster">class AVGMonsterData</param>
            /// <param name="isNeedUpdate">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CalculateMonsterStats")]
            ///  extern void CALCULATE_MONSTER_STATS (nint monster, System.Boolean isNeedUpdate);

            
            /// <summary>
            ///   System.Boolean CheckIsNeedRecovery()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckIsNeedRecovery")]
            ///  extern System.Boolean CHECK_IS_NEED_RECOVERY ();

            
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GainExp(AVGMonsterData monster, System.Int32 amount)
            /// </summary>
            /// <param name="monster">class AVGMonsterData</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainExp")]
            ///  extern nint GAIN_EXP (nint monster, System.Int32 amount);

            
            /// <summary>
            ///   System.Int32 GetExpForNextLevel(AVGMonsterData monster)
            /// </summary>
            /// <param name="monster">class AVGMonsterData</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExpForNextLevel")]
            ///  extern System.Int32 GET_EXP_FOR_NEXT_LEVEL (nint monster);

            
            /// <summary>
            ///   System.Single GetNormalizedStatValue(StatType statType, System.Int32 currentLevel, System.Single currentValue)
            /// </summary>
            /// <param name="statType">enum StatType</param>
            /// <param name="currentLevel">struct System.Int32</param>
            /// <param name="currentValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNormalizedStatValue")]
            ///  extern System.Single GET_NORMALIZED_STAT_VALUE (StatType statType, System.Int32 currentLevel, System.Single currentValue);

            
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GetPropertyChangeValue(AVGMonsterData monster, System.Int32 levelChange)
            /// </summary>
            /// <param name="monster">class AVGMonsterData</param>
            /// <param name="levelChange">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPropertyChangeValue")]
            ///  extern nint GET_PROPERTY_CHANGE_VALUE (nint monster, System.Int32 levelChange);

            
            /// <summary>
            ///   System.Boolean IsExitHandBookId(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsExitHandBookId")]
            ///  extern System.Boolean IS_EXIT_HAND_BOOK_ID (System.UInt64 id);

            
            /// <summary>
            ///   System.Void PermanentBoostHP(AVGMonsterData monster, System.Int32 value)
            /// </summary>
            /// <param name="monster">class AVGMonsterData</param>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PermanentBoostHP")]
            ///  extern void PERMANENT_BOOST_HP (nint monster, System.Int32 value);

            
            /// <summary>
            ///   System.Void RecoveryAll(System.Int32 delay)
            /// </summary>
            /// <param name="delay">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecoveryAll")]
            ///  extern void RECOVERY_ALL (System.Int32 delay);

            
            /// <summary>
            ///   System.Void SetAppointSkill(AVGMonsterData monster, System.Collections.Generic.List<System.UInt64> appointSKillList)
            /// </summary>
            /// <param name="monster">class AVGMonsterData</param>
            /// <param name="appointSKillList">class System.Collections.Generic.List<System.UInt64></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetAppointSkill")]
            ///  extern void SET_APPOINT_SKILL (nint monster, nint appointSKillList);
            
            

            
            /// public static partial class Search_AVGMonsterService
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}