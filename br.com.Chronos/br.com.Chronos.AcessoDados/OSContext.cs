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
        public DbSet<LancamentoEvento> LancamentoEventos { get; set; }       
        public DbSet<MensagemDados> MensagensDados { get; set; }
        public DbSet<OrdemDeServico> OrdemDeServicos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

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

            modelBuilder.Entity<LancamentoEvento>().ToTable("LancamentoEventos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelEvento);

            modelBuilder.Entity<MensagemDados>().ToTable("MensagensDados")
                .HasKey(x => x.Id);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.clienteOS);

            modelBuilder.Entity<Cliente>().ToTable("Clientes")
                .HasKey(x => x.Id);
                



        }

    }
}
