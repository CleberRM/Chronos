using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace br.com.Chronos.WebUI.Controllers
{
    public class SetorController : Controller
    {
        private ANegocio<Setor> _blSetor;
        public SetorController(ANegocio<Setor> blSetor)
        {
            this._blSetor = blSetor;
        }

        // GET: Setor
        public ActionResult Index()
        {
            return View();
        }
    }
}