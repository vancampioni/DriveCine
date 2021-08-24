namespace Cinema.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CLASSIFICACAO")]
    public partial class CLASSIFICACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASSIFICACAO()
        {
            FILME = new HashSet<FILME>();
        }

        [Key]
        public int Id_Class { get; set; }

        [StringLength(2)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILME> FILME { get; set; }
    }
}
