using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.Chronos.Entidade;
using System.Reflection;

namespace br.com.Chronos.FakeRepositorio
{
    public class RepositorioFake<T> : IAcoesBanco<T> where T : IEntidade
    {
        private IList<T> _lista;
        public RepositorioFake()
        {
            this._lista = new List<T>();
        }

        public bool ExcluirEntidadePor(int id)
        {
            T entidade = RetornarEntidadePor(id);
            if (entidade != null)
            {
                this._lista.Remove(entidade);
                return true;
            }
            else
            {
                return false;
            }
        }

        public T RetornarEntidadePor(int id)
        {
            return this._lista.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<T> RetornarLista(T entidade)
        {
            if (entidade != null)
            {
                return this._lista.Where(x => x.Id == entidade.Id).ToList();
            }
            else
            {
                return this._lista;
            }
        }

        public int Salvar(T entidade)
        {
            if (entidade.Id != 0)
            {
                T entidadeNaLista = this._lista.Where(x => x.Id == entidade.Id).FirstOrDefault();
                PropertyInfo[] propertyInfo = entidade.GetType().GetProperties();
                foreach (var item in propertyInfo)
                {
                    object valorASerAtribuido = item.GetValue(entidade);
                    item.SetValue(entidadeNaLista, valorASerAtribuido);
                }
            }
            else
            {
                entidade.Id = this._lista.Count + 1;
                this._lista.Add(entidade);
            }
        }
    }
}
