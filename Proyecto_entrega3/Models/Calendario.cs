using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Calendario
    {
        [Display(Name = "Id Calendario")]
        [Key] public int IdCalendario { get; set; }
        [Required(ErrorMessage = "La fecha del calendario es requerido.")]
        [Display(Name = "Fecha")]
        public DateTime fechacalendario { get; set; }
        [Required(ErrorMessage = "El tipo de día es requerido.")]
        [Display(Name = "Tipo de día (Laboral/Feriado/Libre")]
        public string tipodia { get; set; }
        [Display(Name = "Descripción")]
        public string descripcioncalen { get; set; }
        public Calendario() { }
    }
}