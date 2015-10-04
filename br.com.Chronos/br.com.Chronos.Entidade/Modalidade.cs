namespace br.com.Chronos.Entidade
{
    public class Modalidade : AEntidade
    {
        public string Descricao { get; set; }
        public int IdOrdemServico { get; set; }
        public virtual OrdemDeServico OrdemServico { get; set; }
    }
}
