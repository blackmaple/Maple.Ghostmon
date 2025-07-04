using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector;
using Microsoft.Extensions.Logging;
using System;
using System.Runtime.CompilerServices;
using static Maple.Ghostmon.Metadata.AVGBaseBuff;
using static Maple.Ghostmon.Metadata.ListGenericAVGBaseBuff;

namespace Maple.Ghostmon.Metadata.MetadataContext
{
    public sealed class GhostGameAVG(GhostmonGameContext gameContext) : IGhostmonGameCheatService
    {
        static ListGenericAVGBaseBuff? ListGenericAVGBaseBuff { get; set; }
        static ListGenericAVGBaseSkill? ListGenericAVGBaseSkill { get; set; }

        bool InitListGeneric(AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData)
        {
            if (ListGenericAVGBaseSkill is null)
            {
                var skillMetadata = this.Context.RuntimeContext.RuntiemProvider.GetMonoClass((nint)ptr_AVGMonsterData.SKILLS);
                if (skillMetadata != nint.Zero)
                {
                    var classInfoDTO = this.Context.RuntimeContext.GetMonoCollectorClassInfo(skillMetadata);
                    ListGenericAVGBaseSkill = new ListGenericAVGBaseSkill(this.Context, classInfoDTO);

                    var add_method = ListGenericAVGBaseSkill.ClassInfo.MethodInfos.Find(p => p.Name == "Add");
                    ListGenericAVGBaseSkill.METHOD_ADD = add_method?.Pointer ?? nint.Zero;

                    var remove_method = ListGenericAVGBaseSkill.ClassInfo.MethodInfos.Find(p => p.Name == "Remove");
                    ListGenericAVGBaseSkill.METHOD_REMOVE = remove_method?.Pointer ?? nint.Zero;


                }
            }
            if (ListGenericAVGBaseBuff is null)
            {
                var buffMetadata = this.Context.RuntimeContext.RuntiemProvider.GetMonoClass((nint)ptr_AVGMonsterData.BUFFS);
                if (buffMetadata != nint.Zero)
                {
                    var classInfoDTO = this.Context.RuntimeContext.GetMonoCollectorClassInfo(buffMetadata);
                    ListGenericAVGBaseBuff = new ListGenericAVGBaseBuff(this.Context, classInfoDTO);

                    var add_method = ListGenericAVGBaseBuff.ClassInfo.MethodInfos.Find(p => p.Name == "Add");
                    ListGenericAVGBaseBuff.METHOD_ADD = add_method?.Pointer ?? nint.Zero;


                    var remove_method = ListGenericAVGBaseBuff.ClassInfo.MethodInfos.Find(p => p.Name == "Remove");
                    ListGenericAVGBaseBuff.METHOD_REMOVE = remove_method?.Pointer ?? nint.Zero;


                }
            }





            return ListGenericAVGBaseSkill is not null && ListGenericAVGBaseBuff is not null;


        }

        public GhostGameType GameType => GhostGameType.AVG;

        public GhostmonGameContext Context { get; } = gameContext;

        public AVGUserDataManager.Ptr_AVGUserDataManager Ptr_AVGUserDataManager { get; } = gameContext.AVGUserDataManager.INSTANCE;
        AVGUserData.Ptr_AVGUserData Ptr_AVGUserData => Ptr_AVGUserDataManager.USER_DATA;


        static AVGItemService.Ptr_AVGItemService GetOrCreateItemService(GhostmonGameContext context)
        {
            var serviceMgr = context.AVGServiceManager.INSTANCE;
            if (serviceMgr.Valid())
            {
                var service = serviceMgr.AVG_ITEM_SERVICE;
                if (service.Valid())
                {
                    return service;
                }
            }
            return context.AVGItemService.GCNew<AVGItemService.Ptr_AVGItemService>(true);
        }
        AVGItemService.Ptr_AVGItemService Ptr_AVGItemService { get; } = GetOrCreateItemService(gameContext);

