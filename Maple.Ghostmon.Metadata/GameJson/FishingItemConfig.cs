using System;

namespace Maple.Ghostmon.Metadata.GameJson
{
    // Token: 0x02000259 RID: 601
    public class FishingItemConfig : BaseConfig
    {
        // Token: 0x06001533 RID: 5427 RVA: 0x000839D5 File Offset: 0x00081BD5
        //public FishingItemConfig(string monsterTable)
        //{
        //	if (!string.IsNullOrEmpty(monsterTable))
        //	{
        //		this.monsterTable = monsterTable.Split(new char[] { ',' });
        //	}
        //}

        // Token: 0x040019AD RID: 6573
        public int runoffPoint;

        // Token: 0x040019AE RID: 6574
        public int risePoint;

        // Token: 0x040019AF RID: 6575
        public float fishingRange;

        // Token: 0x040019B0 RID: 6576
        public ulong curveConfig;

        // Token: 0x040019B1 RID: 6577
        public bool isMonster;

        // Token: 0x040019B2 RID: 6578
        //public string[] monsterTable;

        // Token: 0x040019B3 RID: 6579
        public ulong awardTable;
    }
}
