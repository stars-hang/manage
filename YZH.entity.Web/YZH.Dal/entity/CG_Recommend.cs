namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Recommend
    {
        [Key]
        public int RecomID { get; set; }

        public string RecomName { get; set; }

        public int? RecomImg { get; set; }

        public double? RecomDiscount { get; set; }

        public string RecomDemo { get; set; }

        public int? ShopsID { get; set; }

        public double? RecomRebate { get; set; }

        public double? RecomPrice { get; set; }
    }
}
