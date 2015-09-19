using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace br.com.Chronos.Entidade
{
    public class Usuario : IEntidade

    {
        //construtor
        public Usuario(string nomeUsuario, string senhaUsuario, Escritorio escritorio, Setor setor)
        {
            this.NomeEscritorio = escritorio;
            this.Setor = setor;
            this.NomeUsuario = nomeUsuario;
            this.SenhaUsuario = senhaUsuario;
        }

        public int Id { get; set; }
        // Dados Usuário
        public string UserName { get; set; }
        public string SenhaUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public int RamalUsuario { get; set; }
        public string AssinaturaTexto { get; set; }
        public Escritorio NomeEscritorio { get; private set; }
        public Setor Setor { get; private set; }
        //Configuração do Usuário
        public bool Administrador { get; set; }
        public bool TrocarSenha { get; set; }
        public bool SincronizarOutlook { get; set; }
        public bool SincronizarOs { get; set; }
        public bool UsuarioInativo { get; set; }
        //Configuração SMTP
        public string NomeEmail { get; set; }
        // Utilizar e-mail do usuario para configuração do SMTP
        public string ConfiguraçãoSmtp { get; set; }
        public int PortaSmtp { get; set; }
        public string UsuarioSmtp { get; set; }
        public string SenhaSmtp { get; set; }
        public string TextoAssinaturaSmtp { get; set; }
        public bool AutenticacaoTSL { get; set; }


    }
}