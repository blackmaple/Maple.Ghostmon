using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.Text.Json;


namespace Maple.Ghostmon
{
    internal sealed partial class GhostmonGameService(
        ILogger<GhostmonGameService> logger,
        MonoRuntimeContext runtimeContext,
        MonoGameSettings gameSettings)
        : GameService<GhostmonGameContext>(logger, runtimeContext, gameSettings)
    {

        #region LoadService

        //   protected sealed override bool EnableService => true;

        protected sealed override GhostmonGameContext LoadGameContext()
            => GhostmonGameContext.LoadGhostmonGameContext(this.RuntimeContext, EnumMonoCollectorTypeVersion.Ver_Common, this.Logger);

        //protected sealed override GameSwitchDisplayDTO[] InitListGameSwitch()
        //{
        //    return Enumerable.Range(0, 10).Select(p => new GameSwitchDisplayDTO { ObjectId = p.ToString(), DisplayName = $"DisplayName_{p}", DisplayDesc = $"DisplayDesc_{p}", SwitchValue = false }).ToArray();
        //}
        #endregion


        protected override async ValueTask F5_KeyDown()
        {
            var config = await this.UnityTaskAsync((gameContext) => gameContext.GetGameConfigDictionary()).ConfigureAwait(false);
            this.Logger.LogInformation("config=>{c}", config.Count);
            foreach (var cfg in config)
            {
                foreach (var kv in cfg.Value)
                {
                    this.Logger.LogInformation("config json=>{kv}", kv.Key);
                    var val = kv.Value;
                    if (val.Valid())
                    {
                        this.Logger.LogInformation("config=>{name}", val.ToString());
                        //var data = ConfigJsonSerializerContext.GameConfigJsonElementDeserialize(val.AsReadOnlySpan());
                        //if (data?.TryGetValue(nameof(BaseConfig.name), out var jsonElement) == true)
                        //{
                        //    // 

                        //}
                    }

                }
            }

        }

    }


}
