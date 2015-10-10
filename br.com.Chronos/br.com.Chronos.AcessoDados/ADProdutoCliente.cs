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
            throw new NotImplementedException();
        }

        public ProdutoCliente RetornarEntidadePor(int id)
        {
            return (from c in _context.ProdutosCliente
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<ProdutoCliente> RetornarLista(ProdutoCliente entidade)
        {
            throw new NotImplementedException();
        }

        public int Salvar(ProdutoCliente entidade)
        {
            throw new NotImplementedException();
        }
    }
}
