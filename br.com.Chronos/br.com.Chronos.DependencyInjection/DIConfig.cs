using br.com.Chronos.AcessoDados;
using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using SimpleInjector;

namespace br.com.Chronos.DependencyInjection
{
    public class DIConfig
    {
        public Container ConfigurarDI()
        {
            Container container = new Container();
            container.Register<IAcoesBanco<Usuario>, ADUsuario>();
            container.Register<IAcoesBanco<LancamentoEvento>, ADLancamentoEvento>();
            container.Register<IAcoesBanco<MensagemDados>, ADMensagemDados>();
            container.Register<IAcoesBanco<OrdemDeServico>, ADOrdemDeServico>();
            container.Register<IAcoesBanco<Setor>, ADSetor>();

            return container;
        }
    }
}
