using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class Produto : AEntidade
    {
        public string Descricao { get; set; }
        public virtual Modalidade Modalidade { get; set; } 
        public virtual ProdutoCliente ProdutoCliente { get; set; }
    }
}
