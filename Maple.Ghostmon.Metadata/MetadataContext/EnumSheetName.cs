namespace Maple.Ghostmon.Metadata.MetadataContext
{
    /// <summary>
    /// 请不要改动位置
    /// </summary>
    public enum EnumSheetName
    {
        None = -1,

        MaterialConfig = 1,
        CharmConfig = 2,
        RareConfig = 3,
        AbilityBookConfig = 4,
        TreasureConfig = 5,
        EvoMaterialConfig = 7,
        ClothingConfig = 8,
        MenuConfig = 9,
        EggConfig = 10,
        ItemRecipeConfig = 11,
        FishLureConfig = 12,

        /// <summary>
        /// 灵石
        /// </summary>
        GEM = 21,
        /// <summary>
        /// 金币
        /// </summary>
        COIN = 22,
        /// <summary>
        /// 
        /// </summary>
        HeartStone = 23,
        /// <summary>
        /// 灵气
        /// </summary>
        REIKI = 99,

        AbilityConfig = 100,
        CuisineConfig = 101,
        BuffConfig = 102,
        IllustrationConfig = 103,

        /// <summary>
        /// 读取以上游戏中的JSON 反序列成对象
        /// </summary>
        MaxLoadConfig = 999,
        //load

        AreaTipConfig,
        BuildingsConfig,
        CharmBookConfig,

        DialogConfig,
        EntrustConfig,
        EvolveConfig,
        FishingItemConfig,
        FishingPoolConfig,
        GoodsConfig,
        GuideConfig,
        LanguageConfig,
        MonsterPoolConfig,
        MonsterTypeConfig,
        NameConfig,
        NpcConfig,
        PortalConfig,
        ProjectileConfig,
        RandomdropConfig,
        RoleRankConfig,
        ShopsConfig,
        SnameConfig,
        SubaffixConfig,
        TaskBattleConfig,
        TaskConfig,
        TaskMonsterConfig,
        TaskNodeConfig,
        TaskTargetConfig,
        TipsConfig,
        TradeConfig,

        //add
        Skill = 10001,
        Monster = 10002,

        Player = 10003,
        Demon = 10004,
    };


    //public enum EnumLanguageConfig : ulong
    //{
    //    COIN_NAME = 33030166UL,
    //    COIN_DESC= 33030164UL,
    //    GEM_NAME = 33030167UL,
    //    GEM_DESC= 33030165UL,

    //    REIKI_NAME,
    //    REIKI_DESC
    //}
}
