namespace Cinema.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SALA")]
    public partial class SALA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALA()
        {
            ASSENTO = new HashSet<ASSENTO>();
            ASSENTOSALA = new HashSet<ASSENTOSALA>();
            INGRESSO = new HashSet<INGRESSO>();
            SESSAO = new HashSet<SESSAO>();
        }

        [Key]
        public int Id_Sala { get; set; }

        public int? Qtd_Assento { get; set; }

        [StringLength(5)]
        [DisplayName("Sala")]
        public string Nome_Sala { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSENTO> ASSENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSENTOSALA> ASSENTOSALA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSAO> SESSAO { get; set; }
    }
}
