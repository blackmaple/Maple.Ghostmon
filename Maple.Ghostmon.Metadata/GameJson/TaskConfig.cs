namespace Maple.Ghostmon.Metadata.GameJson
{
    // Token: 0x0200026A RID: 618
    public class TaskConfig : BaseConfig
    {
        // Token: 0x06001544 RID: 5444 RVA: 0x00083B28 File Offset: 0x00081D28
        //public TaskConfig(string task_node_line, string next_story, string world_pos)
        //{
        //	this.task_node_line = GameBasicUtil.StringToLongArray(task_node_line, ',');
        //	this.next_story = GameBasicUtil.StringToLongArray(next_story, ',');
        //	if (!string.IsNullOrEmpty(world_pos))
        //	{
        //		this.world_pos = GameBasicUtil.StringToVector3(world_pos, ',');
        //		return;
        //	}
        //	this.world_pos = Vector3.zero;
        //}

        // Token: 0x040019F2 RID: 6642
        public bool accept_manual;

        // Token: 0x040019F3 RID: 6643
        public string? accept_condition;

        // Token: 0x040019F4 RID: 6644
        public string? accept_register;

        // Token: 0x040019F5 RID: 6645
        //public ulong[] task_node_line;

        // Token: 0x040019F6 RID: 6646
        public bool main_story;

        // Token: 0x040019F7 RID: 6647
        public string? icon_mainStory;

        // Token: 0x040019F8 RID: 6648
        public string? mapIcon;

        // Token: 0x040019F9 RID: 6649
        //public Vector3 world_pos;

        // Token: 0x040019FA RID: 6650
        //public ulong[] next_story;

        // Token: 0x040019FB RID: 6651
        public bool focus;

        // Token: 0x040019FC RID: 6652
        public bool hide;
    }
}
