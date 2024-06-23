namespace Maple.Ghostmon
{
    // Token: 0x02000260 RID: 608
    public class NpcConfig : BaseConfig
	{
		// Token: 0x0600153A RID: 5434 RVA: 0x00083A50 File Offset: 0x00081C50
		//public NpcConfig(string taskGroup, string dialogGroup)
		//{
		//	this.taskGroup = GameBasicUtil.StringToLongArray(taskGroup, ',');
		//	this.dialogGroup = GameBasicUtil.StringToLongArray(dialogGroup, ',');
		//}

		// Token: 0x040019C3 RID: 6595
		//public ulong[] taskGroup;

		//// Token: 0x040019C4 RID: 6596
		//public ulong[] dialogGroup;

		// Token: 0x040019C5 RID: 6597
		public ulong battleID;

		// Token: 0x040019C6 RID: 6598
		public ulong battleDialogBegin;

		// Token: 0x040019C7 RID: 6599
		public ulong battleDefeatDialog;

		// Token: 0x040019C8 RID: 6600
		public ulong battleVictoryDialog;

		// Token: 0x040019C9 RID: 6601
		public ulong shopID;

		// Token: 0x040019CA RID: 6602
		public bool isWander;

		// Token: 0x040019CB RID: 6603
		public float wanderRange;
	}
}
