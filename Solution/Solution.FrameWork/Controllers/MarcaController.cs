using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Solution.FrameWork.Models;
using Solution.FrameWork.Models.ViewModels;

namespace Solution.FrameWork.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaCLS> listaMarca = null;
            //Creamos la conexión con la base de datos
            using (var bd = new BDPasajeEntities())
            {
                listaMarca = (from marca in bd.Marca
                              select new MarcaCLS
                              {
                                  //ClaseCLS = model.Dato
                                  iddmarca = marca.IIDMARCA,
                                  nombre = marca.NOMBRE,
                                  descripcion = marca.DESCRIPCION
                              }).ToList();
            }
            return View(listaMarca);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        //Método por como serán enviados los datos
        [HttpPost]
        public ActionResult Agregar(MarcaCLS marcaCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(marcaCLS);
            }
            else
            {
                using (var bd = new BDPasajeEntities())
                {
                    //Instanciamos el objeto marca
                    Marca marca = new Marca();
                    marca.NOMBRE = marcaCLS.nombre;
                    marca.DESCRIPCION = marcaCLS.descripcion;
                    marca.BHABILITADO = marcaCLS.bhabilitado;
                    //Enviamos los datos a la base de datos
                    bd.Marca.Add(marca);
                    //Guardamos los datos en la base de datos
                    bd.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}