using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.FakeRepositorio
{
    public class RepositorioFake<T> : IAcoesBanco<T>
    {
        public bool ExcluirEntidadePor(int id)
        {
            throw new NotImplementedException();
        }

        public T RetornarEntidadePor(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> RetornarLista(T entidade)
        {
            throw new NotImplementedException();
        }

        public int Salvar(T entidade)
        {
            throw new NotImplementedException();
        }
    }
}
