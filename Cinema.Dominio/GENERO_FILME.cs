namespace Cinema.Dominio
{
    using System.ComponentModel.DataAnnotations;

    public partial class GENERO_FILME
    {
        [Key]
        public int Id_GeneroFilme { get; set; }

        public int Id_Genero { get; set; }

        public int Id_Filme { get; set; }

        public virtual FILME FILME { get; set; }

        public virtual GENERO GENERO { get; set; }
    }
}
