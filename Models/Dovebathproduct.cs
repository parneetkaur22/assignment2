namespace parneetkaur.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dovebathproduct
    {
        [Key]
        [Column("[Giftcardno_")]
        public int C_Giftcardno_ { get; set; }

        [Required]
        [StringLength(50)]
        public string DoveSoap { get; set; }

        [Required]
        [StringLength(50)]
        public string DoveShampoo { get; set; }

        [Required]
        [StringLength(50)]
        public string DoveConditioner { get; set; }
    }
}
