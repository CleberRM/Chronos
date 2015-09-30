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
        private OSContext _contexto;

        public ADSetor(OSContext contexto)
        {
            _contexto = contexto;
        }


        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.Setores.Remove(result);
                _contexto.SaveChanges();
                return true;

            }
            return false;

        }

        public Setor RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Setores
                    where c.Id == id
                    select c).FirstOrDefault();

        }

        public IList<Setor> RetornarLista(Setor entidade)
        {
            return _contexto.Setores.Where(x => x.Descricao.Contains(entidade.Descricao)).ToList();

        }

        public int Salvar(Setor entidade)
        {

            var result = RetornarEntidadePor(entidade.Id);

            if (result != null)
            {

                _contexto.Entry(result).CurrentValues.SetValues(entidade);


            }
            else
            {
                _contexto.Setores.Add(entidade);

            }

            _contexto.SaveChanges();
            return entidade.Id;


        }
    }
}
