using System;
using System.Collections.Generic;
using System.Linq;
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
        public string NumeroOS { get; set; }

        public int IdCliente { get; set; }
        public Cliente clienteOS { get; set; }
        public int NivelDaOS { get; set; } 
        public string NomeDocumento { get; set; }
        public string ReferenciaExemplo { get; set; }
        public DateTime DataVencimentoOS { get; set; }
        public Usuario ResponsavelConclusaoOS { get; set; }
        public DateTime DataConclusaoOS { get; set; }
        public string DescricaoOS { get; set; }
        public string ObservacaoOS { get; set; }
        public int TipoDeContato { get; set; }
        public string ResponsavelCriacao { get; set; }
    }

}   
