using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Solution.FrameWork.Models.ViewModels
{
    public class MarcaCLS
    {
        [Display(Name = "Id Marca")]
        public int iddmarca { get; set; }
        [Display(Name = "Nombre Marca")]
        [Required]
        [StringLength(100, ErrorMessage = "La longitud máxima es 100")]
        public string nombre { get; set; }
        [Display(Name = "Descripción Marca")]
        [Required]
        [StringLength(200, ErrorMessage = "La longitud máxima es 200")]
        public string descripcion { get; set; }
        public  int bhabilitado { get; set; }
    }
}