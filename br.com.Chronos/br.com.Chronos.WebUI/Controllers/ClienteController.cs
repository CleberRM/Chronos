using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using br.com.Chronos.Negocio;
using br.com.Chronos.Entidade;

namespace br.com.Chronos.WebUI.Controllers
{
    public class ClienteController : Controller
    {
        private ANegocio<Cliente> _blCliente;
        public ClienteController(ANegocio<Cliente> blCliente)
        {
            this._blCliente = blCliente;
        } 

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
    }
}