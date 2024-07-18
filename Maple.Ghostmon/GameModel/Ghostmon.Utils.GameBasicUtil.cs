
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
    /// static class ["Assembly-CSharp.dll"."Ghostmon.Utils"."GameBasicUtil"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020002DAU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110, 46, 85, 116, 105, 108, 115], [71, 97, 109, 101, 66, 97, 115, 105, 99, 85, 116, 105, 108])]
    
    
    public partial class GameBasicUtil
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon.Utils";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110, 46, 85, 116, 105, 108, 115];

        //public const string Const_ClassName = "GameBasicUtil";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 66, 97, 115, 105, 99, 85, 116, 105, 108];

        //public const uint Const_TypeToken = 0x020002DAU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameBasicUtil(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameBasicUtil(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameBasicUtil obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameBasicUtil obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Ghostmon.Utils"."GameBasicUtil"]
        /// </summary>
        public partial class GameBasicUtil
        { 

            
            
            /// <summary>
            /// static  T GetOrAddComponent(UnityEngine.GameObject go)
            /// </summary>
            /// <param name="go">class UnityEngine.GameObject</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOrAddComponent")]
            /// static extern nint GET_OR_ADD_COMPONENT (nint go);

            
            /// <summary>
            /// static  System.Collections.Generic.List<System.Int32> numSection(System.Int32 num, System.Int32 section)
            /// </summary>
            /// <param name="num">struct System.Int32</param>
            /// <param name="section">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("numSection")]
            /// static extern nint NUM_SECTION (System.Int32 num, System.Int32 section);

            
            /// <summary>
            /// static  System.Single ParseFloat(System.String s)
            /// </summary>
            /// <param name="s">class System.String</param>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ParseFloat")]
            /// static extern System.Single PARSE_FLOAT (nint s);

            
            /// <summary>
            /// static  System.Collections.Generic.List<System.Int32> RandomIntList(System.Collections.Generic.List<System.Int32> oriList)
            /// </summary>
            /// <param name="oriList">class System.Collections.Generic.List<System.Int32></param>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomIntList")]
            /// static extern nint RANDOM_INT_LIST (nint oriList);

            
            /// <summary>
            /// static  System.Void RemoveAllChild(UnityEngine.Transform mParent)
            /// </summary>
            /// <param name="mParent">class UnityEngine.Transform</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllChild")]
            /// static extern void REMOVE_ALL_CHILD (nint mParent);

            
            /// <summary>
            /// static  System.String Second2HHMMSSTime(System.Int32 totalSecond)
            /// </summary>
            /// <param name="totalSecond">struct System.Int32</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Second2HHMMSSTime")]
            /// static extern nint SECOND2_HHMMSS_TIME (System.Int32 totalSecond);

            
            /// <summary>
            /// static  System.Int32[] StringToIntArray(System.String str, System.Char delimiter)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="delimiter">struct System.Char</param>
            /// <returns>class System.Int32[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StringToIntArray")]
            /// static extern nint STRING_TO_INT_ARRAY (nint str, System.Char delimiter);

            
            /// <summary>
            /// static  System.UInt64[] StringToLongArray(System.String str, System.Char delimiter)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="delimiter">struct System.Char</param>
            /// <returns>class System.UInt64[]</returns>
              [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StringToLongArray")]
              static extern nint STRING_TO_LONG_ARRAY (nint str, System.Char delimiter);

            
            /// <summary>
            /// static  UnityEngine.Vector2 StringToVector2(System.String str, System.Char delimiter)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="delimiter">struct System.Char</param>
            /// <returns>struct UnityEngine.Vector2</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StringToVector2")]
            /// static extern UnityEngine.Vector2 STRING_TO_VECTOR2 (nint str, System.Char delimiter);

            
            /// <summary>
            /// static  UnityEngine.Vector2Int StringToVector2Int(System.String str, System.Char delimiter)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="delimiter">struct System.Char</param>
            /// <returns>struct UnityEngine.Vector2Int</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StringToVector2Int")]
            /// static extern UnityEngine.Vector2Int STRING_TO_VECTOR2_INT (nint str, System.Char delimiter);

            
            /// <summary>
            /// static  System.Collections.Generic.List<UnityEngine.Vector2Int> StringToVector2IntList(System.String str, System.Char delimiter, System.Char subDelimiter)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="delimiter">struct System.Char</param>
            /// <param name="subDelimiter">struct System.Char</param>
            /// <returns>class System.Collections.Generic.List<UnityEngine.Vector2Int></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StringToVector2IntList")]
            /// static extern nint STRING_TO_VECTOR2_INT_LIST (nint str, System.Char delimiter, System.Char subDelimiter);

            
            /// <summary>
            /// static  UnityEngine.Vector3 StringToVector3(System.String str, System.Char delimiter)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="delimiter">struct System.Char</param>
            /// <returns>struct UnityEngine.Vector3</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StringToVector3")]
            /// static extern UnityEngine.Vector3 STRING_TO_VECTOR3 (nint str, System.Char delimiter);

            
            /// <summary>
            /// static  System.String[] SubStringToStrings(System.String str, System.Int32 subCount)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="subCount">struct System.Int32</param>
            /// <returns>class System.String[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SubStringToStrings")]
            /// static extern nint SUB_STRING_TO_STRINGS (nint str, System.Int32 subCount);

            
            /// <summary>
            /// static  UnityEngine.Vector3 Vector3MultiplyInt(UnityEngine.Vector3 vec3, System.Int32 modulus)
            /// </summary>
            /// <param name="vec3">struct UnityEngine.Vector3</param>
            /// <param name="modulus">struct System.Int32</param>
            /// <returns>struct UnityEngine.Vector3</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Vector3MultiplyInt")]
            /// static extern UnityEngine.Vector3 VECTOR3_MULTIPLY_INT (UnityEngine.Vector3 vec3, System.Int32 modulus);

            
            /// <summary>
            /// static  System.Void XmlSerialize(System.String filePath, T data)
            /// </summary>
            /// <param name="filePath">class System.String</param>
            /// <param name="data">class T</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("XmlSerialize")]
            /// static extern void XML_SERIALIZE (nint filePath, nint data);
            
            
            
            /// <summary>
            /// static  T XmlDeserializer(System.String filePath)
            /// </summary>
            /// <param name="filePath">class System.String</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("XmlDeserializer", Search = typeof(Search_GameBasicUtil))]
            /// static extern nint XML_DESERIALIZER_00 (nint filePath);

            
            /// <summary>
            /// static  T XmlDeserializer(System.Byte[] bytes)
            /// </summary>
            /// <param name="bytes">class System.Byte[]</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("XmlDeserializer", Search = typeof(Search_GameBasicUtil))]
            /// static extern nint XML_DESERIALIZER_01 (nint bytes);

            
            /// public static partial class Search_GameBasicUtil
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    /// static  T XmlDeserializer(System.String filePath)
                    /// </summary>
                    /// public static bool XML_DESERIALIZER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "XmlDeserializer", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T XmlDeserializer(System.Byte[] bytes)
                    /// </summary>
                    /// public static bool XML_DESERIALIZER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "XmlDeserializer", "System.Byte[]");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}