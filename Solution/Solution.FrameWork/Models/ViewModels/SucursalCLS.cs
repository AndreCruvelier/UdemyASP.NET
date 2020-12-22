using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Solution.FrameWork.Models.ViewModels
{
    public class SucursalCLS
    {
        [Display(Name = "Id Sucursal")]
        public int iidsucursal { get; set; }
        [Display(Name = "Nombre Sucursal")]
        public string nombre { get; set; }
        [Display(Name = "Teléfono Surcursal")]
        public string telefono { get; set; }
        [Display(Name = "Email Sucursal")]
        public string email { get; set; }
        public DateTime fechaapertura { get; set; }
        public int bhabilitado { get; set; }
    }
}