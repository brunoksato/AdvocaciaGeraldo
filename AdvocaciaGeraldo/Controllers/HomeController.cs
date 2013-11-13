using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvocaciaGeraldo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "A Empresa";

            return View();
        }

        public ActionResult Atuacao()
        {
            ViewBag.Message = "Áreas de atuação";

            return View();
        }

        public ActionResult Equipe()
        {
            ViewBag.Message = "Equipe Profissional";

            return View();
        }

        public ActionResult Processo()
        {
            ViewBag.Message = "Processos";

            return View();
        }

        public ActionResult Acordo()
        {
            ViewBag.Message = "Acordos";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Contatos";

            return View();
        }
    }
}
