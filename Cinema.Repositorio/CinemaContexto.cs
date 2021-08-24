using Cinema.Dominio;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cinema.Repositorio
{
    public partial class CinemaContexto : DbContext
    {
        public CinemaContexto()
            : base(@"data source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CINEMA")
        {
        }

        public virtual DbSet<ASSENTO> ASSENTO { get; set; }
        public virtual DbSet<ASSENTOSALA> ASSENTOSALA { get; set; }
        public virtual DbSet<CLASSIFICACAO> CLASSIFICACAO { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<FILME> FILME { get; set; }
        public virtual DbSet<GENERO> GENERO { get; set; }
        public virtual DbSet<GENERO_FILME> GENERO_FILME { get; set; }
        public virtual DbSet<INGRESSO> INGRESSO { get; set; }
        public virtual DbSet<SALA> SALA { get; set; }
        public virtual DbSet<SESSAO> SESSAO { get; set; }
        public virtual DbSet<TIPO_INGRESSO> TIPO_INGRESSO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ASSENTO>()
                .Property(e => e.Numero_Assento)
                .IsUnicode(false);

            modelBuilder.Entity<ASSENTO>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.ASSENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLASSIFICACAO>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CLASSIFICACAO>()
                .HasMany(e => e.FILME)
                .WithRequired(e => e.CLASSIFICACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.Nome_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FILME>()
                .Property(e => e.Nome_Filme)
                .IsUnicode(false);

            modelBuilder.Entity<FILME>()
                .Property(e => e.Sinopse)
                .IsUnicode(false);

            modelBuilder.Entity<FILME>()
                .Property(e => e.Imagem)
                .IsUnicode(false);

            modelBuilder.Entity<FILME>()
                .HasMany(e => e.GENERO_FILME)
                .WithRequired(e => e.FILME)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FILME>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.FILME)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GENERO>()
                .Property(e => e.Descricao_Genero)
                .IsUnicode(false);

            modelBuilder.Entity<GENERO>()
                .HasMany(e => e.GENERO_FILME)
                .WithRequired(e => e.GENERO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SALA>()
                .Property(e => e.Nome_Sala)
                .IsUnicode(false);

            modelBuilder.Entity<SALA>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.SALA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SALA>()
                .HasMany(e => e.SESSAO)
                .WithRequired(e => e.SALA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SESSAO>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.SESSAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_INGRESSO>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_INGRESSO>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.TIPO_INGRESSO)
                .WillCascadeOnDelete(false);
        }
    }
}
