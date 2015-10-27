using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System.Web.Mvc;

namespace br.com.Chronos.WebUI.Controllers
{
    public class EscritorioController : Controller
    {

        private ANegocio<Escritorio> _blEscritorio;
        public EscritorioController(ANegocio<Escritorio> blEscritorio)
        {
            _blEscritorio = blEscritorio;
        }


        // GET: Escritorio
        public ActionResult Index()
        {
            return View();
        }
    }
}