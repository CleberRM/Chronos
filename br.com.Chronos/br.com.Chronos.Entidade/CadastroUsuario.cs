using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace br.com.Chronos.Entidade 
{
    public class CadastroUsuario : IEntidade
    {
        // Dados Usuário
        public string UserName { get; set; }
        public string SenhaUsuario { get; set; }
        public string ConfirmacaoSenha { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public int RamalUsuario { get; set; }
        public string AssinaturaTexto { get; set; }
        //Configuração do Usuário
        public bool FlagAdministrador { get; set; }
        public bool FlagTrocarSenha { get; set; }
        public bool FlagSincronizarOutlook { get; set; }
        public bool SincronizarOs { get; set; }
        public bool UsuariInativo { get; set; }
        //Configuração SMTP
        public string NomeEmail { get; set; }
        // Utilizar e-mail do usuario para configuração do SMTP
        public string ConfiguraçãoSmtp { get; set; }
        public int PortaSmtp { get; set; }
        public string UsuarioSmtp { get; set; }
        public string SenhaSmtp { get; set; }
        public string TextoAssinaturaSmtp { get; set; }
        public bool AutenticacaoTsl { get; set; }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
