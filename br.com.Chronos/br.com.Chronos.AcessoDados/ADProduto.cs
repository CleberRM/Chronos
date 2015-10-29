using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADProduto : IAcoesBanco<Produto>
    {
        private OSContext _context;
        public ADProduto(OSContext contexto)
        {
            _context = contexto;
        } 

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _context.Produtos.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Produto RetornarEntidadePor(int id)
        {
            return (from c in _context.Produtos
                    where c.IdProduto == id
                    select c).FirstOrDefault();
        }

        public IList<Produto> RetornarLista(Produto entidade)
        {
            return _context.Produtos.Where(x => x.Descricao.Contains(entidade.Descricao)).ToList();
        }

        public int Salvar(Produto entidade)
        {
            var result = RetornarEntidadePor(entidade.IdProduto);
            if (result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _context.Produtos.Add(entidade);
            }
            _context.SaveChanges();
            return entidade.IdProduto;
        }
    }
}