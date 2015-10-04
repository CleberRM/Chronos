using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class Setor : AEntidade
    {
        public string Descricao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
