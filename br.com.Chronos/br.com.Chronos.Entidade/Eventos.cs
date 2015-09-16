using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace br.com.Chronos.Entidade
{
    public class Eventos : IEntidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CorHex { get; set; }

        
    }
}
