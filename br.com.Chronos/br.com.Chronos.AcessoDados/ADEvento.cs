using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADEvento : IAcoesBanco<Evento>
    {
        private OSContext _contexto;
        public ADEvento(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.Eventos.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Evento RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Eventos
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<Evento> RetornarLista(Evento entidade)
        {
            return _contexto.Eventos.Where(x => x.Descricao.Contains(entidade.Descricao)).ToList();
        }

        public int Salvar(Evento entidade)
        {
            var result = RetornarEntidadePor(entidade.Id);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.Eventos.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.Id;
        }
    }
}