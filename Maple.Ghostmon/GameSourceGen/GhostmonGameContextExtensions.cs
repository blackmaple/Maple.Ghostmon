using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.Logging;
using GameConfigJsonElement = System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>;
using GameConfigJsonElementUnmanaged = Maple.MonoGameAssistant.Core.PMonoString;

namespace Maple.Ghostmon
{

    using GameConfigStore = System.Collections.Generic.Dictionary<string, Dictionary<ulong, GameConfigJsonElementUnmanaged>>;

    internal static class GhostmonGameContextExtensions
    {

        public static GameConfigStore GetGameConfigDictionary(this GhostmonGameContext @this)
        {
            GameConfigStore gameConfigStore = [];
            if (@this.ConfigDataStore.CFG_LOADED)
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
                        Dictionary<ulong, GameConfigJsonElementUnmanaged> configData = [];
                        gameConfigStore.TryAdd(dic.Key.ToString()!, configData);
                        foreach (var kvp in val.AsRefArray())
                        {
                            ref readonly var kVal = ref kvp.Value;
                            if (false == kVal.Valid())
                            {
                                continue;
                            }
                            var json = kvp.Value.TO_STRING_00();
                            if (json.Valid())
                            {
                                configData.Add(kvp.Key, json);
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
            return gameConfigStore;
            //@this.Logger.Info(System.Text.Json.JsonSerializer.Serialize(config, ConfigJsonSerializerContext.Default.DictionaryStringDictionaryUInt64DictionaryStringJsonElement));
        }
    }
}
