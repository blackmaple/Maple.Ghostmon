namespace Maple.Ghostmon.Metadata.GameJson
{
    public class AVGBuffConfig : BaseConfig
    {
        public int buffType;
    }

    public enum AVGPrimaryBuffType
    {
        // Token: 0x04000181 RID: 385
        None,
        // Token: 0x04000182 RID: 386
        Buff,
        // Token: 0x04000183 RID: 387
        Debuff,
        // Token: 0x04000184 RID: 388
        Abnormal,
        // Token: 0x04000185 RID: 389
        Recovery
    }
}
