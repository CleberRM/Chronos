using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class AdicionarEvento
    {
        public AdicionarEvento(Eventos evento)
        {
            EventoLancado = evento;
            DataCriacao = DateTime.Now;
        }

        public int CodigoEvento{ get; set; }
        public Eventos EventoLancado { get; private set; }
        public Usuario ResponsavelCriacao { get;private set; }
        public Usuario ResponsavelEvento { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataPrevistaConclusao { get; set; }
        public DateTime DataConclusao { get; set; }
        public String StatusEvento { get; set; }

    }

}