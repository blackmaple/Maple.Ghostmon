using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Ghostmon
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]



    [MonoCollectorType(typeof(ConfigDataStore))]
    [MonoCollectorType(typeof(JObject))]
    [MonoCollectorType(typeof(MonsterObject))]
    [MonoCollectorType(typeof(CollectionObject))]
    [MonoCollectorType(typeof(SpriteObject))]
    [MonoCollectorType(typeof(SkillObject))]




    [MonoCollectorType(typeof(MonsterData))]



    [MonoCollectorType(typeof(UserDataManager))]
    [MonoCollectorType(typeof(UserData))]
    [MonoCollectorType(typeof(PlayerProperty))]

    internal partial class GhostmonGameContext
    {

    }
}
