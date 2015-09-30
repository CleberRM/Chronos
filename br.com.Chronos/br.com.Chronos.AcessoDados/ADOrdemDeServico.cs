using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADOrdemDeServico : IAcoesBanco<OrdemDeServico>
    {

        private OSContext _contexto;

        public ADOrdemDeServico(OSContext contexto)
        {
            _contexto = contexto;
        }


        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.OrdemDeServicos.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public OrdemDeServico RetornarEntidadePor(int id)
        {
            return (from c in _contexto.OrdemDeServicos
                    where c.Id == id
                    select c).FirstOrDefault();

        }

        public IList<OrdemDeServico> RetornarLista(OrdemDeServico entidade)
        {
            return _contexto.OrdemDeServicos.Where(x => x.NumeroOS.Contains(entidade.NumeroOS)).ToList();
        }

        public int Salvar(OrdemDeServico entidade)
        {
            var result = RetornarEntidadePor(entidade.Id);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.OrdemDeServicos.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.Id;
        }
    }
}
