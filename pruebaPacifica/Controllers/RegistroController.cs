using pruebaPacifica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pruebaPacifica.Controllers
{
    public class RegistroController : Controller
    {
        RegistroContext bd = new RegistroContext();
        // POST: Registro
        [HttpPost]
        public ActionResult Registrar(Registro r)
        {
          
            bd.Registro.Add(r);
            bd.SaveChanges();
            return View(bd.Registro.ToList());
        }
    }
}