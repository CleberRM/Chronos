using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADEscritorio
    {
        public bool ExcluirEntidadePor(int id)
        {
            throw new NotImplementedException();
        }

        public Escritorio RetornarEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                return (from c in contexto.Escritorios
                        where c.Id == id
                        select c).FirstOrDefault();

            }

        }

        public IList<Escritorio> RetornarLista(Escritorio entidade)
        {
            throw new NotImplementedException();
        }

        public int Salvar(Escritorio entidade)
        {
            throw new NotImplementedException();
        }
    }
}
