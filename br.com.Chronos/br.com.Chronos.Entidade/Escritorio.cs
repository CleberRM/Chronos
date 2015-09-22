using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.Entidade
{
    public class Escritorio : AEntidade
    {
        public int Cnpj { get; set; }
        public int InscricaoEstadual { get; set; }
        public int InscricaoMunicipal { get; set; }
        public string NomeEscritorio { get; set; }
        public string NomeFantasia { get; set; }
        public string Sigla { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int Telefone { get; set; }
        public int Fax { get; set; }
        public string Site { get; set; }
    }
}