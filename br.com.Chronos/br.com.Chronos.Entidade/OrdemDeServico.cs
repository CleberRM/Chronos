using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class OrdemDeServico : AEntidade

    {
        public string NumeroOS { get; set; }
        public Cliente clienteOS { get; set; }

    }

}   
