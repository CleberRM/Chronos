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
            using (OSContext contexto = new OSContext())
            {

                var result = RetornarEntidadePor(id);
                if (result != null)
                {
                    contexto.Setores.Remove(result);
                    contexto.SaveChanges();
                    return true;

                }
                return false;
            }
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
            using (OSContext contexto = new OSContext())
            {
                return contexto.Setores.Where(x => x.Descricao.Contains(entidade.Descricao)).ToList();
            }    

        }

        public int Salvar(Setor entidade)
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
                    contexto.Setores.Add(entidade);
                    
                }

                contexto.SaveChanges();
                return entidade.Id;
            }

            
        }
    }
}
