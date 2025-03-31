
using Maple.MonoGameAssistant.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// struct ["mscorlib.dll"."System"."UInt64"]
    /// [System.IComparable]=>[System.IFormattable]=>[System.IConvertible]=>[System.IComparable<System.UInt64>]=>[System.IEquatable<System.UInt64>]
    /// </summary>
    public partial class SystemUInt64
    {


        /// <summary>
        /// struct System.UInt64 MaxValue "18446744073709551615"
        /// </summary>
        /// public const System.UInt64 MAX_VALUE=>"18446744073709551615";

        /// <summary>
        /// struct System.UInt64 MinValue "0"
        /// </summary>
        /// public const System.UInt64 MIN_VALUE=>"0";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_SystemUInt64
        {



            /// const string Name_Field_m_value = "m_value";
            /// <summary>
            /// struct 0x10 System.UInt64 m_value
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.UInt64 m_value;

        }

    }

    /// <summary>
    /// struct ["mscorlib.dll"."System"."UInt64"]
    /// 
    /// [System.IComparable]=>[System.IFormattable]=>[System.IConvertible]=>[System.IComparable<System.UInt64>]=>[System.IEquatable<System.UInt64>]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([109, 115, 99, 111, 114, 108, 105, 98, 46, 100, 108, 108], 0x02000157U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([109, 115, 99, 111, 114, 108, 105, 98, 46, 100, 108, 108], [83, 121, 115, 116, 101, 109], [85, 73, 110, 116, 54, 52])]


    // struct 0x10 System.UInt64 m_value
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt64),"m_value", "M_VALUE")]
    public partial class SystemUInt64
    {
        //public const string Const_ImageName = "mscorlib.dll";
        //public static byte[] Static_ImageName { get; } = [109, 115, 99, 111, 114, 108, 105, 98, 46, 100, 108, 108];

        //public const string Const_Namespace = "System";
        //public static byte[] Static_Namespace { get; } = [83, 121, 115, 116, 101, 109];

        //public const string Const_ClassName = "UInt64";
        //public static byte[] Static_ClassName { get; } = [85, 73, 110, 116, 54, 52];

        //public const uint Const_TypeToken = 0x02000157U;




        /// <summary>
        /// struct System.UInt64 MaxValue "18446744073709551615"
        /// </summary>
        /// public const System.UInt64 MAX_VALUE=>"18446744073709551615";

        /// <summary>
        /// struct System.UInt64 MinValue "0"
        /// </summary>
        /// public const System.UInt64 MIN_VALUE=>"0";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SystemUInt64(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SystemUInt64(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SystemUInt64 obj) => obj._ptr;
            public static implicit operator bool(Ptr_SystemUInt64 obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["mscorlib.dll"."System"."UInt64"]
    /// </summary>
    public partial class SystemUInt64
    {



        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   System.TypeCode GetTypeCode()
        /// </summary>
        /// <returns>enum System.TypeCode</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTypeCode")]
        ///  extern System.TypeCode GET_TYPE_CODE ();


        /// <summary>
        ///   System.Boolean System.IConvertible.ToBoolean(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToBoolean")]
        ///  extern System.Boolean SYSTEM.I_CONVERTIBLE.TO_BOOLEAN (nint provider);


        /// <summary>
        ///   System.Byte System.IConvertible.ToByte(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Byte</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToByte")]
        ///  extern System.Byte SYSTEM.I_CONVERTIBLE.TO_BYTE (nint provider);


        /// <summary>
        ///   System.Char System.IConvertible.ToChar(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Char</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToChar")]
        ///  extern System.Char SYSTEM.I_CONVERTIBLE.TO_CHAR (nint provider);


        /// <summary>
        ///   System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.DateTime</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToDateTime")]
        ///  extern System.DateTime SYSTEM.I_CONVERTIBLE.TO_DATE_TIME (nint provider);


        /// <summary>
        ///   System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Decimal</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToDecimal")]
        ///  extern System.Decimal SYSTEM.I_CONVERTIBLE.TO_DECIMAL (nint provider);


        /// <summary>
        ///   System.Double System.IConvertible.ToDouble(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Double</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToDouble")]
        ///  extern System.Double SYSTEM.I_CONVERTIBLE.TO_DOUBLE (nint provider);


        /// <summary>
        ///   System.Int16 System.IConvertible.ToInt16(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Int16</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToInt16")]
        ///  extern System.Int16 SYSTEM.I_CONVERTIBLE.TO_INT16 (nint provider);


        /// <summary>
        ///   System.Int32 System.IConvertible.ToInt32(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToInt32")]
        ///  extern System.Int32 SYSTEM.I_CONVERTIBLE.TO_INT32 (nint provider);


        /// <summary>
        ///   System.Int64 System.IConvertible.ToInt64(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Int64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToInt64")]
        ///  extern System.Int64 SYSTEM.I_CONVERTIBLE.TO_INT64 (nint provider);


        /// <summary>
        ///   System.SByte System.IConvertible.ToSByte(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.SByte</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToSByte")]
        ///  extern System.SByte SYSTEM.I_CONVERTIBLE.TO_S_BYTE (nint provider);


        /// <summary>
        ///   System.Single System.IConvertible.ToSingle(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToSingle")]
        ///  extern System.Single SYSTEM.I_CONVERTIBLE.TO_SINGLE (nint provider);


        /// <summary>
        ///   System.Object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToType")]
        ///  extern nint SYSTEM.I_CONVERTIBLE.TO_TYPE (nint type, nint provider);


        /// <summary>
        ///   System.UInt16 System.IConvertible.ToUInt16(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.UInt16</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToUInt16")]
        ///  extern System.UInt16 SYSTEM.I_CONVERTIBLE.TO_U_INT16 (nint provider);


        /// <summary>
        ///   System.UInt32 System.IConvertible.ToUInt32(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.UInt32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToUInt32")]
        ///  extern System.UInt32 SYSTEM.I_CONVERTIBLE.TO_U_INT32 (nint provider);


        /// <summary>
        ///   System.UInt64 System.IConvertible.ToUInt64(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.IConvertible.ToUInt64")]
        ///  extern System.UInt64 SYSTEM.I_CONVERTIBLE.TO_U_INT64 (nint provider);


        /// <summary>
        /// static  System.Boolean TryParse(System.String s, System.Globalization.NumberStyles style, System.IFormatProvider provider, System.UInt64& result)
        /// </summary>
        /// <param name="s">class System.String</param>
        /// <param name="style">enum System.Globalization.NumberStyles</param>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <param name="result">struct System.UInt64&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryParse")]
        /// static extern System.Boolean TRY_PARSE (nint s, System.Globalization.NumberStyles style, nint provider, System.UInt64& result);



        /// <summary>
        ///   System.Int32 CompareTo(System.Object value)
        /// </summary>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_UInt64))]
        ///  extern System.Int32 COMPARE_TO_00 (nint value);


        /// <summary>
        ///   System.Int32 CompareTo(System.UInt64 value)
        /// </summary>
        /// <param name="value">struct System.UInt64</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_UInt64))]
        ///  extern System.Int32 COMPARE_TO_01 (System.UInt64 value);


        /// <summary>
        ///   System.Boolean Equals(System.Object obj)
        /// </summary>
        /// <param name="obj">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_UInt64))]
        ///  extern System.Boolean EQUALS_00 (nint obj);


        /// <summary>
        ///   System.Boolean Equals(System.UInt64 obj)
        /// </summary>
        /// <param name="obj">struct System.UInt64</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_UInt64))]
        ///  extern System.Boolean EQUALS_01 (System.UInt64 obj);


        /// <summary>
        /// static  System.UInt64 Parse(System.String s)
        /// </summary>
        /// <param name="s">class System.String</param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_UInt64))]
        /// static extern System.UInt64 PARSE_00 (nint s);


        /// <summary>
        /// static  System.UInt64 Parse(System.String s, System.Globalization.NumberStyles style)
        /// </summary>
        /// <param name="s">class System.String</param>
        /// <param name="style">enum System.Globalization.NumberStyles</param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_UInt64))]
        /// static extern System.UInt64 PARSE_01 (nint s, System.Globalization.NumberStyles style);


        /// <summary>
        /// static  System.UInt64 Parse(System.String s, System.IFormatProvider provider)
        /// </summary>
        /// <param name="s">class System.String</param>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_UInt64))]
        /// static extern System.UInt64 PARSE_02 (nint s, nint provider);


        /// <summary>
        /// static  System.UInt64 Parse(System.String s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
        /// </summary>
        /// <param name="s">class System.String</param>
        /// <param name="style">enum System.Globalization.NumberStyles</param>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>struct System.UInt64</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_UInt64))]
        /// static extern System.UInt64 PARSE_03 (nint s, System.Globalization.NumberStyles style, nint provider);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_UInt64))]
        ///  extern nint TO_STRING_00 ();


        /// <summary>
        ///   System.String ToString(System.IFormatProvider provider)
        /// </summary>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_UInt64))]
        ///  extern nint TO_STRING_01 (nint provider);


        /// <summary>
        ///   System.String ToString(System.String format)
        /// </summary>
        /// <param name="format">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_UInt64))]
        ///  extern nint TO_STRING_02 (nint format);


        /// <summary>
        ///   System.String ToString(System.String format, System.IFormatProvider provider)
        /// </summary>
        /// <param name="format">class System.String</param>
        /// <param name="provider">interface System.IFormatProvider</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_UInt64))]
        ///  extern nint TO_STRING_03 (nint format, nint provider);


        /// public static partial class Search_UInt64
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Int32 CompareTo(System.Object value)
        /// </summary>
        /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 CompareTo(System.UInt64 value)
        /// </summary>
        /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.UInt64");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Equals(System.Object obj)
        /// </summary>
        /// public static bool EQUALS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "System.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Equals(System.UInt64 obj)
        /// </summary>
        /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "System.UInt64");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.UInt64 Parse(System.String s)
        /// </summary>
        /// public static bool PARSE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.UInt64 Parse(System.String s, System.Globalization.NumberStyles style)
        /// </summary>
        /// public static bool PARSE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.String", "System.Globalization.NumberStyles");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.UInt64 Parse(System.String s, System.IFormatProvider provider)
        /// </summary>
        /// public static bool PARSE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.String", "System.IFormatProvider");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.UInt64 Parse(System.String s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
        /// </summary>
        /// public static bool PARSE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.String", "System.Globalization.NumberStyles", "System.IFormatProvider");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String ToString(System.IFormatProvider provider)
        /// </summary>
        /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "System.IFormatProvider");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String ToString(System.String format)
        /// </summary>
        /// public static bool TO_STRING_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String ToString(System.String format, System.IFormatProvider provider)
        /// </summary>
        /// public static bool TO_STRING_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "System.String", "System.IFormatProvider");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}