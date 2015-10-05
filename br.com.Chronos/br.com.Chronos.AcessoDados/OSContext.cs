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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<DocumentosAnexos> DocumentosAnexosDaOS { get; set; }
        public DbSet<Escritorio> Escritorios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<FollowUpOSCliente> FollowUpOSClientes { get; set; }
        public DbSet<LancamentoEvento> LancamentoEventos { get; set; }
        public DbSet<MensagemDados> MensagensDados { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<MotivoOS> MotivosOS { get; set; }
        public DbSet<OrdemDeServico> OrdemDeServicos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes")
                .HasKey(x => x.Id)
                .HasMany(x => x.Contatos).WithRequired(x => x.Clientes);

            modelBuilder.Entity<Contato>().ToTable("Contatos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.Clientes);

            modelBuilder.Entity<DocumentosAnexos>().ToTable("DocumentosAnexosDaOS")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Escritorio>().ToTable("Escritorios")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Evento>().ToTable("Eventos")
                .HasKey(x => x.Id);

            modelBuilder.Entity<FollowUpOSCliente>().ToTable("FollowUpOSClientes")
                .HasKey(x => x.Id);
                
            modelBuilder.Entity<LancamentoEvento>().ToTable("LancamentoEventos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelEvento);

            modelBuilder.Entity<LancamentoEvento>().ToTable("LancamentoEventos")
                .HasRequired(x => x.EventoLancado);

            modelBuilder.Entity<MensagemDados>().ToTable("MensagensDados")
                .HasKey(x => x.Id)
                .HasRequired(x => x.OrdemServico);

            modelBuilder.Entity<MotivoOS>().ToTable("MotivosOS")
                .HasKey(x => x.Id)
                .HasRequired(x => x.OrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.clienteOS);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasMany(x => x.EventosDaOS).WithRequired(x => x.OrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasMany(x => x.ModalidadeDaOS).WithRequired(x => x.OrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasMany(x => x.DocumentosAnexosDaOS).WithRequired(x => x.OrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasMany(x => x.MotivoAberturaOS).WithRequired(x => x.OrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasMany(x => x.FollowCliente).WithRequired(x => x.OrdemServico);

            //modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
            //    .HasKey(x => x.Id)
            //    .HasMany(x => x.EmailsEnviadosOS).WithRequired(x => x.OrdemServico);

            modelBuilder.Entity<OrdemDeServico>().HasMany(x => x.EmailsRecebidosOS).WithRequired(x => x.OrdemServico);


            modelBuilder.Entity<Setor>().ToTable("Setores")
                .HasKey(x => x.Id);
                
            modelBuilder.Entity<Usuario>().ToTable("Usuarios")
                .HasKey(x => x.Id)
                .HasRequired(x => x.EscritorioUsuario);

            modelBuilder.Entity<Usuario>().ToTable("Usuarios")
                .HasKey(x => x.Id)
                .HasRequired(x => x.SetorUsuario);
        }
    }
}
