using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    class ADMensagemDados : IAcoesBanco<MensagemDados>
    {
        public bool ExcluirEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                var result = RetornarEntidadePor(id);
                if (result != null)
                {
                    contexto.MensagensDados.Remove(result);
                    contexto.SaveChanges();
                    return true;
                }
                return false;
            }

        }

        public MensagemDados RetornarEntidadePor(int id)
        {
            using (OSContext contexto = new OSContext())
            {
                return (from c in contexto.MensagensDados
                        where c.Id == id
                        select c).FirstOrDefault();
            }
        }

        public IList<MensagemDados> RetornarLista(MensagemDados entidade)
        {
            using (OSContext contexto = new OSContext())
            {
                return contexto.MensagensDados.Where(x => x.Assunto.Contains(entidade.Assunto)).ToList();
            }
        }

        public int Salvar(MensagemDados entidade)
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
                    contexto.MensagensDados.Add(entidade);
                }
                contexto.SaveChanges();
                return entidade.Id;
                
            }
        }
    }
}
