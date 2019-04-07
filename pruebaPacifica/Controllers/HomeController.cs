using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using pruebaPacifica.Models;
using System.IO;
using System.Text;
using System.Collections;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace pruebaPacifica.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            PacificaContext bd = new PacificaContext();
            

            return View(bd.Departamento.ToList());
        }
        [HttpGet]
        public string provinciasFiltro(int departament)
        {
           
            PacificaContext bd = new PacificaContext();
            bd.Configuration.ProxyCreationEnabled = false;
            //realizamos la consulta con LINQ to Entities
            var lst = bd.Provincia.Where(a => a.Id_departamento == departament).ToList();
            //creamos el Objeto para serializar
            JavaScriptSerializer serializer = new JavaScriptSerializer(null);
            //serializamos la lista de objetos devueltos de nuestra consulta realizada.
            string json = serializer.Serialize(lst);
            //devolvemos la cadena en formato JSON
            return json;
        
    }
        [HttpGet]
        public string distritoFiltro(int province)
        {
            PacificaContext bd = new PacificaContext();
            bd.Configuration.ProxyCreationEnabled = false;
            //realizamos la consulta con LINQ to Entities
            var lst = bd.Distrito.Where(a => a.Id_provincia == province).ToList();
            //creamos el Objeto para serializar
            JavaScriptSerializer serializer = new JavaScriptSerializer(null);
            //serializamos la lista de objetos devueltos de nuestra consulta realizada.
            string json = serializer.Serialize(lst);
            //devolvemos la cadena en formato JSON
            return json;

        }
/*
        public ActionResult Registro()
        {
            ViewBag.Message = "registro";

            return View();
        }
        public ActionResult Departament()
        {
            return View();
        }
*/
    }
}