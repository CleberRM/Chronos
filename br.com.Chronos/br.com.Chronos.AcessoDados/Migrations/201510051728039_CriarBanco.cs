namespace br.com.Chronos.AcessoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Setores", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Setores", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Contatos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Clientes", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.MensagensDados", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Eventos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelEvento_Id", "dbo.Usuarios");
            DropForeignKey("dbo.FollowUpOSClientes", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Modalidades", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.MotivosOS", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelConclusaoOS_Id", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.DocumentosAnexosDaOS", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Eventos", "Id", "dbo.LancamentoEventos");
            DropIndex("dbo.Usuarios", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.Eventos", new[] { "Id" });
            DropIndex("dbo.Eventos", new[] { "ResponsavelCriacao_Id" });
            DropColumn("dbo.Usuarios", "Id");
            RenameColumn(table: "dbo.Usuarios", name: "ResponsavelCriacao_Id", newName: "Id");
            DropPrimaryKey("dbo.Usuarios");
            DropPrimaryKey("dbo.LancamentoEventos");
            DropPrimaryKey("dbo.Eventos");
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.LancamentoEventos", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Eventos", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Usuarios", "Id");
            AddPrimaryKey("dbo.LancamentoEventos", "Id");
            AddPrimaryKey("dbo.Eventos", "Id");
            CreateIndex("dbo.Usuarios", "Id");
            CreateIndex("dbo.Usuarios", "ResponsavelCriacao_Id");
            CreateIndex("dbo.LancamentoEventos", "Id");
            AddForeignKey("dbo.Usuarios", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Setores", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Setores", "Usuario_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Contatos", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Clientes", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.MensagensDados", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.LancamentoEventos", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.LancamentoEventos", "ResponsavelEvento_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.FollowUpOSClientes", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Modalidades", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.MotivosOS", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.OrdemDeServicos", "ResponsavelConclusaoOS_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.OrdemDeServicos", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.DocumentosAnexosDaOS", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Usuarios", "Id", "dbo.Eventos", "Id");
            AddForeignKey("dbo.LancamentoEventos", "Id", "dbo.Eventos", "Id");
            DropColumn("dbo.Eventos", "ResponsavelCriacao_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eventos", "ResponsavelCriacao_Id", c => c.Int());
            DropForeignKey("dbo.LancamentoEventos", "Id", "dbo.Eventos");
            DropForeignKey("dbo.Usuarios", "Id", "dbo.Eventos");
            DropForeignKey("dbo.DocumentosAnexosDaOS", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelConclusaoOS_Id", "dbo.Usuarios");
            DropForeignKey("dbo.MotivosOS", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Modalidades", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.FollowUpOSClientes", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelEvento_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.MensagensDados", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Clientes", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Contatos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Setores", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Setores", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropIndex("dbo.LancamentoEventos", new[] { "Id" });
            DropIndex("dbo.Usuarios", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.Usuarios", new[] { "Id" });
            DropPrimaryKey("dbo.Eventos");
            DropPrimaryKey("dbo.LancamentoEventos");
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Eventos", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.LancamentoEventos", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Usuarios", "Id", c => c.Int());
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Eventos", "Id");
            AddPrimaryKey("dbo.LancamentoEventos", "Id");
            AddPrimaryKey("dbo.Usuarios", "Id");
            RenameColumn(table: "dbo.Usuarios", name: "Id", newName: "ResponsavelCriacao_Id");
            AddColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Eventos", "ResponsavelCriacao_Id");
            CreateIndex("dbo.Eventos", "Id");
            CreateIndex("dbo.Usuarios", "ResponsavelCriacao_Id");
            AddForeignKey("dbo.Eventos", "Id", "dbo.LancamentoEventos", "Id");
            AddForeignKey("dbo.DocumentosAnexosDaOS", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.OrdemDeServicos", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.OrdemDeServicos", "ResponsavelConclusaoOS_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.MotivosOS", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Modalidades", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.FollowUpOSClientes", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.LancamentoEventos", "ResponsavelEvento_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.LancamentoEventos", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Eventos", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.MensagensDados", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Clientes", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Contatos", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Setores", "Usuario_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Setores", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Usuarios", "ResponsavelCriacao_Id", "dbo.Usuarios", "Id");
        }
    }
}
