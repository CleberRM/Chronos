using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class ProdutoCliente : AEntidade
    {

        public ProdutoCliente(Cliente cliente)
        {
            Cliente = cliente;
            IdCliente = cliente.IdCliente;
        }

        public int IdProdutoCliente { get; set; } 

        public int IdProduto { get; set; }
        public virtual Produto DescricaoProduto { get; set; }

        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        public string ResponsavelCriacao { get; set; }
    }
}
