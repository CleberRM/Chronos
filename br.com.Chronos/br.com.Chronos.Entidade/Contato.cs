using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
     public class Contato : IEntidade

    {
        public int Id { get; set; }
        
        public string nomeContato { get; set; }

        public string telefoneContato { get; set; }

        public string celularContato { get; set; }

        public string setorContato { get; set; }

        public string ramalContato { get; set; }

        public string skypeContato { get; set; }

        public string emailContato { get; set; }

        public DateTime dataniverContato { get; set; }

        public DateTime dataRegistroContato { get; set; }

        public string respRegistroContato { get; set; }

        public bool treinamentoContato { get; set; }

    }
}
