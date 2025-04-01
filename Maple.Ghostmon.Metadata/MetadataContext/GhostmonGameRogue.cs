using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;

namespace Maple.Ghostmon.Metadata.MetadataContext
{
    public sealed class GhostmonGameRogue(GhostmonGameContext context) : IGhostmonGameCheatService
    {
        RogueDataManager.Ptr_RogueDataManager Ptr_RogueDataManager { get; } = context.RogueDataManager.INSTANCE;
        RogueCore.Ptr_RogueCore Ptr_RogueCore { get; } = context.RogueCore.INSTANCE;


        public GhostmonGameContext Context { get; } = context;

        public GameCurrencyInfoDTO GetCurrencyInfo(GameCurrencyObjectDTO currencyObjectDTO)
        {
            if (false == Enum.TryParse<EnumSheetName>(currencyObjectDTO.CurrencyObject, out var obj))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {currencyObjectDTO.CurrencyObject}");
            }

            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;
            string count;
            if (obj == EnumSheetName.GEM)
            {
                count = string.Empty;// userData.GEM_NUM.ToString();
            }
            else if (obj == EnumSheetName.COIN)
            {
                count = userData.COIN_NUM.ToString();
            }
            else if (obj == EnumSheetName.REIKI)
            {
                count = userData.REIKI.ToString();
            }
            else if (obj == EnumSheetName.HeartStone)
            {
                count = string.Empty;//userData.HEART_STONE_NUM.ToString();
            }
            else
            {
                count = string.Empty;
            }
            return new GameCurrencyInfoDTO() { ObjectId = currencyObjectDTO.CurrencyObject, DisplayValue = count };

        }
        public GameCurrencyInfoDTO UpdateCurrencyInfo(GameCurrencyModifyDTO currencyModifyDTO)
        {
            if (false == Enum.TryParse<EnumSheetName>(currencyModifyDTO.CurrencyObject, out var obj))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {currencyModifyDTO.CurrencyObject}");
            }
            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;

            if (obj == EnumSheetName.GEM)
            {
                //  userData.GEM_NUM = currencyModifyDTO.IntValue;
            }
            else if (obj == EnumSheetName.COIN)
            {
                userData.COIN_NUM = currencyModifyDTO.IntValue;
            }
            else if (obj == EnumSheetName.REIKI)
            {
                userData.REIKI = currencyModifyDTO.IntValue;
            }
            else if (obj == EnumSheetName.HeartStone)
            {
                //  userData.HEART_STONE_NUM = currencyModifyDTO.IntValue;
            }

            //        @this.PlayMessage($"{obj}:{currencyModifyDTO.NewValue}");

