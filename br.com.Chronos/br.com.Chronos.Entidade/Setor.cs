using br.com.Chronos.Idioma.Resources;
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
        [Display(ResourceType = typeof(Language), Name = "Descricao")]

        public int IdSetor { get; set; }
        public string Descricao { get; set; }
        public string ResponsavelCriacao { get; set; }
    }
}
