using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class HistorialPracticas:PracticaProfesional
    {
        [Display(Name = "Id Historial")]
        [Key] public int IdHistorial { get; set; }
        [Required(ErrorMessage = "El número de prácticas realizadas es requerido.")]
        [Display(Name = "No. Prácticas Realizadas")]
        public int totalpracticas { get; set; }

        public HistorialPracticas() { }
    }
}