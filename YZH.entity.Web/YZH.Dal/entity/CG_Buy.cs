namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Buy
    {
        [Key]
        public int BuyID { get; set; }

        public DateTime? BuyTime { get; set; }

        public double? BuyMoney { get; set; }
    }
}
