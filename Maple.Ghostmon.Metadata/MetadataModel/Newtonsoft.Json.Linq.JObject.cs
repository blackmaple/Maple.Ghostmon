
using Maple.MonoGameAssistant.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Newtonsoft.Json.dll"."Newtonsoft.Json.Linq"."JObject"]
    /// [Newtonsoft.Json.Linq.JContainer]=>[Newtonsoft.Json.Linq.JToken]=>[System.Object]
    /// [System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>]=>[System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>]=>[System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>]=>[System.Collections.IEnumerable]=>[System.ComponentModel.ICustomTypeDescriptor]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([78, 101, 119, 116, 111, 110, 115, 111, 102, 116, 46, 74, 115, 111, 110, 46, 100, 108, 108], 0x020000D1U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([78, 101, 119, 116, 111, 110, 115, 111, 102, 116, 46, 74, 115, 111, 110, 46, 100, 108, 108], [78, 101, 119, 116, 111, 110, 115, 111, 102, 116, 46, 74, 115, 111, 110, 46, 76, 105, 110, 113], [74, 79, 98, 106, 101, 99, 116])]

    //  class static Newtonsoft.Json.Linq.JTokenType[] BooleanTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"BooleanTypes", "BOOLEAN_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] NumberTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"NumberTypes", "NUMBER_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] BigIntegerTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"BigIntegerTypes", "BIG_INTEGER_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] StringTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"StringTypes", "STRING_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] GuidTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"GuidTypes", "GUID_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] TimeSpanTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"TimeSpanTypes", "TIME_SPAN_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] UriTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"UriTypes", "URI_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] CharTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"CharTypes", "CHAR_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] DateTimeTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"DateTimeTypes", "DATE_TIME_TYPES", true)]

    //  class static Newtonsoft.Json.Linq.JTokenType[] BytesTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"BytesTypes", "BYTES_TYPES", true)]

    // abstract class 0x10 Newtonsoft.Json.Linq.JContainer _parent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_parent", "_PARENT")]

    // abstract class 0x18 Newtonsoft.Json.Linq.JToken _previous
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_previous", "_PREVIOUS")]

    // abstract class 0x20 Newtonsoft.Json.Linq.JToken _next
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_next", "_NEXT")]

    // class 0x28 System.Object _annotations
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_annotations", "_ANNOTATIONS")]

    // class 0x30 System.ComponentModel.ListChangedEventHandler _listChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_listChanged", "_LIST_CHANGED")]

    // class 0x38 System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_collectionChanged", "_COLLECTION_CHANGED")]

    // class 0x40 System.Object _syncRoot
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_syncRoot", "_SYNC_ROOT")]

    // struct 0x48 System.Boolean _busy
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"_busy", "_BUSY")]

    // class 0x50 Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_properties", "_PROPERTIES")]

    // class 0x58 System.ComponentModel.PropertyChangedEventHandler PropertyChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"PropertyChanged", "PROPERTY_CHANGED")]

    // class 0x60 System.ComponentModel.PropertyChangingEventHandler PropertyChanging
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"PropertyChanging", "PROPERTY_CHANGING")]
    public partial class JObject
    {
        //public const string Const_ImageName = "Newtonsoft.Json.dll";
        //public static byte[] Static_ImageName { get; } = [78, 101, 119, 116, 111, 110, 115, 111, 102, 116, 46, 74, 115, 111, 110, 46, 100, 108, 108];

        //public const string Const_Namespace = "Newtonsoft.Json.Linq";
        //public static byte[] Static_Namespace { get; } = [78, 101, 119, 116, 111, 110, 115, 111, 102, 116, 46, 74, 115, 111, 110, 46, 76, 105, 110, 113];

        //public const string Const_ClassName = "JObject";
        //public static byte[] Static_ClassName { get; } = [74, 79, 98, 106, 101, 99, 116];

        //public const uint Const_TypeToken = 0x020000D1U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_JObject(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_JObject(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_JObject obj) => obj._ptr;
            public static implicit operator bool(Ptr_JObject obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Newtonsoft.Json.dll"."Newtonsoft.Json.Linq"."JObject"]
    /// </summary>
    public partial class JObject
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token)
        /// </summary>
        /// <param name="token">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAndSkipParentCheck")]
        ///  extern void ADD_AND_SKIP_PARENT_CHECK (nint token);


        /// <summary>
        ///   System.Void AddAnnotation(System.Object annotation)
        /// </summary>
        /// <param name="annotation">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnnotation")]
        ///  extern void ADD_ANNOTATION (nint annotation);


        /// <summary>
        ///   System.Void AddInternal(System.Int32 index, System.Object content, System.Boolean skipParentCheck)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="content">class System.Object</param>
        /// <param name="skipParentCheck">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInternal")]
        ///  extern void ADD_INTERNAL (System.Int32 index, nint content, System.Boolean skipParentCheck);


        /// <summary>
        ///   T Annotation()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Annotation")]
        ///  extern nint ANNOTATION ();


        /// <summary>
        ///   System.Void CheckReentrancy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckReentrancy")]
        ///  extern void CHECK_REENTRANCY ();


        /// <summary>
        ///   System.Void ClearItems()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearItems")]
        ///  extern void CLEAR_ITEMS ();


        /// <summary>
        ///   System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContainsItem")]
        ///  extern System.Boolean CONTAINS_ITEM (nint item);


        /// <summary>
        ///   System.Boolean ContainsKey(System.String propertyName)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContainsKey")]
        ///  extern System.Boolean CONTAINS_KEY (nint propertyName);


        /// <summary>
        ///   System.Void CopyItemsTo(System.Array array, System.Int32 arrayIndex)
        /// </summary>
        /// <param name="array">abstract class System.Array</param>
        /// <param name="arrayIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyItemsTo")]
        ///  extern void COPY_ITEMS_TO (nint array, System.Int32 arrayIndex);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JToken CreateFromContent(System.Object content)
        /// </summary>
        /// <param name="content">class System.Object</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateFromContent")]
        /// static extern nint CREATE_FROM_CONTENT (nint content);


        /// <summary>
        ///   Newtonsoft.Json.JsonReader CreateReader()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.JsonReader</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateReader")]
        ///  extern nint CREATE_READER ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken DeepClone()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeepClone")]
        ///  extern nint DEEP_CLONE ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="skipParentCheck">struct System.Boolean</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureParentToken")]
        ///  extern nint ENSURE_PARENT_TOKEN (nint item, System.Boolean skipParentCheck);


        /// <summary>
        ///   System.Int32 get_Count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Count")]
        ///  extern System.Int32 GET_COUNT ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Next()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Next")]
        ///  extern nint GET_NEXT ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JContainer get_Parent()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JContainer</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Parent")]
        ///  extern nint GET_PARENT ();


        /// <summary>
        ///   System.String get_Path()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Path")]
        ///  extern nint GET_PATH ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Previous()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Previous")]
        ///  extern nint GET_PREVIOUS ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Root()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Root")]
        ///  extern nint GET_ROOT ();


        /// <summary>
        ///   System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
        ///  extern nint GET_ENUMERATOR ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItem")]
        ///  extern nint GET_ITEM (System.Int32 index);


        /// <summary>
        /// static  System.String GetType(Newtonsoft.Json.Linq.JToken token)
        /// </summary>
        /// <param name="token">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetType")]
        /// static extern nint GET_TYPE (nint token);


        /// <summary>
        ///   System.Void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty)
        /// </summary>
        /// <param name="childProperty">class Newtonsoft.Json.Linq.JProperty</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalPropertyChanged")]
        ///  extern void INTERNAL_PROPERTY_CHANGED (nint childProperty);


        /// <summary>
        ///   System.Void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty)
        /// </summary>
        /// <param name="childProperty">class Newtonsoft.Json.Linq.JProperty</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalPropertyChanging")]
        ///  extern void INTERNAL_PROPERTY_CHANGING (nint childProperty);


        /// <summary>
        ///   System.Boolean IsMultiContent(System.Object content)
        /// </summary>
        /// <param name="content">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsMultiContent")]
        ///  extern System.Boolean IS_MULTI_CONTENT (nint content);


        /// <summary>
        /// static  System.Boolean IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue)
        /// </summary>
        /// <param name="currentValue">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="newValue">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsTokenUnchanged")]
        /// static extern System.Boolean IS_TOKEN_UNCHANGED (nint currentValue, nint newValue);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
        /// </summary>
        /// <param name="reader">abstract class Newtonsoft.Json.JsonReader</param>
        /// <param name="settings">class Newtonsoft.Json.Linq.JsonLoadSettings</param>
        /// <returns>class Newtonsoft.Json.Linq.JObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Load")]
        /// static extern nint LOAD (nint reader, nint settings);


        /// <summary>
        ///   System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LineNumber()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Newtonsoft.Json.IJsonLineInfo.get_LineNumber")]
        ///  extern System.Int32 NEWTONSOFT.JSON.I_JSON_LINE_INFO.GET_LINE_NUMBER ();


        /// <summary>
        ///   System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LinePosition()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Newtonsoft.Json.IJsonLineInfo.get_LinePosition")]
        ///  extern System.Int32 NEWTONSOFT.JSON.I_JSON_LINE_INFO.GET_LINE_POSITION ();


        /// <summary>
        ///   System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Newtonsoft.Json.IJsonLineInfo.HasLineInfo")]
        ///  extern System.Boolean NEWTONSOFT.JSON.I_JSON_LINE_INFO.HAS_LINE_INFO ();


        /// <summary>
        ///   System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        /// </summary>
        /// <param name="e">class System.Collections.Specialized.NotifyCollectionChangedEventArgs</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCollectionChanged")]
        ///  extern void ON_COLLECTION_CHANGED (nint e);


        /// <summary>
        ///   System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
        /// </summary>
        /// <param name="e">class System.ComponentModel.ListChangedEventArgs</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnListChanged")]
        ///  extern void ON_LIST_CHANGED (nint e);


        /// <summary>
        ///   System.Void OnPropertyChanged(System.String propertyName)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPropertyChanged")]
        ///  extern void ON_PROPERTY_CHANGED (nint propertyName);


        /// <summary>
        ///   System.Void OnPropertyChanging(System.String propertyName)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPropertyChanging")]
        ///  extern void ON_PROPERTY_CHANGING (nint propertyName);


        /// <summary>
        ///   System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Properties")]
        ///  extern nint PROPERTIES ();


        /// <summary>
        ///   System.Void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings)
        /// </summary>
        /// <param name="r">abstract class Newtonsoft.Json.JsonReader</param>
        /// <param name="settings">class Newtonsoft.Json.Linq.JsonLoadSettings</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReadContentFrom")]
        ///  extern void READ_CONTENT_FROM (nint r, nint settings);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent)
        /// </summary>
        /// <param name="r">abstract class Newtonsoft.Json.JsonReader</param>
        /// <param name="settings">class Newtonsoft.Json.Linq.JsonLoadSettings</param>
        /// <param name="lineInfo">interface Newtonsoft.Json.IJsonLineInfo</param>
        /// <param name="parent">abstract class Newtonsoft.Json.Linq.JContainer</param>
        /// <returns>class Newtonsoft.Json.Linq.JProperty</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReadProperty")]
        /// static extern nint READ_PROPERTY (nint r, nint settings, nint lineInfo, nint parent);


        /// <summary>
        ///   System.Void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options)
        /// </summary>
        /// <param name="reader">abstract class Newtonsoft.Json.JsonReader</param>
        /// <param name="options">class Newtonsoft.Json.Linq.JsonLoadSettings</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReadTokenFrom")]
        ///  extern void READ_TOKEN_FROM (nint reader, nint options);


        /// <summary>
        ///   System.Void RemoveAll()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAll")]
        ///  extern void REMOVE_ALL ();


        /// <summary>
        ///   System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItem")]
        ///  extern System.Boolean REMOVE_ITEM (nint item);


        /// <summary>
        ///   System.Void RemoveItemAt(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItemAt")]
        ///  extern void REMOVE_ITEM_AT (System.Int32 index);


        /// <summary>
        ///   System.Void Replace(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Replace")]
        ///  extern void REPLACE (nint value);


        /// <summary>
        ///   System.Void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement)
        /// </summary>
        /// <param name="existing">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="replacement">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceItem")]
        ///  extern void REPLACE_ITEM (nint existing, nint replacement);


        /// <summary>
        ///   System.Void set_Item(System.String propertyName, Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item")]
        ///  extern void SET_ITEM (nint propertyName, nint value);


        /// <summary>
        ///   System.Void set_Next(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Next")]
        ///  extern void SET_NEXT (nint value);


        /// <summary>
        ///   System.Void set_Parent(Newtonsoft.Json.Linq.JContainer value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JContainer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Parent")]
        ///  extern void SET_PARENT (nint value);


        /// <summary>
        ///   System.Void set_Previous(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Previous")]
        ///  extern void SET_PREVIOUS (nint value);


        /// <summary>
        ///   System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItem")]
        ///  extern void SET_ITEM (System.Int32 index, nint item);


        /// <summary>
        ///   System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<NEWTONSOFT.JSON.LINQ.J_TOKEN>.ADD (nint item);


        /// <summary>
        ///   System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<NEWTONSOFT.JSON.LINQ.J_TOKEN>.CLEAR ();


        /// <summary>
        ///   System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<NEWTONSOFT.JSON.LINQ.J_TOKEN>.CONTAINS (nint item);


        /// <summary>
        ///   System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex)
        /// </summary>
        /// <param name="array">class Newtonsoft.Json.Linq.JToken[]</param>
        /// <param name="arrayIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<NEWTONSOFT.JSON.LINQ.J_TOKEN>.COPY_TO (nint array, System.Int32 arrayIndex);


        /// <summary>
        ///   System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<NEWTONSOFT.JSON.LINQ.J_TOKEN>.GET_IS_READ_ONLY ();


        /// <summary>
        ///   System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<NEWTONSOFT.JSON.LINQ.J_TOKEN>.REMOVE (nint item);


        /// <summary>
        ///   System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
        /// </summary>
        /// <param name="item">struct System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<SYSTEM.COLLECTIONS.GENERIC.KEY_VALUE_PAIR<SYSTEM.STRING,NEWTONSOFT.JSON.LINQ.J_TOKEN>>.ADD (System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item);


        /// <summary>
        ///   System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<SYSTEM.COLLECTIONS.GENERIC.KEY_VALUE_PAIR<SYSTEM.STRING,NEWTONSOFT.JSON.LINQ.J_TOKEN>>.CLEAR ();


        /// <summary>
        ///   System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
        /// </summary>
        /// <param name="item">struct System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken></param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<SYSTEM.COLLECTIONS.GENERIC.KEY_VALUE_PAIR<SYSTEM.STRING,NEWTONSOFT.JSON.LINQ.J_TOKEN>>.CONTAINS (System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item);


        /// <summary>
        ///   System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, System.Int32 arrayIndex)
        /// </summary>
        /// <param name="array">class System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[]</param>
        /// <param name="arrayIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<SYSTEM.COLLECTIONS.GENERIC.KEY_VALUE_PAIR<SYSTEM.STRING,NEWTONSOFT.JSON.LINQ.J_TOKEN>>.COPY_TO (nint array, System.Int32 arrayIndex);


        /// <summary>
        ///   System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<SYSTEM.COLLECTIONS.GENERIC.KEY_VALUE_PAIR<SYSTEM.STRING,NEWTONSOFT.JSON.LINQ.J_TOKEN>>.GET_IS_READ_ONLY ();


        /// <summary>
        ///   System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
        /// </summary>
        /// <param name="item">struct System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken></param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<SYSTEM.COLLECTIONS.GENERIC.KEY_VALUE_PAIR<SYSTEM.STRING,NEWTONSOFT.JSON.LINQ.J_TOKEN>>.REMOVE (System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item);


        /// <summary>
        ///   System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values()
        /// </summary>
        /// <returns>interface System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values")]
        ///  extern nint SYSTEM.COLLECTIONS.GENERIC.I_DICTIONARY<SYSTEM.STRING,NEWTONSOFT.JSON.LINQ.J_TOKEN>.GET_VALUES ();


        /// <summary>
        ///   System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator")]
        ///  extern nint SYSTEM.COLLECTIONS.GENERIC.I_ENUMERABLE<NEWTONSOFT.JSON.LINQ.J_TOKEN>.GET_ENUMERATOR ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item")]
        ///  extern nint SYSTEM.COLLECTIONS.GENERIC.I_LIST<NEWTONSOFT.JSON.LINQ.J_TOKEN>.GET_ITEM (System.Int32 index);


        /// <summary>
        ///   System.Int32 System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf")]
        ///  extern System.Int32 SYSTEM.COLLECTIONS.GENERIC.I_LIST<NEWTONSOFT.JSON.LINQ.J_TOKEN>.INDEX_OF (nint item);


        /// <summary>
        ///   System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_LIST<NEWTONSOFT.JSON.LINQ.J_TOKEN>.INSERT (System.Int32 index, nint item);


        /// <summary>
        ///   System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_LIST<NEWTONSOFT.JSON.LINQ.J_TOKEN>.REMOVE_AT (System.Int32 index);


        /// <summary>
        ///   System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(System.Int32 index, Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item")]
        ///  extern void SYSTEM.COLLECTIONS.GENERIC.I_LIST<NEWTONSOFT.JSON.LINQ.J_TOKEN>.SET_ITEM (System.Int32 index, nint value);


        /// <summary>
        ///   System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
        /// </summary>
        /// <param name="array">abstract class System.Array</param>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.CopyTo")]
        ///  extern void SYSTEM.COLLECTIONS.I_COLLECTION.COPY_TO (nint array, System.Int32 index);


        /// <summary>
        ///   System.Boolean System.Collections.ICollection.get_IsSynchronized()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.get_IsSynchronized")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_COLLECTION.GET_IS_SYNCHRONIZED ();


        /// <summary>
        ///   System.Object System.Collections.ICollection.get_SyncRoot()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.get_SyncRoot")]
        ///  extern nint SYSTEM.COLLECTIONS.I_COLLECTION.GET_SYNC_ROOT ();


        /// <summary>
        ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IEnumerable.GetEnumerator")]
        ///  extern nint SYSTEM.COLLECTIONS.I_ENUMERABLE.GET_ENUMERATOR ();


        /// <summary>
        ///   System.Int32 System.Collections.IList.Add(System.Object value)
        /// </summary>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Add")]
        ///  extern System.Int32 SYSTEM.COLLECTIONS.I_LIST.ADD (nint value);


        /// <summary>
        ///   System.Void System.Collections.IList.Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Clear")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.CLEAR ();


        /// <summary>
        ///   System.Boolean System.Collections.IList.Contains(System.Object value)
        /// </summary>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Contains")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.CONTAINS (nint value);


        /// <summary>
        ///   System.Boolean System.Collections.IList.get_IsFixedSize()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_IsFixedSize")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.GET_IS_FIXED_SIZE ();


        /// <summary>
        ///   System.Boolean System.Collections.IList.get_IsReadOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_IsReadOnly")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.GET_IS_READ_ONLY ();


        /// <summary>
        ///   System.Object System.Collections.IList.get_Item(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_Item")]
        ///  extern nint SYSTEM.COLLECTIONS.I_LIST.GET_ITEM (System.Int32 index);


        /// <summary>
        ///   System.Int32 System.Collections.IList.IndexOf(System.Object value)
        /// </summary>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.IndexOf")]
        ///  extern System.Int32 SYSTEM.COLLECTIONS.I_LIST.INDEX_OF (nint value);


        /// <summary>
        ///   System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Insert")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.INSERT (System.Int32 index, nint value);


        /// <summary>
        ///   System.Void System.Collections.IList.Remove(System.Object value)
        /// </summary>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Remove")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.REMOVE (nint value);


        /// <summary>
        ///   System.Void System.Collections.IList.RemoveAt(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.RemoveAt")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.REMOVE_AT (System.Int32 index);


        /// <summary>
        ///   System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.set_Item")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.SET_ITEM (System.Int32 index, nint value);


        /// <summary>
        ///   System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
        /// </summary>
        /// <returns>class System.ComponentModel.AttributeCollection</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetAttributes")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_ATTRIBUTES ();


        /// <summary>
        ///   System.String System.ComponentModel.ICustomTypeDescriptor.GetClassName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetClassName")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_CLASS_NAME ();


        /// <summary>
        ///   System.String System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetComponentName")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_COMPONENT_NAME ();


        /// <summary>
        ///   System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
        /// </summary>
        /// <returns>class System.ComponentModel.TypeConverter</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetConverter")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_CONVERTER ();


        /// <summary>
        ///   System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
        /// </summary>
        /// <returns>abstract class System.ComponentModel.EventDescriptor</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_DEFAULT_EVENT ();


        /// <summary>
        ///   System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
        /// </summary>
        /// <returns>abstract class System.ComponentModel.PropertyDescriptor</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_DEFAULT_PROPERTY ();


        /// <summary>
        ///   System.Object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType)
        /// </summary>
        /// <param name="editorBaseType">abstract class System.Type</param>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetEditor")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_EDITOR (nint editorBaseType);


        /// <summary>
        ///   System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
        /// </summary>
        /// <param name="pd">abstract class System.ComponentModel.PropertyDescriptor</param>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner")]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_PROPERTY_OWNER (nint pd);


        /// <summary>
        ///   System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter)
        /// </summary>
        /// <param name="parameter">abstract class System.Linq.Expressions.Expression</param>
        /// <returns>class System.Dynamic.DynamicMetaObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject")]
        ///  extern nint SYSTEM.DYNAMIC.I_DYNAMIC_META_OBJECT_PROVIDER.GET_META_OBJECT (nint parameter);


        /// <summary>
        ///   System.Object System.ICloneable.Clone()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ICloneable.Clone")]
        ///  extern nint SYSTEM.I_CLONEABLE.CLONE ();


        /// <summary>
        /// static  System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Numerics.BigInteger</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBigInteger")]
        /// static extern System.Numerics.BigInteger TO_BIG_INTEGER (nint value);


        /// <summary>
        /// static  System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Numerics.BigInteger></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBigIntegerNullable")]
        /// static extern System.Nullable<System.Numerics.BigInteger> TO_BIG_INTEGER_NULLABLE (nint value);


        /// <summary>
        ///   System.Boolean TryGetValue(System.String propertyName, Newtonsoft.Json.Linq.JToken& value)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetValue")]
        ///  extern System.Boolean TRY_GET_VALUE (nint propertyName, nint value);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_JObject))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(Newtonsoft.Json.Linq.JObject other)
        /// </summary>
        /// <param name="other">class Newtonsoft.Json.Linq.JObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_JObject))]
        ///  extern void .CTOR_01 (nint other);


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_JObject))]
        ///  extern void .CTOR_02 ();


        /// <summary>
        ///   System.Void .ctor(Newtonsoft.Json.Linq.JContainer other)
        /// </summary>
        /// <param name="other">abstract class Newtonsoft.Json.Linq.JContainer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_JObject))]
        ///  extern void .CTOR_03 (nint other);


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_JObject))]
        ///  extern void .CTOR_04 ();


        /// <summary>
        ///   System.Void Add(System.String propertyName, Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_JObject))]
        ///  extern void ADD_00 (nint propertyName, nint value);


        /// <summary>
        ///   System.Void Add(System.Object content)
        /// </summary>
        /// <param name="content">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_JObject))]
        ///  extern void ADD_01 (nint content);


        /// <summary>
        ///   Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
        /// </summary>
        /// <returns>struct Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Children", Search = typeof(Search_JObject))]
        ///  extern Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> CHILDREN_00 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
        /// </summary>
        /// <returns>struct Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Children", Search = typeof(Search_JObject))]
        ///  extern Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> CHILDREN_01 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken CloneToken()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloneToken", Search = typeof(Search_JObject))]
        ///  extern nint CLONE_TOKEN_00 ();


        /// <summary>
        ///  abstract Newtonsoft.Json.Linq.JToken CloneToken()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloneToken", Search = typeof(Search_JObject))]
        ///  extern nint CLONE_TOKEN_01 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken EnsureValue(System.Object value)
        /// </summary>
        /// <param name="value">class System.Object</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureValue", Search = typeof(Search_JObject))]
        ///  extern nint ENSURE_VALUE_00 (nint value);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>class Newtonsoft.Json.Linq.JValue</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureValue", Search = typeof(Search_JObject))]
        /// static extern nint ENSURE_VALUE_01 (nint value);


        /// <summary>
        ///   System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ChildrenTokens", Search = typeof(Search_JObject))]
        ///  extern nint GET_CHILDREN_TOKENS_00 ();


        /// <summary>
        ///  abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ChildrenTokens", Search = typeof(Search_JObject))]
        ///  extern nint GET_CHILDREN_TOKENS_01 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_First()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_First", Search = typeof(Search_JObject))]
        ///  extern nint GET_FIRST_00 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_First()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_First", Search = typeof(Search_JObject))]
        ///  extern nint GET_FIRST_01 ();


        /// <summary>
        ///   System.Boolean get_HasValues()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HasValues", Search = typeof(Search_JObject))]
        ///  extern System.Boolean GET_HAS_VALUES_00 ();


        /// <summary>
        ///  abstract System.Boolean get_HasValues()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HasValues", Search = typeof(Search_JObject))]
        ///  extern System.Boolean GET_HAS_VALUES_01 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
        /// </summary>
        /// <param name="key">class System.Object</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_JObject))]
        ///  extern nint GET_ITEM_00 (nint key);


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Item(System.String propertyName)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_JObject))]
        ///  extern nint GET_ITEM_01 (nint propertyName);


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
        /// </summary>
        /// <param name="key">class System.Object</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_JObject))]
        ///  extern nint GET_ITEM_02 (nint key);


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Last()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Last", Search = typeof(Search_JObject))]
        ///  extern nint GET_LAST_00 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JToken get_Last()
        /// </summary>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Last", Search = typeof(Search_JObject))]
        ///  extern nint GET_LAST_01 ();


        /// <summary>
        ///   Newtonsoft.Json.Linq.JTokenType get_Type()
        /// </summary>
        /// <returns>enum Newtonsoft.Json.Linq.JTokenType</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Type", Search = typeof(Search_JObject))]
        ///  extern Newtonsoft.Json.Linq.JTokenType GET_TYPE_00 ();


        /// <summary>
        ///  abstract Newtonsoft.Json.Linq.JTokenType get_Type()
        /// </summary>
        /// <returns>enum Newtonsoft.Json.Linq.JTokenType</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Type", Search = typeof(Search_JObject))]
        ///  extern Newtonsoft.Json.Linq.JTokenType GET_TYPE_01 ();


        /// <summary>
        ///   System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
        /// </summary>
        /// <param name="parameter">abstract class System.Linq.Expressions.Expression</param>
        /// <returns>class System.Dynamic.DynamicMetaObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMetaObject", Search = typeof(Search_JObject))]
        ///  extern nint GET_META_OBJECT_00 (nint parameter);


        /// <summary>
        ///   System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
        /// </summary>
        /// <param name="parameter">abstract class System.Linq.Expressions.Expression</param>
        /// <returns>class System.Dynamic.DynamicMetaObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMetaObject", Search = typeof(Search_JObject))]
        ///  extern nint GET_META_OBJECT_01 (nint parameter);


        /// <summary>
        ///   System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOfItem", Search = typeof(Search_JObject))]
        ///  extern System.Int32 INDEX_OF_ITEM_00 (nint item);


        /// <summary>
        ///  abstract System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
        /// </summary>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOfItem", Search = typeof(Search_JObject))]
        ///  extern System.Int32 INDEX_OF_ITEM_01 (nint item);


        /// <summary>
        ///   System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="skipParentCheck">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InsertItem", Search = typeof(Search_JObject))]
        ///  extern void INSERT_ITEM_00 (System.Int32 index, nint item, System.Boolean skipParentCheck);


        /// <summary>
        ///   System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="item">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="skipParentCheck">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("InsertItem", Search = typeof(Search_JObject))]
        ///  extern void INSERT_ITEM_01 (System.Int32 index, nint item, System.Boolean skipParentCheck);


        /// <summary>
        /// static  System.Boolean op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Boolean OP_EXPLICIT_00 (nint value);


        /// <summary>
        /// static  System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.DateTimeOffset</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.DateTimeOffset OP_EXPLICIT_01 (nint value);


        /// <summary>
        /// static  System.Nullable<System.Boolean> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Boolean></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Boolean> OP_EXPLICIT_02 (nint value);


        /// <summary>
        /// static  System.Int64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Int64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Int64 OP_EXPLICIT_03 (nint value);


        /// <summary>
        /// static  System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.DateTime></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.DateTime> OP_EXPLICIT_04 (nint value);


        /// <summary>
        /// static  System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.DateTimeOffset></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.DateTimeOffset> OP_EXPLICIT_05 (nint value);


        /// <summary>
        /// static  System.Nullable<System.Decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Decimal></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Decimal> OP_EXPLICIT_06 (nint value);


        /// <summary>
        /// static  System.Nullable<System.Double> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Double></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Double> OP_EXPLICIT_07 (nint value);


        /// <summary>
        /// static  System.Nullable<System.Char> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Char></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Char> OP_EXPLICIT_08 (nint value);


        /// <summary>
        /// static  System.Int32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Int32 OP_EXPLICIT_09 (nint value);


        /// <summary>
        /// static  System.Int16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Int16</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Int16 OP_EXPLICIT_0A (nint value);


        /// <summary>
        /// static  System.UInt16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.UInt16</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.UInt16 OP_EXPLICIT_0B (nint value);


        /// <summary>
        /// static  System.Char op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Char</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Char OP_EXPLICIT_0C (nint value);


        /// <summary>
        /// static  System.Byte op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Byte</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Byte OP_EXPLICIT_0D (nint value);


        /// <summary>
        /// static  System.SByte op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.SByte</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.SByte OP_EXPLICIT_0E (nint value);


        /// <summary>
        /// static  System.Nullable<System.Int32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Int32></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Int32> OP_EXPLICIT_0F (nint value);


        /// <summary>
        /// static  System.Nullable<System.Int16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Int16></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Int16> OP_EXPLICIT_10 (nint value);


        /// <summary>
        /// static  System.Nullable<System.UInt16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.UInt16></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.UInt16> OP_EXPLICIT_11 (nint value);


        /// <summary>
        /// static  System.Nullable<System.Byte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Byte></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Byte> OP_EXPLICIT_12 (nint value);


        /// <summary>
        /// static  System.Nullable<System.SByte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.SByte></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.SByte> OP_EXPLICIT_13 (nint value);


        /// <summary>
        /// static  System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.DateTime</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.DateTime OP_EXPLICIT_14 (nint value);


        /// <summary>
        /// static  System.Nullable<System.Int64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Int64></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Int64> OP_EXPLICIT_15 (nint value);


        /// <summary>
        /// static  System.Nullable<System.Single> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Single></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Single> OP_EXPLICIT_16 (nint value);


        /// <summary>
        /// static  System.Decimal op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Decimal</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Decimal OP_EXPLICIT_17 (nint value);


        /// <summary>
        /// static  System.Nullable<System.UInt32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.UInt32></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.UInt32> OP_EXPLICIT_18 (nint value);


        /// <summary>
        /// static  System.Nullable<System.UInt64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.UInt64></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.UInt64> OP_EXPLICIT_19 (nint value);


        /// <summary>
        /// static  System.Double op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Double</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Double OP_EXPLICIT_1A (nint value);


        /// <summary>
        /// static  System.Single op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Single OP_EXPLICIT_1B (nint value);


        /// <summary>
        /// static  System.String op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern nint OP_EXPLICIT_1C (nint value);


        /// <summary>
        /// static  System.UInt32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.UInt32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.UInt32 OP_EXPLICIT_1D (nint value);


        /// <summary>
        /// static  System.UInt64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.UInt64 OP_EXPLICIT_1E (nint value);


        /// <summary>
        /// static  System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Guid</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Guid OP_EXPLICIT_1F (nint value);


        /// <summary>
        /// static  System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.Guid></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.Guid> OP_EXPLICIT_20 (nint value);


        /// <summary>
        /// static  System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.TimeSpan</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.TimeSpan OP_EXPLICIT_21 (nint value);


        /// <summary>
        /// static  System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Nullable<System.TimeSpan></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern System.Nullable<System.TimeSpan> OP_EXPLICIT_22 (nint value);


        /// <summary>
        /// static  System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value)
        /// </summary>
        /// <param name="value">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>class System.Uri</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit", Search = typeof(Search_JObject))]
        /// static extern nint OP_EXPLICIT_23 (nint value);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JObject Parse(System.String json)
        /// </summary>
        /// <param name="json">class System.String</param>
        /// <returns>class Newtonsoft.Json.Linq.JObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_JObject))]
        /// static extern nint PARSE_00 (nint json);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JObject Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings)
        /// </summary>
        /// <param name="json">class System.String</param>
        /// <param name="settings">class Newtonsoft.Json.Linq.JsonLoadSettings</param>
        /// <returns>class Newtonsoft.Json.Linq.JObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_JObject))]
        /// static extern nint PARSE_01 (nint json, nint settings);


        /// <summary>
        ///   Newtonsoft.Json.Linq.JProperty Property(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>class Newtonsoft.Json.Linq.JProperty</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Property", Search = typeof(Search_JObject))]
        ///  extern nint PROPERTY_00 (nint name);


        /// <summary>
        ///   Newtonsoft.Json.Linq.JProperty Property(System.String name, System.StringComparison comparison)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="comparison">enum System.StringComparison</param>
        /// <returns>class Newtonsoft.Json.Linq.JProperty</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Property", Search = typeof(Search_JObject))]
        ///  extern nint PROPERTY_01 (nint name, System.StringComparison comparison);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader)
        /// </summary>
        /// <param name="reader">abstract class Newtonsoft.Json.JsonReader</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReadFrom", Search = typeof(Search_JObject))]
        /// static extern nint READ_FROM_00 (nint reader);


        /// <summary>
        /// static  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
        /// </summary>
        /// <param name="reader">abstract class Newtonsoft.Json.JsonReader</param>
        /// <param name="settings">class Newtonsoft.Json.Linq.JsonLoadSettings</param>
        /// <returns>abstract class Newtonsoft.Json.Linq.JToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReadFrom", Search = typeof(Search_JObject))]
        /// static extern nint READ_FROM_01 (nint reader, nint settings);


        /// <summary>
        ///   System.Boolean Remove(System.String propertyName)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_JObject))]
        ///  extern System.Boolean REMOVE_00 (nint propertyName);


        /// <summary>
        ///   System.Void Remove()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_JObject))]
        ///  extern void REMOVE_01 ();


        /// <summary>
        ///   System.Void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings)
        /// </summary>
        /// <param name="lineInfo">interface Newtonsoft.Json.IJsonLineInfo</param>
        /// <param name="settings">class Newtonsoft.Json.Linq.JsonLoadSettings</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLineInfo", Search = typeof(Search_JObject))]
        ///  extern void SET_LINE_INFO_00 (nint lineInfo, nint settings);


        /// <summary>
        ///   System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
        /// </summary>
        /// <param name="lineNumber">struct System.Int32</param>
        /// <param name="linePosition">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLineInfo", Search = typeof(Search_JObject))]
        ///  extern void SET_LINE_INFO_01 (System.Int32 lineNumber, System.Int32 linePosition);


        /// <summary>
        ///   System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes)
        /// </summary>
        /// <param name="attributes">class System.Attribute[]</param>
        /// <returns>class System.ComponentModel.EventDescriptorCollection</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetEvents", Search = typeof(Search_JObject))]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_EVENTS_00 (nint attributes);


        /// <summary>
        ///   System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
        /// </summary>
        /// <returns>class System.ComponentModel.EventDescriptorCollection</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetEvents", Search = typeof(Search_JObject))]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_EVENTS_01 ();


        /// <summary>
        ///   System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
        /// </summary>
        /// <returns>class System.ComponentModel.PropertyDescriptorCollection</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetProperties", Search = typeof(Search_JObject))]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_PROPERTIES_00 ();


        /// <summary>
        ///   System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
        /// </summary>
        /// <param name="attributes">class System.Attribute[]</param>
        /// <returns>class System.ComponentModel.PropertyDescriptorCollection</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.ComponentModel.ICustomTypeDescriptor.GetProperties", Search = typeof(Search_JObject))]
        ///  extern nint SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_PROPERTIES_01 (nint attributes);


        /// <summary>
        ///   System.Object ToObject(System.Type objectType)
        /// </summary>
        /// <param name="objectType">abstract class System.Type</param>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToObject", Search = typeof(Search_JObject))]
        ///  extern nint TO_OBJECT_00 (nint objectType);


        /// <summary>
        ///   System.Object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer)
        /// </summary>
        /// <param name="objectType">abstract class System.Type</param>
        /// <param name="jsonSerializer">class Newtonsoft.Json.JsonSerializer</param>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToObject", Search = typeof(Search_JObject))]
        ///  extern nint TO_OBJECT_01 (nint objectType, nint jsonSerializer);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_JObject))]
        extern PMonoString TO_STRING_00();


        /// <summary>
        ///   System.String ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters)
        /// </summary>
        /// <param name="formatting">enum Newtonsoft.Json.Formatting</param>
        /// <param name="converters">class Newtonsoft.Json.JsonConverter[]</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_JObject))]
        ///  extern nint TO_STRING_01 (Newtonsoft.Json.Formatting formatting, nint converters);


        /// <summary>
        ///   System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
        /// </summary>
        /// <param name="o">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="existing">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ValidateToken", Search = typeof(Search_JObject))]
        ///  extern void VALIDATE_TOKEN_00 (nint o, nint existing);


        /// <summary>
        ///   System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
        /// </summary>
        /// <param name="o">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="existing">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ValidateToken", Search = typeof(Search_JObject))]
        ///  extern void VALIDATE_TOKEN_01 (nint o, nint existing);


        /// <summary>
        /// static  System.Boolean ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, System.Boolean nullable)
        /// </summary>
        /// <param name="o">abstract class Newtonsoft.Json.Linq.JToken</param>
        /// <param name="validTypes">class Newtonsoft.Json.Linq.JTokenType[]</param>
        /// <param name="nullable">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ValidateToken", Search = typeof(Search_JObject))]
        /// static extern System.Boolean VALIDATE_TOKEN_02 (nint o, nint validTypes, System.Boolean nullable);


        /// <summary>
        ///   System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
        /// </summary>
        /// <param name="writer">abstract class Newtonsoft.Json.JsonWriter</param>
        /// <param name="converters">class Newtonsoft.Json.JsonConverter[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("WriteTo", Search = typeof(Search_JObject))]
        ///  extern void WRITE_TO_00 (nint writer, nint converters);


        /// <summary>
        ///  abstract System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
        /// </summary>
        /// <param name="writer">abstract class Newtonsoft.Json.JsonWriter</param>
        /// <param name="converters">class Newtonsoft.Json.JsonConverter[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("WriteTo", Search = typeof(Search_JObject))]
        ///  extern void WRITE_TO_01 (nint writer, nint converters);


        public static partial class Search_JObject
        {
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
            ///   System.Void .ctor(Newtonsoft.Json.Linq.JObject other)
            /// </summary>
            /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Newtonsoft.Json.Linq.JObject");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(Newtonsoft.Json.Linq.JContainer other)
            /// </summary>
            /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Newtonsoft.Json.Linq.JContainer");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Add(System.String propertyName, Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool ADD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "System.String", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Add(System.Object content)
            /// </summary>
            /// public static bool ADD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "System.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
            /// </summary>
            /// public static bool CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Children");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
            /// </summary>
            /// public static bool CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Children");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken CloneToken()
            /// </summary>
            /// public static bool CLONE_TOKEN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CloneToken");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract Newtonsoft.Json.Linq.JToken CloneToken()
            /// </summary>
            /// public static bool CLONE_TOKEN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CloneToken");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken EnsureValue(System.Object value)
            /// </summary>
            /// public static bool ENSURE_VALUE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EnsureValue", "System.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool ENSURE_VALUE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EnsureValue", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
            /// </summary>
            /// public static bool GET_CHILDREN_TOKENS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_ChildrenTokens");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
            /// </summary>
            /// public static bool GET_CHILDREN_TOKENS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_ChildrenTokens");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken get_First()
            /// </summary>
            /// public static bool GET_FIRST_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_First");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken get_First()
            /// </summary>
            /// public static bool GET_FIRST_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_First");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean get_HasValues()
            /// </summary>
            /// public static bool GET_HAS_VALUES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_HasValues");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract System.Boolean get_HasValues()
            /// </summary>
            /// public static bool GET_HAS_VALUES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_HasValues");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
            /// </summary>
            /// public static bool GET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken get_Item(System.String propertyName)
            /// </summary>
            /// public static bool GET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
            /// </summary>
            /// public static bool GET_ITEM_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken get_Last()
            /// </summary>
            /// public static bool GET_LAST_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Last");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JToken get_Last()
            /// </summary>
            /// public static bool GET_LAST_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Last");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JTokenType get_Type()
            /// </summary>
            /// public static bool GET_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Type");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract Newtonsoft.Json.Linq.JTokenType get_Type()
            /// </summary>
            /// public static bool GET_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Type");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
            /// </summary>
            /// public static bool GET_META_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMetaObject", "System.Linq.Expressions.Expression");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
            /// </summary>
            /// public static bool GET_META_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMetaObject", "System.Linq.Expressions.Expression");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
            /// </summary>
            /// public static bool INDEX_OF_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IndexOfItem", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
            /// </summary>
            /// public static bool INDEX_OF_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IndexOfItem", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck)
            /// </summary>
            /// public static bool INSERT_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InsertItem", "System.Int32", "Newtonsoft.Json.Linq.JToken", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck)
            /// </summary>
            /// public static bool INSERT_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InsertItem", "System.Int32", "Newtonsoft.Json.Linq.JToken", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Boolean op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Boolean> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Int64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Double> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Char> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Int32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Int16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_0A (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.UInt16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_0B (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Char op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_0C (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Byte op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_0D (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.SByte op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_0E (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Int32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_0F (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Int16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_10 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.UInt16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_11 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Byte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_12 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.SByte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_13 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_14 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Int64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_15 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Single> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_16 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Decimal op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_17 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.UInt32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_18 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.UInt64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_19 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Double op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_1A (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Single op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_1B (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.String op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_1C (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.UInt32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_1D (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.UInt64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_1E (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_1F (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_20 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_21 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_22 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value)
            /// </summary>
            /// public static bool OP_EXPLICIT_23 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Explicit", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  Newtonsoft.Json.Linq.JObject Parse(System.String json)
            /// </summary>
            /// public static bool PARSE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  Newtonsoft.Json.Linq.JObject Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings)
            /// </summary>
            /// public static bool PARSE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.String", "Newtonsoft.Json.Linq.JsonLoadSettings");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JProperty Property(System.String name)
            /// </summary>
            /// public static bool PROPERTY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Property", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Newtonsoft.Json.Linq.JProperty Property(System.String name, System.StringComparison comparison)
            /// </summary>
            /// public static bool PROPERTY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Property", "System.String", "System.StringComparison");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader)
            /// </summary>
            /// public static bool READ_FROM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReadFrom", "Newtonsoft.Json.JsonReader");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
            /// </summary>
            /// public static bool READ_FROM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReadFrom", "Newtonsoft.Json.JsonReader", "Newtonsoft.Json.Linq.JsonLoadSettings");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean Remove(System.String propertyName)
            /// </summary>
            /// public static bool REMOVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Remove()
            /// </summary>
            /// public static bool REMOVE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings)
            /// </summary>
            /// public static bool SET_LINE_INFO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLineInfo", "Newtonsoft.Json.IJsonLineInfo", "Newtonsoft.Json.Linq.JsonLoadSettings");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
            /// </summary>
            /// public static bool SET_LINE_INFO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLineInfo", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes)
            /// </summary>
            /// public static bool SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_EVENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "System.ComponentModel.ICustomTypeDescriptor.GetEvents", "System.Attribute[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
            /// </summary>
            /// public static bool SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_EVENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "System.ComponentModel.ICustomTypeDescriptor.GetEvents");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
            /// </summary>
            /// public static bool SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_PROPERTIES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "System.ComponentModel.ICustomTypeDescriptor.GetProperties");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
            /// </summary>
            /// public static bool SYSTEM.COMPONENT_MODEL.I_CUSTOM_TYPE_DESCRIPTOR.GET_PROPERTIES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "System.ComponentModel.ICustomTypeDescriptor.GetProperties", "System.Attribute[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Object ToObject(System.Type objectType)
            /// </summary>
            /// public static bool TO_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToObject", "System.Type");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer)
            /// </summary>
            /// public static bool TO_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToObject", "System.Type", "Newtonsoft.Json.JsonSerializer");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String ToString()
            /// </summary>
            public static bool TO_STRING_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters)
            /// </summary>
            /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "Newtonsoft.Json.Formatting", "Newtonsoft.Json.JsonConverter[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
            /// </summary>
            /// public static bool VALIDATE_TOKEN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ValidateToken", "Newtonsoft.Json.Linq.JToken", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
            /// </summary>
            /// public static bool VALIDATE_TOKEN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ValidateToken", "Newtonsoft.Json.Linq.JToken", "Newtonsoft.Json.Linq.JToken");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Boolean ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, System.Boolean nullable)
            /// </summary>
            /// public static bool VALIDATE_TOKEN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ValidateToken", "Newtonsoft.Json.Linq.JToken", "Newtonsoft.Json.Linq.JTokenType[]", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
            /// </summary>
            /// public static bool WRITE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "WriteTo", "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
            /// </summary>
            /// public static bool WRITE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "WriteTo", "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]");
            ///     
            ///  
            /// 
            /// 
        }

    }


}