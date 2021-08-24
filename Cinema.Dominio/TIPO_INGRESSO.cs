namespace Cinema.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TIPO_INGRESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_INGRESSO()
        {
            INGRESSO = new HashSet<INGRESSO>();
        }

        [Key]
        public int Id_TipoIngresso { get; set; }

        public int? Tipo { get; set; }

        [StringLength(6)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }
    }
}
