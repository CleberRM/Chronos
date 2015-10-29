using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADEmail : IAcoesBanco<Email>
    {
        private OSContext _contexto;
        public ADEmail(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.Emails.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Email RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Emails
                    where c.IdEmail == id
                    select c).FirstOrDefault();
        }

        public IList<Email> RetornarLista(Email entidade)
        {
            return _contexto.Emails.Where(x => x.Assunto.Contains(entidade.Assunto)).ToList();
        }

        public int Salvar(Email entidade)
        {
                var result = RetornarEntidadePor(entidade.IdEmail);
                if (result != null)
                {
                    _contexto.Entry(result).CurrentValues.SetValues(entidade);
                }
                else
                {
                    _contexto.Emails.Add(entidade);
                }
                _contexto.SaveChanges();
                return entidade.IdEmail;
        }
    }
}