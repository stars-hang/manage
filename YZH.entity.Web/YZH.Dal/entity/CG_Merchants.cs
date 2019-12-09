namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Merchants
    {
        [Key]
        public int MerID { get; set; }

        [StringLength(50)]
        public string MerName { get; set; }

        [StringLength(100)]
        public string ShopName { get; set; }

        [StringLength(50)]
        public string MerPhone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string MerHome { get; set; }

        public string MerCardID { get; set; }

        [StringLength(200)]
        public string MerBrand { get; set; }

        public int? ShopID { get; set; }

        [StringLength(100)]
        public string MerType { get; set; }

        public int? MerDel { get; set; }
    }
}
