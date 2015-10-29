using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class LancamentoEvento : AEntidade
    {
        public LancamentoEvento(Evento evento)
        {
            EventoLancado = evento;
            DataCriacaoEvento = DateTime.Now;
        }

        public int IdLancamento { get; set; }

        public int IdEventoLancado { get; set; }
        public virtual Evento EventoLancado { get; set; }

        public int IdResponsavelCriacao { get; set; }
        public virtual Usuario ResponsavelCriacaoEvento { get; set; }

        public int IdResponsavelEvento { get; set; }
        public virtual Usuario ResponsavelEvento { get; set; }

        public DateTime DataCriacaoEvento { get; set; }
        public DateTime DataPrevistaConclusao { get; set; }
        public DateTime DataConclusao { get; set; }

        public string StatusEvento { get; set; }

        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }
        public string ResponsavelCriacao { get; set; }
    }

}