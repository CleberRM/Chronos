using br.com.Chronos.Negocio;
using br.com.Chronos.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace br.com.Chronos.WebUI.Controllers
{
    public class OrdemDeServicoController : Controller
    {

        private ANegocio<OrdemDeServico> _blOrdemDeServico;
        public OrdemDeServicoController(ANegocio<OrdemDeServico> blOrdemDeServico)
        {
            this._blOrdemDeServico = blOrdemDeServico;
        }
        
        // GET: OrdemDeServico 
        public ActionResult Index()
        {
            return View();
        }
    }
}