        static AVGMonsterService.Ptr_AVGMonsterService GetOrCreateMonsterService(GhostmonGameContext context)
        {
            var serviceMgr = context.AVGServiceManager.INSTANCE;
            if (serviceMgr.Valid())
            {
                var service = serviceMgr.AVG_MONSTER_SERVICE;
                if (service.Valid())
                {
                    return service;
                }
            }
            return context.AVGMonsterService.GCNew<AVGMonsterService.Ptr_AVGMonsterService>(true);
        }
        AVGMonsterService.Ptr_AVGMonsterService Ptr_AVGMonsterService { get; } = GetOrCreateMonsterService(gameContext);




        public GameCurrencyInfoDTO GetCurrencyInfo(GameCurrencyObjectDTO currencyObjectDTO)
        {
            if (false == Enum.TryParse<EnumSheetName>(currencyObjectDTO.CurrencyObject, out var obj))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {currencyObjectDTO.CurrencyObject}");
            }
            var userData = this.Ptr_AVGUserData;
            string count;
            if (obj == EnumSheetName.COIN)
            {
                count = userData.GOLD.ToString();
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

            var userData = this.Ptr_AVGUserData;
            if (obj == EnumSheetName.COIN)
            {
                userData.GOLD = currencyModifyDTO.IntValue;
            }

            return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, DisplayValue = currencyModifyDTO.NewValue };
        }

