namespace br.com.Chronos.AcessoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizarEscritorio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Escritorios", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Escritorios", "IdResponsavelCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.LancamentoEventos", "DataCriacaoEvento", c => c.DateTime(nullable: false));
            AddColumn("dbo.LancamentoEventos", "ResponsavelCriacaoEvento_Id", c => c.Int());
            CreateIndex("dbo.Escritorios", "IdResponsavelCriacao");
            CreateIndex("dbo.LancamentoEventos", "ResponsavelCriacaoEvento_Id");
            AddForeignKey("dbo.Escritorios", "IdResponsavelCriacao", "dbo.Usuarios", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LancamentoEventos", "ResponsavelCriacaoEvento_Id", "dbo.Usuarios", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelCriacaoEvento_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Escritorios", "IdResponsavelCriacao", "dbo.Usuarios");
            DropIndex("dbo.LancamentoEventos", new[] { "ResponsavelCriacaoEvento_Id" });
            DropIndex("dbo.Escritorios", new[] { "IdResponsavelCriacao" });
            DropColumn("dbo.LancamentoEventos", "ResponsavelCriacaoEvento_Id");
            DropColumn("dbo.LancamentoEventos", "DataCriacaoEvento");
            DropColumn("dbo.Escritorios", "IdResponsavelCriacao");
            DropColumn("dbo.Escritorios", "DataCriacao");
        }
    }
}
