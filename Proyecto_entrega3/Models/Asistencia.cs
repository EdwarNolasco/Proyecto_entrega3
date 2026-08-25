using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Asistencia
    {
        [Display(Name = "Id Asistencia")]
        [Key] public int IdAsistencia { get; set; }
        [Display(Name = "Observaciones")]
        public string observacionesasis { get; set; }
        public Estudiante Estudiante { get; set; }
        [Required(ErrorMessage = "El nombre del estudiante es requerido.")]
        [Display(Name = "Nombre estudiante")]
        public int IdEstudiante { get; set; }
        public Calendario Calendario { get; set; }
        [Required(ErrorMessage = "La fecha del calendario es requerido.")]
        [Display(Name = "Fecha Calendario")]
        public int IdCalendario { get; set; }
        public Asistencia() { }
    }
}