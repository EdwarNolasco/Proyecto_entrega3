using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Periodo
    {
        [Display(Name = "Id Periodo")]
        [Key] public int IdPeriodo { get; set; }
        [Required(ErrorMessage = "El número de período del año es requerido.")]
        [Display(Name = "Número Período")]
        public int NumeroPeriodo { get; set; }
        [Required(ErrorMessage = "La fecha de inicio del período es requerido.")]
        [Display(Name = "Inicio Período")]
        public DateTime InicioPeriodo { get; set; }
        [Required(ErrorMessage = "La fecha de finalización del período es requerido.")]
        [Display(Name = "Fin Período")]
        public DateTime FinPeriodo { get; set; }
        public Estudiante Estudiante { get; set; }
        [Required(ErrorMessage = "El nombre del estudiante es requerido.")]
        [Display(Name = "Nombre Estudiante")]
        public int IdEstudiante { get; set; }
        public Periodo() { }
    }
}