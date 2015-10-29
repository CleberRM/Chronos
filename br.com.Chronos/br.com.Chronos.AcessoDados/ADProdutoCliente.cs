using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADProdutoCliente : IAcoesBanco<ProdutoCliente>
    {
        private OSContext _context;
        public ADProdutoCliente(OSContext contexto)
        {
            _context = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _context.ProdutosCliente.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public ProdutoCliente RetornarEntidadePor(int id)
        {
            return (from c in _context.ProdutosCliente
                    where c.IdProdutoCliente == id
                    select c).FirstOrDefault();
        }

        public IList<ProdutoCliente> RetornarLista(ProdutoCliente entidade)
        {
            return _context.ProdutosCliente.Where(x => x.DescricaoProduto.Descricao.Contains(entidade.DescricaoProduto.Descricao)).ToList();
        }

        public int Salvar(ProdutoCliente entidade)
        {
            var result = RetornarEntidadePor(entidade.IdProdutoCliente);
            if (result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(entidade);
            }
            else
            {
                _context.ProdutosCliente.Add(entidade);
            }
            _context.SaveChanges();
            return entidade.IdProdutoCliente;
        }
    }
}