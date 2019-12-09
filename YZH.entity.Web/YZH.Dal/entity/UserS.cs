namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserS
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]

        public string UserName { get; set; }

        [Required]
        [StringLength(100)]

        public string UserPwd { get; set; }

        public int UserState { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string UserMiMa { get; set; }

        [Required]
        [StringLength(100)]
        public string phone { get; set; }

        public int? UserImg { get; set; }

        public int? MbwtID { get; set; }
    }
}
