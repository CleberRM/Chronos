using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    class ADLancamentoEvento : IAcoesBanco<LancamentoEvento>
    {
        public bool ExcluirEntidadePor(int id)
        {

            using (OSContext contexto = new OSContext())
            {
                var result = RetornarEntidadePor(id);
                if (result != null)
                {
                    contexto.LancamentoEventos.Remove(result);
                    contexto.SaveChanges();
                    return true;
                }
                return false;
            }


        }

        public LancamentoEvento RetornarEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                return (from c in contexto.LancamentoEventos
                        where c.Id == id
                        select c).FirstOrDefault();
            }


        }

        public IList<LancamentoEvento> RetornarLista(LancamentoEvento entidade)
        {
            using (OSContext contexto = new OSContext())
            {
                return contexto.LancamentoEventos.Where(x => x.StatusEvento.Contains(entidade.StatusEvento)).ToList();
                
            }


        }

        public int Salvar(LancamentoEvento entidade)
        {
            using (OSContext contexto = new OSContext())
            {
                var result = RetornarEntidadePor(entidade.Id);
                if (result != null)
                {
                    contexto.Entry(result).CurrentValues.SetValues(entidade);
                }else
                {
                    contexto.LancamentoEventos.Add(entidade);
                }

                contexto.SaveChanges();
                return entidade.Id;
           }
        }
    }
}
