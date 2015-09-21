using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.Chronos.Entidade;

namespace br.com.Chronos.Negocio
{
    public class BLContato : ANegocio<Contato>
    {
        public BLContato(IAcoesBanco<Contato> acoesBanco) : base(acoesBanco)
        {

        }
    }
}
