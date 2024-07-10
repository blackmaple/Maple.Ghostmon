using Maple.GameContext;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;


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

        public async Task<UserDataManager.Ptr_UserDataManager> GetUserDataManagerAsync()
        {
            var userDataMgr = await this.MonoTaskAsync(p => p.GetUserDataManager()).ConfigureAwait(false);
            return userDataMgr ? userDataMgr : GameException.Throw<UserDataManager.Ptr_UserDataManager>("UserDataManager IS NULL");
        }

        public async ValueTask PlayMessageAsync(string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            await this.UnityTaskAsync((p, msg) => p.PlayMessage(msg), msg).ConfigureAwait(false);
        }
        #endregion

        #region WebApi

        #region Currency


        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var datas = this.GameContext.GetListCurrencyDisplay();
            this.UpdateListGameImage(datas);
            return ValueTask.FromResult(datas);

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
            var userDataMgr = await GetUserDataManagerAsync().ConfigureAwait(false);
            return this.GameContext.GetInventoryInfo(userDataMgr, inventoryObjectDTO);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var userDataMgr = await GetUserDataManagerAsync().ConfigureAwait(false);
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
            var data = await  this.MonoTaskAsync((p, gameSkillObject) => p.AddSkillDisplay(gameSkillObject), gameSkillObject).ConfigureAwait(false);
            return data;
        }


        public sealed override 
        #endregion

        #region Switch

        public sealed override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        {
            var switchDisplay = this.ListGameSwitch.Where(p => p.ObjectId == gameSwitchModify.SwitchObjectId).FirstOrDefault();
            if (switchDisplay is null)
            {
                return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND {gameSwitchModify.SwitchObjectId}");
            }
            if (Enum.TryParse<MapWeather>(gameSwitchModify.SwitchObjectId, out var weather))
            {
                var name = await this.MonoTaskAsync((p, weather) => p.SetMapWeather(weather), weather).ConfigureAwait(false);
                await this.PlayMessageAsync($"Weather:{name}").ConfigureAwait(false);
            }
            else if (gameSwitchModify.SwitchObjectId == EnumGameSwitchName.RandomBuff.ToString())
            {
                var name = await this.MonoTaskAsync(p => p.SetBuff2Character()).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add Buff:{name}").ConfigureAwait(false);
            }
            else if (gameSwitchModify.SwitchObjectId == EnumGameSwitchName.RandomDeBuff.ToString())
            {
                var name = await this.MonoTaskAsync(p => p.SetDeBuff2Enemy()).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add DeBuff:{name}").ConfigureAwait(false);

            }
            else if (gameSwitchModify.SwitchObjectId == EnumGameSwitchName.DoubleMoveSpeed.ToString())
            {
                if (switchDisplay.SwitchValue != gameSwitchModify.SwitchValue)
                {
                    var userDataMgr = await this.MonoTaskAsync(p => p.GetUserDataManager()).ConfigureAwait(false);
                    await this.MonoTaskAsync((p, args) => p.ChangelayerDoubleMoveSpeed(args.userDataMgr, args.switchDisplay), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                    await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{switchDisplay.SwitchValue}").ConfigureAwait(false);
                    switchDisplay.SwitchValue = gameSwitchModify.SwitchValue;
                }
            }
            else if (gameSwitchModify.SwitchObjectId == EnumGameSwitchName.DoubleMonsterExp.ToString())
            {
                if (switchDisplay.SwitchValue != gameSwitchModify.SwitchValue)
                {
                    var userDataMgr = await this.MonoTaskAsync(p => p.GetUserDataManager()).ConfigureAwait(false);
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterDoubleExp(args.userDataMgr, args.switchDisplay), (userDataMgr, switchDisplay)).ConfigureAwait(false);
                    await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{switchDisplay.SwitchValue}").ConfigureAwait(false);
                    switchDisplay.SwitchValue = gameSwitchModify.SwitchValue;

                }

            }
            else if (gameSwitchModify.SwitchObjectId == EnumGameSwitchName.ScanMode.ToString())
            {
                if (switchDisplay.SwitchValue != gameSwitchModify.SwitchValue)
                {
                    var userDataMgr = await this.MonoTaskAsync(p => p.GetUserDataManager()).ConfigureAwait(false);
                    var userData = await this.MonoTaskAsync((p, userDataMgr) => userDataMgr.GetUserData(), userDataMgr).ConfigureAwait(false);
                    var character = await this.MonoTaskAsync(p => p.GetScanMode()).ConfigureAwait(false);

                    await this.UnityTaskAsync((p, args) => p.ChangeScanMode(args.userData, args.character, args.switchDisplay), (userData, character, switchDisplay)).ConfigureAwait(false);
                    await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{switchDisplay.SwitchValue}").ConfigureAwait(false);
                    switchDisplay.SwitchValue = gameSwitchModify.SwitchValue;
                }

            }
            return switchDisplay;
        }

        public enum EnumGameSwitchName
        {
            RandomBuff,
            RandomDeBuff,
            DoubleMoveSpeed,
            DoubleMonsterExp,
            ScanMode

        }


        protected override GameSwitchDisplayDTO[] InitListGameSwitch()
        {
            return [
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.ScanMode.ToString(), ButtonType = false, DisplayName = "1分钟灵视(F10)" , DisplayDesc=   "直接进入灵视|时长约为:60s" ,SwitchValue = false,},
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.RandomBuff.ToString(), ButtonType = true, DisplayName = "随机增益(F11)" , DisplayDesc=  "随机Buff给我方妖精|仅限战斗准备阶段使用" ,SwitchValue = false,},
                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.RandomDeBuff.ToString(), ButtonType = true, DisplayName = "随机减益(F12)" , DisplayDesc=  "随机DeBuff给敌方妖怪|仅限战斗准备阶段使用" ,SwitchValue = false,},

                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.DoubleMoveSpeed.ToString(), ButtonType = false, DisplayName = "人物双倍移速" , DisplayDesc=  "移速*2" ,SwitchValue = false,},
                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.DoubleMonsterExp.ToString(), ButtonType = false, DisplayName = "妖精双倍经验值" , DisplayDesc=  "经验值*2" ,SwitchValue = false,},



                 new GameSwitchDisplayDTO(){ ObjectId = MapWeather.CLEAR.ToString(), ButtonType = true, DisplayName = "天气-晴天" , DisplayDesc=  "天气-晴天" ,SwitchValue = false,},
                 new GameSwitchDisplayDTO(){ ObjectId = MapWeather.CLOUDY.ToString(), ButtonType = true, DisplayName = "天气-多云" , DisplayDesc=  "天气-多云" ,SwitchValue = false,},
                new GameSwitchDisplayDTO(){ ObjectId = MapWeather.LIGHT_RAIN.ToString(), ButtonType = true, DisplayName = "天气-小雨" , DisplayDesc=  "天气-小雨" ,SwitchValue = false,},
                 new GameSwitchDisplayDTO(){ ObjectId = MapWeather.MODERATE_RAIN.ToString(), ButtonType = true, DisplayName = "天气-中雨" , DisplayDesc=  "天气-中雨" ,SwitchValue = false,},
                new GameSwitchDisplayDTO(){ ObjectId = MapWeather.HEAVY_RAIN.ToString(), ButtonType = true, DisplayName = "天气-大雨" , DisplayDesc=  "天气-大雨" ,SwitchValue = false,},

                new GameSwitchDisplayDTO(){ ObjectId = nameof(MapWeather),   DisplayName = nameof(MapWeather) , DisplayDesc=  nameof(MapWeather) ,ContentValue= MapWeather.CLEAR.ToString(),
                SelectedContents=[
                     new GameValueInfoDTO(){ ObjectId = MapWeather.CLEAR.ToString(), DisplayName="天气-晴天" ,DisplayValue = MapWeather.CLEAR.ToString()},
                      new GameValueInfoDTO(){ ObjectId = MapWeather.CLOUDY.ToString(), DisplayName="天气-多云" ,DisplayValue = MapWeather.CLOUDY.ToString()},
                     new GameValueInfoDTO(){ ObjectId = MapWeather.LIGHT_RAIN.ToString(), DisplayName="天气-小雨" ,DisplayValue = MapWeather.LIGHT_RAIN.ToString()},
                     new GameValueInfoDTO(){ ObjectId = MapWeather.MODERATE_RAIN.ToString(), DisplayName="天气-中雨" ,DisplayValue = MapWeather.MODERATE_RAIN.ToString()},
                     new GameValueInfoDTO(){ ObjectId = MapWeather.HEAVY_RAIN.ToString(), DisplayName="天气-大雨" ,DisplayValue = MapWeather.HEAVY_RAIN.ToString()},

                    ]
                },

            ];
        }


        #endregion







        #endregion
    }


}
