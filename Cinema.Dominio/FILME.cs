namespace Cinema.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FILME")]
    public partial class FILME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FILME()
        {
            GENERO_FILME = new HashSet<GENERO_FILME>();
            INGRESSO = new HashSet<INGRESSO>();
            SESSAO = new HashSet<SESSAO>();
        }

        [Key]
        public int Id_Filme { get; set; }

        public int Id_Class { get; set; }

        [StringLength(50)]
        [DisplayName("Filme")]
        public string Nome_Filme { get; set; }

        [StringLength(500)]
        public string Sinopse { get; set; }

        public int? Duracao { get; set; }

        [StringLength(300)]
        public string Imagem { get; set; }

        public virtual CLASSIFICACAO CLASSIFICACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENERO_FILME> GENERO_FILME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSAO> SESSAO { get; set; }
    }
}
