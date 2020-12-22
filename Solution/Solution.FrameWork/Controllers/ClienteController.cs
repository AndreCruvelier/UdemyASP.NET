using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Solution.FrameWork.Models;
using Solution.FrameWork.Models.ViewModels;

namespace Solution.FrameWork.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> listaCliente = null;
            using (var db = new BDPasajeEntities())
            {
                listaCliente = (from cliente in db.Cliente
                                where cliente.BHABILITADO == 1
                                select new ClienteCLS
                                {
                                    iidcliente = cliente.IIDCLIENTE,
                                    nombre = cliente.NOMBRE,
                                    appaterno = cliente.APPATERNO,
                                    apmaterno = cliente.APMATERNO,
                                    email = cliente.EMAIL,
                                    direccion = cliente.DIRECCION,
                                    telefonofijo = cliente.TELEFONOFIJO,
                                    telefonocelular = cliente.TELEFONOCELULAR
                                }).ToList();

            }
                return View(listaCliente);
        }
    }
}