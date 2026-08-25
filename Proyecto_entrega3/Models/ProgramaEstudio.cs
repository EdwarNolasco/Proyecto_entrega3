using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class ProgramaEstudio
    {
        [Display(Name = "Id Programa Estudio")]
        [Key] public int IdProgramaEstudio { get; set; }
        [Required(ErrorMessage = "El nombre del programa de estudio es requerido.")]
        [Display(Name = "Nombre")]
        public string Nombreprograes { get; set; }
        [Display(Name = "Nivel (Básico/Intermedio/Avanzado)")]
        public string Nivel { get; set; }
        [Display(Name = "Facultad")]
        public string Facultad { get; set; }
        [Display(Name = "Duración (Meses)")]
        public int Duracionprograes { get; set; }
        public Estudiante Estudiante { get; set; }
        [Required(ErrorMessage = "El nombre del estudiante es requerido.")]
        [Display(Name = "Nombre Estudiante")]
        public int IdEstudiante { get; set; }
        public ProgramaEstudio() { }
    }
}