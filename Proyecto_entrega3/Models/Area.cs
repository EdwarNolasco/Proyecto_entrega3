using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Area
    {
        [Display(Name = "Id Área")]
        [Key] public int IdArea { get; set; }
        [Required(ErrorMessage = "El nombre del área es requerido.")]
        [Display(Name = "Nombre")]
        public string Nombrearea { get; set; }
        [Display(Name = "Descripción:")]
        public string Descripcionarea { get; set; }
        public Area() { }
    }
}