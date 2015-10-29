using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADFollowUpOSCliente : IAcoesBanco<FollowUpOSCliente>
    {
        private OSContext _contexto;
        public ADFollowUpOSCliente(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.FollowUpOSClientes.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public FollowUpOSCliente RetornarEntidadePor(int id)
        {
            return (from c in _contexto.FollowUpOSClientes
                    where c.IdFollow == id
                    select c).FirstOrDefault();
        }

        public IList<FollowUpOSCliente> RetornarLista(FollowUpOSCliente entidade)
        {
            return _contexto.FollowUpOSClientes.Where(x => x.Descricao.Contains(entidade.Descricao)).ToList();
        }

        public int Salvar(FollowUpOSCliente entidade)
        {
            var result = RetornarEntidadePor(entidade.IdFollow);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.FollowUpOSClientes.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.IdFollow;
        }
    }
}