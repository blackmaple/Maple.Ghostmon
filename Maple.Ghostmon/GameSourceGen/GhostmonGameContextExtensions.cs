using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.Ghostmon
{


    internal static class GhostmonGameContextExtensions
    {
        //private static string[] SheetNames { get; } = 
        //    [
        //        "AbilityBookConfig","AbilityConfig","CharmConfig","EggConfig","GoodsConfig","IllustrationConfig"
        //    ];

        public static IEnumerable<GameConfigStoreDTO> GetGameConfigDictionary(this GhostmonGameContext @this)
        {

            if (@this.ConfigDataStore.CFG_LOADED)
            {
                var dicConfig = @this.ConfigDataStore.CONFIG_STORE;
                if (dicConfig.Valid())
                {
                    foreach (var dic in dicConfig.AsRefArray())
                    {
                        var val = dic.Value;
                        if (false == val.Valid())
                        {
                            continue;
                        }

                        foreach (var kvp in val.AsRefArray())
                        {
                            var kVal = kvp.Value;
                            if (false == kVal.Valid())
                            {
                                continue;
                            }
                            var json = kvp.Value.TO_STRING_00().ToString();
                            if (!string.IsNullOrEmpty(json))
                            {
                                yield return new GameConfigStoreDTO()
                                {
                                    SheetName = dic.Key.ToString(),
                                    ConfigId = kvp.Key,
                                    Json = json
                                };
                            }
                        }
                    }
                }

            }

            //using (@this.Logger.Running())
            //{

            //    using (@this.Logger.Running("CONFIG_STORE"))
            //    {
            //    }

            //    //using (@this.Logger.Running("MONSTER_CFG_STORE"))
            //    //{
            //    //    var dicMonster = @this.ConfigDataStore.MONSTER_CFG_STORE;
            //    //    if (dicMonster.Valid())
            //    //    {
            //    //        foreach (var dic in dicMonster.AsRefArray())
            //    //        {
            //    //            var val = dic.Value;
            //    //            @this.Logger.LogInformation("MONSTER:{v1} ", val.M_TITLE.ToString());
            //    //        }
            //    //    }

            //    //}

            //    //using (@this.Logger.Running("SKILL_CFG_STORE"))
            //    //{
            //    //    var dicSkill = @this.ConfigDataStore.SKILL_CFG_STORE;
            //    //    if (dicSkill.Valid())
            //    //    {
            //    //        foreach (var dic in dicSkill.AsRefArray())
            //    //        {
            //    //            var val = dic.Value;
            //    //            @this.Logger.LogInformation("skill:{v1} ", val.SCRIPT_NAME.ToString());
            //    //        }
            //    //    }

            //    //}

            //    //using (@this.Logger.Running("SPRITE_CFG_STORE"))
            //    //{
            //    //    var dicSprite = @this.ConfigDataStore.SPRITE_CFG_STORE;
            //    //    if (dicSprite.Valid())
            //    //    {
            //    //        foreach (var dic in dicSprite.AsRefArray())
            //    //        {
            //    //            var val = dic.Value;
            //    //            @this.Logger.LogInformation("Sprite:{v1} ", val.DROP_ID.ToString());
            //    //        }
            //    //    }

            //    //}

            //}

            //@this.Logger.Info(System.Text.Json.JsonSerializer.Serialize(config, ConfigJsonSerializerContext.Default.DictionaryStringDictionaryUInt64DictionaryStringJsonElement));
        }
    }



    public class GameConfigStoreDTO
    {
        [NotNull]
        public string? SheetName { set; get; }
        public ulong ConfigId { set; get; }
        [NotNull]
        public string? Json { set; get; }
    }
}
