using CRUDPeopleMotion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace CRUDPeopleMotion.Controllers
{
    public class ProductoController : Controller
    {
        private BDPEOPLEMOTIONEntities db = new BDPEOPLEMOTIONEntities();
        // GET: Producto
        public ActionResult Index()
        {
            ViewBag.producto = db.PRODUCTO.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Crear()
        {
            ViewBag.producto = db.PRODUCTO.ToList();
            ViewBag.categorias = db.CATEGORIA.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Crear(PRODUCTO producto)
        {
            if (ModelState.IsValid)
            {
                db.PRODUCTO.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Si el modelo no es válido, regresa a la vista con el modelo para mostrar los mensajes de error.
            ViewBag.producto = db.PRODUCTO.ToList();
            ViewBag.categorias = db.CATEGORIA.ToList();
            return View(producto);
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var producto = db.PRODUCTO.Find(id);
            ViewBag.categorias = db.CATEGORIA.ToList();
            return View("Editar", producto);
        }

        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Editar(PRODUCTO product)
        {
           if (ModelState.IsValid)
            {
                db.Entry(product).State=EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           return View(product);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var producto = db.PRODUCTO.Find(id);
            db.PRODUCTO.Remove(producto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Detalles(int id)
        {
            PRODUCTO products = db.PRODUCTO.Find(id);
            return View("Detalles", products);
        }


    }
}