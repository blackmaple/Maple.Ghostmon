namespace Maple.Ghostmon.Metadata.GameJson
{
    // Token: 0x0200026B RID: 619
    public class TaskNodeConfig : BaseConfig
    {
        // Token: 0x06001545 RID: 5445 RVA: 0x00083B7C File Offset: 0x00081D7C
        //public TaskNodeConfig(string task_targets)
        //{
        //	ulong[] targetIDs = GameBasicUtil.StringToLongArray(task_targets, ',');
        //	this.task_targets = new TaskTargetConfig[targetIDs.Length];
        //	for (int i = 0; i < targetIDs.Length; i++)
        //	{
        //		this.task_targets[i] = ConfigDataStore.GetDataJObject<TaskTargetConfig>("TaskTargetConfig", targetIDs[i]);
        //	}
        //}

        // Token: 0x040019FD RID: 6653
        //public TaskTargetConfig[] task_targets;

        // Token: 0x040019FE RID: 6654
        public bool logic_or;

        // Token: 0x040019FF RID: 6655
        public string? task_dialog_register;

        // Token: 0x04001A00 RID: 6656
        public string? task_areaLimit_register;

        // Token: 0x04001A01 RID: 6657
        public ulong dropID;

        // Token: 0x04001A02 RID: 6658
        public int exp_award;

        // Token: 0x04001A03 RID: 6659
        public ulong nextMission;

        // Token: 0x04001A04 RID: 6660
        public string? manual_script;

        // Token: 0x04001A05 RID: 6661
        public int unlockFunc;
    }
}
