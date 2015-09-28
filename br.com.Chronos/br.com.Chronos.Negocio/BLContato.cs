using br.com.Chronos.Entidade;

namespace br.com.Chronos.Negocio
{
    public class BLContato :ANegocio<Contato>
    {
        public BLContato(IAcoesBanco<Contato>acoesbanco) : base(acoesbanco)
        {

        }
    }
}
