using Maple.GameContext;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore;
using Microsoft.Extensions.Logging;


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

 

        protected sealed override async ValueTask LoadGameDataAsync()
        {
            var load = await this.MonoTaskAsync(p => p.LoadGameConfigStore()).ConfigureAwait(false);
            this.Logger.LogInformation("LoadGameConfigStore=>{load}", load);
            var count = await this.MonoTaskAsync(p => p.LoadListMonsterInfo()).ConfigureAwait(false);
            this.Logger.LogInformation("LoadListMonsterInfo=>{count}", count);

        }
        #endregion

        #region HotKey
        //protected sealed override   ValueTask F10_KeyDown()
        //{
        //    //try
        //    //{
        //    //    var name = await  this.MonoTaskAsync(p => p.SetBuff2Character()).ConfigureAwait(false);
        //    //    await this.PlayMessageAsync($"Add Buff:{name}").ConfigureAwait(false);
        //    //}
        //    //catch (GameException ex)
        //    //{
        //    //    await this.PlayMessageAsync(ex.Message).ConfigureAwait(false);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    this.Logger.LogError("{ex}", ex);
        //    //}
        //}
        protected sealed override async ValueTask F11_KeyDown()
        {
            try
            {
                var name = await this.MonoTaskAsync(p => p.SetBuff2Character()).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add Buff:{name}").ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                await this.PlayMessageAsync(ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }
        }
        protected sealed override async ValueTask F12_KeyDown()
        {
            try
            {
                var name = await this.MonoTaskAsync(p => p.SetDeBuff2Enemy()).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add DeBuff:{name}").ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                await this.PlayMessageAsync(ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }
        }

        protected override async ValueTask F5_KeyDown()
        {
            var gameImageDatas = await this.MonoTaskAsync((p) => p.GetListGameImageData().ToArray()).ConfigureAwait(false);
            var imageObjs = await this.UnityTaskAsync((p, args) => p.GetListUnitySpriteImageData(args.UnityEngineContext, args.gameImageDatas).ToArray(),
                (this.UnityEngineContext, gameImageDatas)).ConfigureAwait(false);
            foreach (var gameIcon in imageObjs)
            {
                this.GameSettings.WriteImageFile(gameIcon.ImageData.AsReadOnlySpan(), gameIcon.Category, $"{gameIcon.Name}.png");
            }


        }
        #endregion

        #region Game Data

        private async Task<UserDataManager.Ptr_UserDataManager> GetUserDataManagerAsync()
        {
            var userDataMgr = await this.MonoTaskAsync(p => p.GetUserDataManager()).ConfigureAwait(false);
            return userDataMgr;
        }
        private async Task<UserData.Ptr_UserData> GetUserDataAsync(UserDataManager.Ptr_UserDataManager userDataManager)
        {
            var userDataMgr = await this.MonoTaskAsync((p, userDataManager) => userDataManager.GetUserData(), (userDataManager)).ConfigureAwait(false);
            return userDataMgr;
        }
        private async ValueTask PlayMessageAsync(string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            await this.UnityTaskAsync((p, msg) => p.PlayMessage(msg), msg).ConfigureAwait(false);
        }
        #endregion

        #region WebApi

        public sealed override ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            var api = this.GameContext.ApiVersion;
            var data = this.GameSettings.GetGameSessionInfo(api);
            return ValueTask.FromResult(data);
        }

        #region Game Res
        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            var gameImageDatas = await this.MonoTaskAsync((p) => p.GetListGameImageData().ToArray()).ConfigureAwait(false);
            var imageObjs = await this.UnityTaskAsync((p, args) => p.GetListUnitySpriteImageData(args.UnityEngineContext, args.gameImageDatas).ToArray(),
                (this.UnityEngineContext, gameImageDatas)).ConfigureAwait(false);
            foreach (var gameIcon in imageObjs)
            {
                this.GameSettings.WriteImageFile(gameIcon.ImageData.AsReadOnlySpan(), gameIcon.Category, $"{gameIcon.Name}.png");
            }
            return await this.GetSessionInfoAsync().ConfigureAwait(false);
        }
        #endregion

        #region Currency


        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var datas = this.GameContext.GetListCurrencyDisplay();
            this.UpdateListGameImage(datas);
            return ValueTask.FromResult(datas);

        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync((gameContext, args) =>
                gameContext.GetCurrencyInfo(args.userDataMgr, args.currencyObjectDTO)
                , (userDataMgr, currencyObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);

            var data = await this.MonoTaskAsync(
                (gameContext, args)
                    => gameContext.UpdateCurrencyInfo(args.userDataMgr, args.currencyModifyDTO),
                (userDataMgr, currencyModifyDTO)).ConfigureAwait(false);

            await this.PlayMessageAsync($@"{data.ObjectId}:{data.DisplayValue}").ConfigureAwait(false);



            return data;
        }
        #endregion

        #region Inventory

        public sealed override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var datas = this.GameContext.GetListInventoryDisplay().ToArray();
            this.UpdateListGameImage(datas);
            return ValueTask.FromResult(datas);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            return this.GameContext.GetInventoryInfo(userDataMgr, inventoryObjectDTO);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync((gameContext, args) =>
            gameContext.UpdateInventoryInfo(args.userDataMgr, args.inventoryObjectDTO),
            (userDataMgr, inventoryObjectDTO)).ConfigureAwait(false);
            await this.PlayMessageAsync($@"{data.ObjectId}:{data.DisplayValue}").ConfigureAwait(false);
            return data;
        }
        #endregion

        #region Character

        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync((p, userDataMgr) => p.GetListCharacterDisplay(userDataMgr).ToArray(), userDataMgr).ConfigureAwait(false);
            this.UpdateListGameImage(datas, p => $@"{p.DisplayImage}.png");
            return datas;
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
            var data = await this.MonoTaskAsync((p, args) => p.UpdateCharacterStatus(args.userDataMgr, args.characterModifyDTO), (userDataMgr, characterModifyDTO)).ConfigureAwait(false);
            await this.PlayMessageAsync($@"CharacterStatus:{data.ObjectId}").ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync((p, args) => p.UpdateCharacterSkill(args.userDataMgr, args.characterModifyDTO), (userDataMgr, characterModifyDTO)).ConfigureAwait(false);
            await this.PlayMessageAsync($@"CharacterSkill:{data.ObjectId}").ConfigureAwait(false);
            return data;
        }

        #endregion

        #region Monster

        public sealed override ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            var datas = this.GameContext.GetListMonsterDisplay().ToArray();
            this.UpdateListGameImage(datas);
            return ValueTask.FromResult(datas);
        }

        public sealed override async ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync((p, args) => p.AddMonsterMember(args.userDataMgr, args.monsterObjectDTO), (userDataMgr, monsterObjectDTO)).ConfigureAwait(false);
            await this.PlayMessageAsync($@"CharacterSkill:{data.ObjectId}").ConfigureAwait(false);
            return data;
        }
        #endregion

        #region Skill

        public sealed override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            var datas = this.GameContext.GetListGameSkillDisplay().ToArray();
            this.UpdateListGameImage(datas);
            return ValueTask.FromResult(datas);
        }

        public sealed override async ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
        {
            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);

            var data = await this.MonoTaskAsync((p, gameSkillObject) => p.AddSkillDisplay(gameSkillObject), gameSkillObject).ConfigureAwait(false);
            return data;
        }


        #endregion

        #region Switch

        public sealed override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        {
            var switchDisplay = this.ListGameSwitch.Where(p => p.ObjectId == gameSwitchModify.SwitchObjectId).FirstOrDefault();
            if (switchDisplay is null)
            {
                return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND {gameSwitchModify.SwitchObjectId} (0)");
            }
            if (false == Enum.TryParse<EnumGameSwitchName>(switchDisplay.ObjectId, out var gameSwitchName))
            {
                return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND {gameSwitchModify.SwitchObjectId} (1)");
            }

            var userDataMgr = await this.GetUserDataManagerAsync().ConfigureAwait(false);


            if (gameSwitchName == EnumGameSwitchName.RandomBuff)
            {
                var name = await this.MonoTaskAsync(p => p.SetBuff2Character()).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add Buff:{name}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.RandomDeBuff)
            {
                var name = await this.MonoTaskAsync(p => p.SetDeBuff2Enemy()).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add DeBuff:{name}").ConfigureAwait(false);

            }
            else if (gameSwitchName == EnumGameSwitchName.DoubleMoveSpeed)
            {

                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangelayerDoubleMoveSpeed(args.userDataMgr, args.switchDisplay, true), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangelayerDoubleMoveSpeed(args.userDataMgr, args.switchDisplay, false), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.DoubleMonsterExp)
            {
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterDoubleExp(args.userDataMgr, args.switchDisplay, true), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterDoubleExp(args.userDataMgr, args.switchDisplay, false), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.MonsterFlash)
            {
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterFlash(args.userDataMgr, args.switchDisplay, true), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterFlash(args.userDataMgr, args.switchDisplay, false), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.MonsterColor)
            {
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterColor(args.userDataMgr, args.switchDisplay, true), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterColor(args.userDataMgr, args.switchDisplay, false), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.ScanMode)
            {
                var userData = await this.GetUserDataAsync(userDataMgr).ConfigureAwait(false);
                var character = await this.MonoTaskAsync(p => p.GetScanMode()).ConfigureAwait(false);
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.UnityTaskAsync((p, args) => p.ChangeScanMode(args.userData, args.character, true), (userData, character)).ConfigureAwait(false);
                }
                else
                {
                    await this.UnityTaskAsync((p, args) => p.ChangeScanMode(args.userData, args.character, false), (userData, character)).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{gameSwitchModify.SwitchValue}").ConfigureAwait(false);


            }
            else if (gameSwitchName == EnumGameSwitchName.MapWeather)
            {
                if (Enum.TryParse<MapWeather>(gameSwitchModify.ContentValue, out var mapWeather))
                {
                    await this.MonoTaskAsync(static (p, mapWeather) => p.SetMapWeather(mapWeather), mapWeather).ConfigureAwait(false);
                }
                else
                {
                    return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND Map Weather");
                }
            }
            switchDisplay.ContentValue = gameSwitchModify.ContentValue;

            return switchDisplay;
        }

        public enum EnumGameSwitchName
        {
            RandomBuff,
            RandomDeBuff,
            DoubleMoveSpeed,
            DoubleMonsterExp,
            ScanMode,
            MapWeather,
            MonsterFlash,
            MonsterColor
        }


        protected override GameSwitchDisplayDTO[] InitListGameSwitch()
        {



            return [
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.ScanMode.ToString(),   DisplayName = "1分钟灵视(F10)" , DisplayDesc=   "直接进入灵视|时长约为:60s" ,SwitchValue = false, UIType = (int)EnumGameSwitchUIType.Switches},
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.RandomBuff.ToString(),   DisplayName = "随机增益(F11)" , DisplayDesc=  "随机Buff给我方妖精|仅限战斗准备阶段使用" ,SwitchValue = false,  UIType = (int)EnumGameSwitchUIType.Button},
                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.RandomDeBuff.ToString(),   DisplayName = "随机减益(F12)" , DisplayDesc=  "随机DeBuff给敌方妖怪|仅限战斗准备阶段使用" ,SwitchValue = false, UIType = (int)EnumGameSwitchUIType.Button},

                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.DoubleMoveSpeed.ToString(),   DisplayName = "人物双倍移速" , DisplayDesc=  "移速*2" ,SwitchValue = false,UIType = (int)EnumGameSwitchUIType.Switches},
                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.DoubleMonsterExp.ToString(),   DisplayName = "妖精双倍经验值" , DisplayDesc=  "经验值*2" ,SwitchValue = false,UIType = (int)EnumGameSwitchUIType.Switches},

                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.MonsterFlash.ToString(),   DisplayName = "全地图闪光妖精" , DisplayDesc=  "传送/切换地图后生效" ,SwitchValue = false,UIType = (int)EnumGameSwitchUIType.Switches},
                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.MonsterColor.ToString(),   DisplayName = "全地图异色妖精" , DisplayDesc=  "传送/切换地图后生效" ,SwitchValue = false,UIType = (int)EnumGameSwitchUIType.Switches},

                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.MapWeather.ToString(),   DisplayName = "天气" , DisplayDesc=  "天气" ,ContentValue =   MapWeather.CLEAR.ToString(),UIType = (int)EnumGameSwitchUIType.Selects,
                 SelectedContents = [
                     new GameValueInfoDTO(){ ObjectId= MapWeather.CLEAR.ToString(), DisplayName = "天气-晴天",DisplayValue = MapWeather.CLEAR.ToString(),},
                     new GameValueInfoDTO(){ ObjectId= MapWeather.CLOUDY.ToString(), DisplayName = "天气-多云",DisplayValue = MapWeather.CLOUDY.ToString(),},
                     new GameValueInfoDTO(){ ObjectId= MapWeather.LIGHT_RAIN.ToString(), DisplayName = "天气-小雨",DisplayValue = MapWeather.LIGHT_RAIN.ToString(),},
                     new GameValueInfoDTO(){ ObjectId= MapWeather.MODERATE_RAIN.ToString(), DisplayName = "天气-中雨",DisplayValue = MapWeather.MODERATE_RAIN.ToString(),},
                     new GameValueInfoDTO(){ ObjectId= MapWeather.HEAVY_RAIN.ToString(), DisplayName = "天气-大雨",DisplayValue = MapWeather.HEAVY_RAIN.ToString(),},

                     ]
                 },


 

            ];
        }


        #endregion







        #endregion
    }


}
