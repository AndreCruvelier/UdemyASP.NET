using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Solution.FrameWork.Models.ViewModels
{
    public class ClienteCLS
    {
        [Display(Name = "Id Cliente")]
        public int iidcliente { get; set; }
        [Display(Name = "Nombre Cliente")]
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string appaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        public string apmaterno { get; set; }
        [Display(Name = "Email Cliente")]
        public string email { get; set; }
        [Display(Name = "Direccion Cliente")]
        public string direccion { get; set; }
        [Display(Name = "Género Cliente")]
        public int iidsexo { get; set; }
        [Display(Name = "Teléfono Cliente")]
        public string telefonofijo { get; set; }
        [Display(Name = "Celular Cliente")]
        public string telefonocelular { get; set; }
        public int bhabilitado { get; set; }
    }
}