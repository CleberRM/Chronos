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
                .HasKey(x => x.IdCliente)
                .HasMany(x => x.Contatos)
                .WithRequired(x => x.Cliente)
                .HasForeignKey( x=> x.IdContato)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Cliente>().ToTable("Clientes")
                .HasMany(x => x.ProdutosAdquiridos)
                .WithRequired(x => x.Cliente);                       
            
            modelBuilder.Entity<Contato>().ToTable("Contatos")
                .HasKey(x => x.IdContato)
                .HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdutoCliente>().ToTable("ProdutosCliente")
                .HasKey(x => x.IdProdutoCliente);
                

            modelBuilder.Entity<ProdutoCliente>().ToTable("ProdutosCliente")
                .HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdutoCliente>().ToTable("ProdutosCliente")
                .HasRequired(x => x.DescricaoProduto)
                .WithMany()
                .HasForeignKey(x => x.IdProduto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentosAnexos>().ToTable("DocumentosAnexosDaOS")
                .HasKey(x => x.IdDocAnexos);

            modelBuilder.Entity<Escritorio>().ToTable("Escritorios")
                .HasKey(x => x.IdEscritorio);

            modelBuilder.Entity<Evento>().ToTable("Eventos")
                .HasKey(x => x.IdEvento);

            modelBuilder.Entity<FollowUpOSCliente>().ToTable("FollowUpOSClientes")
                .HasKey(x => x.IdFollow);

            modelBuilder.Entity<LancamentoEvento>().ToTable("LancamentoEventos")
                .HasKey(x => x.IdLancamento)
                .HasRequired(x => x.ResponsavelEvento)
                .WithMany()
                .HasForeignKey(x => x.IdEventoLancado);

            modelBuilder.Entity<Email>().ToTable("Emails")
                .HasKey(x => x.IdEmail);
                
            modelBuilder.Entity<Modalidade>().ToTable("ModalidadesDaOS")
                .HasKey( x => x.IdModalidade)
                .HasRequired(x => x.DescricaoProduto)
                .WithMany()
                .HasForeignKey(x => x.IdProduto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>().ToTable("Produtos")
                .HasKey(x => x.IdProduto);

            modelBuilder.Entity<MotivoOS>().ToTable("MotivosDaOS")
                .HasKey(x => x.IdMotivo);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasKey(x => x.IdOrdemServico)
                .HasRequired(x => x.clienteOS)
                .WithMany()
                .HasForeignKey(x => x.clienteOS);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.EventosDaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.ModalidadeDaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.DocumentosAnexosDaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.MotivoAberturaOS)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.FollowCliente)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdemDeServico>().ToTable("OrdemDeServicos")
                .HasMany(x => x.Emails)
                .WithRequired(x => x.OrdemServico)
                .HasForeignKey(x => x.IdOrdemServico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Setor>().ToTable("Setores")
                .HasKey(x => x.IdSetor);

            modelBuilder.Entity<Usuario>().ToTable("Usuarios")
                .HasKey(x => x.IdUsuario);
                
            
        }
    }
}