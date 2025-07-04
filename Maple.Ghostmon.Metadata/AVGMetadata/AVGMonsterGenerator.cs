namespace Maple.Ghostmon.Metadata
{


    /// <summary>
    /// static class ["Assembly-CSharp.dll".""."AVGMonsterGenerator"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200004DU)]
    [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [65, 86, 71, 77, 111, 110, 115, 116, 101, 114, 71, 101, 110, 101, 114, 97, 116, 111, 114])]

    //  class static System.Int32[] QualityProbabilities
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"QualityProbabilities", "QUALITY_PROBABILITIES", true)]

    public partial class AVGMonsterGenerator
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AVGMonsterGenerator";
        //public static byte[] Static_ClassName { get; } = [65, 86, 71, 77, 111, 110, 115, 116, 101, 114, 71, 101, 110, 101, 114, 97, 116, 111, 114];

        //public const uint Const_TypeToken = 0x0200004DU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AVGMonsterGenerator(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AVGMonsterGenerator(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AVGMonsterGenerator obj) => obj._ptr;
            public static implicit operator bool(Ptr_AVGMonsterGenerator obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."AVGMonsterGenerator"]
    /// </summary>
    public partial class AVGMonsterGenerator
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        /// static  AVGMonsterData CreateMonsterData(AVGMonsterConfig config, System.Int32 level, System.Collections.Generic.List<System.Int32> quality)
        /// </summary>
        /// <param name="config">class AVGMonsterConfig</param>
        /// <param name="level">struct System.Int32</param>
        /// <param name="quality">class System.Collections.Generic.List<System.Int32></param>
        /// <returns>class AVGMonsterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateMonsterData")]
        /// static extern nint CREATE_MONSTER_DATA (nint config, System.Int32 level, nint quality);


        /// <summary>
        /// static  System.Collections.Generic.List<AVGMonsterData> GenerateListMonster(System.String ids)
        /// </summary>
        /// <param name="ids">class System.String</param>
        /// <returns>class System.Collections.Generic.List<AVGMonsterData></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateListMonster")]
        /// static extern nint GENERATE_LIST_MONSTER (nint ids);


        /// <summary>
        /// static  System.Collections.Generic.List<AVGMonsterData> GenerateMonsterByTag(System.Int32 tag)
        /// </summary>
        /// <param name="tag">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.List<AVGMonsterData></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateMonsterByTag")]
        /// static extern nint GENERATE_MONSTER_BY_TAG (System.Int32 tag);


        /// <summary>
        /// static  System.Void GenerateMonsterSkills(AVGMonsterData monster, AVGMonsterConfig config)
        /// </summary>
        /// <param name="monster">class AVGMonsterData</param>
        /// <param name="config">class AVGMonsterConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateMonsterSkills")]
        /// static extern void GENERATE_MONSTER_SKILLS (nint monster, nint config);


        /// <summary>
        /// static  System.Int32 GenerateQuality()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateQuality")]
        /// static extern System.Int32 GENERATE_QUALITY ();


        /// <summary>
        /// static  System.Collections.Generic.List<AVGMonsterData> RandomGenerateMonster(System.Int32 num)
        /// </summary>
        /// <param name="num">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.List<AVGMonsterData></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomGenerateMonster")]
        /// static extern nint RANDOM_GENERATE_MONSTER (System.Int32 num);



        /// <summary>
        /// static  AVGMonsterData GenerateMonster(System.Int32 poolId)
        /// </summary>
        /// <param name="poolId">struct System.Int32</param>
        /// <returns>class AVGMonsterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateMonster", Search = typeof(Search_AVGMonsterGenerator))]
        /// static extern nint GENERATE_MONSTER_00 (System.Int32 poolId);


        /// <summary>
        /// static  AVGMonsterData GenerateMonster(System.UInt64 id, System.Int32 level, System.Collections.Generic.List<System.Int32> quality)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <param name="level">struct System.Int32</param>
        /// <param name="quality">class System.Collections.Generic.List<System.Int32></param>
        /// <returns>class AVGMonsterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateMonster", Search = typeof(Search_AVGMonsterGenerator))]
        /// static extern nint GENERATE_MONSTER_01 (System.UInt64 id, System.Int32 level, nint quality);


        /// <summary>
        /// static  AVGMonsterData GenerateMonster(System.UInt64 id)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <returns>class AVGMonsterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateMonster", Search = typeof(Search_AVGMonsterGenerator))]
        /// static extern nint GENERATE_MONSTER_02 (System.UInt64 id);


        /// <summary>
        /// static  AVGMonsterData GenerateMonster(System.UInt64 id, System.Int32 level)
        /// </summary>
        /// <param name="id">struct System.UInt64</param>
        /// <param name="level">struct System.Int32</param>
        /// <returns>class AVGMonsterData</returns>
        [Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateMonster", Search = typeof(Search_AVGMonsterGenerator))]
        static extern nint GENERATE_MONSTER_03(System.UInt64 id, System.Int32 level);


        public static partial class Search_AVGMonsterGenerator
        {
            /// 
            ///     

            /// <summary>
            /// static  AVGMonsterData GenerateMonster(System.Int32 poolId)
            /// </summary>
            /// public static bool GENERATE_MONSTER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GenerateMonster", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  AVGMonsterData GenerateMonster(System.UInt64 id, System.Int32 level, System.Collections.Generic.List<System.Int32> quality)
            /// </summary>
            /// public static bool GENERATE_MONSTER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GenerateMonster", "System.UInt64", "System.Int32", "System.Collections.Generic.List<System.Int32>");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  AVGMonsterData GenerateMonster(System.UInt64 id)
            /// </summary>
            /// public static bool GENERATE_MONSTER_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GenerateMonster", "System.UInt64");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  AVGMonsterData GenerateMonster(System.UInt64 id, System.Int32 level)
            /// </summary>
            public static bool GENERATE_MONSTER_03(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GenerateMonster", "System.UInt64", "System.Int32");
            ///     
            ///  
            /// 
            /// 
        }

    }


}