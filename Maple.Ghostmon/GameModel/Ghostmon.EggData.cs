
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
    /// class ["Assembly-CSharp.dll"."Ghostmon"."EggData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000276U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [69, 103, 103, 68, 97, 116, 97])]

    // struct 0x10 System.UInt64 dataID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "dataID", "DATA_ID")]

    // struct 0x18 System.UInt64 configID
    [MonoCollectorSearchFieldAttribute(typeof(System.UInt64), "configID", "CONFIG_ID")]

    // struct 0x20 System.Int32 propertyRank
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "propertyRank", "PROPERTY_RANK", IsReadOnly = false)]

    // struct 0x24 System.Int32 abilityRank
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "abilityRank", "ABILITY_RANK", IsReadOnly = false)]

    // class 0x28 System.String monster
     [MonoCollectorSearchFieldAttribute(typeof(PMonoString),"monster", "MONSTER")]

    // class 0x30 System.UInt64[] ablity
    [MonoCollectorSearchFieldAttribute(typeof(nint), "ablity", "ABLITY", IsReadOnly = false)]

    // class 0x38 System.Int32[] property
    [MonoCollectorSearchFieldAttribute(typeof(PMonoArray<int>), "property", "PROPERTY", IsReadOnly = false)]

    // struct 0x40 System.Int32 damageType
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "damageType", "DAMAGE_TYPE", IsReadOnly = false)]

    // struct 0x44 System.Single totalTime
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "totalTime", "TOTAL_TIME", IsReadOnly = false)]

    // struct 0x48 System.Single remainingTime
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "remainingTime", "REMAINING_TIME", IsReadOnly = false)]

    // struct 0x4C System.Boolean variColor
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "variColor", "VARI_COLOR", IsReadOnly = false)]

    // struct 0x4D System.Boolean flash
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "flash", "FLASH", IsReadOnly = false)]

    // struct 0x4E System.Boolean leader
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "leader", "LEADER", IsReadOnly = false)]

    // struct 0x50 System.Int32 price
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "price", "PRICE")]

    // class 0x58 System.String parentName
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"parentName", "PARENT_NAME")]

    // struct 0x60 System.Int32 gemPrice
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"gemPrice", "GEM_PRICE")]
    public partial class EggData
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "EggData";
        //public static byte[] Static_ClassName { get; } = [69, 103, 103, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x02000276U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_EggData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_EggData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_EggData obj) => obj._ptr;
            public static implicit operator bool(Ptr_EggData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."EggData"]
    /// </summary>
    public partial class EggData
    {





        /// <summary>
        ///   System.Void .ctor(Ghostmon.EggConfig config)
        /// </summary>
        /// <param name="config">class Ghostmon.EggConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_EggData))]
        ///  extern void .CTOR_00 (nint config);


        /// <summary>
        ///   System.Void .ctor(System.String monster, System.UInt64[] ablity, System.Single[] property, System.Int32 propertyRank)
        /// </summary>
        /// <param name="monster">class System.String</param>
        /// <param name="ablity">class System.UInt64[]</param>
        /// <param name="property">class System.Single[]</param>
        /// <param name="propertyRank">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_EggData))]
        ///  extern void .CTOR_01 (nint monster, nint ablity, nint property, System.Int32 propertyRank);


        /// public static partial class Search_EggData
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(Ghostmon.EggConfig config)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Ghostmon.EggConfig");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.String monster, System.UInt64[] ablity, System.Single[] property, System.Int32 propertyRank)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.String", "System.UInt64[]", "System.Single[]", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}