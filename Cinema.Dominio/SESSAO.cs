namespace Cinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SESSAO")]
    public partial class SESSAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SESSAO()
        {
            INGRESSO = new HashSet<INGRESSO>();
        }

        [Key]
        public int Id_Sessao { get; set; }

        public int? Id_Filme { get; set; }

        public int Id_Sala { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Sessão")]
        public DateTime? Data_Sessao { get; set; }
        [DisplayName("Horário")]
        public TimeSpan? Horario_Sessao { get; set; }

        public virtual FILME FILME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }

        public virtual SALA SALA { get; set; }
    }
}
