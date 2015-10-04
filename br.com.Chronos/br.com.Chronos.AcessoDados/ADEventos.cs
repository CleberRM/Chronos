using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADEventos : IAcoesBanco<Eventos>
    {
        private OSContext _contexto;
        public ADEventos(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.EventosDaOS.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Eventos RetornarEntidadePor(int id)
        {
            return (from c in _contexto.EventosDaOS
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<Eventos> RetornarLista(Eventos entidade)
        {
            return _contexto.EventosDaOS.Where(x => x.Descricao.Contains(entidade.Descricao)).ToList();
        }

        public int Salvar(Eventos entidade)
        {
            var result = RetornarEntidadePor(entidade.Id);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.EventosDaOS.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.Id;
        }
    }
}