namespace domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.formation")]
    public partial class formation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public formation()
        {
            invetation = new HashSet<invetation>();
            participation = new HashSet<participation>();
            test = new HashSet<test>();
            skills = new HashSet<skills>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_debut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_fin { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string img { get; set; }

        [StringLength(255)]
        public string titre { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        public int? formateur_id { get; set; }

        public int? test_id { get; set; }

        public virtual formateur formateur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invetation> invetation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participation> participation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<test> test { get; set; }

        public virtual test test1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skills> skills { get; set; }
    }
}
