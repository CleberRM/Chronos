using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace br.com.Chronos.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ANegocio<Usuario> _blUsuario;
        public HomeController(ANegocio<Usuario> blUsuario)
        {
            this._blUsuario = blUsuario;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}