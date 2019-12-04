namespace domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.avis")]
    public partial class avis
    {
        public avis()
        {

        }
        public int id { get; set; }

        [StringLength(255)]
        public string contenu { get; set; }

        public int? employe_id { get; set; }

        public int? evaluation_id { get; set; }

        public virtual employe employe { get; set; }

        public virtual evaluation evaluation { get; set; }
    }
}
