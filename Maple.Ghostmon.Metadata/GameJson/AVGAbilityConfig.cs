namespace Maple.Ghostmon.Metadata.GameJson
{
    public class AVGAbilityConfig : BaseConfig
    {
        //// Token: 0x06000129 RID: 297 RVA: 0x00007B80 File Offset: 0x00005D80
        //public AVGAbilityConfig(int attributeType, string buffId, string buffChance, string buffTarget, string eff, string effTarget)
        //{
        //    this.attributeType = (AVGAttributeType)attributeType;
        //    this.buffChance = buffChance;
        //    this.buffConfigs = new List<AVGBuffConfig>();
        //    this.buffChanceList = new List<float>();
        //    this.buffTarget = new List<int>();
        //    this.effNames = new List<string>();
        //    this.effTarget = new List<int>();
        //    this.buffId = buffId;
        //    if (!string.IsNullOrEmpty(buffId))
        //    {
        //        if (!string.IsNullOrEmpty(buffId))
        //        {
        //            string[] strings = buffId.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        //            for (int i = 0; i < strings.Length; i++)
        //            {
        //                this.buffConfigs.Add(ConfigDataStore.GetDataJObject<AVGBuffConfig>("AVGBuffConfig", ulong.Parse(strings[i])));
        //            }
        //        }
        //        if (!string.IsNullOrEmpty(buffChance))
        //        {
        //            string[] chances = buffChance.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        //            for (int j = 0; j < chances.Length; j++)
        //            {
        //                this.buffChanceList.Add((float)int.Parse(chances[j]) * 1f / 100f);
        //            }
        //        }
        //        if (!string.IsNullOrEmpty(buffTarget))
        //        {
        //            string[] targets = buffTarget.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        //            for (int k = 0; k < targets.Length; k++)
        //            {
        //                this.buffTarget.Add(int.Parse(targets[k]));
        //            }
        //        }
        //    }
        //    if (!string.IsNullOrEmpty(eff))
        //    {
        //        string[] effs = eff.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        //        string[] effTargets = effTarget.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        //        for (int l = 0; l < effs.Length; l++)
        //        {
        //            this.effNames.Add(effs[l]);
        //            this.effTarget.Add(int.Parse(effTargets[l]));
        //        }
        //    }
        //}

        //// Token: 0x040000F2 RID: 242
        //public int power;

        //// Token: 0x040000F3 RID: 243
        //public int hitRate;

        //// Token: 0x040000F4 RID: 244
        //public bool definitelyHit;

        //// Token: 0x040000F5 RID: 245
        //public int attackType;

        //// Token: 0x040000F6 RID: 246
        //public int mpCost;

        //// Token: 0x040000F7 RID: 247
        //public int skillType;

        //// Token: 0x040000F8 RID: 248
        //public string CSScript;

        //// Token: 0x040000F9 RID: 249
        //public string parameter;

        //// Token: 0x040000FA RID: 250
        //public AVGAttributeType attributeType;

        //// Token: 0x040000FB RID: 251
        //public int studyLevel;

        //// Token: 0x040000FC RID: 252
        //public string buffId;

        //// Token: 0x040000FD RID: 253
        //public List<AVGBuffConfig> buffConfigs;

        //// Token: 0x040000FE RID: 254
        //public List<float> buffChanceList;

        //// Token: 0x040000FF RID: 255
        //public List<int> buffTarget;

        //// Token: 0x04000100 RID: 256
        //public string buffChance;

        //// Token: 0x04000101 RID: 257
        //public int crit;

        //// Token: 0x04000102 RID: 258
        //public int tag;

        //// Token: 0x04000103 RID: 259
        //public List<string> effNames;

        //// Token: 0x04000104 RID: 260
        //public List<int> effTarget;

        //// Token: 0x04000105 RID: 261
        //public int continusCount;
    }
}
