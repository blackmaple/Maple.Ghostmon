using Maple.MonoGameAssistant.GameDTO;

namespace Maple.Ghostmon.Metadata.MetadataContext
{
    public sealed class GhostGameAVG(GhostmonGameContext gameContext) : IGhostmonGameCheatService
    {
        public GhostmonGameContext Context { get; } = gameContext;

        public GameCharacterSkillDTO AddMonsterMember(GameMonsterObjectDTO monsterObjectDTO)
        {
            throw new NotImplementedException();
        }

        public GameCharacterSkillDTO GetCharacterSkill(GameCharacterObjectDTO characterObjectDTO)
        {
            throw new NotImplementedException();
        }

        public GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            throw new NotImplementedException();
        }

        public GameCurrencyInfoDTO GetCurrencyInfo(GameCurrencyObjectDTO currencyObjectDTO)
        {
            throw new NotImplementedException();
        }

        public GameInventoryInfoDTO GetInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO)
        {
            throw new NotImplementedException();
        }

        public GameCharacterDisplayDTO[] GetListCharacterDisplay()
        {
            throw new NotImplementedException();
        }

        public GameCharacterSkillDTO UpdateCharacterSkill(GameCharacterModifyDTO characterModifyDTO)
        {
            throw new NotImplementedException();
        }

        public GameCharacterStatusDTO UpdateCharacterStatus(GameCharacterModifyDTO characterModifyDTO)
        {
            throw new NotImplementedException();
        }

        public GameCurrencyInfoDTO UpdateCurrencyInfo(GameCurrencyModifyDTO currencyModifyDTO)
        {
            throw new NotImplementedException();
        }

        public GameInventoryInfoDTO UpdateInventoryInfo(GameInventoryModifyDTO inventoryObjectDTO)
        {
            throw new NotImplementedException();
        }
    }
}
