namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Shops
    {
        [Key]
        public int ShopID { get; set; }

        [StringLength(64)]
        public string ShopName { get; set; }

        [Required]
        [StringLength(100)]
        public string ShopSeat { get; set; }

        public int? ShopRange { get; set; }

        public int ShopMoney { get; set; }

        public DateTime? ShopDate { get; set; }

        public int? MarketID { get; set; }

        public int? IsShow { get; set; }
    }
}
