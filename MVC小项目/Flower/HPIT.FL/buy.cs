namespace HPIT.FL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("buy")]
    public partial class buy
    {
        [Key]
        public int bid { get; set; }

        public int? shuliang { get; set; }

        [StringLength(20)]
        public string datedays { get; set; }

        public int? hid { get; set; }

        public virtual xinxi xinxi { get; set; }
    }
}
