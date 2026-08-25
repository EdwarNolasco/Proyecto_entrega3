using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class PracticaProfesional
    {
        [Display(Name = "Id Práctica")]
        [Key] public int IdPractica { get; set; }
        [Required(ErrorMessage = "La fecha de inicio de la Práctica Profesional es requerido.")]
        [Display(Name = "Fecha Inicio")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "La fecha de finalización de la Práctica Profesional es requerido.")]
        [Display(Name = "Fecha Fin")]
        public DateTime FechaFin { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcionpractica { get; set; }
        public Estudiante Estudiante { get; set; }
        [Required(ErrorMessage = "El nombre del estudiante es requerido.")]
        [Display(Name = "Nombre Estudiante")]
        public int IdEstudiante { get; set; }
        public Supervisor Supervisor { get; set; }
        [Required(ErrorMessage = "El nombre del supervisor es requerido.")]
        [Display(Name = "Nombre Supervisor")]
        public int IdSupervisor { get; set; }
        public Area Area { get; set; }
        [Required(ErrorMessage = "El nombre del área de la empresa es requerido.")]
        [Display(Name = "Área Empresa")]
        public int IdArea { get; set; }
        public PracticaProfesional() { }
    }
}