using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Asignatura
    {
        [Display(Name = "Id Asignatura")]
        [Key] public int IdAsignatura { get; set; }
        [Required(ErrorMessage = "El nombre de la asignatura es requerido.")]
        [Display(Name = "Nombre")]
        public string Nombreasig { get; set; }
        [Required(ErrorMessage = "El estado de la asignatura es requerido.")]
        [Display(Name = "Estado (Aprobado/Reprobado)")]
        public string Estadoasig { get; set; }
        public Carrera Carrera { get; set; }
        [Required(ErrorMessage ="El nombre de la carrera es requerido.")]
        [Display(Name = "Nombre Carrera")]
        public int IdCarrera { get; set; }
        public Estudiante Estudiante { get; set; }
        [Required(ErrorMessage = "El nombre del estudiante es requerido.")]
        [Display(Name = "Nombre Estudiante")]
        public int IdEstudiante { get; set; }
        public Asignatura() { }
    }
}