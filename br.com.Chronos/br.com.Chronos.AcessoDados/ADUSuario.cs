using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADUsuario : IAcoesBanco<Usuario>
    {
        public bool ExcluirEntidadePor(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario RetornarEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                return (from c in contexto.Usuarios
                        where c.Id == id
                        select c).FirstOrDefault();

            }

        }

        public IList<Usuario> RetornarLista(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        public int Salvar(Usuario entidade)
        {
            throw new NotImplementedException();
        }
    }
}
