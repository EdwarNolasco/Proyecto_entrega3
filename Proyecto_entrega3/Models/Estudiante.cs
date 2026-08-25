using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Estudiante:Persona
    {
        [Display(Name = "Id Estudiante")]
        [Key] public int IdEstudiante { get; set; }
        public Estudiante() { }
    }
}