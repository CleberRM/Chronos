using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class Contato : AEntidade
    {

        public Contato(Cliente cliente)
        {
            this.Clientes = cliente;
            this.IdCliente = cliente.Id;

        }

        public string NomeContato { get; set; }
        public string TelefoneContato { get; set; }
        public string CelularContato { get; set; }
        public string SetorContato { get; set; }
        public string RamalContato { get; set; }
        public string SkypeContato { get; set; }
        public string EmailContato { get; set; }
        public DateTime DataAniversarioContato { get; set; }
        public DateTime DataRegistroContato { get; set; }
        public string ResponsavelRegistroContato { get; set; }
        public bool TreinamentoContato { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Clientes { get; set; }
    }
}
