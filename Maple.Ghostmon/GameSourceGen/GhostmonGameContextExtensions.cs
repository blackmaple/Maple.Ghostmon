using Maple.MonoGameAssistant.Common;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using GameConfigJson = System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>;
namespace Maple.Ghostmon
{
    internal static class GhostmonGameContextExtensions
    {
        public static void DebugInfo(this GhostmonGameContext @this)
        {
            Dictionary<string, Dictionary<ulong, GameConfigJson>> config = [];
            using (@this.Logger.Running())
            {

                using (@this.Logger.Running("CONFIG_STORE"))
                {
                    var dicConfig = @this.ConfigDataStore.CONFIG_STORE;
                    if (dicConfig.Valid())
                    {
                        foreach (var dic in dicConfig.AsRefArray())
                        {
                            ref readonly var val = ref dic.Value;
                            if (false == val.Valid())
                            {
                                continue;
                            }
                            Dictionary<ulong, GameConfigJson> kConfig = [];
                            config.TryAdd(dic.Key.ToString()!, kConfig);
                            foreach (var kvp in val.AsRefArray())
                            {
                                ref readonly var kVal = ref kvp.Value;
                                if (false == kVal.Valid())
                                {
                                    continue;
                                }
                                var json = kvp.Value.TO_STRING_00().ToString();
                                if (string.IsNullOrEmpty(json) == false)
                                {
                                    var cfg = System.Text.Json.JsonSerializer.Deserialize(json, ConfigJsonSerializerContext.Default.DictionaryStringJsonElement);
                                    if (cfg is not null)
                                    {
                                        kConfig.Add(kvp.Key, cfg);
                                    }
                                }
                            }
                        }
                    }
                }

                using (@this.Logger.Running("MONSTER_CFG_STORE"))
                {
                    var dicMonster = @this.ConfigDataStore.MONSTER_CFG_STORE;
                    if (dicMonster.Valid())
                    {
                        foreach (var dic in dicMonster.AsRefArray())
                        {
                            var val = dic.Value;
                            @this.Logger.LogInformation("MONSTER:{v1} ", val.M_TITLE.ToString());
                        }
                    }

                }

                using (@this.Logger.Running("SKILL_CFG_STORE"))
                {
                    var dicSkill = @this.ConfigDataStore.SKILL_CFG_STORE;
                    if (dicSkill.Valid())
                    {
                        foreach (var dic in dicSkill.AsRefArray())
                        {
                            var val = dic.Value;
                            @this.Logger.LogInformation("skill:{v1} ", val.SCRIPT_NAME.ToString());
                        }
                    }

                }

                using (@this.Logger.Running("SPRITE_CFG_STORE"))
                {
                    var dicSprite = @this.ConfigDataStore.SPRITE_CFG_STORE;
                    if (dicSprite.Valid())
                    {
                        foreach (var dic in dicSprite.AsRefArray())
                        {
                            var val = dic.Value;
                            @this.Logger.LogInformation("Sprite:{v1} ", val.DROP_ID.ToString());
                        }
                    }

                }

            }

        }
    }
}
