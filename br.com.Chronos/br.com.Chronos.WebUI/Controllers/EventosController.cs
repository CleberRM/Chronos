using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;

namespace br.com.Chronos.WebUI.Controllers
{
    public class EventosController : Controller
    {

        private ANegocio<Evento> _blEventos;
        public EventosController(ANegocio<Evento> blEventos)
        {
            this._blEventos = blEventos;
        }
        // GET: Evento
        public ActionResult Index()
        {
            return View();
        }
    }
}