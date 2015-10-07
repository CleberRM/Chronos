using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public abstract class AEntidade
    {
        
        public int Id { get; set; }
        public virtual Usuario ResponsavelCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int IdResponsavelCriacao { get; set; }
    }
}
