namespace br.com.Chronos.Entidade
{
    public class Modalidade : AEntidade
    {
        public int IdModalidade { get; set; }

        public int IdProduto { get; set; }
        public virtual Produto DescricaoProduto { get; set; }

        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }

        public string ResponsavelCriacao { get; set; }
    }
}
