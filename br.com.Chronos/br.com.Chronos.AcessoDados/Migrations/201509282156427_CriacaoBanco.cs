namespace br.com.Chronos.AcessoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Escritorios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.Int(nullable: false),
                        InscricaoEstadual = c.Int(nullable: false),
                        InscricaoMunicipal = c.Int(nullable: false),
                        NomeEscritorio = c.String(),
                        NomeFantasia = c.String(),
                        Sigla = c.String(),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Bairro = c.String(),
                        Estado = c.String(),
                        Pais = c.String(),
                        Telefone = c.Int(nullable: false),
                        Fax = c.Int(nullable: false),
                        Site = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Setores",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Descricao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        SenhaUsuario = c.String(),
                        NomeUsuario = c.String(),
                        EmailUsuario = c.String(),
                        RamalUsuario = c.Int(nullable: false),
                        AssinaturaTexto = c.String(),
                        Administrador = c.Boolean(nullable: false),
                        TrocarSenha = c.Boolean(nullable: false),
                        SincronizarOutlook = c.Boolean(nullable: false),
                        SincronizarOs = c.Boolean(nullable: false),
                        UsuarioInativo = c.Boolean(nullable: false),
                        NomeEmail = c.String(),
                        ConfiguraçãoSmtp = c.String(),
                        PortaSmtp = c.Int(nullable: false),
                        UsuarioSmtp = c.String(),
                        SenhaSmtp = c.String(),
                        TextoAssinaturaSmtp = c.String(),
                        AutenticacaoTSL = c.Boolean(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        EscritorioUsusario_Id = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escritorios", t => t.EscritorioUsusario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .Index(t => t.EscritorioUsusario_Id)
                .Index(t => t.ResponsavelCriacao_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Setores", "Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "EscritorioUsusario_Id", "dbo.Escritorios");
            DropIndex("dbo.Usuarios", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.Usuarios", new[] { "EscritorioUsusario_Id" });
            DropIndex("dbo.Setores", new[] { "Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Setores");
            DropTable("dbo.Escritorios");
        }
    }
}
