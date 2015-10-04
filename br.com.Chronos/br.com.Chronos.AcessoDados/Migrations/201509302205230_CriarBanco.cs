namespace br.com.Chronos.AcessoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeReduzido = c.String(),
                        NomeCompleto = c.String(),
                        CNPJeCPF = c.String(),
                        Endereco = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        CEP = c.String(),
                        Cidade = c.String(),
                        UF = c.String(),
                        Pais = c.String(),
                        NomeVendedor = c.String(),
                        Observacoes = c.String(),
                        ConexaoRemota = c.String(),
                        Telefone = c.Int(nullable: false),
                        Fax = c.Int(nullable: false),
                        VersaoAtual = c.Int(nullable: false),
                        QuantidadeLicencas = c.Int(nullable: false),
                        TipoCliente = c.Int(nullable: false),
                        ProdutoAcess = c.Boolean(nullable: false),
                        ProdutoOfficecomexMax = c.Boolean(nullable: false),
                        ProdutoOfficecomexInternacional = c.Boolean(nullable: false),
                        ProdutoFollowebInternacional = c.Boolean(nullable: false),
                        ProdutoFolloweb = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        ClienteProspecto = c.Boolean(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .Index(t => t.ResponsavelCriacao_Id);
            
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeContato = c.String(),
                        TelefoneContato = c.String(),
                        CelularContato = c.String(),
                        SetorContato = c.String(),
                        RamalContato = c.String(),
                        SkypeContato = c.String(),
                        EmailContato = c.String(),
                        DataAniversarioContato = c.DateTime(nullable: false),
                        DataRegistroContato = c.DateTime(nullable: false),
                        ResponsavelRegistroContato = c.String(),
                        TreinamentoContato = c.Boolean(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                        Clientes_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .ForeignKey("dbo.Clientes", t => t.Clientes_Id, cascadeDelete: true)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.Clientes_Id);
            
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
                        EscritorioUsuario_Id = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                        SetorUsuario_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escritorios", t => t.EscritorioUsuario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .ForeignKey("dbo.Setores", t => t.SetorUsuario_Id, cascadeDelete: true)
                .Index(t => t.EscritorioUsuario_Id)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.SetorUsuario_Id);
            
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
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.DocumentosAnexosDaOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDocumento = c.String(),
                        CaminhoDocumento = c.String(),
                        IdOS = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        OrdemServico_Id = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrdemDeServicos", t => t.OrdemServico_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .Index(t => t.OrdemServico_Id)
                .Index(t => t.ResponsavelCriacao_Id);
            
            CreateTable(
                "dbo.OrdemDeServicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroOS = c.String(),
                        NivelDaOS = c.Int(nullable: false),
                        NomeDocumento = c.String(),
                        ReferenciaExemplo = c.String(),
                        DataVencimentoOS = c.DateTime(nullable: false),
                        DataConclusaoOS = c.DateTime(nullable: false),
                        DescricaoOS = c.String(),
                        ObservacaoOS = c.String(),
                        TipoDeContato = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        clienteOS_Id = c.Int(nullable: false),
                        ResponsavelConclusaoOS_Id = c.Int(),
                        ResponsavelCriacao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.clienteOS_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelConclusaoOS_Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .Index(t => t.clienteOS_Id)
                .Index(t => t.ResponsavelConclusaoOS_Id)
                .Index(t => t.ResponsavelCriacao_Id);
            
            CreateTable(
                "dbo.MensagensDados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remetente = c.String(),
                        Destinatario = c.String(),
                        ComCopia = c.String(),
                        ComCopiaOculta = c.String(),
                        Assunto = c.String(),
                        Mensagem = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                        OrdemDeServico_Id = c.Int(),
                        OrdemServico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .ForeignKey("dbo.OrdemDeServicos", t => t.OrdemDeServico_Id)
                .ForeignKey("dbo.OrdemDeServicos", t => t.OrdemServico_Id, cascadeDelete: true)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.OrdemDeServico_Id)
                .Index(t => t.OrdemServico_Id);
            
            CreateTable(
                "dbo.LancamentoEventos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataPrevistaConclusao = c.DateTime(nullable: false),
                        DataConclusao = c.DateTime(nullable: false),
                        StatusEvento = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        EventoLancado_Id = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                        ResponsavelEvento_Id = c.Int(nullable: false),
                        OrdemServico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventosDaOS", t => t.EventoLancado_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelEvento_Id, cascadeDelete: true)
                .ForeignKey("dbo.OrdemDeServicos", t => t.OrdemServico_Id, cascadeDelete: true)
                .Index(t => t.EventoLancado_Id)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.ResponsavelEvento_Id)
                .Index(t => t.OrdemServico_Id);
            
            CreateTable(
                "dbo.EventosDaOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        CorHexadecimal = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .Index(t => t.ResponsavelCriacao_Id);
            
            CreateTable(
                "dbo.FollowUpOSClientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                        OrdemServico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .ForeignKey("dbo.OrdemDeServicos", t => t.OrdemServico_Id, cascadeDelete: true)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.OrdemServico_Id);
            
            CreateTable(
                "dbo.Modalidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                        OrdemServico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .ForeignKey("dbo.OrdemDeServicos", t => t.OrdemServico_Id, cascadeDelete: true)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.OrdemServico_Id);
            
            CreateTable(
                "dbo.MotivosOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        ResponsavelCriacao_Id = c.Int(),
                        OrdemServico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacao_Id)
                .ForeignKey("dbo.OrdemDeServicos", t => t.OrdemServico_Id, cascadeDelete: true)
                .Index(t => t.ResponsavelCriacao_Id)
                .Index(t => t.OrdemServico_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentosAnexosDaOS", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelConclusaoOS_Id", "dbo.Usuarios");
            DropForeignKey("dbo.MotivosOS", "OrdemServico_Id", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.MotivosOS", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Modalidades", "OrdemServico_Id", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.Modalidades", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.FollowUpOSClientes", "OrdemServico_Id", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.FollowUpOSClientes", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "OrdemServico_Id", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelEvento_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "EventoLancado_Id", "dbo.EventosDaOS");
            DropForeignKey("dbo.EventosDaOS", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.MensagensDados", "OrdemServico_Id", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.MensagensDados", "OrdemDeServico_Id", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.MensagensDados", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.DocumentosAnexosDaOS", "OrdemServico_Id", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.OrdemDeServicos", "clienteOS_Id", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Contatos", "Clientes_Id", "dbo.Clientes");
            DropForeignKey("dbo.Contatos", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "SetorUsuario_Id", "dbo.Setores");
            DropForeignKey("dbo.Setores", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Setores", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "ResponsavelCriacao_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "EscritorioUsuario_Id", "dbo.Escritorios");
            DropIndex("dbo.MotivosOS", new[] { "OrdemServico_Id" });
            DropIndex("dbo.MotivosOS", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.Modalidades", new[] { "OrdemServico_Id" });
            DropIndex("dbo.Modalidades", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.FollowUpOSClientes", new[] { "OrdemServico_Id" });
            DropIndex("dbo.FollowUpOSClientes", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.EventosDaOS", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.LancamentoEventos", new[] { "OrdemServico_Id" });
            DropIndex("dbo.LancamentoEventos", new[] { "ResponsavelEvento_Id" });
            DropIndex("dbo.LancamentoEventos", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.LancamentoEventos", new[] { "EventoLancado_Id" });
            DropIndex("dbo.MensagensDados", new[] { "OrdemServico_Id" });
            DropIndex("dbo.MensagensDados", new[] { "OrdemDeServico_Id" });
            DropIndex("dbo.MensagensDados", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.OrdemDeServicos", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.OrdemDeServicos", new[] { "ResponsavelConclusaoOS_Id" });
            DropIndex("dbo.OrdemDeServicos", new[] { "clienteOS_Id" });
            DropIndex("dbo.DocumentosAnexosDaOS", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.DocumentosAnexosDaOS", new[] { "OrdemServico_Id" });
            DropIndex("dbo.Setores", new[] { "Usuario_Id" });
            DropIndex("dbo.Setores", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.Usuarios", new[] { "SetorUsuario_Id" });
            DropIndex("dbo.Usuarios", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.Usuarios", new[] { "EscritorioUsuario_Id" });
            DropIndex("dbo.Contatos", new[] { "Clientes_Id" });
            DropIndex("dbo.Contatos", new[] { "ResponsavelCriacao_Id" });
            DropIndex("dbo.Clientes", new[] { "ResponsavelCriacao_Id" });
            DropTable("dbo.MotivosOS");
            DropTable("dbo.Modalidades");
            DropTable("dbo.FollowUpOSClientes");
            DropTable("dbo.EventosDaOS");
            DropTable("dbo.LancamentoEventos");
            DropTable("dbo.MensagensDados");
            DropTable("dbo.OrdemDeServicos");
            DropTable("dbo.DocumentosAnexosDaOS");
            DropTable("dbo.Setores");
            DropTable("dbo.Escritorios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Contatos");
            DropTable("dbo.Clientes");
        }
    }
}
