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
            EmailsEnviadosOS = new List<MensagemDados>();
            EmailsRecebidosOS = new List<MensagemDados>();
        }

        public string NumeroOS { get; set; }
        public Cliente clienteOS { get; set; }
        public List<LancamentoEvento> EventosDaOS { get; set; }
        private List<Modalidade> ModalidadeDaOS { get; set; }
        private List<MensagemDados> EmailsEnviadosOS { get; set; }
        private List<MensagemDados> EmailsRecebidosOS { get; set; }
        public int NivelDaOS { get; set; } 
        public string NomeDocumento { get; set; }
        public string ReferenciaExemplo { get; set; }
        public DateTime DataVencimentoOS { get; set; }
        public Usuario ResponsavelConclusaoOS { get; set; }
        public DateTime DataConclusaoOS { get; set; }
        public List<DocumentosAnexos> DocumentosAnexosDaOS { get; set; }
        private List<MotivoOS> MotivoAberturaOS { get; set; }
        private List<FollowUpOSCliente> FollowCliente { get; set; }
        public string DescricaoOS { get; set; }
        public string ObservacaoOS { get; set; }
        public int TipoDeContato { get; set; }
    }

}   
