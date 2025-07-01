namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AVGBaseSkill"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000032U)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 66, 97, 115, 101, 83, 107, 105, 108, 108])]


    // class 0x10 AVGAbilityConfig abilityConfig
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"abilityConfig", "ABILITY_CONFIG")]
    public partial class AVGBaseSkill
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGBaseSkill";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 66, 97, 115, 101, 83, 107, 105, 108, 108];

        //public const uint Const_TypeToken = 0x02000032U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGBaseSkill(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGBaseSkill(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGBaseSkill obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGBaseSkill obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGBaseSkill"]
    /// </summary>
    public partial class AVGBaseSkill
    {



        /// <summary>
        ///   System.Void .ctor(AVGAbilityConfig config)
        /// </summary>
        /// <param name="config">class AVGAbilityConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (nint config);


        /// <summary>
        ///   System.Void RefreshAbilityConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshAbilityConfig")]
        ///  extern void REFRESH_ABILITY_CONFIG ();




        /// public static partial class Search_AVGBaseSkill
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}