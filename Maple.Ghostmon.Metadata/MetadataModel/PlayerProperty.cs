
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."PlayerProperty"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000126U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [80, 108, 97, 121, 101, 114, 80, 114, 111, 112, 101, 114, 116, 121])]

    // struct 0x10 System.Single p_flash_scale
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "p_flash_scale", "P_FLASH_SCALE", IsReadOnly = false)]

    // struct 0x14 System.Single p_colorful_scale
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "p_colorful_scale", "P_COLORFUL_SCALE", IsReadOnly = false)]
    // struct 0x10 System.Single p_move_speed_scale
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "p_move_speed_scale", "P_MOVE_SPEED_SCALE", IsReadOnly = false)]

    // struct 0x14 System.Single p_endurance_consume_scale
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"p_endurance_consume_scale", "P_ENDURANCE_CONSUME_SCALE")]

    // struct 0x18 System.Single p_endurance_resume_scale
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"p_endurance_resume_scale", "P_ENDURANCE_RESUME_SCALE")]

    // struct 0x1C System.Single p_hide_scale
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"p_hide_scale", "P_HIDE_SCALE")]

    // struct 0x20 System.Single p_cast_cd
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"p_cast_cd", "P_CAST_CD")]

    // struct 0x24 System.Single p_exp_scale
    [MonoCollectorSearchFieldAttribute(typeof(System.Single), "p_exp_scale", "P_EXP_SCALE", IsReadOnly = false)]
    public partial class PlayerProperty
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PlayerProperty";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 80, 114, 111, 112, 101, 114, 116, 121];

        //public const uint Const_TypeToken = 0x02000126U;




        /// <summary>
        /// struct System.Single PLAYER_MOVE_SPEED "7"
        /// </summary>
        /// public const System.Single PLAYER_MOVE_SPEED=>"7";

        /// <summary>
        /// struct System.Single PLAYER_ENDURANCE_CONSUME "6"
        /// </summary>
        /// public const System.Single PLAYER_ENDURANCE_CONSUME=>"6";

        /// <summary>
        /// struct System.Single PLAYER_ENDURANCE_RESUME "3"
        /// </summary>
        /// public const System.Single PLAYER_ENDURANCE_RESUME=>"3";

        /// <summary>
        /// struct System.Single PLAYER_HIDE_SCALE "1"
        /// </summary>
        /// public const System.Single PLAYER_HIDE_SCALE=>"1";

        /// <summary>
        /// struct System.Single PLAYER_CAST_CD "0"
        /// </summary>
        /// public const System.Single PLAYER_CAST_CD=>"0";

        /// <summary>
        /// struct System.Single PLAYER_EXP_ADDITION "1"
        /// </summary>
        /// public const System.Single PLAYER_EXP_ADDITION=>"1";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerProperty(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerProperty(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerProperty obj) => obj._ptr;
            public static implicit operator bool(Ptr_PlayerProperty obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."PlayerProperty"]
    /// </summary>
    public partial class PlayerProperty
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Void PlayerPropertyAdjust(PlayerPropertyType type, System.Single value)
        /// </summary>
        /// <param name="type">enum PlayerPropertyType</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayerPropertyAdjust")]
        ///  extern void PLAYER_PROPERTY_ADJUST (PlayerPropertyType type, System.Single value);




        /// public static partial class Search_PlayerProperty
        /// {
        /// 
        ///     
        /// 
        /// }

    }
}