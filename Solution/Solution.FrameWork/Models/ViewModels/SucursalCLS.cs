﻿using System;
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
        [Required]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        public string nombre { get; set; }
        [Display(Name = "Dirección")]
        [Required]
        [StringLength(200, ErrorMessage = "Longitud máxima 200")]
        public string direccion { get; set; }
        [Display(Name = "Teléfono Surcursal")]
        [Required]
        [StringLength(10, ErrorMessage = "Longitud máxima 10")]
        public string telefono { get; set; }
        [Display(Name = "Email Sucursal")]
        [Required]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [EmailAddress(ErrorMessage = "Ingresar un email valido")]
        public string email { get; set; }
        [Display(Name = "Fecha Apertura")]
        [Required]
        [DataType(DataType.Date)]
        //Formato de la fecha
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime fechaapertura { get; set; }
        public int bhabilitado { get; set; }
    }
}