namespace Cinema.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GENERO")]
    public partial class GENERO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GENERO()
        {
            GENERO_FILME = new HashSet<GENERO_FILME>();
        }

        [Key]
        public int Id_Genero { get; set; }

        [StringLength(10)]
        public string Descricao_Genero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENERO_FILME> GENERO_FILME { get; set; }
    }
}
