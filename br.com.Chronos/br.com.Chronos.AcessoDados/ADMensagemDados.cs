using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADMensagemDados : IAcoesBanco<MensagemDados>
    {
        private OSContext _contexto;
        public ADMensagemDados(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.MensagensDados.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public MensagemDados RetornarEntidadePor(int id)
        {
            return (from c in _contexto.MensagensDados
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<MensagemDados> RetornarLista(MensagemDados entidade)
        {
            return _contexto.MensagensDados.Where(x => x.Assunto.Contains(entidade.Assunto)).ToList();
        }

        public int Salvar(MensagemDados entidade)
        {
                var result = RetornarEntidadePor(entidade.Id);
                if (result != null)
                {
                    _contexto.Entry(result).CurrentValues.SetValues(entidade);
                }
                else
                {
                    _contexto.MensagensDados.Add(entidade);
                }
                _contexto.SaveChanges();
                return entidade.Id;
        }
    }
}