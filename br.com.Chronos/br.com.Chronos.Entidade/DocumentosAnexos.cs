using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class DocumentosAnexos : AEntidade
    {
        public int IdDocAnexos { get; set; }
        public string NomeDocumento {get; set;}
        public string CaminhoDocumento { get; set; }
        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }
        public string ResponsavelCriacao { get; set; }
    }

}
