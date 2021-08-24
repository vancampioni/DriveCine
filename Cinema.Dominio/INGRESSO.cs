namespace Cinema.Dominio
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("INGRESSO")]
    public partial class INGRESSO
    {
        [Key]
        public int Id_Ingresso { get; set; }

        public int Id_Cliente { get; set; }

        public int Id_TipoIngresso { get; set; }

        public int Id_Filme { get; set; }

        public int Id_Sessao { get; set; }

        public int Id_Sala { get; set; }

        public int Id_Assento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data_Venda { get; set; }

        public virtual ASSENTO ASSENTO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual FILME FILME { get; set; }

        public virtual SALA SALA { get; set; }

        public virtual SESSAO SESSAO { get; set; }

        public virtual TIPO_INGRESSO TIPO_INGRESSO { get; set; }
    }
}
