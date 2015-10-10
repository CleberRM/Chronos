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
        public DbSet<Email> Emails { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<MotivoOS> MotivosOS { get; set; }
        public DbSet<OrdemDeServico> OrdemDeServicos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCliente> ProdutosCliente { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>().ToTable("Clientes")
                .HasKey(x => x.Id)
                .HasMany(x => x.Contatos).WithRequired(x => x.Clientes);

            modelBuilder.Entity<Cliente>().ToTable("Clientes")
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Contato>().ToTable("Contatos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.Clientes)
                .WithMany()
                .HasForeignKey(x => x.IdCliente);

            modelBuilder.Entity<Contato>().ToTable("Contatos")
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<ProdutoCliente>().ToTable("ProdutosCliente")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<ProdutoCliente>().ToTable("ProdutosCliente")
                .HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.IdCliente);

            modelBuilder.Entity<ProdutoCliente>().ToTable("ProdutosCliente")
                .HasRequired(x => x.Descricao);
             
            modelBuilder.Entity<DocumentosAnexos>().ToTable("DocumentosAnexosDaOS")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Escritorio>().ToTable("Escritorios")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Evento>().ToTable("Eventos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<FollowUpOSCliente>().ToTable("FollowUpOSClientes")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<LancamentoEvento>().ToTable("LancamentoEventos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelEvento);

            modelBuilder.Entity<LancamentoEvento>().ToTable("LancamentoEventos")
                .HasRequired(x => x.EventoLancado);

            modelBuilder.Entity<LancamentoEvento>().ToTable("LancamentoEventos")
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Email>().ToTable("Emails")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Modalidade>().ToTable("ModalidadesDaOS")
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Produto>().ToTable("Produtos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Produto>().ToTable("Produtos")
                .HasRequired(x => x.Modalidade);

            modelBuilder.Entity<MotivoOS>().ToTable("MotivosDaOS")
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(X => X.IdResponsavelCriacao);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.Id)
                .HasRequired(x => x.clienteOS);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.EventosDaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.ModalidadeDaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.DocumentosAnexosDaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.MotivoAberturaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.FollowCliente)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.Emails)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico);
            
            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Setor>().ToTable("Setores")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);

            modelBuilder.Entity<Usuario>().ToTable("Usuarios")
                .HasKey(x => x.Id)
                .HasRequired(x => x.ResponsavelCriacao)
                .WithMany()
                .HasForeignKey(x => x.IdResponsavelCriacao);
        }
    }
}