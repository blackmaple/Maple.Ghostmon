using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."RogueDataManager"]
    /// [Ghostmon.Framework.Singleton<RogueDataManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200020FU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [82, 111, 103, 117, 101, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114])]

    //  class static RogueDataManager instance
    [MonoCollectorSearchFieldAttribute(typeof(RogueDataManager.Ptr_RogueDataManager), "instance", "INSTANCE", true)]

    // class 0x10 Ghostmon.RogueData rogueData
    [MonoCollectorSearchFieldAttribute(typeof(RogueData.Ptr_RogueData), "rogueData", "ROGUE_DATA")]
    public partial class RogueDataManager
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "RogueDataManager";
        //public static byte[] Static_ClassName { get; } = [82, 111, 103, 117, 101, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x0200020FU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RogueDataManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RogueDataManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RogueDataManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_RogueDataManager obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."RogueDataManager"]
    /// </summary>
    public partial class RogueDataManager
    {



        /// <summary>
        /// static  System.Single <MonsterEvolve>g__ReMapNumber|23_1(System.Single value, UnityEngine.Vector2 a, UnityEngine.Vector2 b)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <param name="a">struct UnityEngine.Vector2</param>
        /// <param name="b">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<MonsterEvolve>g__ReMapNumber|23_1")]
        /// static extern System.Single <MONSTER_EVOLVE>G__RE_MAP_NUMBER|23_1 (System.Single value, UnityEngine.Vector2 a, UnityEngine.Vector2 b);


        /// <summary>
        ///   System.Boolean <RoleUpLev>b__15_0(Newtonsoft.Json.Linq.JToken t)
        /// </summary>
        /// <param name="t">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RoleUpLev>b__15_0")]
        ///  extern System.Boolean <ROLE_UP_LEV>B__15_0 (nint t);


        /// <summary>
        ///   System.Void AddDispatchData(MonsterData monsterData)
        /// </summary>
        /// <param name="monsterData">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDispatchData")]
        ///  extern void ADD_DISPATCH_DATA (nint monsterData);


        /// <summary>
        ///   System.Void AddMonster(MonsterData monster)
        /// </summary>
        /// <param name="monster">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonster")]
        extern void ADD_MONSTER(MonsterData.Ptr_MonsterData monster);


        /// <summary>
        ///   System.Single CalculateAddition(System.Collections.Generic.List<System.UInt64> list)
        /// </summary>
        /// <param name="list">class System.Collections.Generic.List<System.UInt64></param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CalculateAddition")]
        ///  extern System.Single CALCULATE_ADDITION (nint list);


        /// <summary>
        ///   System.Void CancelTopRecord(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelTopRecord")]
        ///  extern void CANCEL_TOP_RECORD (System.UInt64 id);


        /// <summary>
        ///   System.Boolean CheckIsExitDestiny(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckIsExitDestiny")]
        ///  extern System.Boolean CHECK_IS_EXIT_DESTINY (System.UInt64 id);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask CompleteChallenge()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompleteChallenge")]
        ///  extern Cysharp.Threading.Tasks.UniTask COMPLETE_CHALLENGE ();


        /// <summary>
        /// static  RogueDataManager CreateInstance()
        /// </summary>
        /// <returns>class RogueDataManager</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInstance")]
        /// static extern nint CREATE_INSTANCE ();


        /// <summary>
        ///   System.Void CreateNewData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateNewData")]
        ///  extern void CREATE_NEW_DATA ();


        /// <summary>
        ///   System.Collections.Generic.List<Ghostmon.CommonData> DealDropData(System.UInt64 ID, System.Boolean value)
        /// </summary>
        /// <param name="ID">struct System.UInt64</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>class System.Collections.Generic.List<Ghostmon.CommonData></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DealDropData")]
        ///  extern nint DEAL_DROP_DATA (System.UInt64 ID, System.Boolean value);


        /// <summary>
        ///   System.Boolean EmployMonster(Ghostmon.EmployeeData data)
        /// </summary>
        /// <param name="data">class Ghostmon.EmployeeData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("EmployMonster")]
        ///  extern System.Boolean EMPLOY_MONSTER (nint data);


        /// <summary>
        ///   System.Void EndOfLongDispatch()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("EndOfLongDispatch")]
        ///  extern void END_OF_LONG_DISPATCH ();


        /// <summary>
        ///   System.Void GainAbilityBook(System.UInt64 id, System.Int32 num)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainAbilityBook")]
        extern void GAIN_ABILITY_BOOK(System.UInt64 id, System.Int32 num);


        /// <summary>
        ///   System.Void GainCharms(System.UInt64 id, System.Int32 num)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainCharms")]
        extern void GAIN_CHARMS(System.UInt64 id, System.Int32 num);


        /// <summary>
        ///   System.Void GainCoins(System.Int32 num)
        /// </summary>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainCoins")]
        extern void GAIN_COINS(System.Int32 num);


        /// <summary>
        ///   System.Void GainItem(System.Int32 type, System.UInt64 id, System.Int32 num)
        /// </summary>
        /// <param name="type">struct System.Int32</param>
        /// <param name="id">struct System.UInt64</param>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GainItem")]
        extern void GAIN_ITEM(System.Int32 type, System.UInt64 id, System.Int32 num);


        /// <summary>
        /// static  RogueDataManager get_Instance()
        /// </summary>
        /// <returns>class RogueDataManager</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
        /// static extern nint GET_INSTANCE ();


        /// <summary>
        ///   System.Int32 GetCurItemNum(System.Int32 type, System.UInt64 id)
        /// </summary>
        /// <param name="type">struct System.Int32</param>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurItemNum")]
        extern System.Int32 GET_CUR_ITEM_NUM(System.Int32 type, System.UInt64 id);


        /// <summary>
        ///   System.Void GetDestiny(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDestiny")]
        ///  extern void GET_DESTINY (System.UInt64 id);


        /// <summary>
        ///   System.Void GetDismissAward(System.Collections.Generic.List<MonsterData> monsters, System.Action callback)
        /// </summary>
        /// <param name="monsters">class System.Collections.Generic.List<MonsterData></param>
        /// <param name="callback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDismissAward")]
        ///  extern void GET_DISMISS_AWARD (nint monsters, nint callback);


        /// <summary>
        ///   System.Int32 GetParameter(StratageEvent stratage)
        /// </summary>
        /// <param name="stratage">enum StratageEvent</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetParameter")]
        ///  extern System.Int32 GET_PARAMETER (StratageEvent stratage);


        /// <summary>
        ///   System.Void GetShelterExp(System.Int32 exp)
        /// </summary>
        /// <param name="exp">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetShelterExp")]
        extern void GET_SHELTER_EXP(System.Int32 exp);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask InitRougeData()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitRougeData")]
        ///  extern Cysharp.Threading.Tasks.UniTask INIT_ROUGE_DATA ();


        /// <summary>
        /// static  System.Boolean IsActive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
        /// static extern System.Boolean IS_ACTIVE ();


        /// <summary>
        ///   System.Void LoadManual()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadManual")]
        ///  extern void LOAD_MANUAL ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask MonsterEvolve(MonsterData preData, System.String evoName)
        /// </summary>
        /// <param name="preData">class MonsterData</param>
        /// <param name="evoName">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterEvolve")]
        ///  extern Cysharp.Threading.Tasks.UniTask MONSTER_EVOLVE (nint preData, nint evoName);


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove")]
        ///  extern void ON_REMOVE ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask<Ghostmon.RogueRecord> RecordGameData()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<Ghostmon.RogueRecord></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecordGameData")]
        ///  extern Cysharp.Threading.Tasks.UniTask<Ghostmon.RogueRecord> RECORD_GAME_DATA ();


        /// <summary>
        ///   System.Void ReduceItem(System.Int32 type, System.UInt64 id, System.Int32 num)
        /// </summary>
        /// <param name="type">struct System.Int32</param>
        /// <param name="id">struct System.UInt64</param>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReduceItem")]
        ///  extern void REDUCE_ITEM (System.Int32 type, System.UInt64 id, System.Int32 num);


        /// <summary>
        ///   System.Void Remove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
        ///  extern void REMOVE ();


        /// <summary>
        ///   System.Void RemoveMonster(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMonster")]
        ///  extern void REMOVE_MONSTER (System.UInt64 id);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask RoleGainExp(System.Int32 exp)
        /// </summary>
        /// <param name="exp">struct System.Int32</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RoleGainExp")]
        ///  extern Cysharp.Threading.Tasks.UniTask ROLE_GAIN_EXP (System.Int32 exp);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask RoleUpLev()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RoleUpLev")]
        ///  extern Cysharp.Threading.Tasks.UniTask ROLE_UP_LEV ();


        /// <summary>
        ///   System.Void SaveManual()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SaveManual")]
        ///  extern void SAVE_MANUAL ();


        /// <summary>
        ///   System.Void SetMonsterInfo(MonsterData monster)
        /// </summary>
        /// <param name="monster">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterInfo")]
        extern void SET_MONSTER_INFO(MonsterData.Ptr_MonsterData monster);


        /// <summary>
        ///   System.Void SetMonsterName(MonsterData monsterData)
        /// </summary>
        /// <param name="monsterData">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMonsterName")]
        ///  extern void SET_MONSTER_NAME (nint monsterData);


        /// <summary>
        ///   System.Boolean TopRecord(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("TopRecord")]
        ///  extern System.Boolean TOP_RECORD (System.UInt64 id);


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask UnlockMonster(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockMonster")]
        ///  extern Cysharp.Threading.Tasks.UniTask UNLOCK_MONSTER (System.UInt64 id);


        /// <summary>
        ///   System.Boolean UpIncome()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpIncome")]
        ///  extern System.Boolean UP_INCOME ();


        /// <summary>
        ///   System.Void UpShelter()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpShelter")]
        ///  extern void UP_SHELTER ();


        /// <summary>
        ///   System.Boolean UpShop()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpShop")]
        ///  extern System.Boolean UP_SHOP ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_RogueDataManager))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_RogueDataManager))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void MonsterLevelUp(MonsterData data)
        /// </summary>
        /// <param name="data">class MonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterLevelUp", Search = typeof(Search_RogueDataManager))]
        ///  extern void MONSTER_LEVEL_UP_00 (nint data);


        /// <summary>
        ///   System.Void MonsterLevelUp(MonsterData data, System.Int32 value)
        /// </summary>
        /// <param name="data">class MonsterData</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("MonsterLevelUp", Search = typeof(Search_RogueDataManager))]
        extern void MONSTER_LEVEL_UP_01(nint data, System.Int32 value);


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_RogueDataManager))]
        ///  extern void ON_INIT_00 ();


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_RogueDataManager))]
        ///  extern void ON_INIT_01 ();


        public static partial class Search_RogueDataManager
        {
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
            ///   System.Void MonsterLevelUp(MonsterData data)
            /// </summary>
            /// public static bool MONSTER_LEVEL_UP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MonsterLevelUp", "MonsterData");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void MonsterLevelUp(MonsterData data, System.Int32 value)
            /// </summary>
            public static bool MONSTER_LEVEL_UP_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MonsterLevelUp", "MonsterData", "System.Int32");
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
        }

    }


}