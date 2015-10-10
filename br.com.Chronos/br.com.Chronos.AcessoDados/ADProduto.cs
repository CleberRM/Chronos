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
            throw new NotImplementedException();
        }

        public Produto RetornarEntidadePor(int id)
        {
            return (from c in _context.Produtos
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IList<Produto> RetornarLista(Produto entidade)
        {
            throw new NotImplementedException();
        }

        public int Salvar(Produto entidade)
        {
            throw new NotImplementedException();
        }
    }
}
