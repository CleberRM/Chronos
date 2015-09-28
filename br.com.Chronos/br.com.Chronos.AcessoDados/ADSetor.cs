using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADSetor : IAcoesBanco<Setor>
    {
        public bool ExcluirEntidadePor(int id)
        {
            throw new NotImplementedException();
        }

        public Setor RetornarEntidadePor(int id)
        {
            using(OSContext contexto = new OSContext())
            {
                return (from c in contexto.Setores
                        where c.Id == id
                        select c).FirstOrDefault();
            }
        }

        public IList<Setor> RetornarLista(Setor entidade)
        {
            throw new NotImplementedException();
        }

        public int Salvar(Setor entidade)
        {
            throw new NotImplementedException();
        }
    }
}
