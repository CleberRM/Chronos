using br.com.Chronos.Idioma.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class OrdemDeServico : AEntidade
    {
        public OrdemDeServico()
        {
            EventosDaOS = new List<LancamentoEvento>();
            ModalidadeDaOS = new List<Modalidade>();
            DocumentosAnexosDaOS = new List<DocumentosAnexos>();
            MotivoAberturaOS = new List<MotivoOS>();
            FollowCliente = new List<FollowUpOSCliente>();
            Emails = new List<Email>();
            
        }



        public List<LancamentoEvento> EventosDaOS { get; set; }
        public List<Modalidade> ModalidadeDaOS { get; set; }
        public List<Email> Emails { get; set; }
        public List<DocumentosAnexos> DocumentosAnexosDaOS { get; set; }
        public List<MotivoOS> MotivoAberturaOS { get; set; }
        public List<FollowUpOSCliente> FollowCliente { get; set; }


        public int IdOrdemServico { get; set; }

        [Display(ResourceType = typeof(Language), Name = "NumeroOS")]
        public string NumeroOS { get; set; }

        public int IdCliente { get; set; }
        public Cliente clienteOS { get; set; }

        [Display(ResourceType = typeof(Language), Name = "NivelDaOS")]
        public int NivelDaOS { get; set; }

        [Display(ResourceType = typeof(Language), Name = "NomeDocumento")]
        public string NomeDocumento { get; set; }

        [Display(ResourceType = typeof(Language), Name = "ReferenciaExemplo")]
        public string ReferenciaExemplo { get; set; }

        [Display(ResourceType = typeof(Language), Name = "DataVencimentoOS")]
        public DateTime DataVencimentoOS { get; set; }

        [Display(ResourceType = typeof(Language), Name = "ResponsavelConclusaoOS")]
        public Usuario ResponsavelConclusaoOS { get; set; }

        [Display(ResourceType = typeof(Language), Name = "DataConclusaoOS")]
        public DateTime DataConclusaoOS { get; set; }

        [Display(ResourceType = typeof(Language), Name = "DescricaoOS")]
        public string DescricaoOS { get; set; }

        [Display(ResourceType = typeof(Language), Name = "ObservacaoOS")]
        public string ObservacaoOS { get; set; }

        
        public int TipoDeContato { get; set; }

        [Display(ResourceType = typeof(Language), Name = "ResponsavelCriacao")]
        public string ResponsavelCriacao { get; set; }
    }

}   
