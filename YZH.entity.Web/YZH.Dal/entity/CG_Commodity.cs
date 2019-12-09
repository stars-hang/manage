namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Commodity
    {
        [Key]
        [DisplayName("ID")]
        public int ComID { get; set; }
        [DisplayName("商品名")]
        public string ComName { get; set; }
        [DisplayName("价钱")]
        public double? ComDiscount { get; set; }
        [DisplayName("商品介绍")]
        public string CommDemo { get; set; }
        [DisplayName("商品ID")]
        public int? ShopID { get; set; }

        public int? Show { get; set; }
    }
}
