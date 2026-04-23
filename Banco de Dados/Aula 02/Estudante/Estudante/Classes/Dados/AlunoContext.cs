using Microsoft.EntityFrameworkCore;
using Estudante.Classes.Entidades; 

namespace Estudante.Classes.Dados
{
    internal class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        //O servidor está aqui, é aqui que você encontra o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=ECFP507D1319388\SQLEXPRESS
                ;Database=AlunoDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(a => a.id);
                entity.Property(a => a.RA);
                entity.Property(a => a.Nome).IsRequired().HasMaxLength(50);
                entity.Property(a => a.Curso).HasMaxLength(50);
            });
        }
    }
}
