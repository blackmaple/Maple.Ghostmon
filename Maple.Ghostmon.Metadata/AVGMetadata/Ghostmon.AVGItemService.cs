namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Ghostmon"."AVGItemService"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000436U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [71, 104, 111, 115, 116, 109, 111, 110], [65, 86, 71, 73, 116, 101, 109, 83, 101, 114, 118, 105, 99, 101])]


    public partial class AVGItemService
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Ghostmon";
        //public static byte[] Static_Namespace { get; } = [71, 104, 111, 115, 116, 109, 111, 110];

        //public const string Const_ClassName = "AVGItemService";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 73, 116, 101, 109, 83, 101, 114, 118, 105, 99, 101];

        //public const uint Const_TypeToken = 0x02000436U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGItemService(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGItemService(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGItemService obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGItemService obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Ghostmon"."AVGItemService"]
    /// </summary>
    public partial class AVGItemService
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Void AddItem(AVGBagItemData item)
        /// </summary>
        /// <param name="item">class AVGBagItemData</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItem")]
        extern void ADD_ITEM(AVGBagItemData.Ptr_AVGBagItemData item);


        /// <summary>
        ///   System.Boolean ExistItem(System.UInt64 configId)
        /// </summary>
        /// <param name="configId">struct System.UInt64</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExistItem")]
        ///  extern System.Boolean EXIST_ITEM (System.UInt64 configId);


        /// <summary>
        ///   AVGBagItemData FindBestItem(System.Collections.Generic.List<AVGBagItemData> items, AVGBagItemEffect type, System.Int32 neededValue)
        /// </summary>
        /// <param name="items">class System.Collections.Generic.List<AVGBagItemData></param>
        /// <param name="type">enum AVGBagItemEffect</param>
        /// <param name="neededValue">struct System.Int32</param>
        /// <returns>class AVGBagItemData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindBestItem")]
        ///  extern nint FIND_BEST_ITEM (nint items, AVGBagItemEffect type, System.Int32 neededValue);


        /// <summary>
        ///   System.Void GetDropItem(System.UInt64 dropId)
        /// </summary>
        /// <param name="dropId">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDropItem")]
        ///  extern void GET_DROP_ITEM (System.UInt64 dropId);


        /// <summary>
        ///   System.Void RecoveryBestState(AVGMonsterData currentSelectedMonster)
        /// </summary>
        /// <param name="currentSelectedMonster">class AVGMonsterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecoveryBestState")]
        ///  extern void RECOVERY_BEST_STATE (nint currentSelectedMonster);


        /// <summary>
        ///   System.Void RemoveItem(AVGBagItemData item)
        /// </summary>
        /// <param name="item">class AVGBagItemData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItem")]
        ///  extern void REMOVE_ITEM (nint item);


        /// <summary>
        ///   System.Void UpdateItem(System.UInt64 configId, System.Int32 num)
        /// </summary>
        /// <param name="configId">struct System.UInt64</param>
        /// <param name="num">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateItem")]
        ///  extern void UPDATE_ITEM (System.UInt64 configId, System.Int32 num);


        /// <summary>
        ///   System.ValueTuple<System.Boolean,System.String> UseItemOnMonster(AVGMonsterData target, System.UInt64 itemId, AVGBagItemData item)
        /// </summary>
        /// <param name="target">class AVGMonsterData</param>
        /// <param name="itemId">struct System.UInt64</param>
        /// <param name="item">class AVGBagItemData</param>
        /// <returns>struct System.ValueTuple<System.Boolean,System.String></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("UseItemOnMonster")]
        ///  extern System.ValueTuple<System.Boolean,System.String> USE_ITEM_ON_MONSTER (nint target, System.UInt64 itemId, nint item);




        /// public static partial class Search_AVGItemService
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}