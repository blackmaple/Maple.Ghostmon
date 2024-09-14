using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;

namespace Maple.Ghostmon
{

    sealed class GhostmonGameEnvironment
    {

        public GhostmonGameEnvironment(GhostmonGameContext @this)
        {
            var userDataManager = @this.UserDataManager.INSTANCE;
            if (false == userDataManager)
            {
                return;
            }
            this.Ptr_UserDataManager = userDataManager;

            var regionManager = @this.RegionManager.INSTANCE;
            if (false == regionManager)
            {
                return;
            }
            this.Ptr_RegionManager = regionManager;
            this.Ptr_BattleCore = @this.BattleCore.INSTANCE;
            this.Ptr_CharacterCore = @this.CharacterCore.INSTANCE;
        }

        public UserDataManager.Ptr_UserDataManager Ptr_UserDataManager { get; }
        public UserData.Ptr_UserData Ptr_UserData => Ptr_UserDataManager.USER_DATA;
        public PlayerProperty.Ptr_PlayerProperty Ptr_PlayerProperty => Ptr_UserDataManager.PLAYER_PROPERTY;

        public RegionManager.Ptr_RegionManager Ptr_RegionManager { get; }
        public EnvironmentCtrl.Ptr_EnvironmentCtrl Ptr_EnvironmentCtrl => Ptr_RegionManager.ENVIRONMENT_CTRL;
        public BattleCore.Ptr_BattleCore Ptr_BattleCore { get; }

        public JudgeControl.Ptr_JudgeControl Ptr_JudgeControl => Ptr_BattleCore.JUDGE_CONTROL;

        public CharacterCore.Ptr_CharacterCore Ptr_CharacterCore { get; }


        /// <summary>
        /// 游戏运行
        /// </summary>
        /// <returns></returns>
        private bool InGame()
        {
            return this.Ptr_UserDataManager.Valid();
        }
        public bool ThrowIfNotInGame()
        {
            return InGame() || GameException.Throw<bool>("Game is not init");
        }

        /// <summary>
        /// 已读档
        /// </summary>
        /// <returns></returns>
        private bool Loaded()
        {
            return this.Ptr_RegionManager.Valid();
        }
        public bool ThrowIfNotLoaded()
        {
            return Loaded() || GameException.Throw<bool>("Game is not loaded");
        }


        /// <summary>
        /// 对战中
        /// </summary>
        /// <param name="battlePhase"></param>
        /// <returns></returns>
        private bool InBattle(BattlePhase battlePhase = BattlePhase.Deploy)
        {
            var battle = this.Ptr_BattleCore;
            if (battle)
            {
                return battle.PHASE == battlePhase;
            }
            return default;
        }
        public bool ThrowIfNotInBattle(BattlePhase battlePhase = BattlePhase.Deploy)
        {
            return InBattle(battlePhase) || GameException.Throw<bool>($"Battle is not {battlePhase.ToString()}");
        }

        /// <summary>
        /// 不可移动角色
        /// </summary>
        /// <returns></returns>
        public bool IsLocked()
        {
            var characterCore = this.Ptr_CharacterCore;
            if (characterCore)
            {
                return characterCore.IS_LOCKED;
            }
            return default;
        }
        public bool ThrowIfIsLocked()
        {
            return IsLocked() || GameException.Throw<bool>("Character is locked");
        }
    }
}