            return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, DisplayValue = currencyModifyDTO.NewValue };

        }


        public GameCharacterSkillDTO AddMonsterMember(GameMonsterObjectDTO monsterObjectDTO)
        {

            if (false == this.Context.TryGetMonsterObject(monsterObjectDTO.MonsterObject, out var monsterObject))
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {monsterObjectDTO.MonsterObject}");
            }
            var userDataManager = this.Ptr_RogueDataManager;

            //固定不释放
            var gchandle = this.Context.RuntimeContext.CreateMonoGCHandle(this.Context.MonsterData.New(false));
            var monsterData = gchandle.Target;

            monsterData.CTOR(monsterObject, 1, 0, true);

            //     monsterData.GET_ABILITIES();

            userDataManager.SET_MONSTER_INFO(monsterData);

            userDataManager.ADD_MONSTER(monsterData);

            return new GameCharacterSkillDTO()
            {
                ObjectId = monsterData.DATA_ID.ToString(),
                SkillInfos = GhostmonGameContextExtensions.GetListSkill_Monster(this.Context, monsterData),

            };
        }

        IEnumerable<GameCharacterDisplayDTO> EnumCharacters()
        {
            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;
            foreach (var monster in userData.TAKE_MONSTERS)
            {
                yield return new GameCharacterDisplayDTO()
                {
                    ObjectId = monster.DATA_ID.ToString(),
                    DisplayCategory = EnumSheetName.Monster.ToString(),
                    DisplayName = monster.U_NAME.ToString(),
                    DisplayDesc = ConfigDataStore.Ptr_ConfigDataStore.GET_LANGUAGE_TEXT(monster.U_PROFESSIONAL).ToString(),
                    DisplayImage = monster.U_PREFAB.ToString(),
                    CharacterAttributes = [
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_VARI_COLOR),DisplayName =  "属性*异色",DisplayValue = monster.U_VARI_COLOR.ToString()  },
                         new GameValueInfoDTO(){ObjectId = nameof(monster.U_FLASH),DisplayName = "属性*闪光",DisplayValue = monster.U_FLASH.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_LEVEL),DisplayName =  "属性*等级",DisplayValue = monster.U_LEVEL.ToString(),CanPreview = true,  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_EXP),DisplayName = "属性*当前经验",DisplayValue = monster.U_EXP.ToString() ,CanWrite = true },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_TOTAL_EXP),DisplayName =  "属性*累计经验",DisplayValue = monster.U_TOTAL_EXP.ToString()  },
                        new GameValueInfoDTO(){ObjectId = nameof(monster.U_FAVORABILITY),DisplayName =  "属性*亲密",DisplayValue = monster.U_FAVORABILITY.ToString(),CanWrite= true },





                        ]
                };
            }
        }
        public GameCharacterDisplayDTO[] GetListCharacterDisplay()
        {
            return [.. EnumCharacters()];
        }
        public GameCharacterSkillDTO GetCharacterSkill(GameCharacterObjectDTO characterObjectDTO)
        {
            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;
            if (characterObjectDTO.CharacterCategory == EnumSheetName.Player.ToString())
            {

            }
            else if (characterObjectDTO.CharacterCategory == EnumSheetName.Monster.ToString())
            {
                foreach (var monsterData in userData.TAKE_MONSTERS)
                {
                    if (monsterData.DATA_ID == characterObjectDTO.UCharacterId)
                    {
                        return new GameCharacterSkillDTO()
                        {
                            ObjectId = characterObjectDTO.CharacterId,
                            SkillInfos = GhostmonGameContextExtensions.GetListSkill_Monster(this.Context, monsterData),
                        };
                    }
                }
            }
            else if (characterObjectDTO.CharacterCategory == EnumSheetName.EggConfig.ToString())
            {

            }

            return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
        }
        public GameCharacterSkillDTO UpdateCharacterSkill(GameCharacterModifyDTO characterModifyDTO)
        {

            if (false == ulong.TryParse(characterModifyDTO.ModifyObject, out var removeSkillId) && string.IsNullOrEmpty(characterModifyDTO.NewValue))
            {
                return GameException.Throw<GameCharacterSkillDTO>("ERROR");
            }
            if (characterModifyDTO.CharacterCategory == EnumSheetName.Player.ToString())
            {
                return GameException.Throw<GameCharacterSkillDTO>($"ERROR {characterModifyDTO.CharacterCategory}");
            }

            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;
            if (characterModifyDTO.CharacterCategory == EnumSheetName.Monster.ToString())
            {

                foreach (var monsterData in userData.TAKE_MONSTERS)
                {
                    if (monsterData.DATA_ID == characterModifyDTO.UCharacterId)
                    {



                        var addSkillId = characterModifyDTO.ULongValue;

                        //fix skill
                        IEnumerable<ulong> skills;
                        //if (monsterData.U_ABILITIES.Size > 4)
                        //{
                        //    skills = [];
                        //}
                        //else
                        if (addSkillId == 0LU)
                        {
                            skills = GhostmonGameContextExtensions.RemoveTheSkill(monsterData.U_ABILITIES, removeSkillId);
                        }
                        else
                        {
                            skills = GhostmonGameContextExtensions.AddTheSkill(monsterData.U_ABILITIES, addSkillId, removeSkillId);
                        }
                        var strSkill = string.Join(',', skills);
                        using var monoString = this.Context.T2(strSkill);
                        var ptrSkills = GameBasicUtil.Ptr_GameBasicUtil.STRING_TO_LONG_ARRAY(monoString, ',');

                        //固定不释放
                        var gchandle = this.Context.RuntimeContext.CreateMonoGCHandle(ptrSkills);
                        var newPtrSkills = gchandle.GetTarget();
                        monsterData.U_ABILITIES = newPtrSkills;


                        return new GameCharacterSkillDTO()
                        {
                            ObjectId = characterModifyDTO.CharacterId,
                            SkillInfos = GhostmonGameContextExtensions.GetListSkill_Monster(this.Context, monsterData),
                        };
                    }
                }
            }
            else if (characterModifyDTO.CharacterCategory == EnumSheetName.EggConfig.ToString())
            {


            }
            return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.CharacterCategory}");


        }

        public GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;
            if (characterObjectDTO.CharacterCategory == EnumSheetName.Player.ToString())
            {

            }
            else if (characterObjectDTO.CharacterCategory == EnumSheetName.Monster.ToString())
            {

                foreach (var monsterData in userData.TAKE_MONSTERS)
                {
                    if (monsterData.DATA_ID == characterObjectDTO.UCharacterId)
                    {
                        return GhostmonGameContextExtensions.GetCharacterStatus_Monster(characterObjectDTO, monsterData);
                    }
                }
            }
            else if (characterObjectDTO.CharacterCategory == EnumSheetName.EggConfig.ToString())
            {

            }

            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
        }
        public GameCharacterStatusDTO UpdateCharacterStatus(GameCharacterModifyDTO characterModifyDTO)
        {
            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;

            if (characterModifyDTO.CharacterCategory == EnumSheetName.Player.ToString())
            {

            }
            else if (characterModifyDTO.CharacterCategory == EnumSheetName.Monster.ToString())
            {
                foreach (var monster in userData.TAKE_MONSTERS)
                {
                    if (monster.DATA_ID == characterModifyDTO.UCharacterId)
                    {
                        if (false == this.Context.TryGetMonsterObject(monster.U_PREFAB, out var monsterObj))
                        {
                            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterModifyDTO.CharacterId}");
                        }
                        if (characterModifyDTO.ModifyObject == nameof(monster.U_EXP))
                        {
                            monster.U_EXP = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_FAVORABILITY))
                        {
                            monster.U_FAVORABILITY = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_LUCK))
                        {
                            monster.U_LUCK = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_YING_YANG))
                        {
                            monster.U_YING_YANG = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_TYPE))
                        {
                            var type = characterModifyDTO.IntValue;
                            monster.U_TYPE = type;
                            if (type == (int)EnumMonsterType.首领)
                            {
                                monster.SET_LEADER();
                            }
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_ATK_FORCE))
                        {
                            monster.U_ATK_FORCE = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_WEIGHT))
                        {
                            monster.U_WEIGHT = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_ATK_TYPE))
                        {
                            monster.U_ATK_TYPE = characterModifyDTO.IntValue;
                        }


                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_ATK))
                        {
                            monster.GROWTH_ATK = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_DEF))
                        {
                            monster.GROWTH_DEF = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_HP))
                        {
                            monster.GROWTH_HP = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_WP))
                        {
                            monster.GROWTH_WP = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_MAGIC))
                        {
                            monster.GROWTH_MAGIC = characterModifyDTO.FloatValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.GROWTH_CRIT))
                        {
                            monster.GROWTH_CRIT = characterModifyDTO.FloatValue;
                        }

                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_ATK))
                        {
                            var r = characterModifyDTO.IntValue;
                            monster.RANK_ATK = r;
                            monster.GROWTH_ATK = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_ATK);

                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_DEF))
                        {
                            var r = characterModifyDTO.IntValue;
                            monster.RANK_DEF = r;
                            monster.GROWTH_DEF = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_DEF);

                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_HP))
                        {
                            var r = characterModifyDTO.IntValue;
                            monster.RANK_HP = r;
                            monster.GROWTH_HP = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_HP);

                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_WP))
                        {
                            var r = characterModifyDTO.IntValue;
                            monster.RANK_WP = r;
                            monster.GROWTH_WP = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_WP);

                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_MAGIC))
                        {
                            var r = characterModifyDTO.IntValue;
                            monster.RANK_MAGIC = r;
                            monster.GROWTH_MAGIC = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_MAGIC);

                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.RANK_CRIT))
                        {
                            var r = characterModifyDTO.IntValue;
                            monster.RANK_CRIT = r;
                            monster.GROWTH_CRIT = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_CRIT);

                        }

                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_FIRE_RESIST))
                        {
                            monster.U_FIRE_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_COLD_RESIST))
                        {
                            monster.U_COLD_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_LTNG_RESIST))
                        {
                            monster.U_LTNG_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_WIND_RESIST))
                        {
                            monster.U_WIND_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_POISON_RESIST))
                        {
                            monster.U_POISON_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_DARK_RESIST))
                        {
                            monster.U_DARK_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_PUNCTURE_RESIST))
                        {
                            monster.U_PUNCTURE_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_SHOCK_RESIST))
                        {
                            monster.U_SHOCK_RESIST = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_TEAR_RESIST))
                        {
                            monster.U_TEAR_RESIST = characterModifyDTO.IntValue;
                        }

                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_COOK))
                        {
                            monster.U_COOK = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_DRAW))
                        {
                            monster.U_DRAW = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_PLANT))
                        {
                            monster.U_PLANT = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_EXPLOIT))
                        {
                            monster.U_EXPLOIT = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_UNDERSTANDING))
                        {
                            monster.U_UNDERSTANDING = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_GUARD))
                        {
                            monster.U_GUARD = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_TRADE))
                        {
                            monster.U_TRADE = characterModifyDTO.IntValue;
                        }
                        else if (characterModifyDTO.ModifyObject == nameof(monster.U_HUNT))
                        {
                            monster.U_HUNT = characterModifyDTO.IntValue;
                        }
                        else
                        {
                            var rank = 0;
                            var upRank = characterModifyDTO.BoolValue ?? false;
                            if (characterModifyDTO.ModifyObject == nameof(monster.U_FLASH))
                            {
                                monster.U_FLASH = upRank;
                                rank = 6;
                            }
                            else if (characterModifyDTO.ModifyObject == nameof(monster.U_VARI_COLOR))
                            {
                                monster.U_VARI_COLOR = upRank;
                                rank = 3;

                            }
                            if (rank > 0)
                            {
                                if (upRank)
                                {
                                    monster.RANK_ATK = rank;
                                    monster.RANK_DEF = rank;
                                    monster.RANK_HP = rank;
                                    monster.RANK_MAGIC = rank;
                                    monster.RANK_WP = rank;
                                    monster.RANK_CRIT = rank;

                                    monster.GROWTH_ATK = monster.SET_GROWTH_VALUE(rank, monsterObj.GROWTH_ATK);
                                    monster.GROWTH_DEF = monster.SET_GROWTH_VALUE(rank, monsterObj.GROWTH_DEF);
                                    monster.GROWTH_HP = monster.SET_GROWTH_VALUE(rank, monsterObj.GROWTH_HP);
                                    monster.GROWTH_MAGIC = monster.SET_GROWTH_VALUE(rank, monsterObj.GROWTH_MAGIC);
                                    monster.GROWTH_WP = monster.SET_GROWTH_VALUE(rank, monsterObj.GROWTH_WP);
                                    monster.GROWTH_CRIT = monster.SET_GROWTH_VALUE(rank, monsterObj.GROWTH_CRIT);


                                }
                                else
                                {
                                    var r = monster.GET_RANDOM_APTITUDE_RANK();
                                    monster.RANK_ATK = r;
                                    monster.GROWTH_ATK = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_ATK);

                                    r = monster.GET_RANDOM_APTITUDE_RANK();
                                    monster.RANK_DEF = r;
                                    monster.GROWTH_DEF = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_DEF);

                                    r = monster.GET_RANDOM_APTITUDE_RANK();
                                    monster.RANK_HP = r;
                                    monster.GROWTH_HP = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_HP);

                                    r = monster.GET_RANDOM_APTITUDE_RANK();
                                    monster.RANK_MAGIC = r;
                                    monster.GROWTH_MAGIC = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_MAGIC);

                                    r = monster.GET_RANDOM_APTITUDE_RANK();
                                    monster.RANK_WP = r;
                                    monster.GROWTH_WP = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_WP);

                                    r = monster.GET_RANDOM_APTITUDE_RANK();
                                    monster.RANK_CRIT = r;
                                    monster.GROWTH_CRIT = monster.SET_GROWTH_VALUE(r, monsterObj.GROWTH_CRIT);

                                }
                            }

                        }

                        //基础属性重新计算
                        monster.REFRESH_PROPERTY(monsterObj);





                        return GhostmonGameContextExtensions.GetCharacterStatus_Monster(characterModifyDTO, monster);



                    }
                }
            }
            else if (characterModifyDTO.CharacterCategory == EnumSheetName.EggConfig.ToString())
            {

            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterModifyDTO.UCharacterId}:{characterModifyDTO.ModifyObject}");

        }


        private static int GetInventoryCount(CurRogueData.Ptr_CurRogueData userData, EnumSheetName category, ulong configId)
        {
            int count = 0;
            if (category == EnumSheetName.MaterialConfig)
            {

                //foreach (var data in userData.TOTAL_MATERIALS)
                //{
                //    if (data.CONFIG_ID == configId)
                //    {
                //        count = data.COUNT;
                //        break;
                //    }
                //}
            }
            else if (category == EnumSheetName.CharmConfig)
            {

                foreach (var data in userData.TOTAL_CHARMS)
                {

                    if (data.CONFIG_ID == configId)
                    {
                        count = data.NUM;
                        break;
                    }
                }
            }
            else if (category == EnumSheetName.RareConfig)
            {
                //foreach (var data in userData.TOTAL_RARE)
                //{
                //    if (data.CONFIG_ID == configId)
                //    {
                //        count = data.NUM;
                //        break;
                //    }
                //}
            }
            else if (category == EnumSheetName.AbilityBookConfig)
            {
                foreach (var data in userData.TOTAL_ABILITY_BOOKS)
                {
                    if (data.CONFIG_ID == configId)
                    {
                        count = data.NUM;
                    }
                }
            }
            else if (category == EnumSheetName.TreasureConfig)
            {
                //foreach (var data in userData.TOTAL_TREASURE)
                //{
                //    if (data.CONFIG_ID == configId)
                //    {
                //        count = data.NUM;
                //    }
                //}
            }
            else if (category == EnumSheetName.ClothingConfig)
            {
                //foreach (var data in userData.TOTAL_CLOTHING)
                //{
                //    if (data == configId)
                //    {
                //        count = 1;
                //        break;
                //    }
                //}
            }
            else if (category == EnumSheetName.MenuConfig)
            {

                //foreach (var data in userData.TOTAL_MENU.AsRefArray())
                //{
                //    if (data.Value == configId)
                //    {
                //        count = 1;
                //        break;
                //    }
                //}
            }
            else if (category == EnumSheetName.EggConfig)
            {
                //foreach (var data in userData.TOTAL_EGG.AsRefArray())
                //{
                //    var egg = data.Value;
                //    if (egg.Valid() && egg.CONFIG_ID == configId)
                //    {
                //        count++;
                //    }
                //}
            }
            else if (category == EnumSheetName.ItemRecipeConfig)
            {

                //foreach (var data in userData.TOTAL_ITEM_RECIPE.AsRefArray())
                //{
                //    if (data.Key == configId)
                //    {
                //        count = 1;
                //    }
                //}
            }
            else if (category == EnumSheetName.FishLureConfig)
            {
                //foreach (var data in userData.TOTAL_FISH_LURE.AsRefArray())
                //{
                //    if (data.Key == configId && data.Value)
                //    {
                //        count = data.Value.NUM;
                //    }
                //}
            }
            else if (category == EnumSheetName.EvoMaterialConfig)
            {
                foreach (var data in userData.TOTAL_EVO_MATERIALS)
                {
                    if (data.CONFIG_ID == configId)
                    {
                        count = data.NUM;
                    }
                }
            }
            return count;
        }
        public GameInventoryInfoDTO GetInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO)
        {
            if (false == Enum.TryParse<EnumSheetName>(inventoryObjectDTO.InventoryCategory, out var category))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryCategory}");
            }
            if (false == ulong.TryParse(inventoryObjectDTO.InventoryObject, out var configId))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryObject}");
            }
            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;
            var count = GetInventoryCount(userData, category, configId);
            return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject, InventoryCount = count };
        }
        public GameInventoryInfoDTO UpdateInventoryInfo(GameInventoryModifyDTO inventoryModifyDTO)
        {
            if (false == Enum.TryParse<EnumSheetName>(inventoryModifyDTO.InventoryCategory, out var category))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryCategory}");
            }
            if (false == ulong.TryParse(inventoryModifyDTO.InventoryObject, out var configId))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryObject}");
            }
            var userData = this.Ptr_RogueDataManager.ROGUE_DATA.CUR_ROGUE_DATA;
            var oldCount = GetInventoryCount(userData, category, configId);
            var newCount = inventoryModifyDTO.InventoryCount;
            var addCount = newCount - oldCount;
            if (addCount <= 0)
            {
                return GameException.Throw<GameInventoryInfoDTO>($"ERROR NUM:{inventoryModifyDTO.InventoryCategory}");
            }
            if (category == EnumSheetName.EggConfig)
            {
                addCount = 1;
            }
            this.Ptr_RogueDataManager.GAIN_ITEM((int)category, configId, addCount);
            return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = newCount };
        }
    }

}
