using br.com.Chronos.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Negocio
{
    public class BLModalidade : ANegocio<Usuario>
    {
        public BLModalidade(IAcoesBanco<Usuario>acoesbanco) : base(acoesbanco)
        {

        }
    }
}
