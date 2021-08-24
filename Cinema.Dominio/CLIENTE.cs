namespace Cinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            INGRESSO = new HashSet<INGRESSO>();
        }

        [Key]
        public int Id_Cliente { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Cliente { get; set; }

        public long CPF { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data_Nasc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }
    }
}
