using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Textil.Web.Database;
using Textil.Web.Models;

namespace Textil.Web.Controllers
{
    public class CadastroController : Controller
    {
        Operacoes oper = Operacoes.Instance;

        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastraTecido(Tecido tecido)
        {
            oper.Adicionar(tecido);

            return View(tecido);
        }
    }
}