using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class Email : AEntidade
    {
        public enum TipoMensagem { ENVIADO=1, RECEBIDO=2 };

        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string ComCopia { get; set; }
        public string ComCopiaOculta { get; set; }
        public string Assunto { get; set; }
        public string TextoMensagem { get; set; }
        public TipoMensagem Mensagem { get; set; }

        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }
    }
}
