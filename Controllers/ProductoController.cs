using CRUDPeopleMotion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDPeopleMotion.Controllers
{
    public class ProductoController : Controller
    {
        private BDPEOPLEMOTIONEntities1 db = new BDPEOPLEMOTIONEntities1();
        // GET: Producto
        public ActionResult Index()
        {
            ViewBag.producto = db.PRODUCTO.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Add(PRODUCTO producto)
        {
            db.PRODUCTO.Add(producto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}