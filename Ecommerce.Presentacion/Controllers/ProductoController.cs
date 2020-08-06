using Ecommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace Ecommerce.Presentacion.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            //HttpClient clienteHttp = new HttpClient();
            return View();
        }
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(ProductoDTO producto)
        {
            return View();
        }
    }
}