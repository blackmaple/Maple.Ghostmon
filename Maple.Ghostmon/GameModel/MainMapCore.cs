
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
    /// class ["Assembly-CSharp.dll".""."MainMapCore"]
    /// [Ghostmon.Framework.Singleton<MainMapCore>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000160U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [77, 97, 105, 110, 77, 97, 112, 67, 111, 114, 101])]

    //  class static MainMapCore instance
    [MonoCollectorSearchFieldAttribute(typeof(MainMapCore.Ptr_MainMapCore), "instance", "INSTANCE", true)]

    // class 0x10 MapUI mapui
      [MonoCollectorSearchFieldAttribute(typeof(MapUI.Ptr_MapUI),"mapui", "MAPUI")]

    // class 0x18 System.Single[] cameraSizeArray
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"cameraSizeArray", "CAMERA_SIZE_ARRAY")]

    // struct 0x20 System.Int32 currSizeIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currSizeIndex", "CURR_SIZE_INDEX")]

    // class 0x28 System.Collections.Generic.Dictionary<MapMonster,UnityEngine.GameObject> demonRegister
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"demonRegister", "DEMON_REGISTER")]

    // class 0x30 System.Collections.Generic.Dictionary<MapShelter,UnityEngine.GameObject> shelterRegister
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"shelterRegister", "SHELTER_REGISTER")]

    // class 0x38 System.Collections.Generic.Dictionary<MapSpring,UnityEngine.GameObject> springRegister
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"springRegister", "SPRING_REGISTER")]

    // class 0x40 System.Collections.Generic.Dictionary<System.UInt64,UnityEngine.GameObject> targetRegister
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"targetRegister", "TARGET_REGISTER")]

    // class 0x48 System.Collections.Generic.Dictionary<System.UInt64,UnityEngine.GameObject> receiveRegister
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"receiveRegister", "RECEIVE_REGISTER")]

    // class 0x50 System.Collections.Generic.Dictionary<Ghostmon.MapMarkData,UnityEngine.GameObject> markerRegister
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"markerRegister", "MARKER_REGISTER")]

    // class 0x58 UnityEngine.GameObject miniIcon_shelter
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"miniIcon_shelter", "MINI_ICON_SHELTER")]

    // class 0x60 UnityEngine.GameObject miniIcon_spring
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"miniIcon_spring", "MINI_ICON_SPRING")]

    // class 0x68 UnityEngine.GameObject miniIcon_demon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"miniIcon_demon", "MINI_ICON_DEMON")]

    // class 0x70 UnityEngine.GameObject miniIcon_manual
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"miniIcon_manual", "MINI_ICON_MANUAL")]

    // class 0x78 UnityEngine.Transform recycle_node
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"recycle_node", "RECYCLE_NODE")]

    // class 0x80 System.Collections.Generic.Dictionary<MainMapCore.MiniIconType,System.Collections.Generic.List<UnityEngine.GameObject>> recycelPool
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"recycelPool", "RECYCEL_POOL")]
    public partial class MainMapCore
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "MainMapCore";
        //public static byte[] Static_ClassName { get; } = [77, 97, 105, 110, 77, 97, 112, 67, 111, 114, 101];

        //public const uint Const_TypeToken = 0x02000160U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_MainMapCore(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_MainMapCore(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_MainMapCore obj) => obj._ptr;
            public static implicit operator bool(Ptr_MainMapCore obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."MainMapCore"]
    /// </summary>
    public partial class MainMapCore
    {



        /// <summary>
        ///   UnityEngine.Vector2 CalculatePosInMinimap(UnityEngine.Vector3 worldPos)
        /// </summary>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CalculatePosInMinimap")]
        ///  extern UnityEngine.Vector2 CALCULATE_POS_IN_MINIMAP (UnityEngine.Vector3 worldPos);


        /// <summary>
        /// static  MainMapCore CreateInstance()
        /// </summary>
        /// <returns>class MainMapCore</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInstance")]
        /// static extern nint CREATE_INSTANCE ();


        /// <summary>
        /// static  MainMapCore get_Instance()
        /// </summary>
        /// <returns>class MainMapCore</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
        /// static extern nint GET_INSTANCE ();


        /// <summary>
        ///   System.Void HideMapUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideMapUI")]
        extern void HIDE_MAP_UI();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask InitMapUI()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitMapUI")]
        ///  extern Cysharp.Threading.Tasks.UniTask INIT_MAP_UI ();


        /// <summary>
        ///   System.Void InitTaskRegistInMiniMap()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitTaskRegistInMiniMap")]
        ///  extern void INIT_TASK_REGIST_IN_MINI_MAP ();


        /// <summary>
        /// static  System.Boolean IsActive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
        /// static extern System.Boolean IS_ACTIVE ();


        /// <summary>
        ///   System.Void LogoutDemonInMinimap(MapMonster mapMonster)
        /// </summary>
        /// <param name="mapMonster">class MapMonster</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogoutDemonInMinimap")]
        ///  extern void LOGOUT_DEMON_IN_MINIMAP (nint mapMonster);


        /// <summary>
        ///   System.Void LogoutMapMarkerInMinimap(Ghostmon.MapMarkData mark)
        /// </summary>
        /// <param name="mark">class Ghostmon.MapMarkData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogoutMapMarkerInMinimap")]
        ///  extern void LOGOUT_MAP_MARKER_IN_MINIMAP (nint mark);


        /// <summary>
        ///   System.Void LogoutShelterInMinimap(MapShelter mapShelter)
        /// </summary>
        /// <param name="mapShelter">class MapShelter</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogoutShelterInMinimap")]
        ///  extern void LOGOUT_SHELTER_IN_MINIMAP (nint mapShelter);


        /// <summary>
        ///   System.Void LogoutSpringInMinimap(MapSpring mapSpring)
        /// </summary>
        /// <param name="mapSpring">class MapSpring</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogoutSpringInMinimap")]
        ///  extern void LOGOUT_SPRING_IN_MINIMAP (nint mapSpring);


        /// <summary>
        ///   System.Void LogoutTaskReceiveInMinimap(System.UInt64 taskID)
        /// </summary>
        /// <param name="taskID">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogoutTaskReceiveInMinimap")]
        ///  extern void LOGOUT_TASK_RECEIVE_IN_MINIMAP (System.UInt64 taskID);


        /// <summary>
        ///   System.Void LogoutTaskTargetInMinimap(Ghostmon.TaskTargetConfig taskTarget)
        /// </summary>
        /// <param name="taskTarget">class Ghostmon.TaskTargetConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogoutTaskTargetInMinimap")]
        ///  extern void LOGOUT_TASK_TARGET_IN_MINIMAP (nint taskTarget);


        /// <summary>
        ///   System.Void RefreshCharacterPos()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCharacterPos")]
        ///  extern void REFRESH_CHARACTER_POS ();


        /// <summary>
        ///   System.Void RegistDemonInMinimap(MapMonster mapMonster)
        /// </summary>
        /// <param name="mapMonster">class MapMonster</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegistDemonInMinimap")]
        ///  extern void REGIST_DEMON_IN_MINIMAP (nint mapMonster);


        /// <summary>
        ///   System.Void RegistMapMarkerInMinimap(Ghostmon.MapMarkData mark)
        /// </summary>
        /// <param name="mark">class Ghostmon.MapMarkData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegistMapMarkerInMinimap")]
        ///  extern void REGIST_MAP_MARKER_IN_MINIMAP (nint mark);


        /// <summary>
        ///   System.Void RegistShelterInMinimap(MapShelter mapShelter)
        /// </summary>
        /// <param name="mapShelter">class MapShelter</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegistShelterInMinimap")]
        ///  extern void REGIST_SHELTER_IN_MINIMAP (nint mapShelter);


        /// <summary>
        ///   System.Void RegistSpringInMinimap(MapSpring mapSpring)
        /// </summary>
        /// <param name="mapSpring">class MapSpring</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegistSpringInMinimap")]
        ///  extern void REGIST_SPRING_IN_MINIMAP (nint mapSpring);


        /// <summary>
        ///   System.Void RegistTaskReceiveInMinimap(Ghostmon.TaskConfig task)
        /// </summary>
        /// <param name="task">class Ghostmon.TaskConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegistTaskReceiveInMinimap")]
        ///  extern void REGIST_TASK_RECEIVE_IN_MINIMAP (nint task);


        /// <summary>
        ///   System.Void RegistTaskTargetInMinimap(Ghostmon.TaskTargetConfig taskTarget)
        /// </summary>
        /// <param name="taskTarget">class Ghostmon.TaskTargetConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegistTaskTargetInMinimap")]
        ///  extern void REGIST_TASK_TARGET_IN_MINIMAP (nint taskTarget);


        /// <summary>
        ///   System.Void Remove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
        ///  extern void REMOVE ();


        /// <summary>
        ///   System.Void SetMiniIconPos(UnityEngine.Transform icon, UnityEngine.Vector3 worldPos)
        /// </summary>
        /// <param name="icon">class UnityEngine.Transform</param>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMiniIconPos")]
        ///  extern void SET_MINI_ICON_POS (nint icon, UnityEngine.Vector3 worldPos);


        /// <summary>
        ///   System.Void SetMiniIconSprite(UnityEngine.Transform icon, System.String iconName, System.Single scale)
        /// </summary>
        /// <param name="icon">class UnityEngine.Transform</param>
        /// <param name="iconName">class System.String</param>
        /// <param name="scale">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMiniIconSprite")]
        ///  extern void SET_MINI_ICON_SPRITE (nint icon, nint iconName, System.Single scale);


        /// <summary>
        ///   System.Void SetMinimapCameraZoomIn()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMinimapCameraZoomIn")]
        ///  extern void SET_MINIMAP_CAMERA_ZOOM_IN ();


        /// <summary>
        ///   System.Void SetMinimapCameraZoomOut()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMinimapCameraZoomOut")]
        ///  extern void SET_MINIMAP_CAMERA_ZOOM_OUT ();


        /// <summary>
        ///   System.Void ShowMapUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowMapUI")]
        ///  extern void SHOW_MAP_UI ();


        /// <summary>
        ///   System.Void UpdateIconPos()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateIconPos")]
        ///  extern void UPDATE_ICON_POS ();


        /// <summary>
        ///   System.Void UpdateIconScale(System.Single scale)
        /// </summary>
        /// <param name="scale">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateIconScale")]
        ///  extern void UPDATE_ICON_SCALE (System.Single scale);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainMapCore))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MainMapCore))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_MainMapCore))]
        ///  extern void ON_INIT_00 ();


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInit", Search = typeof(Search_MainMapCore))]
        ///  extern void ON_INIT_01 ();


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove", Search = typeof(Search_MainMapCore))]
        ///  extern void ON_REMOVE_00 ();


        /// <summary>
        ///   System.Void OnRemove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnRemove", Search = typeof(Search_MainMapCore))]
        ///  extern void ON_REMOVE_01 ();


        /// public static partial class Search_MainMapCore
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
        ///   System.Void OnInit()
        /// </summary>
        /// public static bool ON_INIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void OnInit()
        /// </summary>
        /// public static bool ON_INIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnInit");
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
        /// 
        /// }

    }


}