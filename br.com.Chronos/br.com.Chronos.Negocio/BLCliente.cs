using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.Chronos.Entidade;
namespace br.com.Chronos.Negocio
{
         public class BLCliente : ANegocio<Cliente>
        {
            public BLCliente(IAcoesBanco<Cliente> acoesBanco) : base(acoesBanco)
            {
                //Here
            }
        }
}
