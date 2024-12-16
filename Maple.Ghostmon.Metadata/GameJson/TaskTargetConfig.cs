namespace Maple.Ghostmon.Metadata.GameJson
{
    // Token: 0x0200026C RID: 620
    public class TaskTargetConfig : BaseConfig
    {
        // Token: 0x06001546 RID: 5446 RVA: 0x00083BC9 File Offset: 0x00081DC9
        //public TaskTargetConfig(string worldPos)
        //{
        //	if (!string.IsNullOrEmpty(worldPos))
        //	{
        //		this.worldPos = GameBasicUtil.StringToVector3(worldPos, ',');
        //		return;
        //	}
        //	this.worldPos = Vector3.zero;
        //}

        // Token: 0x04001A06 RID: 6662
        public int task_type;

        // Token: 0x04001A07 RID: 6663
        public string? task_params;

        // Token: 0x04001A08 RID: 6664
        public string? task_register;

        // Token: 0x04001A09 RID: 6665
        public string? task_events;

        // Token: 0x04001A0A RID: 6666
        public bool display;

        // Token: 0x04001A0B RID: 6667
        public bool schedule;

        // Token: 0x04001A0C RID: 6668
        public ulong dropID;

        //// Token: 0x04001A0D RID: 6669
        //public Vector3 worldPos;

        // Token: 0x04001A0E RID: 6670
        public string? mapIcon;
    }
}
