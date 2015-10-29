using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADUsuario : IAcoesBanco<Usuario>
    {
        private OSContext _contexto;
        public ADUsuario(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.Usuarios.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario RetornarEntidadePor(int id)
        {
            return (from c in _contexto.Usuarios
                    where c.IdUsuario == id
                    select c).FirstOrDefault();
        }

        public IList<Usuario> RetornarLista(Usuario entidade)
        {
            return _contexto.Usuarios.Where(x => x.NomeUsuario.Contains(entidade.NomeUsuario)).ToList();
        }

        public int Salvar(Usuario entidade)
        {
            var result = RetornarEntidadePor(entidade.IdUsuario);
            if (result != null)
            {
                _contexto.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.Usuarios.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.IdUsuario;
        }
    }
}