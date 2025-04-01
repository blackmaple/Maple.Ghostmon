using Maple.Ghostmon.Metadata.MetadataModel;
using Maple.MonoGameAssistant.GameDTO;
using static Maple.Ghostmon.BattleCore;
using static Maple.Ghostmon.RegionManager;
using static Maple.Ghostmon.UserDataManager;

namespace Maple.Ghostmon.Metadata.MetadataContext
{

    public sealed partial class GhostmonGameEnvironment : IGhostmonGameCheatService
    {

        public GhostmonGameEnvironment(GhostmonGameContext context)
        {
            this.Context = context;
            var userDataManager = context.UserDataManager.INSTANCE;
            if (false == userDataManager)
            {
                return;
            }
            Ptr_UserDataManager = userDataManager;

            var regionManager = context.RegionManager.INSTANCE;
            if (false == regionManager)
            {
                return;
            }
            Ptr_RegionManager = regionManager;
            Ptr_BattleCore = context.BattleCore.INSTANCE;
            Ptr_CharacterCore = context.CharacterCore.INSTANCE;

        }

        public GhostmonGameContext Context { get; }
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
            return Ptr_UserDataManager.Valid();
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
            return Ptr_RegionManager.Valid();
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
            var battle = Ptr_BattleCore;
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
            var characterCore = Ptr_CharacterCore;
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


    partial class GhostmonGameEnvironment
    {

        public GameCurrencyInfoDTO GetCurrencyInfo(GameCurrencyObjectDTO currencyObjectDTO)
        {
            return this.Context.GetCurrencyInfo(this, currencyObjectDTO);
        }
        public GameCurrencyInfoDTO UpdateCurrencyInfo(GameCurrencyModifyDTO currencyModifyDTO)
        {
            return this.Context.UpdateCurrencyInfo(this, currencyModifyDTO);
        }

        public GameInventoryInfoDTO GetInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO)
        {
            return this.Context.GetInventoryInfo(this, inventoryObjectDTO);
        }
        public GameInventoryInfoDTO UpdateInventoryInfo(GameInventoryModifyDTO inventoryObjectDTO)
        {
            return this.Context.UpdateInventoryInfo(this, inventoryObjectDTO);
        }

        public GameCharacterDisplayDTO[] GetListCharacterDisplay()
        {
            return [.. this.Context.GetListCharacterDisplay(this)];
        }
        public GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            return this.Context.GetCharacterStatus(this, characterObjectDTO);
        }
        public GameCharacterStatusDTO UpdateCharacterStatus(GameCharacterModifyDTO characterModifyDTO)
        {
            return this.Context.UpdateCharacterStatus(this, characterModifyDTO);
        }
        public GameCharacterSkillDTO GetCharacterSkill(GameCharacterObjectDTO characterObjectDTO)
        {
            return this.Context.GetCharacterSkill(this, characterObjectDTO);
        }
        public GameCharacterSkillDTO UpdateCharacterSkill(GameCharacterModifyDTO characterModifyDTO)
        {
            return this.Context.UpdateCharacterSkill(this, characterModifyDTO);
        }

        public GameCharacterSkillDTO AddMonsterMember(GameMonsterObjectDTO monsterObjectDTO)
        {
            return this.Context.AddMonsterMember(this, monsterObjectDTO);
        }
    }
}
