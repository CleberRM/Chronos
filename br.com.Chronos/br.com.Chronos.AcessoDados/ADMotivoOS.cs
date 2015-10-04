using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADMotivoOS : IAcoesBanco<MotivoOS>
    {
        private OSContext _contexto;
        public ADMotivoOS(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.MotivosOS.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public MotivoOS RetornarEntidadePor(int id)
        {
            return (from c in _contexto.MotivosOS
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<MotivoOS> RetornarLista(MotivoOS entidade)
        {
            return _contexto.MotivosOS.Where(x => x.Descricao.Contains(entidade.Descricao)).ToList();
        }

        public int Salvar(MotivoOS entidade)
        {
            var result = RetornarEntidadePor(entidade.Id);
            if (result !=null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.MotivosOS.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.Id;
        }
    }
}