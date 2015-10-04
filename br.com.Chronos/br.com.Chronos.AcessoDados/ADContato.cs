using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADContato : IAcoesBanco<Contato>
    {
        private OSContext _contexto;
        public ADContato(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.Contatos.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return true;
        }

        public Contato RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Contatos
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<Contato> RetornarLista(Contato entidade)
        {
            return _contexto.Contatos.Where(x => x.NomeContato.Contains(entidade.NomeContato)).ToList();
        }

        public int Salvar(Contato entidade)
        {
            var result = RetornarEntidadePor(entidade.Id);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.Contatos.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.Id;
        }
    }
}