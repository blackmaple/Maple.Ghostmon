using System;

namespace Maple.Ghostmon.Metadata.GameJson
{
    // Token: 0x02000261 RID: 609
    public class ProjectileConfig : BaseConfig
    {
        // Token: 0x040019CC RID: 6604
        public float speed;

        // Token: 0x040019CD RID: 6605
        public float g;

        // Token: 0x040019CE RID: 6606
        public float radius;

        // Token: 0x040019CF RID: 6607
        public float lifeTime;

        // Token: 0x040019D0 RID: 6608
        public string? hit_effect;

        // Token: 0x040019D1 RID: 6609
        public string? hit_sound;

        // Token: 0x040019D2 RID: 6610
        public float knock;

        // Token: 0x040019D3 RID: 6611
        public int type;

        // Token: 0x040019D4 RID: 6612
        public string? type_params;

        // Token: 0x020005FC RID: 1532
        public enum ProjectileType
        {
            // Token: 0x04002BEC RID: 11244
            Collision,
            // Token: 0x04002BED RID: 11245
            Explode,
            // Token: 0x04002BEE RID: 11246
            Penetrate,
            // Token: 0x04002BEF RID: 11247
            Sustained
        }
    }
}
