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
                        ProdutoOfficeComexMax = c.Boolean(nullable: false),
                        ProdutoOfficeComex2010 = c.Boolean(nullable: false),
                        ProdutoOfficecomexInternacional = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        ClienteProspecto = c.Boolean(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .Index(t => t.IdResponsavelCriacao);
            
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .Index(t => t.IdCliente)
                .Index(t => t.IdResponsavelCriacao);
            
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
                        EscritorioUsuario_Id = c.Int(),
                        SetorUsuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escritorios", t => t.EscritorioUsuario_Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao)
                .ForeignKey("dbo.Setores", t => t.SetorUsuario_Id)
                .Index(t => t.IdResponsavelCriacao)
                .Index(t => t.EscritorioUsuario_Id)
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .Index(t => t.IdResponsavelCriacao);
            
            CreateTable(
                "dbo.ProdutosCliente",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Id)
                .Index(t => t.IdCliente)
                .Index(t => t.IdResponsavelCriacao)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Descricao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ModalidadesDaOS", t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.IdResponsavelCriacao);
            
            CreateTable(
                "dbo.ModalidadesDaOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .Index(t => t.IdOrdemServico)
                .Index(t => t.IdResponsavelCriacao);
            
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.clienteOS_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelConclusaoOS_Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .Index(t => t.IdResponsavelCriacao)
                .Index(t => t.clienteOS_Id)
                .Index(t => t.ResponsavelConclusaoOS_Id);
            
            CreateTable(
                "dbo.DocumentosAnexosDaOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDocumento = c.String(),
                        CaminhoDocumento = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico, cascadeDelete: true)
                .Index(t => t.IdOrdemServico)
                .Index(t => t.IdResponsavelCriacao);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remetente = c.String(),
                        Destinatario = c.String(),
                        ComCopia = c.String(),
                        ComCopiaOculta = c.String(),
                        Assunto = c.String(),
                        TextoMensagem = c.String(),
                        Mensagem = c.Int(nullable: false),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico, cascadeDelete: true)
                .Index(t => t.IdOrdemServico)
                .Index(t => t.IdResponsavelCriacao);
            
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
                        ResponsavelEvento_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Eventos", t => t.EventoLancado_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelEvento_Id, cascadeDelete: true)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico, cascadeDelete: true)
                .Index(t => t.IdOrdemServico)
                .Index(t => t.IdResponsavelCriacao)
                .Index(t => t.EventoLancado_Id)
                .Index(t => t.ResponsavelEvento_Id);
            
            CreateTable(
                "dbo.Eventos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        CorHexadecimal = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .Index(t => t.IdResponsavelCriacao);
            
            CreateTable(
                "dbo.FollowUpOSClientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico, cascadeDelete: true)
                .Index(t => t.IdOrdemServico)
                .Index(t => t.IdResponsavelCriacao);
            
            CreateTable(
                "dbo.MotivosDaOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdResponsavelCriacao, cascadeDelete: true)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico, cascadeDelete: true)
                .Index(t => t.IdOrdemServico)
                .Index(t => t.IdResponsavelCriacao);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.ProdutosCliente", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.ProdutosCliente", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.ProdutosCliente", "Id", "dbo.Produtos");
            DropForeignKey("dbo.Produtos", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Produtos", "Id", "dbo.ModalidadesDaOS");
            DropForeignKey("dbo.ModalidadesDaOS", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelConclusaoOS_Id", "dbo.Usuarios");
            DropForeignKey("dbo.MotivosDaOS", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.MotivosDaOS", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.ModalidadesDaOS", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.FollowUpOSClientes", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.FollowUpOSClientes", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelEvento_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "EventoLancado_Id", "dbo.Eventos");
            DropForeignKey("dbo.Eventos", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Emails", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.Emails", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.DocumentosAnexosDaOS", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.DocumentosAnexosDaOS", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.OrdemDeServicos", "clienteOS_Id", "dbo.Clientes");
            DropForeignKey("dbo.ProdutosCliente", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Contatos", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Contatos", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "SetorUsuario_Id", "dbo.Setores");
            DropForeignKey("dbo.Setores", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "IdResponsavelCriacao", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "EscritorioUsuario_Id", "dbo.Escritorios");
            DropIndex("dbo.MotivosDaOS", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.MotivosDaOS", new[] { "IdOrdemServico" });
            DropIndex("dbo.FollowUpOSClientes", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.FollowUpOSClientes", new[] { "IdOrdemServico" });
            DropIndex("dbo.Eventos", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.LancamentoEventos", new[] { "ResponsavelEvento_Id" });
            DropIndex("dbo.LancamentoEventos", new[] { "EventoLancado_Id" });
            DropIndex("dbo.LancamentoEventos", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.LancamentoEventos", new[] { "IdOrdemServico" });
            DropIndex("dbo.Emails", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.Emails", new[] { "IdOrdemServico" });
            DropIndex("dbo.DocumentosAnexosDaOS", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.DocumentosAnexosDaOS", new[] { "IdOrdemServico" });
            DropIndex("dbo.OrdemDeServicos", new[] { "ResponsavelConclusaoOS_Id" });
            DropIndex("dbo.OrdemDeServicos", new[] { "clienteOS_Id" });
            DropIndex("dbo.OrdemDeServicos", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.ModalidadesDaOS", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.ModalidadesDaOS", new[] { "IdOrdemServico" });
            DropIndex("dbo.Produtos", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.Produtos", new[] { "Id" });
            DropIndex("dbo.ProdutosCliente", new[] { "Cliente_Id" });
            DropIndex("dbo.ProdutosCliente", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.ProdutosCliente", new[] { "IdCliente" });
            DropIndex("dbo.ProdutosCliente", new[] { "Id" });
            DropIndex("dbo.Setores", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.Usuarios", new[] { "SetorUsuario_Id" });
            DropIndex("dbo.Usuarios", new[] { "EscritorioUsuario_Id" });
            DropIndex("dbo.Usuarios", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.Contatos", new[] { "IdResponsavelCriacao" });
            DropIndex("dbo.Contatos", new[] { "IdCliente" });
            DropIndex("dbo.Clientes", new[] { "IdResponsavelCriacao" });
            DropTable("dbo.MotivosDaOS");
            DropTable("dbo.FollowUpOSClientes");
            DropTable("dbo.Eventos");
            DropTable("dbo.LancamentoEventos");
            DropTable("dbo.Emails");
            DropTable("dbo.DocumentosAnexosDaOS");
            DropTable("dbo.OrdemDeServicos");
            DropTable("dbo.ModalidadesDaOS");
            DropTable("dbo.Produtos");
            DropTable("dbo.ProdutosCliente");
            DropTable("dbo.Setores");
            DropTable("dbo.Escritorios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Contatos");
            DropTable("dbo.Clientes");
        }
    }
}
