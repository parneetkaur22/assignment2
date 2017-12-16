namespace parneetkaur.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dovestylingproduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Gidtcardno_ { get; set; }

        [Key]
        [StringLength(50)]
        public string Dovehairspray { get; set; }

        [Required]
        [StringLength(50)]
        public string Dovehairgel { get; set; }

        [Required]
        [StringLength(50)]
        public string Doveheatprotector { get; set; }
    }
}