        private AVGBagItemData.Ptr_AVGBagItemData NewItemData(ulong configId, int count)
        {
            using var gc_config = this.Context._AVGPropConfig.GCNew<_AVGPropConfig.Ptr__AVGPropConfig>(true);
            var config = gc_config.Target;
            config.CONFIG_ID = configId;
            var itemData = this.Context.AVGBagItemData.GCNew<AVGBagItemData.Ptr_AVGBagItemData>(false).Target;
            itemData.CTOR(config, count);
            itemData.REFRESH_CONFIG();
            return itemData;
        }
        private static bool TryGetItemData(AVGUserData.Ptr_AVGUserData userData, ulong configId, out AVGBagItemData.Ptr_AVGBagItemData ptr_AVGBagItemData)
        {
            Unsafe.SkipInit(out ptr_AVGBagItemData);
            foreach (var item in userData.TOTAL_ITEMS)
            {
                if (item.CONFIG.CONFIG_ID == configId)
                {
                    ptr_AVGBagItemData = item;
                    return true;
                }
            }
            return false;
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
            var userData = this.Ptr_AVGUserData;
            var count = TryGetItemData(userData, configId, out var ptr_AVGBagItemData) ? ptr_AVGBagItemData.COUNT : 0;
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
            var userData = this.Ptr_AVGUserData;
            var count = inventoryModifyDTO.InventoryCount;
            if (TryGetItemData(userData, configId, out var ptr_AVGBagItemData))
            {
                ptr_AVGBagItemData.COUNT = count;
            }
            else
            {
                var itemData = this.NewItemData(configId, count);
                this.Ptr_AVGItemService.ADD_ITEM(itemData);
            }

            return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = count };
        }



        static IEnumerable<GameCharacterDisplayDTO> EnumMonsters(AVGUserData.Ptr_AVGUserData userData)
        {
            foreach (var monster in userData.TAKE_MONSTERS)
            {
                var config = monster.CONFIG;
                yield return new GameCharacterDisplayDTO()
                {
                    ObjectId = monster.UUID.ToString()!,
                    DisplayCategory = EnumSheetName.AVGMonsterConfig.ToString(),
                    DisplayName = config.NAME.ToString(),
                    DisplayDesc = config.DESCRIPTION.ToString(),
                    //  DisplayImage = config.PREFAB.ToString(),
                    CharacterAttributes = [
                       new GameValueInfoDTO(){ ObjectId = nameof(monster.LEVEL),DisplayName = "属性*等级",DisplayValue=monster.LEVEL.ToString(),CanPreview = true }
                      ],
                };
            }
        }
        public GameCharacterDisplayDTO[] GetListCharacterDisplay()
        {
            return [.. EnumMonsters(this.Ptr_AVGUserData)];
        }

        private AVGBaseBuff.Ptr_AVGBaseBuff NewBaseBuff(ulong configId)
        {
            using var gc_config = this.Context._AVGBuffConfig.GCNew<_AVGBuffConfig.Ptr__AVGBuffConfig>(true);
            var config = gc_config.Target;
            config.CONFIG_ID = configId;
            var buffData = this.Context.AVGBaseBuff.GCNew<AVGBaseBuff.Ptr_AVGBaseBuff>(false).Target;
            buffData.CTOR(config, int.MaxValue / 2);
            buffData.REFRESH_CONFIG();
            buffData.REMAINING_TURNS = int.MaxValue / 2;
            return buffData;
        }
        private AVGBaseSkill.Ptr_AVGBaseSkill NewBaseSkill(ulong configId)
        {
            using var gc_config = this.Context._AVGAbilityConfig.GCNew<_AVGAbilityConfig.Ptr__AVGAbilityConfig>(true);
            var config = gc_config.Target;
            config.CONFIG_ID = configId;
            var itemData = this.Context.AVGBaseSkill.GCNew<AVGBaseSkill.Ptr_AVGBaseSkill>(false).Target;
            itemData.CTOR(config);
            itemData.REFRESH_ABILITY_CONFIG();
            return itemData;
        }


        private static bool TryGetMonsterPool(string prefab, out AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData)
        {
            Unsafe.SkipInit(out ptr_AVGMonsterData);
            var config = GhostmonGameContextExtensions.GameConfigStore.ListAVGMonsterConfig.Find(p => p.prefab == prefab);
            if (config is not null)
            {
                ptr_AVGMonsterData = AVGMonsterGenerator.Ptr_AVGMonsterGenerator.GENERATE_MONSTER_03(config.configID, 1);
                return true;
            }
            return false;
        }
        private static IEnumerable<GameSkillInfoDTO> EnumMonsterSkills(AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData)
        {
            yield return new GameSkillInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayName = string.Empty,
                DisplayDesc = string.Empty,
                DisplayCategory = EnumSheetName.AVGAbilityConfig.ToString(),
                CanWrite = true,
            };
            yield return new GameSkillInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayName = string.Empty,
                DisplayDesc = string.Empty,
                DisplayCategory = EnumSheetName.AVGBuffConfig.ToString(),
                CanWrite = true,
            };


            foreach (var skill in ptr_AVGMonsterData.SKILLS)
            {
                var configId = skill.ABILITY_CONFIG.CONFIG_ID;
                var config = GhostmonGameContextExtensions.GameConfigStore.ListAVGAbilityConfig.Find(p => p.configID == configId);
                if (config is not null)
                {
                    yield return new GameSkillInfoDTO()
                    {
                        ObjectId = config.configID.ToString(),
                        DisplayName = config.name,
                        DisplayDesc = config.description,
                        DisplayCategory = EnumSheetName.AVGAbilityConfig.ToString(),
                        CanWrite = true,
                    };
                }

            }
            foreach (var skillPool in ptr_AVGMonsterData.SKILL_POOL)
            {
                var configId = skillPool.ABILITY_CONFIG.CONFIG_ID;
                var config = GhostmonGameContextExtensions.GameConfigStore.ListAVGAbilityConfig.Find(p => p.configID == configId);
                if (config is not null)
                {
                    yield return new GameSkillInfoDTO()
                    {
                        ObjectId = config.configID.ToString(),
                        DisplayName = config.name,
                        DisplayDesc = config.description,
                        DisplayCategory = EnumSheetName.AVGAbilityConfig.ToString(),
                        CanWrite = true,

                    };
                }
            }
            foreach (var buff in ptr_AVGMonsterData.BUFFS)
            {
                var configId = buff.CONFIG.CONFIG_ID;
                var config = GhostmonGameContextExtensions.GameConfigStore.ListAVGBuffConfig.Find(p => p.configID == configId);
                if (config is not null)
                {
                    yield return new GameSkillInfoDTO()
                    {
                        ObjectId = config.configID.ToString(),
                        DisplayName = config.name,
                        DisplayDesc = config.description,
                        DisplayCategory = EnumSheetName.AVGBuffConfig.ToString(),
                        CanWrite = true,

                    };
                }
            }
        }
        private static bool TryFindMonsterSkill(AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData, ulong configId, out AVGBaseSkill.Ptr_AVGBaseSkill ptr_AVGBaseSkill, out bool fromPool)
        {
            Unsafe.SkipInit(out ptr_AVGBaseSkill);
            Unsafe.SkipInit(out fromPool);

            foreach (var skill in ptr_AVGMonsterData.SKILLS)
            {
                if (skill.ABILITY_CONFIG.CONFIG_ID == configId)
                {
                    ptr_AVGBaseSkill = skill;
                    fromPool = false;
                    return true;
                }

            }
            foreach (var skillPool in ptr_AVGMonsterData.SKILL_POOL)
            {
                if (skillPool.ABILITY_CONFIG.CONFIG_ID == configId)
                {
                    ptr_AVGBaseSkill = skillPool;
                    fromPool = true;
                    return true;
                }

            }
            return false;
        }
        private static IEnumerable<AVGBaseSkill.Ptr_AVGBaseSkill> DeleteMonsterSkill(AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData, ulong configId)
        {
            foreach (var skill in ptr_AVGMonsterData.SKILLS)
            {
                if (skill.ABILITY_CONFIG.CONFIG_ID != configId)
                {
                    yield return skill;
                }
            }
        }

        private static bool TryFindMonsterBuff(AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData, ulong configId, out AVGBaseBuff.Ptr_AVGBaseBuff ptr_AVGBaseBuff)
        {
            Unsafe.SkipInit(out ptr_AVGBaseBuff);
            foreach (var skill in ptr_AVGMonsterData.BUFFS)
            {
                if (skill.CONFIG.CONFIG_ID == configId)
                {
                    ptr_AVGBaseBuff = skill;
                    return true;
                }
            }
            return false;
        }
        //private static IEnumerable<AVGBaseBuff.Ptr_AVGBaseBuff> DeleteMonsterBuff(AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData, ulong configId)
        //{
        //    foreach (var skill in ptr_AVGMonsterData.BUFFS)
        //    {
        //        if (skill.CONFIG.CONFIG_ID != configId)
        //        {
        //            yield return skill;
        //        }
        //    }
        //}

        public GameCharacterSkillDTO AddMonsterMember(GameMonsterObjectDTO monsterObjectDTO)
        {
            if (!TryGetMonsterPool(monsterObjectDTO.MonsterObject, out var ptr_AVGMonsterData))
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {monsterObjectDTO.MonsterObject}");
            }
            this.Ptr_AVGMonsterService.ADD_MONSTER(ptr_AVGMonsterData, false);
            return new GameCharacterSkillDTO() { ObjectId = ptr_AVGMonsterData.UUID.ToString()!, SkillInfos = [.. EnumMonsterSkills(ptr_AVGMonsterData)] };

        }
        private static bool TryGetMonster(AVGUserData.Ptr_AVGUserData userData, ReadOnlySpan<char> uuid, out AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData)
        {
            Unsafe.SkipInit(out ptr_AVGMonsterData);
            foreach (var monster in userData.TAKE_MONSTERS)
            {
                if (uuid.SequenceEqual(monster.UUID.AsReadOnlySpan()))
                {
                    ptr_AVGMonsterData = monster;
                    return true;
                }
            }
            return false;
        }
        public GameCharacterSkillDTO GetCharacterSkill(GameCharacterObjectDTO characterObjectDTO)
        {
            if (characterObjectDTO.CharacterCategory != EnumSheetName.AVGMonsterConfig.ToString())
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterObjectDTO.CharacterCategory}");
            }
            if (!TryGetMonster(this.Ptr_AVGUserData, characterObjectDTO.CharacterId, out var ptr_AVGMonsterData))
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
            }
            return new GameCharacterSkillDTO() { ObjectId = characterObjectDTO.CharacterId, SkillInfos = [.. EnumMonsterSkills(ptr_AVGMonsterData)] };
        }
        public GameCharacterSkillDTO UpdateCharacterSkill(GameCharacterModifyDTO characterModifyDTO)
        {
            if (characterModifyDTO.CharacterCategory != EnumSheetName.AVGMonsterConfig.ToString())
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.CharacterCategory}");
            }
            if (!TryGetMonster(this.Ptr_AVGUserData, characterModifyDTO.CharacterId, out var ptr_AVGMonsterData))
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.CharacterId}");
            }
            if (false == ulong.TryParse(characterModifyDTO.ModifyObject, out var removeSkillId) && string.IsNullOrEmpty(characterModifyDTO.NewValue))
            {
                return GameException.Throw<GameCharacterSkillDTO>("ERROR ARGS");
            }
            if (!InitListGeneric(ptr_AVGMonsterData))
            {
                return GameException.Throw<GameCharacterSkillDTO>("ERROR InitListGeneric");
            }

            var addSkillId = characterModifyDTO.ULongValue;

            if (characterModifyDTO.ModifyCategory == EnumSheetName.AVGBuffConfig.ToString())
            {
                ListGenericAVGBaseBuff.Ptr_ListGenericAVGBaseBuff listBuff = (nint)ptr_AVGMonsterData.BUFFS;

                if (addSkillId == 0)
                {
                    if (TryFindMonsterBuff(ptr_AVGMonsterData, removeSkillId, out var ptr_AVGBaseBuff))
                    {
                        listBuff.REMOVE(ptr_AVGBaseBuff, ListGenericAVGBaseBuff!.METHOD_REMOVE);
                    }
                }
                else
                {
                    var baseBuff = NewBaseBuff(addSkillId);
                    listBuff.ADD(baseBuff, ListGenericAVGBaseBuff!.METHOD_ADD);

                }


            }
            else if (characterModifyDTO.ModifyCategory == EnumSheetName.AVGAbilityConfig.ToString())
            {

                if (addSkillId == 0)
                {
                    if (TryFindMonsterSkill(ptr_AVGMonsterData, removeSkillId, out var ptr_AVGBaseSkill, out var fromPool))
                    {
                        ListGenericAVGBaseSkill.Ptr_ListGenericAVGBaseSkill listSkill = (nint)(fromPool ? ptr_AVGMonsterData.SKILL_POOL : ptr_AVGMonsterData.SKILLS);
                        listSkill.REMOVE(ptr_AVGBaseSkill, ListGenericAVGBaseSkill!.METHOD_REMOVE);
                    }
                }
                else
                {
                    ListGenericAVGBaseSkill.Ptr_ListGenericAVGBaseSkill listSkill = (nint)ptr_AVGMonsterData.SKILLS;

                    var baseSkill = NewBaseSkill(addSkillId);
                    listSkill.ADD(baseSkill, ListGenericAVGBaseSkill!.METHOD_ADD);

                }

            }

            return new GameCharacterSkillDTO() { ObjectId = characterModifyDTO.CharacterId, SkillInfos = [.. EnumMonsterSkills(ptr_AVGMonsterData)] };
        }

        private static IEnumerable<GameSwitchDisplayDTO> EnumMonsterStatus(AVGMonsterData.Ptr_AVGMonsterData ptr_AVGMonsterData)
        {
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.LEVEL), DisplayName = "属性*等级", ContentValue = ptr_AVGMonsterData.LEVEL.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.HP), DisplayName = "属性*当前HP", ContentValue = ptr_AVGMonsterData.HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.MAXHP), DisplayName = "属性*最大HP", ContentValue = ptr_AVGMonsterData.MAXHP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.EXTRA_HP), DisplayName = "属性*附加HP", ContentValue = ptr_AVGMonsterData.EXTRA_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.MP), DisplayName = "属性*当前MP", ContentValue = ptr_AVGMonsterData.MP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.MAXMP), DisplayName = "属性*最大MP", ContentValue = ptr_AVGMonsterData.MAXMP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.EXP), DisplayName = "属性*经验", ContentValue = ptr_AVGMonsterData.EXP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.MAXEXP), DisplayName = "属性*累计经验", ContentValue = ptr_AVGMonsterData.MAXEXP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };


            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.PATK), DisplayName = "属性*物攻", ContentValue = ptr_AVGMonsterData.PATK.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.PDEF), DisplayName = "属性*物防", ContentValue = ptr_AVGMonsterData.PDEF.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.MATK), DisplayName = "属性*魔攻", ContentValue = ptr_AVGMonsterData.MATK.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.MDEF), DisplayName = "属性*魔防", ContentValue = ptr_AVGMonsterData.MDEF.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.SPEED), DisplayName = "属性*速度", ContentValue = ptr_AVGMonsterData.SPEED.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.CRITICAL_LEVEL), DisplayName = "?属性*暴击等级", ContentValue = ptr_AVGMonsterData.CRITICAL_LEVEL.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.CRITICAL), DisplayName = "属性*暴击", ContentValue = ptr_AVGMonsterData.CRITICAL.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.DODGE), DisplayName = "?属性*闪避", ContentValue = ptr_AVGMonsterData.DODGE.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(AVGMonsterData.Ptr_AVGMonsterData.HIT), DisplayName = "?属性*命中", ContentValue = ptr_AVGMonsterData.HIT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

        }
        public GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            if (characterObjectDTO.CharacterCategory != EnumSheetName.AVGMonsterConfig.ToString())
            {
                return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterObjectDTO.CharacterCategory}");
            }
            if (!TryGetMonster(this.Ptr_AVGUserData, characterObjectDTO.CharacterId, out var ptr_AVGMonsterData))
            {
                return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
            }
            return new GameCharacterStatusDTO() { ObjectId = characterObjectDTO.CharacterId, CharacterAttributes = [.. EnumMonsterStatus(ptr_AVGMonsterData)] };

        }
        public GameCharacterStatusDTO UpdateCharacterStatus(GameCharacterModifyDTO characterModifyDTO)
        {

            if (characterModifyDTO.CharacterCategory != EnumSheetName.AVGMonsterConfig.ToString())
            {
                return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterModifyDTO.CharacterCategory}");
            }
            if (!TryGetMonster(this.Ptr_AVGUserData, characterModifyDTO.CharacterId, out var ptr_AVGMonsterData))
            {
                return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterModifyDTO.CharacterId}");
            }

            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.LEVEL)) { ptr_AVGMonsterData.LEVEL = characterModifyDTO.IntValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.HP)) { ptr_AVGMonsterData.HP = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.MAXHP)) { ptr_AVGMonsterData.MAXHP = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.EXTRA_HP)) { ptr_AVGMonsterData.EXTRA_HP = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.MP)) { ptr_AVGMonsterData.MP = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.MAXMP)) { ptr_AVGMonsterData.MAXMP = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.EXP)) { ptr_AVGMonsterData.EXP = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.MAXEXP)) { ptr_AVGMonsterData.MAXEXP = characterModifyDTO.FloatValue; }

            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.PATK)) { ptr_AVGMonsterData.PATK = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.PDEF)) { ptr_AVGMonsterData.PDEF = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.MATK)) { ptr_AVGMonsterData.MATK = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.MDEF)) { ptr_AVGMonsterData.MDEF = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.SPEED)) { ptr_AVGMonsterData.SPEED = characterModifyDTO.FloatValue; }

            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.CRITICAL_LEVEL)) { ptr_AVGMonsterData.CRITICAL_LEVEL = characterModifyDTO.IntValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.CRITICAL)) { ptr_AVGMonsterData.CRITICAL = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.DODGE)) { ptr_AVGMonsterData.DODGE = characterModifyDTO.FloatValue; }
            if (characterModifyDTO.ModifyObject == nameof(AVGMonsterData.Ptr_AVGMonsterData.HIT)) { ptr_AVGMonsterData.HIT = characterModifyDTO.FloatValue; }



            return new GameCharacterStatusDTO() { ObjectId = characterModifyDTO.CharacterId, CharacterAttributes = [.. EnumMonsterStatus(ptr_AVGMonsterData)] };
        }

    }
}
