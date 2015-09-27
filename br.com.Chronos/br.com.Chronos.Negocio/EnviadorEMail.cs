using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.Chronos.Entidade;

namespace br.com.Chronos.Negocio
{
    public class EnviadorEMail : IEnviador
    {
        public void Enviar(AMensagem mensagem)
        {
            throw new NotImplementedException();
        }

        public void ConfiguarEnviador(List<ParametroConfiguracaoMensagem> parametrosConfiguracao)
        {
            throw new NotImplementedException();
        }
    }
}
