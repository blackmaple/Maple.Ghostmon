using Maple.MonoGameAssistant.GameDTO;

namespace Maple.Ghostmon.Metadata.MetadataContext
{
    public interface IGhostmonGameCheatService
    {


        GhostGameType GameType { get; }
        GhostmonGameContext Context { get; }

        GameCharacterSkillDTO AddMonsterMember(GameMonsterObjectDTO monsterObjectDTO);
        GameCharacterSkillDTO GetCharacterSkill(GameCharacterObjectDTO characterObjectDTO);
        GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO);
        GameCurrencyInfoDTO GetCurrencyInfo(GameCurrencyObjectDTO currencyObjectDTO);
        GameInventoryInfoDTO GetInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO);
        GameCharacterDisplayDTO[] GetListCharacterDisplay();
        GameCharacterSkillDTO UpdateCharacterSkill(GameCharacterModifyDTO characterModifyDTO);
        GameCharacterStatusDTO UpdateCharacterStatus(GameCharacterModifyDTO characterModifyDTO);
        GameCurrencyInfoDTO UpdateCurrencyInfo(GameCurrencyModifyDTO currencyModifyDTO);
        GameInventoryInfoDTO UpdateInventoryInfo(GameInventoryModifyDTO inventoryObjectDTO);
    }

}
