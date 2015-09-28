using br.com.Chronos.Entidade;

namespace br.com.Chronos.Negocio
{
    public class BLModalidade : ANegocio<Modalidade>
    {
        public BLModalidade(IAcoesBanco<Modalidade>acoesbanco) : base(acoesbanco)
        {

        }
    }
}
