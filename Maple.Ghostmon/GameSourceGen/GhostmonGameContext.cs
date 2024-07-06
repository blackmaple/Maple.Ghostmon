using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Diagnostics.CodeAnalysis;

namespace Maple.Ghostmon
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]

    [MonoCollectorType(typeof(UIMsgControl))]

    [MonoCollectorType(typeof(ConfigDataStore))]
    [MonoCollectorType(typeof(JObject))]
    [MonoCollectorType(typeof(MonsterObject))]
    [MonoCollectorType(typeof(CollectionObject))]
    [MonoCollectorType(typeof(SpriteObject))]
    [MonoCollectorType(typeof(SkillObject))]
    [MonoCollectorType(typeof(USkillObject))]



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
    internal partial class GhostmonGameContext
    {
    }
}
