
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
    /// static class ["Assembly-CSharp.dll".""."ConfigDataStore"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000122U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [67, 111, 110, 102, 105, 103, 68, 97, 116, 97, 83, 116, 111, 114, 101])]

    //  class static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.UInt64,Newtonsoft.Json.Linq.JObject>> configStore
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<PMonoString, PMonoDictionary_Ghostmon<UInt64, JObject.Ptr_JObject>>), "configStore", "CONFIG_STORE", true)]

    //  struct static System.Boolean cfgLoaded
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "cfgLoaded", "CFG_LOADED", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,MonsterObject> monster_cfg_store
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<PMonoString, MonsterObject.Ptr_MonsterObject>), "monster_cfg_store", "MONSTER_CFG_STORE", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,CollectionObject> collection_cfg_store
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<PMonoString, CollectionObject.Ptr_CollectionObject>), "collection_cfg_store", "COLLECTION_CFG_STORE", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,SpriteObject> sprite_cfg_store
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<PMonoString, SpriteObject.Ptr_SpriteObject>), "sprite_cfg_store", "SPRITE_CFG_STORE", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,SkillObject> skill_cfg_store
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<PMonoString, SkillObject.Ptr_SkillObject>), "skill_cfg_store", "SKILL_CFG_STORE", true)]

    //  class static System.Collections.Generic.List<System.UInt64> AbilityBufferRank1
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"AbilityBufferRank1", "ABILITY_BUFFER_RANK1", true)]

    //  class static System.Collections.Generic.List<System.UInt64> AbilityBufferRank2
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"AbilityBufferRank2", "ABILITY_BUFFER_RANK2", true)]

    //  class static System.Collections.Generic.List<System.UInt64> AbilityBufferRank3
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"AbilityBufferRank3", "ABILITY_BUFFER_RANK3", true)]

    //  class static System.Collections.Generic.List<System.UInt64> AbilityBufferRank4
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"AbilityBufferRank4", "ABILITY_BUFFER_RANK4", true)]

    //  class static System.Collections.Generic.List<System.UInt64> AbilityBufferRank5
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"AbilityBufferRank5", "ABILITY_BUFFER_RANK5", true)]

    //  class static ToolGood.Words.IllegalWordsSearch illegalWordsSearch
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"illegalWordsSearch", "ILLEGAL_WORDS_SEARCH", true)]

    public partial class ConfigDataStore
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ConfigDataStore";
        //public static byte[] Static_ClassName { get; } = [67, 111, 110, 102, 105, 103, 68, 97, 116, 97, 83, 116, 111, 114, 101];

        //public const uint Const_TypeToken = 0x02000122U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ConfigDataStore(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ConfigDataStore(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ConfigDataStore obj) => obj._ptr;
            public static implicit operator bool(Ptr_ConfigDataStore obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."ConfigDataStore"]
    /// </summary>
    public partial class ConfigDataStore
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        /// static  System.Boolean CheckIllegalWords(System.String str)
        /// </summary>
        /// <param name="str">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckIllegalWords")]
        /// static extern System.Boolean CHECK_ILLEGAL_WORDS (nint str);


        /// <summary>
        /// static  System.Boolean CheckKeyExist(System.String sheetName, System.UInt64 configID)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="configID">struct System.UInt64</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckKeyExist")]
        /// static extern System.Boolean CHECK_KEY_EXIST (nint sheetName, System.UInt64 configID);


        /// <summary>
        /// static  System.Collections.Generic.List<System.UInt64> GetAbilityBuffers(System.Int32 rank)
        /// </summary>
        /// <param name="rank">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.List<System.UInt64></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAbilityBuffers")]
        /// static extern nint GET_ABILITY_BUFFERS (System.Int32 rank);


        /// <summary>
        /// static  System.Collections.Generic.List<T> GetAllData(System.String sheetName)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <returns>class System.Collections.Generic.List<T></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllData")]
        /// static extern nint GET_ALL_DATA (nint sheetName);


        /// <summary>
        /// static  System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> GetAllDataJToken(System.String sheetName, System.String searchKey)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey">class System.String</param>
        /// <returns>class System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllDataJToken")]
        /// static extern nint GET_ALL_DATA_J_TOKEN (nint sheetName, nint searchKey);


        /// <summary>
        /// static  System.Collections.Generic.List<T> GetAllDataLimit(System.String sheetName, System.String searchKey, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey">class System.String</param>
        /// <param name="predicate">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <returns>class System.Collections.Generic.List<T></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllDataLimit")]
        /// static extern nint GET_ALL_DATA_LIMIT (nint sheetName, nint searchKey, nint predicate);


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask<CollectionObject> GetCollectionConfig(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<CollectionObject></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCollectionConfig")]
        /// static extern Cysharp.Threading.Tasks.UniTask<CollectionObject> GET_COLLECTION_CONFIG (nint name);


        /// <summary>
        /// static  T GetDataJObject(System.String sheetName, System.UInt64 configID)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="configID">struct System.UInt64</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDataJObject")]
        /// static extern nint GET_DATA_J_OBJECT (nint sheetName, System.UInt64 configID);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JToken GetDataJToken(System.String sheetName, System.UInt64 configID, System.String searchKey)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="configID">struct System.UInt64</param>
        /// <param name="searchKey">class System.String</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDataJToken")]
        /// static extern nint GET_DATA_J_TOKEN (nint sheetName, System.UInt64 configID, nint searchKey);


        /// <summary>
        /// static  System.Collections.Generic.List<T> GetDataList(System.String sheetName, System.Collections.Generic.List<System.UInt64> configIDs)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="configIDs">class System.Collections.Generic.List<System.UInt64></param>
        /// <returns>class System.Collections.Generic.List<T></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDataList")]
        /// static extern nint GET_DATA_LIST (nint sheetName, nint configIDs);


        /// <summary>
        /// static  System.Int32 GetDataListLength(System.String sheetName)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDataListLength")]
        /// static extern System.Int32 GET_DATA_LIST_LENGTH (nint sheetName);


        /// <summary>
        /// static  System.Collections.Generic.List<Ghostmon.CommonData> GetDropConfig(System.UInt64 ID)
        /// </summary>
        /// <param name="ID">struct System.UInt64</param>
        /// <returns>class System.Collections.Generic.List<Ghostmon.CommonData></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDropConfig")]
        /// static extern nint GET_DROP_CONFIG (System.UInt64 ID);


        /// <summary>
        /// static  System.String GetLanguageText(System.UInt64 Id)
        /// </summary>
        /// <param name="Id">struct System.UInt64</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLanguageText")]
        /// static extern nint GET_LANGUAGE_TEXT (System.UInt64 Id);


        /// <summary>
        /// static  System.String GetLanguageTrans(System.String sheetName, System.UInt64 configID, System.String searchKey)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="configID">struct System.UInt64</param>
        /// <param name="searchKey">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLanguageTrans")]
        /// static extern nint GET_LANGUAGE_TRANS (nint sheetName, System.UInt64 configID, nint searchKey);


        /// <summary>
        /// static  System.Collections.Generic.List<T> GetLimitDataList(System.String sheetName, System.String searchKey, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey">class System.String</param>
        /// <param name="predicate">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <returns>class System.Collections.Generic.List<T></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLimitDataList")]
        /// static extern nint GET_LIMIT_DATA_LIST (nint sheetName, nint searchKey, nint predicate);


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask<MonsterObject> GetMonsterConfig(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<MonsterObject></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMonsterConfig")]
        /// static extern Cysharp.Threading.Tasks.UniTask<MonsterObject> GET_MONSTER_CONFIG (nint name);


        /// <summary>
        /// static  System.String GetSheetConfigFolder()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSheetConfigFolder")]
        /// static extern nint GET_SHEET_CONFIG_FOLDER ();


        /// <summary>
        /// static  System.Collections.Generic.Dictionary<System.String,System.String> GetSheetFileList()
        /// </summary>
        /// <returns>class System.Collections.Generic.Dictionary<System.String,System.String></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSheetFileList")]
        /// static extern nint GET_SHEET_FILE_LIST ();


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask<SkillObject> GetSkillConfig(System.String name, System.String suffix)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="suffix">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<SkillObject></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSkillConfig")]
        /// static extern Cysharp.Threading.Tasks.UniTask<SkillObject> GET_SKILL_CONFIG (nint name, nint suffix);


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask<SpriteObject> GetSpriteConfig(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<SpriteObject></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpriteConfig")]
        /// static extern Cysharp.Threading.Tasks.UniTask<SpriteObject> GET_SPRITE_CONFIG (nint name);


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask LoadAllConfig()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAllConfig")]
        /// static extern Cysharp.Threading.Tasks.UniTask LOAD_ALL_CONFIG ();


        /// <summary>
        /// static  System.Void LoadIllegalWordsConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadIllegalWordsConfig")]
        /// static extern void LOAD_ILLEGAL_WORDS_CONFIG ();



        /// <summary>
        /// static  System.UInt64 GetLimitConfigID(System.String sheetName, System.String searchKey1, System.String searchKey2, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate2)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey1">class System.String</param>
        /// <param name="searchKey2">class System.String</param>
        /// <param name="predicate1">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <param name="predicate2">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLimitConfigID", Search = typeof(Search_ConfigDataStore))]
        /// static extern System.UInt64 GET_LIMIT_CONFIG_ID_00 (nint sheetName, nint searchKey1, nint searchKey2, nint predicate1, nint predicate2);


        /// <summary>
        /// static  System.UInt64 GetLimitConfigID(System.String sheetName, System.String searchKey1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey1">class System.String</param>
        /// <param name="predicate1">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLimitConfigID", Search = typeof(Search_ConfigDataStore))]
        /// static extern System.UInt64 GET_LIMIT_CONFIG_ID_01 (nint sheetName, nint searchKey1, nint predicate1);


        /// <summary>
        /// static  System.Collections.Generic.List<System.UInt64> GetLimitConfigIDList(System.String sheetName, System.String searchKey, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey">class System.String</param>
        /// <param name="predicate">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <returns>class System.Collections.Generic.List<System.UInt64></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLimitConfigIDList", Search = typeof(Search_ConfigDataStore))]
        /// static extern nint GET_LIMIT_CONFIG_ID_LIST_00 (nint sheetName, nint searchKey, nint predicate);


        /// <summary>
        /// static  System.Collections.Generic.List<System.UInt64> GetLimitConfigIDList(System.String sheetName, System.String searchKey1, System.String searchKey2, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate2)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey1">class System.String</param>
        /// <param name="searchKey2">class System.String</param>
        /// <param name="predicate1">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <param name="predicate2">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <returns>class System.Collections.Generic.List<System.UInt64></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLimitConfigIDList", Search = typeof(Search_ConfigDataStore))]
        /// static extern nint GET_LIMIT_CONFIG_ID_LIST_01 (nint sheetName, nint searchKey1, nint searchKey2, nint predicate1, nint predicate2);


        /// <summary>
        /// static  System.Collections.Generic.List<System.UInt64> GetLimitConfigIDList(System.String sheetName, System.String searchKey1, System.String searchKey2, System.String searchKey3, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate2, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate3)
        /// </summary>
        /// <param name="sheetName">class System.String</param>
        /// <param name="searchKey1">class System.String</param>
        /// <param name="searchKey2">class System.String</param>
        /// <param name="searchKey3">class System.String</param>
        /// <param name="predicate1">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <param name="predicate2">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <param name="predicate3">class System.Predicate<Newtonsoft.Json.Linq.JToken></param>
        /// <returns>class System.Collections.Generic.List<System.UInt64></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLimitConfigIDList", Search = typeof(Search_ConfigDataStore))]
        /// static extern nint GET_LIMIT_CONFIG_ID_LIST_02 (nint sheetName, nint searchKey1, nint searchKey2, nint searchKey3, nint predicate1, nint predicate2, nint predicate3);


        /// public static partial class Search_ConfigDataStore
        /// {
        /// 
        ///     

        /// <summary>
        /// static  System.UInt64 GetLimitConfigID(System.String sheetName, System.String searchKey1, System.String searchKey2, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate2)
        /// </summary>
        /// public static bool GET_LIMIT_CONFIG_ID_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLimitConfigID", "System.String", "System.String", "System.String", "System.Predicate<Newtonsoft.Json.Linq.JToken>", "System.Predicate<Newtonsoft.Json.Linq.JToken>");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.UInt64 GetLimitConfigID(System.String sheetName, System.String searchKey1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1)
        /// </summary>
        /// public static bool GET_LIMIT_CONFIG_ID_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLimitConfigID", "System.String", "System.String", "System.Predicate<Newtonsoft.Json.Linq.JToken>");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Collections.Generic.List<System.UInt64> GetLimitConfigIDList(System.String sheetName, System.String searchKey, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate)
        /// </summary>
        /// public static bool GET_LIMIT_CONFIG_ID_LIST_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLimitConfigIDList", "System.String", "System.String", "System.Predicate<Newtonsoft.Json.Linq.JToken>");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Collections.Generic.List<System.UInt64> GetLimitConfigIDList(System.String sheetName, System.String searchKey1, System.String searchKey2, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate2)
        /// </summary>
        /// public static bool GET_LIMIT_CONFIG_ID_LIST_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLimitConfigIDList", "System.String", "System.String", "System.String", "System.Predicate<Newtonsoft.Json.Linq.JToken>", "System.Predicate<Newtonsoft.Json.Linq.JToken>");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Collections.Generic.List<System.UInt64> GetLimitConfigIDList(System.String sheetName, System.String searchKey1, System.String searchKey2, System.String searchKey3, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate1, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate2, System.Predicate<Newtonsoft.Json.Linq.JToken> predicate3)
        /// </summary>
        /// public static bool GET_LIMIT_CONFIG_ID_LIST_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLimitConfigIDList", "System.String", "System.String", "System.String", "System.String", "System.Predicate<Newtonsoft.Json.Linq.JToken>", "System.Predicate<Newtonsoft.Json.Linq.JToken>", "System.Predicate<Newtonsoft.Json.Linq.JToken>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}