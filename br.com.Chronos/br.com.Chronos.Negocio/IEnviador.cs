using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.Chronos.Entidade;

namespace br.com.Chronos.Negocio
{
    public interface IEnviador
    {
        void Enviar(AMensagem mensagem);

        void ConfiguarEnviador(List<ParametroConfiguracaoMensagem> parametrosConfiguracao);
    }
}
