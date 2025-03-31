using Maple.Ghostmon.Metadata.MetadataModel.UniTask;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// static class ["Assembly-CSharp.dll"."Ghostmon"."LoadUtils"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200022FU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [76, 111, 97, 100, 85, 116, 105, 108, 115])]

    //  class static System.Collections.Generic.Dictionary<System.String,Ghostmon.MyAssetInfo> assetInfoDic
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"assetInfoDic", "ASSET_INFO_DIC", true)]

    public partial class LoadUtils
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "LoadUtils";
        //public static byte[] Static_ClassName { get; } = [76, 111, 97, 100, 85, 116, 105, 108, 115];

        //public const uint Const_TypeToken = 0x0200022FU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_LoadUtils(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_LoadUtils(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_LoadUtils obj) => obj._ptr;
            public static implicit operator bool(Ptr_LoadUtils obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."LoadUtils"]
    /// </summary>
    public partial class LoadUtils
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        /// static  System.String <LoadConfigAsync>g__ParseString|10_0(Newtonsoft.Json.Linq.JToken json)
        /// </summary>
        /// <param name="json">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<LoadConfigAsync>g__ParseString|10_0")]
        /// static extern nint <LOAD_CONFIG_ASYNC>G__PARSE_STRING|10_0 (nint json);


        /// <summary>
        /// static  System.Boolean CheckAssetExist(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckAssetExist")]
        /// static extern System.Boolean CHECK_ASSET_EXIST (nint key);


        /// <summary>
        /// static  System.Void ClearAssetsCache()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearAssetsCache")]
        /// static extern void CLEAR_ASSETS_CACHE ();


        /// <summary>
        /// static  System.Void ClearPrefabCache()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearPrefabCache")]
        /// static extern void CLEAR_PREFAB_CACHE ();


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> InstantiateAsync(System.String name, UnityEngine.Transform prarent)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="prarent">class UnityEngine.Transform</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InstantiateAsync")]
        /// static extern Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> INSTANTIATE_ASYNC (nint name, nint prarent);


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask<T> LoadAssetAsync(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAssetAsync")]
        /// static extern Cysharp.Threading.Tasks.UniTask<T> LOAD_ASSET_ASYNC (nint name);


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask LoadConfigAsync()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadConfigAsync")]
        /// static extern Cysharp.Threading.Tasks.UniTask LOAD_CONFIG_ASYNC ();


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadSpriteAsync(System.String atlasName, System.String spriteName)
        /// </summary>
        /// <param name="atlasName">class System.String</param>
        /// <param name="spriteName">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite></returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadSpriteAsync")]
        static extern Ptr_UniTask<Sprite.Ptr_Sprite> LOAD_SPRITE_ASYNC(MapleOut<Ref_UniTask<Sprite.Ptr_Sprite>>  uniTask, nint atlasName, nint spriteName);


        /// <summary>
        /// static  Cysharp.Threading.Tasks.UniTask PreloadPrefab(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PreloadPrefab")]
        /// static extern Cysharp.Threading.Tasks.UniTask PRELOAD_PREFAB (nint name);


        /// <summary>
        /// static  System.Void RecycleAsset(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecycleAsset")]
        /// static extern void RECYCLE_ASSET (nint obj);


        /// <summary>
        /// static  System.Void RecyclePrefab(UnityEngine.GameObject go, System.Boolean recycle)
        /// </summary>
        /// <param name="go">class UnityEngine.GameObject</param>
        /// <param name="recycle">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecyclePrefab")]
        /// static extern void RECYCLE_PREFAB (nint go, System.Boolean recycle);




        /// public static partial class Search_LoadUtils
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}