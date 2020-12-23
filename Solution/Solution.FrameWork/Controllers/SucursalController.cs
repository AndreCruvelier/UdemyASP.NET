using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Solution.FrameWork.Models;
using Solution.FrameWork.Models.ViewModels;

namespace Solution.FrameWork.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            List<SucursalCLS> listaSucursal = null;
            using (var db = new BDPasajeEntities())
            {
                listaSucursal = (from sucursal in db.Sucursal
                                 where sucursal.BHABILITADO == 1
                                 select new SucursalCLS
                                 {
                                     iidsucursal = sucursal.IIDSUCURSAL,
                                     nombre = sucursal.NOMBRE,
                                     telefono = sucursal.TELEFONO,
                                     email = sucursal.EMAIL
                                 }).ToList();
            }
            return View(listaSucursal);
        }

        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(SucursalCLS sucursalCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(sucursalCLS);
            }
            else
            {
                using (var db = new BDPasajeEntities())
                {
                    Sucursal sucursal = new Sucursal();
                    sucursal.NOMBRE = sucursalCLS.nombre;
                    sucursal.DIRECCION = sucursalCLS.direccion;
                    sucursal.TELEFONO = sucursalCLS.telefono;
                    sucursal.EMAIL = sucursalCLS.email;
                    sucursal.FECHAAPERTURA = sucursalCLS.fechaapertura;
                    sucursal.BHABILITADO = 1;
                    db.Sucursal.Add(sucursal);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}