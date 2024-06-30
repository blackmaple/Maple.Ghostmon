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




    [MonoCollectorType(typeof(MonsterData))]



    [MonoCollectorType(typeof(UserDataManager))]
    [MonoCollectorType(typeof(UserData))]
    [MonoCollectorType(typeof(PlayerProperty))]


    //[MonoCollectorType(typeof(Awaiter_MonsterObject))]
    //[MonoCollectorType(typeof(UniTask_MonsterObject))]
    [MonoCollectorType(typeof(UniTaskExtensions))]


    internal partial class GhostmonGameContext
    {
        [NotNull]
        public Awaiter_MonsterObject? Awaiter_MonsterObject { set; get; }

        [NotNull]
        public UniTask_MonsterObject? UniTask_MonsterObject { set; get; }
    }
}
