using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.Chronos.Entidade;

namespace br.com.Chronos.Negocio
{
    public abstract class ANegocio<T> where T : AEntidade
    {
        protected IAcoesBanco<T> _acoesBanco;
        public ANegocio(IAcoesBanco<T> acoesBanco)
        {
            this._acoesBanco = acoesBanco;
        }

        public virtual T RetornarEntidadePor(int id)
        {
            return this._acoesBanco.RetornarEntidadePor(id);
        }

        public virtual int Salvar(T entidade)
        {
            return this._acoesBanco.Salvar(entidade);
        }

        public virtual IList<T> RetornarLista(T entidade)
        {
            return this._acoesBanco.RetornarLista(entidade);
        }

        public virtual bool ExcluirEntidadePor(int id)
        {
            return this._acoesBanco.ExcluirEntidadePor(id);
        }
    }
}
