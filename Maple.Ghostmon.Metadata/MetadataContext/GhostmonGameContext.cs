using Maple.Ghostmon.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;

namespace Maple.Ghostmon
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]
    [MonoCollectorType(typeof(CharacterCore))]

    [MonoCollectorType(typeof(RegionManager))]
    [MonoCollectorType(typeof(EnvironmentCtrl))]

    [MonoCollectorType(typeof(UIMsgControl))]

    [MonoCollectorType(typeof(ConfigDataStore))]
    [MonoCollectorType(typeof(JObject))]
    [MonoCollectorType(typeof(MonsterObject))]
    [MonoCollectorType(typeof(CollectionObject))]
    [MonoCollectorType(typeof(SpriteObject))]
    [MonoCollectorType(typeof(SkillObject))]
    [MonoCollectorType(typeof(USkillObject))]


    [MonoCollectorType(typeof(EvoMaterialData))]
    [MonoCollectorType(typeof(MaterialData))]

    [MonoCollectorType(typeof(AbilityBookData))]
    [MonoCollectorType(typeof(CharmData))]
    [MonoCollectorType(typeof(CuisineData))]
    [MonoCollectorType(typeof(EggData))]
    [MonoCollectorType(typeof(FishLureItemData))]
    [MonoCollectorType(typeof(ItemRecipeData))]
    [MonoCollectorType(typeof(RareData))]
    [MonoCollectorType(typeof(TreasureData))]

    [MonoCollectorType(typeof(MonsterData))]



    [MonoCollectorType(typeof(UserDataManager))]
    [MonoCollectorType(typeof(UserData))]
    [MonoCollectorType(typeof(PlayerProperty))]


    //[MonoCollectorType(typeof(Awaiter_MonsterObject))]
    //[MonoCollectorType(typeof(UniTask_MonsterObject))]
    [MonoCollectorType(typeof(LoadUtils))]

    [MonoCollectorType(typeof(SystemUInt64))]



    [MonoCollectorType(typeof(BattleCore))]
    [MonoCollectorType(typeof(JudgeControl))]
    [MonoCollectorType(typeof(BUnit))]


    [MonoCollectorType(typeof(GameBasicUtil))]
    [MonoCollectorType(typeof(GhostmonPortalConfig))]

    [MonoCollectorType(typeof(SystemAction))]
    [MonoCollectorType(typeof(MapMarkData))]

    [MonoCollectorType(typeof(MainMapCore))]
    [MonoCollectorType(typeof(MainUI))]
    [MonoCollectorType(typeof(MapUI))]
    [MonoCollectorType(typeof(OrnamentData))]


    [MonoCollectorType(typeof(CurRogueData))]
    [MonoCollectorType(typeof(RogueData))]
    [MonoCollectorType(typeof(RogueCore))]
    [MonoCollectorType(typeof(RogueDataManager))]

    [MonoCollectorType(typeof(AVGRegionManager))]
    [MonoCollectorType(typeof(AVGBagItemData))]
    [MonoCollectorType(typeof(AVGBaseSkill))]
    [MonoCollectorType(typeof(AVGBaseBuff))]
    [MonoCollectorType(typeof(AVGMonsterData))]
    [MonoCollectorType(typeof(AVGItemService))]
    [MonoCollectorType(typeof(AVGMonsterService))]
    [MonoCollectorType(typeof(AVGServiceManager))]
    [MonoCollectorType(typeof(AVGUserData))]
    [MonoCollectorType(typeof(AVGUserDataManager))]
    [MonoCollectorType(typeof(_AVGMonsterConfig))]
    [MonoCollectorType(typeof(_AVGPropConfig))]
    [MonoCollectorType(typeof(_AVGAbilityConfig))]
    [MonoCollectorType(typeof(_AVGBuffConfig))]
    [MonoCollectorType(typeof(AVGMonsterGenerator))]


    public partial class GhostmonGameContext
    {

    }
}
