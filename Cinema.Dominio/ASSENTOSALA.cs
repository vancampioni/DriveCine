namespace Cinema.Dominio
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ASSENTOSALA")]
    public partial class ASSENTOSALA
    {
        [Key]
        public int Id_AssentoSala { get; set; }

        public int? Id_Sala { get; set; }

        public int? Id_Assento { get; set; }

        public virtual ASSENTO ASSENTO { get; set; }

        public virtual SALA SALA { get; set; }
    }
}
