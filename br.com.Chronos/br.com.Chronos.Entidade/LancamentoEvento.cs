using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class LancamentoEvento : AEntidade
    {
        public LancamentoEvento(Eventos evento)
        {
            EventoLancado = evento;
        }

       
        public Eventos EventoLancado { get; private set; }
        public Usuario ResponsavelEvento { get; set; }
        public DateTime DataPrevistaConclusao { get; set; }
        public DateTime DataConclusao { get; set; }
        public string StatusEvento { get; set; }
        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }
    }

}