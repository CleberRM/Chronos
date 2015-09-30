using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    class ADLancamentoEvento : IAcoesBanco<LancamentoEvento>
    {

        private OSContext _contexto;

        public ADLancamentoEvento(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {

            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.LancamentoEventos.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;


        }

        public LancamentoEvento RetornarEntidadePor(int id)
        {
            return (from c in _contexto.LancamentoEventos
                    where c.Id == id
                    select c).FirstOrDefault();


        }

        public IList<LancamentoEvento> RetornarLista(LancamentoEvento entidade)
        {
            return _contexto.LancamentoEventos.Where(x => x.StatusEvento.Contains(entidade.StatusEvento)).ToList();

        }

        public int Salvar(LancamentoEvento entidade)
        {
            var result = RetornarEntidadePor(entidade.Id);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.LancamentoEventos.Add(entidade);
            }

            _contexto.SaveChanges();
            return entidade.Id;
        }
    }
}
