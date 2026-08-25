using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Horario
    {
        [Display(Name = "Id Horario")]
        [Key] public int IdHorario { get; set; }
        [Required(ErrorMessage = "La hora de inicio es requerido.")]
        [Display(Name = "Hora Inicio")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime HoraInicio { get; set; }
        [Required(ErrorMessage = "La hora de finalización es requerido.")]
        [Display(Name = "Hora Fin")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime HoraFin { get; set; }
        public Calendario Calendario { get; set; }
        [Required(ErrorMessage = "La fecha del calendario es requerido.")]
        [Display(Name = "Fecha Calendario")]
        public int IdCalendario { get; set; }
        public Horario() { }
    }
}