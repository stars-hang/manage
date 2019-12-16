namespace HPIT.FL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yonghu")]
    public partial class yonghu
    {
        [Key]
        public int yid { get; set; }

        [StringLength(20)]
        public string yong { get; set; }

        public int? passwords { get; set; }
    }
}
