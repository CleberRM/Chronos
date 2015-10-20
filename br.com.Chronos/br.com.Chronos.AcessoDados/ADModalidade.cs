using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADModalidade : IAcoesBanco<Modalidade>
    {
        private OSContext _contexto;
        public ADModalidade(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result!= null)
            {
                _contexto.Modalidades.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Modalidade RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Modalidades
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<Modalidade> RetornarLista(Modalidade entidade)
        {
            return _contexto.Modalidades.Where(x => x.DescricaoProduto.Descricao.Contains(entidade.DescricaoProduto.Descricao)).ToList();
        }

        public int Salvar(Modalidade entidade)
        {
            var result = RetornarEntidadePor(entidade.Id);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.Modalidades.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.Id;
        }
    }
}