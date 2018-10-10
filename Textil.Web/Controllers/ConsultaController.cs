using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Textil.Web.Database;
using Textil.Web.Models;

namespace Textil.Web.Controllers
{
    public class ConsultaController : Controller
    {
        Operacoes oper = Operacoes.Instance;
        // GET: Consulta
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult ConsultaTecido(Tecido tecido)
        {
            var consulta = oper.Consultar(tecido);
            return View(consulta);
        }
    }
}