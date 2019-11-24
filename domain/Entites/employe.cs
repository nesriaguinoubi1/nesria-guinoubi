namespace domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.employe")]
    public partial class employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employe()
        {
            avis = new HashSet<avis>();
            commentaire = new HashSet<commentaire>();
            evaluation = new HashSet<evaluation>();
            evaluation360 = new HashSet<evaluation360>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string isActif { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        public int rating { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        public int EM_Id { get; set; }

        [StringLength(255)]
        public string EM_Password { get; set; }

        [StringLength(255)]
        public string codeqr { get; set; }

        public DateTime? datedn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<avis> avis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire> commentaire { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation> evaluation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation360> evaluation360 { get; set; }
    }
}
