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
                        IdCliente = c.Int(nullable: false, identity: true),
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
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        IdContato = c.Int(nullable: false, identity: true),
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
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdContato)
                .ForeignKey("dbo.Clientes", t => t.IdCliente)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.ProdutosCliente",
                c => new
                    {
                        IdProdutoCliente = c.Int(nullable: false, identity: true),
                        IdProduto = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProdutoCliente)
                .ForeignKey("dbo.Produtos", t => t.IdProduto)
                .ForeignKey("dbo.Clientes", t => t.IdCliente)
                .Index(t => t.IdProduto)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduto);
            
            CreateTable(
                "dbo.DocumentosAnexosDaOS",
                c => new
                    {
                        IdDocAnexos = c.Int(nullable: false, identity: true),
                        NomeDocumento = c.String(),
                        CaminhoDocumento = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdDocAnexos)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico)
                .Index(t => t.IdOrdemServico);
            
            CreateTable(
                "dbo.OrdemDeServicos",
                c => new
                    {
                        IdOrdemServico = c.Int(nullable: false, identity: true),
                        NumeroOS = c.String(),
                        IdCliente = c.Int(nullable: false),
                        NivelDaOS = c.Int(nullable: false),
                        NomeDocumento = c.String(),
                        ReferenciaExemplo = c.String(),
                        DataVencimentoOS = c.DateTime(nullable: false),
                        DataConclusaoOS = c.DateTime(nullable: false),
                        DescricaoOS = c.String(),
                        ObservacaoOS = c.String(),
                        TipoDeContato = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        ResponsavelConclusaoOS_IdUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.IdOrdemServico)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelConclusaoOS_IdUsuario)
                .Index(t => t.IdCliente)
                .Index(t => t.ResponsavelConclusaoOS_IdUsuario);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        IdEmail = c.Int(nullable: false, identity: true),
                        Remetente = c.String(),
                        Destinatario = c.String(),
                        ComCopia = c.String(),
                        ComCopiaOculta = c.String(),
                        Assunto = c.String(),
                        TextoMensagem = c.String(),
                        Mensagem = c.Int(nullable: false),
                        IdOrdemServico = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmail)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico)
                .Index(t => t.IdOrdemServico);
            
            CreateTable(
                "dbo.LancamentoEventos",
                c => new
                    {
                        IdLancamento = c.Int(nullable: false, identity: true),
                        IdEventoLancado = c.Int(nullable: false),
                        IdResponsavelCriacao = c.Int(nullable: false),
                        IdResponsavelEvento = c.Int(nullable: false),
                        DataCriacaoEvento = c.DateTime(nullable: false),
                        DataPrevistaConclusao = c.DateTime(nullable: false),
                        DataConclusao = c.DateTime(nullable: false),
                        StatusEvento = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        EventoLancado_IdEvento = c.Int(),
                        ResponsavelCriacaoEvento_IdUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.IdLancamento)
                .ForeignKey("dbo.Eventos", t => t.EventoLancado_IdEvento)
                .ForeignKey("dbo.Usuarios", t => t.ResponsavelCriacaoEvento_IdUsuario)
                .ForeignKey("dbo.Usuarios", t => t.IdEventoLancado, cascadeDelete: true)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico)
                .Index(t => t.IdEventoLancado)
                .Index(t => t.IdOrdemServico)
                .Index(t => t.EventoLancado_IdEvento)
                .Index(t => t.ResponsavelCriacaoEvento_IdUsuario);
            
            CreateTable(
                "dbo.Eventos",
                c => new
                    {
                        IdEvento = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        CorHexadecimal = c.String(),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdEvento);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        SenhaUsuario = c.String(),
                        NomeUsuario = c.String(),
                        EmailUsuario = c.String(),
                        RamalUsuario = c.Int(nullable: false),
                        AssinaturaTexto = c.String(),
                        IdEscritorio = c.Int(nullable: false),
                        IdSetor = c.Int(nullable: false),
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
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Escritorios", t => t.IdEscritorio, cascadeDelete: true)
                .ForeignKey("dbo.Setores", t => t.IdSetor, cascadeDelete: true)
                .Index(t => t.IdEscritorio)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "dbo.Escritorios",
                c => new
                    {
                        IdEscritorio = c.Int(nullable: false, identity: true),
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
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdEscritorio);
            
            CreateTable(
                "dbo.Setores",
                c => new
                    {
                        IdSetor = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdSetor);
            
            CreateTable(
                "dbo.FollowUpOSClientes",
                c => new
                    {
                        IdFollow = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdFollow)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico)
                .Index(t => t.IdOrdemServico);
            
            CreateTable(
                "dbo.ModalidadesDaOS",
                c => new
                    {
                        IdModalidade = c.Int(nullable: false, identity: true),
                        IdProduto = c.Int(nullable: false),
                        IdOrdemServico = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdModalidade)
                .ForeignKey("dbo.Produtos", t => t.IdProduto)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico)
                .Index(t => t.IdProduto)
                .Index(t => t.IdOrdemServico);
            
            CreateTable(
                "dbo.MotivosDaOS",
                c => new
                    {
                        IdMotivo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        IdOrdemServico = c.Int(nullable: false),
                        ResponsavelCriacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdMotivo)
                .ForeignKey("dbo.OrdemDeServicos", t => t.IdOrdemServico)
                .Index(t => t.IdOrdemServico);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrdemDeServicos", "ResponsavelConclusaoOS_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.MotivosDaOS", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.ModalidadesDaOS", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.ModalidadesDaOS", "IdProduto", "dbo.Produtos");
            DropForeignKey("dbo.FollowUpOSClientes", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.LancamentoEventos", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.LancamentoEventos", "IdEventoLancado", "dbo.Usuarios");
            DropForeignKey("dbo.LancamentoEventos", "ResponsavelCriacaoEvento_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "IdSetor", "dbo.Setores");
            DropForeignKey("dbo.Usuarios", "IdEscritorio", "dbo.Escritorios");
            DropForeignKey("dbo.LancamentoEventos", "EventoLancado_IdEvento", "dbo.Eventos");
            DropForeignKey("dbo.Emails", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.DocumentosAnexosDaOS", "IdOrdemServico", "dbo.OrdemDeServicos");
            DropForeignKey("dbo.OrdemDeServicos", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.ProdutosCliente", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.ProdutosCliente", "IdProduto", "dbo.Produtos");
            DropForeignKey("dbo.Contatos", "IdCliente", "dbo.Clientes");
            DropIndex("dbo.MotivosDaOS", new[] { "IdOrdemServico" });
            DropIndex("dbo.ModalidadesDaOS", new[] { "IdOrdemServico" });
            DropIndex("dbo.ModalidadesDaOS", new[] { "IdProduto" });
            DropIndex("dbo.FollowUpOSClientes", new[] { "IdOrdemServico" });
            DropIndex("dbo.Usuarios", new[] { "IdSetor" });
            DropIndex("dbo.Usuarios", new[] { "IdEscritorio" });
            DropIndex("dbo.LancamentoEventos", new[] { "ResponsavelCriacaoEvento_IdUsuario" });
            DropIndex("dbo.LancamentoEventos", new[] { "EventoLancado_IdEvento" });
            DropIndex("dbo.LancamentoEventos", new[] { "IdOrdemServico" });
            DropIndex("dbo.LancamentoEventos", new[] { "IdEventoLancado" });
            DropIndex("dbo.Emails", new[] { "IdOrdemServico" });
            DropIndex("dbo.OrdemDeServicos", new[] { "ResponsavelConclusaoOS_IdUsuario" });
            DropIndex("dbo.OrdemDeServicos", new[] { "IdCliente" });
            DropIndex("dbo.DocumentosAnexosDaOS", new[] { "IdOrdemServico" });
            DropIndex("dbo.ProdutosCliente", new[] { "IdCliente" });
            DropIndex("dbo.ProdutosCliente", new[] { "IdProduto" });
            DropIndex("dbo.Contatos", new[] { "IdCliente" });
            DropTable("dbo.MotivosDaOS");
            DropTable("dbo.ModalidadesDaOS");
            DropTable("dbo.FollowUpOSClientes");
            DropTable("dbo.Setores");
            DropTable("dbo.Escritorios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Eventos");
            DropTable("dbo.LancamentoEventos");
            DropTable("dbo.Emails");
            DropTable("dbo.OrdemDeServicos");
            DropTable("dbo.DocumentosAnexosDaOS");
            DropTable("dbo.Produtos");
            DropTable("dbo.ProdutosCliente");
            DropTable("dbo.Contatos");
            DropTable("dbo.Clientes");
        }
    }
}
