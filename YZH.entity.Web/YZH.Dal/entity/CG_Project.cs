namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Project
    {
        [Key]
        public int ProID { get; set; }

        public int? Prostorey { get; set; }

        [StringLength(100)]
        public string ProBusiness { get; set; }

        [StringLength(30)]
        public string ManageID { get; set; }
    }
}
