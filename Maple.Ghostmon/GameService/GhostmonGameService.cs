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
            var config = await this.MonoTaskAsync(p => p.GetGameConfigStore()).ConfigureAwait(false);
            var tasks = new List<Task>();
            foreach (var data in config.ListIllustrationConfig)
            {
                var task = this.MonoTaskAsync((p, args) => p.GetMonsterConfigUniTask(data), data);
                tasks.Add(task);
            }
            await Task.WhenAll(tasks).ConfigureAwait(false);
 

           

        }

        public async Task<UserDataManager.Ptr_UserDataManager> GetUserDataManagerAsync()
        {
            var userDataMgr = await this.MonoTaskAsync(p => p.GetUserDataManager()).ConfigureAwait(false);
            return userDataMgr ? userDataMgr : GameException.Throw<UserDataManager.Ptr_UserDataManager>("UserDataManager IS NULL");
        }

        #region WebApi
        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return ValueTask.FromResult(this.GameContext.GetListCurrencyDisplay());
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var userDataMgr = await GetUserDataManagerAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync((gameContext, args) =>
                gameContext.GetCurrencyInfo(args.userDataMgr, args.currencyObjectDTO)
                , (userDataMgr, currencyObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var userDataMgr = await GetUserDataManagerAsync().ConfigureAwait(false);

            var data = await this.MonoTaskAsync(
                (gameContext, args) =>
                {
                    var ret = gameContext.UpdateCurrencyInfo(args.userDataMgr, args.currencyModifyDTO);

                    gameContext.PlayMessage($"Change:{ret.DisplayValue}");

                    return ret;

                }, (userDataMgr, currencyModifyDTO)
                ).ConfigureAwait(false);




            return data;
        }

        #endregion
    }


}
