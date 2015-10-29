using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADEscritorio : IAcoesBanco<Escritorio>
    {
        private OSContext _contexto;
        public ADEscritorio(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.Escritorios.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Escritorio RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Escritorios
                    where c.IdEscritorio == id
                    select c).FirstOrDefault();
        }

        public IList<Escritorio> RetornarLista(Escritorio entidade)
        {
            return _contexto.Escritorios.Where(x => x.NomeEscritorio.Contains(entidade.NomeEscritorio)).ToList();
        }

        public int Salvar(Escritorio entidade)
        {
            var result = RetornarEntidadePor(entidade.IdEscritorio);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.Escritorios.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.IdEscritorio;
        }
    }
}