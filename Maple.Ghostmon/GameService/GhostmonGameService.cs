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

        protected sealed override async ValueTask LoadGameDataAsync()
        {
            var load = await this.MonoTaskAsync(p => p.LoadGameConfigStore()).ConfigureAwait(false);
            this.Logger.LogInformation("LoadGameConfigStore=>{load}", load);
            var count = await this.MonoTaskAsync(p => p.LoadListMonsterInfo()).ConfigureAwait(false);
            this.Logger.LogInformation("LoadListMonsterInfo=>{count}", count);

        }
        #endregion


        protected override async ValueTask F5_KeyDown()
        {

            var monsterObjs = await this.MonoTaskAsync((p) => p.GetListMonsterConfig()).ConfigureAwait(false);
            var spriteObjs = await this.MonoTaskAsync((p, args) => p.LoadListMonsterAvater(args), monsterObjs).ConfigureAwait(false);

            //var imageObjs = await this.UnityTaskAsync((p, args) => p.LoadListUnitySpriteImageData(args.UnityEngineContext, args.spriteObjs).ToArray(), (this.UnityEngineContext, spriteObjs)).ConfigureAwait(false);

            //foreach (var gameIcon in imageObjs)
            //{
            //    this.GameSettings.WriteImageFile(gameIcon.ImageData.AsReadOnlySpan(), gameIcon.Category, $"{gameIcon.Name}.png");
            //}


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
                (gameContext, args)
                    => gameContext.UpdateCurrencyInfo(args.userDataMgr, args.currencyModifyDTO),
                (userDataMgr, currencyModifyDTO)).ConfigureAwait(false);




            return data;
        }



        public sealed override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var datas = this.GameContext.GetListInventoryDisplay().ToArray();
            return ValueTask.FromResult(datas);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var userDataMgr = await GetUserDataManagerAsync().ConfigureAwait(false);
            return this.GameContext.GetInventoryInfo(userDataMgr, inventoryObjectDTO);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var userDataMgr = await GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((gameContext, args) =>
            gameContext.UpdateInventoryInfo(args.userDataMgr, args.inventoryObjectDTO),
            (userDataMgr, inventoryObjectDTO)).ConfigureAwait(false);
        }



        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, userDataMgr) => p.GetListCharacterDisplay(userDataMgr).ToArray(), userDataMgr).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.GetCharacterEquipment(args.userDataMgr, args.characterObjectDTO), (userDataMgr, characterObjectDTO)).ConfigureAwait(false);

        }
        public sealed override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.GetCharacterSkill(args.userDataMgr, args.characterObjectDTO), (userDataMgr, characterObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.GetCharacterStatus(args.userDataMgr, args.characterObjectDTO), (userDataMgr, characterObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.UpdateCharacterStatus(args.userDataMgr, args.characterModifyDTO), (userDataMgr, characterModifyDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.UpdateCharacterSkill(args.userDataMgr, args.characterModifyDTO), (userDataMgr, characterModifyDTO)).ConfigureAwait(false);
        }
     

        public sealed override ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            var datas = this.GameContext.GetListMonsterDisplay().ToArray();
            return ValueTask.FromResult(datas);
        }

        public sealed override async ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.AddMonsterMember(args.userDataMgr, args.monsterObjectDTO), (userDataMgr, monsterObjectDTO)).ConfigureAwait(false);
        }


        public sealed override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            return ValueTask.FromResult(this.GameContext.GetListGameSkillDisplay().ToArray());
        }
        #endregion
    }


}
