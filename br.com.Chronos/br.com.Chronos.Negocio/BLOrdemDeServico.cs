using br.com.Chronos.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Negocio
{
    public class BLOrdemDeServico : ANegocio<Usuario>
    {
        public BLOrdemDeServico(IAcoesBanco<Usuario>acoesbanco): base(acoesbanco)
        {

        }
    }
}
