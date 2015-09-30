using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    class ADOrdemDeServico : IAcoesBanco<OrdemDeServico>
    {
        public bool ExcluirEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                var result = RetornarEntidadePor(id);
                if (result != null)
                {
                    contexto.OrdemDeServicos.Remove(result);
                    contexto.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public OrdemDeServico RetornarEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                return (from c in contexto.OrdemDeServicos
                        where c.Id == id
                        select c).FirstOrDefault();
            }
        }

        public IList<OrdemDeServico> RetornarLista(OrdemDeServico entidade)
        {
            using (OSContext contexto = new OSContext())
            {
                return contexto.OrdemDeServicos.Where(x => x.NumeroOS.Contains(entidade.NumeroOS)).ToList();
            }
        }

        public int Salvar(OrdemDeServico entidade)
        {
            using (OSContext contexto = new OSContext())
            {
                var result = RetornarEntidadePor(entidade.Id);
                if (result != null)
                {
                    contexto.Entry(result).CurrentValues.SetValues(entidade);
                }
                else
                {
                    contexto.OrdemDeServicos.Add(entidade);
                }
                contexto.SaveChanges();
                return entidade.Id;
            }
        }
    }
}
