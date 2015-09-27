using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Negocio
{
    public abstract class AMensagem
    {
        private IEnviador _enviador;
        public AMensagem(IEnviador enviador)
        {
            _enviador = enviador;
        }
        public abstract string Mensagem();
        public void EnviarMensagem()
        {
            this._enviador.Enviar(this);
        }
    }
}
