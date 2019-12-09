namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Rent
    {
        [Key]
        public int RentID { get; set; }

        [StringLength(100)]
        public string RentName { get; set; }

        public DateTime? RentBegin { get; set; }

        public int? RentLength { get; set; }

        [StringLength(100)]
        public string RentEnd { get; set; }

        [StringLength(200)]
        public string RentAndInclude { get; set; }

        public string RentAccIncome { get; set; }

        [StringLength(200)]
        public string RentDiversity { get; set; }

        [StringLength(100)]
        public string Demo { get; set; }

        [StringLength(100)]
        public string RentType { get; set; }
    }
}
