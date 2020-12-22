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
    }
}