namespace HPIT.FL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("xinxi")]
    public partial class xinxi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public xinxi()
        {
            buy = new HashSet<buy>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string fname { get; set; }

        public int? moneys { get; set; }

        [StringLength(20)]
        public string indurtuds { get; set; }

        public int? fid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buy> buy { get; set; }

        public virtual fenlei fenlei { get; set; }

       

    }
}
