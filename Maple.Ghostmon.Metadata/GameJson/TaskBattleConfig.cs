namespace Maple.Ghostmon.Metadata.GameJson
{
    // Token: 0x02000268 RID: 616
    public class TaskBattleConfig : BaseConfig
    {
        // Token: 0x06001542 RID: 5442 RVA: 0x00083AAC File Offset: 0x00081CAC
        //public TaskBattleConfig(string posIndex, string monsterGroup)
        //{
        //	if (!string.IsNullOrEmpty(posIndex))
        //	{
        //		this.posIndex = GameBasicUtil.StringToIntArray(posIndex, ',');
        //	}
        //	ulong[] monsterIDs = GameBasicUtil.StringToLongArray(monsterGroup, ',');
        //	this.monsters = new TaskMonsterConfig[monsterIDs.Length];
        //	for (int i = 0; i < monsterIDs.Length; i++)
        //	{
        //		this.monsters[i] = ConfigDataStore.GetDataJObject<TaskMonsterConfig>("TaskMonsterConfig", monsterIDs[i]);
        //	}
        //}

        // Token: 0x040019E9 RID: 6633
        //public TaskMonsterConfig[] monsters;

        //// Token: 0x040019EA RID: 6634
        //public int[] posIndex;

        // Token: 0x040019EB RID: 6635
        public string? rivalNPC;

        // Token: 0x040019EC RID: 6636
        public string? battleMap;

        // Token: 0x040019ED RID: 6637
        public string? battleEvent;

        // Token: 0x040019EE RID: 6638
        public ulong drop;
    }
}
