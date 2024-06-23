
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
    /// static class ["Assembly-CSharp.dll".""."ControlSettings"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020001E2U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [67, 111, 110, 116, 114, 111, 108, 83, 101, 116, 116, 105, 110, 103, 115])]
                
    //  struct static System.Boolean isHUDClosed
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isHUDClosed", "IS_HUD_CLOSED", true)]
            
    //  struct static System.Boolean isHateClosed
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isHateClosed", "IS_HATE_CLOSED", true)]
            
    //  struct static System.Boolean isCharacterHide
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isCharacterHide", "IS_CHARACTER_HIDE", true)]
            
    //  struct static System.Boolean is2xSpeedMove
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"is2xSpeedMove", "IS2X_SPEED_MOVE", true)]
            
    //  struct static System.Boolean is10xWorldTime
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"is10xWorldTime", "IS10X_WORLD_TIME", true)]
            
    //  struct static System.Boolean isInfiniteStamina
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isInfiniteStamina", "IS_INFINITE_STAMINA", true)]
            
    //  struct static System.Boolean isBattleAutoWin
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isBattleAutoWin", "IS_BATTLE_AUTO_WIN", true)]
            
    //  struct static System.Boolean is10xBattleExp
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"is10xBattleExp", "IS10X_BATTLE_EXP", true)]
            
    //  struct static System.Boolean isBgmClosed
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isBgmClosed", "IS_BGM_CLOSED", true)]
            
    //  struct static System.Boolean isAwayRain
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isAwayRain", "IS_AWAY_RAIN", true)]
            
    //  struct static System.Boolean isUnlimitedMoney
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isUnlimitedMoney", "IS_UNLIMITED_MONEY", true)]
            
    //  struct static System.Boolean isSealSurefire
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isSealSurefire", "IS_SEAL_SUREFIRE", true)]
            
    //  struct static System.Boolean isBreakStrength
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isBreakStrength", "IS_BREAK_STRENGTH", true)]
            
    //  struct static System.Boolean isLogRecord
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isLogRecord", "IS_LOG_RECORD", true)]
    
    public partial class ControlSettings
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ControlSettings";
        //public static byte[] Static_ClassName { get; } = [67, 111, 110, 116, 114, 111, 108, 83, 101, 116, 116, 105, 110, 103, 115];

        //public const uint Const_TypeToken = 0x020001E2U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ControlSettings(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ControlSettings(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ControlSettings obj) => obj._ptr;
            public static implicit operator bool(Ptr_ControlSettings obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }


}