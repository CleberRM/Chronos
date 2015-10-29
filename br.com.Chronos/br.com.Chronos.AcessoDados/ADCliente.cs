using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADCliente : IAcoesBanco<Cliente>
    {
        private OSContext _contexto;
        public ADCliente(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.Clientes.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Cliente RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Clientes
                    where c.IdCliente == id
                    select c).FirstOrDefault();
        }

        public IList<Cliente> RetornarLista(Cliente entidade)
        {
            return _contexto.Clientes.Where(x => x.NomeReduzido.Contains(entidade.NomeReduzido)).ToList();
        }

        public int Salvar(Cliente entidade)
        {
            var result = RetornarEntidadePor(entidade.IdCliente);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);   
            }
            else
            {
                _contexto.Clientes.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.IdCliente;
        }
    }
}