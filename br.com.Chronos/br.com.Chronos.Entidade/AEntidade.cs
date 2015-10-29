using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public abstract class AEntidade
    {
        
        public DateTime DataCriacao { get; set; }
        

        public AEntidade()
        {
            DataCriacao = DateTime.Now;
        }
        
                         

    }

        


}
