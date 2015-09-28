using br.com.Chronos.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Negocio
{
    public class BLEventos : ANegocio<Eventos>
    {
        public BLEventos(IAcoesBanco<Eventos>acoesbanco) : base(acoesbanco)
        {

        }
    }
}
