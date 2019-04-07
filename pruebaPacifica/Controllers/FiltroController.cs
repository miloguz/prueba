using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pruebaPacifica.Models;


namespace pruebaPacifica.Controllers
{
    public class FiltroController : Controller
    {
        // GET: Filtro
        public ActionResult Index()
        {
            PacificaContext bd = new PacificaContext();
           
            return View(bd.Departamento.ToList());
        }
    }
}