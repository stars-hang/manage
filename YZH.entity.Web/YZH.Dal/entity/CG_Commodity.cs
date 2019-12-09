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
        [DisplayName("��Ʒ��")]
        public string ComName { get; set; }
        [DisplayName("��Ǯ")]
        public double? ComDiscount { get; set; }
        [DisplayName("��Ʒ����")]
        public string CommDemo { get; set; }
        [DisplayName("��ƷID")]
        public int? ShopID { get; set; }

        public int? Show { get; set; }
    }
}
