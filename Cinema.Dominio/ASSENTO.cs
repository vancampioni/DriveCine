namespace Cinema.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ASSENTO")]
    public partial class ASSENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ASSENTO()
        {
            ASSENTOSALA = new HashSet<ASSENTOSALA>();
            INGRESSO = new HashSet<INGRESSO>();
        }

        [Key]
        public int Id_Assento { get; set; }

        public int? Id_Sala { get; set; }

        [Required]
        [StringLength(5)]
        public string Numero_Assento { get; set; }

        public virtual SALA SALA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSENTOSALA> ASSENTOSALA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }
    }
}
