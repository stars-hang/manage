namespace YZH.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CG_Imgs
    {
        [Key]
        public int ImgID { get; set; }

        public int? ImgType { get; set; }

        public string ImgUrl { get; set; }

        public string ImgTableName { get; set; }

        public string ImgTableID { get; set; }
    }
}
