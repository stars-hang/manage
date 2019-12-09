namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Staff
    {
        [Key]
        public int StaffID { get; set; }

        [StringLength(100)]
        public string StaffName { get; set; }

        public DateTime? StaffTime { get; set; }

        [StringLength(100)]
        public string StaffPhone { get; set; }

        public string StaffHome { get; set; }

        public string StaffCardID { get; set; }

        public long? StaffMoney { get; set; }

        public bool? Stafftype { get; set; }
    }
}
