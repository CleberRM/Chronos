namespace br.com.Chronos.Entidade
{
    public class Modalidade : AEntidade
    {
        public Produto DescricaoProduto { get; set; }
        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }
            
    }
}
