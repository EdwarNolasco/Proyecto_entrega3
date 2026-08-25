using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Carrera
    {
        [Display(Name = "Id Carrera")]
        [Key] public int IdCarrera { get; set; }
        [Required(ErrorMessage = "El nombre de la carrera es requerido.")]
        [Display(Name = "Nombre")]
        public string Nombrecarrera { get; set; }
        [Required(ErrorMessage = "La duración en años de la carrera es requerido.")]
        [Display(Name = "Duración (años)")]
        public int Duracion { get; set; }
        public Carrera() { }
    }
}