namespace Maple.Ghostmon.Metadata
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."AVGUserDataManager"]
    /// [Ghostmon.Framework.Singleton<Ghostmon.AVGUserDataManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000444U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [65, 86, 71, 85, 115, 101, 114, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114])]
                
    //  class static Ghostmon.AVGUserDataManager instance
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"instance", "INSTANCE", true)]
                
    // class 0x10 Ghostmon.AVGUserData userData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"userData", "USER_DATA")]
    public partial class AVGUserDataManager
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "AVGUserDataManager";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 85, 115, 101, 114, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x02000444U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGUserDataManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGUserDataManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGUserDataManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGUserDataManager obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Ghostmon"."AVGUserDataManager"]
        /// </summary>
        public partial class AVGUserDataManager
        { 

            
            
            /// <summary>
            ///   System.Void AddGold(System.Int32 num)
            /// </summary>
            /// <param name="num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGold")]
            ///  extern void ADD_GOLD (System.Int32 num);

            
            /// <summary>
            ///   System.Void AddMonster(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonster")]
            ///  extern void ADD_MONSTER (nint monster);

            
            /// <summary>
            ///   System.Boolean BattleMonsterGainFavority(System.Boolean isNPC)
            /// </summary>
            /// <param name="isNPC">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("BattleMonsterGainFavority")]
            ///  extern System.Boolean BATTLE_MONSTER_GAIN_FAVORITY (System.Boolean isNPC);

            
            /// <summary>
            ///   System.Boolean CheckMonsterIsFull()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckMonsterIsFull")]
            ///  extern System.Boolean CHECK_MONSTER_IS_FULL ();

            
            /// <summary>
            /// static  Ghostmon.AVGUserDataManager CreateInstance()
            /// </summary>
            /// <returns>class Ghostmon.AVGUserDataManager</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInstance")]
            /// static extern nint CREATE_INSTANCE ();

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask CreateNewData()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateNewData")]
            ///  extern Cysharp.Threading.Tasks.UniTask CREATE_NEW_DATA ();

            
            /// <summary>
            ///   System.Void DropMonster(System.UInt64 id)
            /// </summary>
            /// <param name="id">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DropMonster")]
            ///  extern void DROP_MONSTER (System.UInt64 id);

            
            /// <summary>
            ///   System.Int32[] GainExpAfterBattle(System.Int32 bLevel, System.Single bType)
            /// </summary>
            /// <param name="bLevel">struct System.Int32</param>
            /// <param name="bType">struct System.Single</param>
            /// <returns>class System.Int32[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainExpAfterBattle")]
            ///  extern nint GAIN_EXP_AFTER_BATTLE (System.Int32 bLevel, System.Single bType);

            
            /// <summary>
            ///   System.Int32[] GainExpAfterMapSeal(System.Int32 bLevel)
            /// </summary>
            /// <param name="bLevel">struct System.Int32</param>
            /// <returns>class System.Int32[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainExpAfterMapSeal")]
            ///  extern nint GAIN_EXP_AFTER_MAP_SEAL (System.Int32 bLevel);

            
            /// <summary>
            /// static  Ghostmon.AVGUserDataManager get_Instance()
            /// </summary>
            /// <returns>class Ghostmon.AVGUserDataManager</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
            /// static extern nint GET_INSTANCE ();

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask InitUserData()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitUserData")]
            ///  extern Cysharp.Threading.Tasks.UniTask INIT_USER_DATA ();

            
            /// <summary>
            /// static  System.Boolean IsActive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
            /// static extern System.Boolean IS_ACTIVE ();

            
            /// <summary>
            ///   System.Void LoadAuto()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAuto")]
            ///  extern void LOAD_AUTO ();

            
            /// <summary>
            ///   System.Void LoadManual(System.Int32 index, System.Boolean isShowError)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="isShowError">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadManual")]
            ///  extern void LOAD_MANUAL (System.Int32 index, System.Boolean isShowError);

            
            /// <summary>
            ///   System.Void MonsterEvolve(MonsterData preData, System.String evoName)
            /// </summary>
            /// <param name="preData">class MonsterData</param>
            /// <param name="evoName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterEvolve")]
            ///  extern void MONSTER_EVOLVE (nint preData, nint evoName);

            
            /// <summary>
            ///   System.Boolean MonsterGainFavority(MonsterData data, System.Int32 value)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterGainFavority")]
            ///  extern System.Boolean MONSTER_GAIN_FAVORITY (nint data, System.Int32 value);

            
            /// <summary>
            ///   System.Void MonsterGainsExp(MonsterData data, System.Int32 exp)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <param name="exp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterGainsExp")]
            ///  extern void MONSTER_GAINS_EXP (nint data, System.Int32 exp);

            
            /// <summary>
            ///   System.Void MonsterLevelUp(MonsterData data)
            /// </summary>
            /// <param name="data">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterLevelUp")]
            ///  extern void MONSTER_LEVEL_UP (nint data);

            
            /// <summary>
            ///   System.Void OnRemove()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove")]
            ///  extern void ON_REMOVE ();

            
            /// <summary>
            ///   System.Void RefreshUserData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshUserData")]
            ///  extern void REFRESH_USER_DATA ();

            
            /// <summary>
            ///   System.Void Remove()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
            ///  extern void REMOVE ();

            
            /// <summary>
            ///   System.Boolean RoleGainExp(System.Int32 exp)
            /// </summary>
            /// <param name="exp">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RoleGainExp")]
            ///  extern System.Boolean ROLE_GAIN_EXP (System.Int32 exp);

            
            /// <summary>
            ///   System.Void RoleUpLev()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RoleUpLev")]
            ///  extern void ROLE_UP_LEV ();

            
            /// <summary>
            ///   System.Void SavaAuto()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SavaAuto")]
            ///  extern void SAVA_AUTO ();

            
            /// <summary>
            ///   System.Void SaveManual(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SaveManual")]
            ///  extern void SAVE_MANUAL (System.Int32 index);

            
            /// <summary>
            ///   System.Void SealMonster(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SealMonster")]
            ///  extern void SEAL_MONSTER (nint monster);

            
            /// <summary>
            ///   System.Void SetMonsterInfo(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterInfo")]
            ///  extern void SET_MONSTER_INFO (nint monster);

            
            /// <summary>
            ///   System.Void SetMonsterName(MonsterData monsterData)
            /// </summary>
            /// <param name="monsterData">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterName")]
            ///  extern void SET_MONSTER_NAME (nint monsterData);

            
            /// <summary>
            ///   System.Void SetMonsterPro(MonsterData monster)
            /// </summary>
            /// <param name="monster">class MonsterData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterPro")]
            ///  extern void SET_MONSTER_PRO (nint monster);

            
            /// <summary>
            ///   System.Void SubGold(System.Int32 percent)
            /// </summary>
            /// <param name="percent">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SubGold")]
            ///  extern void SUB_GOLD (System.Int32 percent);

            
            /// <summary>
            ///   System.Void UpdateRealTime(System.Single deltaTime)
            /// </summary>
            /// <param name="deltaTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateRealTime")]
            ///  extern void UPDATE_REAL_TIME (System.Single deltaTime);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGUserDataManager))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_AVGUserDataManager))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void OnInit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_AVGUserDataManager))]
            ///  extern void ON_INIT_00 ();

            
            /// <summary>
            ///   System.Void OnInit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_AVGUserDataManager))]
            ///  extern void ON_INIT_01 ();

            
            /// public static partial class Search_AVGUserDataManager
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnInit()
                    /// </summary>
                    /// public static bool ON_INIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnInit()
                    /// </summary>
                    /// public static bool ON_INIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}