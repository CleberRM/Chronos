using br.com.Chronos.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class OSContext : DbContext
    {
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Escritorio> Escritorios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setor>().ToTable("Setores")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao);

            modelBuilder.Entity<Usuario>().ToTable("Usuarios")
                .HasKey(x => x.Id)
                .HasRequired(x => x.EscritorioUsusario);

            modelBuilder.Entity<Escritorio>().ToTable("Escritorios")
                .HasKey(x => x.Id);
        }

    }
}
