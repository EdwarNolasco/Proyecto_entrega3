using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "El primer nombre del estudiante es requerido.")]
        [Display(Name = "Primer Nombre")]
        public string Primernombre { get; set; }
        [Display(Name = " Segundo Nombre")]
        public string Segundonombre { get; set; }
        [Required(ErrorMessage = "El primer apellido del estudiante es requerido.")]
        [Display(Name = "Primer Apellido")]
        public string Primerapellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string Segundoapellido { get; set; }
        [Required(ErrorMessage = "La edad del estudiante es requerido.")]
        [Display(Name = "Edad")]
        public int Edad { get; set; }
        [Display(Name = "Teléfono")]
        public int Telefono { get; set; }
        [Display(Name = "Correo Eléctronico")]
        public string CorreoElectronico { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Género (M/F/Otro)")]
        public string Genero { get; set; }
        public Persona() { }
    }
}