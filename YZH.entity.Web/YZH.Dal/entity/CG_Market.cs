namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Market
    {
        [Key]
        public int MarketID { get; set; }

        public int? MarketSize { get; set; }

        [StringLength(100)]
        public string MarketSeat { get; set; }

        public int? ProID { get; set; }

        public DateTime? MarketDate { get; set; }

        public long? ActivateMoney { get; set; }
    }
}
