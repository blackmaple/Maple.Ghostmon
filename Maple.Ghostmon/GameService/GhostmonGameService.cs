using Maple.Ghostmon.Metadata.MetadataModel;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;
using Maple.Ghostmon.Metadata.MetadataContext;
using Microsoft.VisualBasic;
using System.Buffers.Text;
using Microsoft.Extensions.Caching.Memory;
using System.Buffers;

namespace Maple.Ghostmon
{
    internal sealed partial class GhostmonGameService(ILogger<GhostmonGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<GhostmonGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {

        #region LoadService

        //   protected sealed override bool EnableService => true;

        protected sealed override GhostmonGameContext LoadGameContext()
           => GhostmonGameContext.LoadGameContext(this.RuntimeContext, EnumMonoCollectorTypeVersion.APP, this.Logger);



        protected sealed override async ValueTask LoadGameDataAsync()
        {
            using (this.Logger.Running())
            {

                //this.Logger.LogInformation("MonoString:{info}", MonoStringExtensions.GetMonoStringStructLayout());
                //this.Logger.LogInformation("MonoArray:{info}", MonoArrayExtensions.GetMonoArrayStructLayout());

                var load = await this.MonoTaskAsync(p => p.LoadGameConfigStore()).ConfigureAwait(false);
                this.Logger.LogInformation("LoadGameConfigStore=>{load}", load);
                var count = await this.MonoTaskAsync(p => p.LoadListMonsterInfo()).ConfigureAwait(false);
                this.Logger.LogInformation("LoadListMonsterInfo=>{count}", count);
                await this.PlayMessageAsync($"初始化:{load},加载:{count}个妖灵").ConfigureAwait(false);
            }
        }
        #endregion

        #region HotKey
        protected sealed override async ValueTask F11_KeyDown()
        {
            try
            {
                var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
                game_env.ThrowIfNotLoaded();
                game_env.ThrowIfNotInBattle();
                var name = await this.MonoTaskAsync((p, game_env) => p.SetBuff2Character(game_env), game_env).ConfigureAwait(false);
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
                var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
                game_env.ThrowIfNotLoaded();
                game_env.ThrowIfNotInBattle();

                var name = await this.MonoTaskAsync((p, game_env) => p.SetDeBuff2Enemy(game_env), game_env).ConfigureAwait(false);
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

        protected override async ValueTask F9_KeyDown()
        {
            try
            {
                var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
                game_env.ThrowIfNotLoaded();

                var pos = await this.MonoTaskAsync((p, game_env) => p.GetLastMarkDataPos(game_env), game_env).ConfigureAwait(false);
                if (false == pos.has)
                {
                    await this.PlayMessageAsync($"NOT FOUND MARK DATA").ConfigureAwait(false);
                }
                else
                {
                    //await this.PlayMessageAsync($"Teleport:{pos.pos.x},{pos.pos.z}").ConfigureAwait(false);

                    await this.UITaskAsync((p, args) => p.MapTeleport(args.game_env, args.pos.pos), (game_env, pos)).ConfigureAwait(false);
                }

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
        #endregion

        #region Game Data
        private async ValueTask PlayMessageAsync(string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            await this.UITaskAsync((p, msg) => p.PlayMessage(msg), msg).ConfigureAwait(false);
        }

        [Obsolete("remove...")]
        private async Task<UserDataManager.Ptr_UserDataManager> GetUserDataManagerAsync()
        {
            var userDataMgr = await this.MonoTaskAsync(p => p.GetUserDataManager()).ConfigureAwait(false);
            return userDataMgr;
        }
        [Obsolete("remove...")]
        private async Task<UserData.Ptr_UserData> GetUserDataAsync(UserDataManager.Ptr_UserDataManager userDataManager)
        {
            var userDataMgr = await this.MonoTaskAsync((p, userDataManager) => userDataManager.GetUserData(), (userDataManager)).ConfigureAwait(false);
            return userDataMgr;
        }


        private Task<GhostmonGameEnvironment> GetGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(p => p.GetGhostmonGameEnvironment());
        }
        #endregion

        #region WebApi

        //#region SessionInfo

        //public sealed override ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        //{
        //    var api = this.GameContext.ApiVersion;
        //    var data = this.GameSettings.GetGameSessionInfo(api);
        //    return ValueTask.FromResult(data);
        //}
        //#endregion

        #region Game Res
        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            if (this.UnityEngineContext is null)
            {
                return GameException.Throw<GameSessionInfoDTO>("LOADED ERRR");
            }
            var gameImageDatas = await this.MonoTaskAsync((p) => p.GetListGameImageData().ToArray()).ConfigureAwait(false);
            var imageObjs = await this.UITaskAsync((p, args) => p.GetListUnitySpriteImageData(args.UnityEngineContext, args.gameImageDatas).ToArray(),
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
            var datas = this.Context.GetListCurrencyDisplay();
            //        this.UpdateListGameImage(datas);
            foreach (var data in datas)
            {
                data.DisplayImage = default;
            }
            return ValueTask.FromResult(datas);

        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();
            var data = await this.MonoTaskAsync((gameContext, args) => gameContext.GetCurrencyInfo(args.game_env, args.currencyObjectDTO), (game_env, currencyObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            var data = await this.MonoTaskAsync((gameContext, args) => gameContext.UpdateCurrencyInfo(args.game_env, args.currencyModifyDTO), (game_env, currencyModifyDTO)).ConfigureAwait(false);

            await this.PlayMessageAsync($@"{data.ObjectId}:{data.DisplayValue}").ConfigureAwait(false);



            return data;
        }
        #endregion

        #region Inventory

        public sealed override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var datas = this.Context.GetListInventoryDisplay().ToArray();
            //          this.UpdateListGameImage(datas);
            foreach (var data in datas)
            {
                data.DisplayImage = default;
            }
            return ValueTask.FromResult(datas);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();
            return this.Context.GetInventoryInfo(game_env, inventoryObjectDTO);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            var data = await this.MonoTaskAsync((gameContext, args) => gameContext.UpdateInventoryInfo(args.game_env, args.inventoryObjectDTO), (game_env, inventoryObjectDTO)).ConfigureAwait(false);

            await this.PlayMessageAsync($@"{data.ObjectId}:{data.DisplayValue}").ConfigureAwait(false);
            return data;
        }
        #endregion

        #region Character

        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();
            var datas = await this.MonoTaskAsync((p, game_env) => p.GetListCharacterDisplay(game_env).ToArray(), game_env).ConfigureAwait(false);
            //   this.UpdateListGameImage(datas, p => $@"{p.DisplayImage}.png");
            foreach (var data in datas)
            {
                data.DisplayImage = default;
            }
            return datas;
        }
        public sealed override async ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            return await this.MonoTaskAsync((p, args) => p.GetCharacterEquipment(args.game_env, args.characterObjectDTO), (game_env, characterObjectDTO)).ConfigureAwait(false);

        }
        public sealed override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            return await this.MonoTaskAsync((p, args) => p.GetCharacterSkill(args.game_env, args.characterObjectDTO), (game_env, characterObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            return await this.MonoTaskAsync((p, args) => p.GetCharacterStatus(args.game_env, args.characterObjectDTO), (game_env, characterObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            var data = await this.MonoTaskAsync((p, args) => p.UpdateCharacterStatus(args.game_env, args.characterModifyDTO), (game_env, characterModifyDTO)).ConfigureAwait(false);
            await this.PlayMessageAsync($@"CharacterStatus:{data.ObjectId}").ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            var data = await this.MonoTaskAsync((p, args) => p.UpdateCharacterSkill(args.game_env, args.characterModifyDTO), (game_env, characterModifyDTO)).ConfigureAwait(false);

            await this.PlayMessageAsync($@"CharacterSkill:{data.ObjectId}").ConfigureAwait(false);
            return data;
        }

        #endregion

        #region Monster

        public sealed override ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            var datas = this.Context.GetListMonsterDisplay().ToArray();
            //         this.UpdateListGameImage(datas);
            foreach (var data in datas)
            {
                data.DisplayImage = default;
            }
            return ValueTask.FromResult(datas);
        }

        public sealed override async ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
        {
            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();

            var data = await this.MonoTaskAsync((p, args) => p.AddMonsterMember(args.game_env, args.monsterObjectDTO), (game_env, monsterObjectDTO)).ConfigureAwait(false);
            await this.PlayMessageAsync($@"AddMonsterMember:{data.ObjectId}").ConfigureAwait(false);
            return data;
        }
        #endregion

        #region Skill

        public sealed override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            var datas = this.Context.GetListGameSkillDisplay().ToArray();
            //           this.UpdateListGameImage(datas);
            foreach (var data in datas)
            {
                data.DisplayImage = default;
            }
            return ValueTask.FromResult(datas);
        }

        public sealed override async ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
        {
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

            var game_env = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            game_env.ThrowIfNotLoaded();


            if (gameSwitchName == EnumGameSwitchName.RandomBuff)
            {
                game_env.ThrowIfNotInBattle();
                var name = await this.MonoTaskAsync((p, game_env) => p.SetBuff2Character(game_env), game_env).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add Buff:{name}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.RandomDeBuff)
            {
                game_env.ThrowIfNotInBattle();
                var name = await this.MonoTaskAsync((p, game_env) => p.SetDeBuff2Enemy(game_env), game_env).ConfigureAwait(false);
                await this.PlayMessageAsync($"Add DeBuff:{name}").ConfigureAwait(false);

            }
            else if (gameSwitchName == EnumGameSwitchName.DoubleMoveSpeed)
            {
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangelayerDoubleMoveSpeed(args.game_env, args.switchDisplay, true), (game_env, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangelayerDoubleMoveSpeed(args.game_env, args.switchDisplay, false), (game_env, switchDisplay)).ConfigureAwait(false);
                }

                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.DoubleMonsterExp)
            {
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterDoubleExp(args.game_env, args.switchDisplay, true), (game_env, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterDoubleExp(args.game_env, args.switchDisplay, false), (game_env, switchDisplay)).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.MonsterFlash)
            {
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterFlash(args.game_env, args.switchDisplay, true), (game_env, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterFlash(args.game_env, args.switchDisplay, false), (game_env, switchDisplay)).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.MonsterColor)
            {
                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterColor(args.game_env, args.switchDisplay, true), (game_env, switchDisplay)).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync((p, args) => p.ChangeMonsterColor(args.game_env, args.switchDisplay, false), (game_env, switchDisplay)).ConfigureAwait(false);
                }

                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{on}").ConfigureAwait(false);
            }
            else if (gameSwitchName == EnumGameSwitchName.ScanMode)
            {
                game_env.ThrowIfIsLocked();

                var on = gameSwitchModify.SwitchValue;
                if (on)
                {
                    await this.UITaskAsync((p, game_env) => p.ChangeScanMode(game_env, true), game_env).ConfigureAwait(false);
                }
                else
                {
                    await this.UITaskAsync((p, game_env) => p.ChangeScanMode(game_env, false), game_env).ConfigureAwait(false);
                }
                await this.PlayMessageAsync($"{gameSwitchModify.SwitchObjectId}:{gameSwitchModify.SwitchValue}").ConfigureAwait(false);


            }
            else if (gameSwitchName == EnumGameSwitchName.MapWeather)
            {
                if (Enum.TryParse<MapWeather>(gameSwitchModify.ContentValue, out var mapWeather))
                {
                    await this.MonoTaskAsync(static (p, args) => p.SetMapWeather(args.game_env, args.mapWeather), (game_env, mapWeather)).ConfigureAwait(false);
                }
                else
                {
                    return GameException.Throw<GameSwitchDisplayDTO>("NOT FOUND Map Weather");
                }
            }
            else if (gameSwitchName == EnumGameSwitchName.MarkTeleport)
            {
                var pos = await this.MonoTaskAsync((p, game_env) => p.GetLastMarkDataPos(game_env), game_env).ConfigureAwait(false);
                if (false == pos.has)
                {
                    return GameException.Throw<GameSwitchDisplayDTO>("NOT FOUND MARK DATA");
                }
                else
                {
                    //await this.PlayMessageAsync($"Teleport:{pos.pos.x},{pos.pos.z}").ConfigureAwait(false);
                    await this.UITaskAsync((p, args) => p.MapTeleport(args.game_env, args.pos.pos), (game_env, pos)).ConfigureAwait(false);
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
            MonsterColor,
            MarkTeleport
        }


        protected override GameSwitchDisplayDTO[] InitListGameSwitch()
        {



            return [
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.MarkTeleport.ToString(),   DisplayName = "标记点传送(F9)" , DisplayDesc=   "传送到最后标记的地点" ,SwitchValue = false, UIType = (int)EnumGameSwitchUIType.Button},
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.RandomBuff.ToString(),   DisplayName = "随机增益(F11)" , DisplayDesc=  "随机Buff给我方妖精|仅限战斗准备阶段使用" ,SwitchValue = false,  UIType = (int)EnumGameSwitchUIType.Button},
                 new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.RandomDeBuff.ToString(),   DisplayName = "随机减益(F12)" , DisplayDesc=  "随机DeBuff给敌方妖怪|仅限战斗准备阶段使用" ,SwitchValue = false, UIType = (int)EnumGameSwitchUIType.Button},

                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchName.ScanMode.ToString(),   DisplayName = "1分钟灵视" , DisplayDesc=   "直接进入灵视|时长约为:60s" ,SwitchValue = false, UIType = (int)EnumGameSwitchUIType.Switches},

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

    //public class ImageBase64CacheService(MonoGameSettings gameSettings)
    //{
    //    public const string ImageBase64 = "data:image/png;base64,";

    //    public Dictionary<string, string> Cache { get; } = [];
    //    public MonoGameSettings Settings { get; } = gameSettings;
    //    public async ValueTask LoadAsync()
    //    {
    //        if (string.IsNullOrEmpty(Settings.WebRootPath))
    //        {
    //            return;
    //        }

    //        string path = Path.Combine(Settings.WebRootPath, Settings.GameResource ?? "GameResource");
    //        var directoryInfo = new DirectoryInfo(path);
    //        if (false == directoryInfo.Exists)
    //        {
    //            return;
    //        }

    //        foreach (var data in directoryInfo.GetFiles("*.png", SearchOption.AllDirectories))
    //        {
    //            using var fs = data.OpenRead();
    //            using var ms = new MemoryStream();
    //            await fs.CopyToAsync(ms).ConfigureAwait(false);
    //            var bytes = ms.ToArray();
    //            Cache.Add(fs.Name, $"{ImageBase64}{Convert.ToBase64String(bytes)}");

    //        }

    //    }
    //}
}
