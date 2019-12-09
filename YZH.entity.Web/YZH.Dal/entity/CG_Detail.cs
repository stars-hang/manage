namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Detail
    {
        [Key]
        public int DetailID { get; set; }

        public int? ShopID { get; set; }

        public int? MerID { get; set; }

        public int? BuyID { get; set; }
    }
}
