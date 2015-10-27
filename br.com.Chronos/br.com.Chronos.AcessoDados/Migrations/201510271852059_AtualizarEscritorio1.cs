namespace br.com.Chronos.AcessoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizarEscritorio1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "DataCriacao");
            DropColumn("dbo.Contatos", "DataCriacao");
            DropColumn("dbo.Usuarios", "DataCriacao");
            DropColumn("dbo.Escritorios", "DataCriacao");
            DropColumn("dbo.Setores", "DataCriacao");
            DropColumn("dbo.ProdutosCliente", "DataCriacao");
            DropColumn("dbo.Produtos", "DataCriacao");
            DropColumn("dbo.DocumentosAnexosDaOS", "DataCriacao");
            DropColumn("dbo.OrdemDeServicos", "DataCriacao");
            DropColumn("dbo.Emails", "DataCriacao");
            DropColumn("dbo.LancamentoEventos", "DataCriacao");
            DropColumn("dbo.Eventos", "DataCriacao");
            DropColumn("dbo.FollowUpOSClientes", "DataCriacao");
            DropColumn("dbo.ModalidadesDaOS", "DataCriacao");
            DropColumn("dbo.MotivosDaOS", "DataCriacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MotivosDaOS", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.ModalidadesDaOS", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.FollowUpOSClientes", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Eventos", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.LancamentoEventos", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Emails", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.OrdemDeServicos", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.DocumentosAnexosDaOS", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Produtos", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProdutosCliente", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Setores", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Escritorios", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contatos", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clientes", "DataCriacao", c => c.DateTime(nullable: false));
        }
    }
}
