using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class SolicitudPractica
    {
        [Display(Name = "Id Solicitud Practica")]
        [Key] public int IdSolicitud { get; set; }
        [Required(ErrorMessage = "La fecha de la Solicitud de Práctica es requerido.")]
        [Display(Name = "Fecha Solicitud")]
        public DateTime FechaSolicitud { get; set; }
        [Required(ErrorMessage = "El estado de la Solicitud de Práctica es requerido.")]
        [Display(Name = "Estado(Aprobada/Denegada/Espera)")]
        public string EstadoSolicitud { get; set; }
        [Display(Name = "Fecha Inicio")]
        public DateTime FechaInicio { get; set; }
        [Display(Name = "Fecha Fin")]
        public DateTime FechaFin { get; set; }
        [Display(Name = "Observaciones")]
        public string ObservacionesSolicitud { get; set; }
        public Estudiante Estudiante { get; set; }
        [Required(ErrorMessage = "El nombre del estudiante es requerido.")]
        [Display(Name = "Nombre Estudiante")]
        public int IdEstudiante { get; set; }
        public Empresa Empresa { get; set; }
        [Required(ErrorMessage = "El nombre de la empresa es requerido.")]
        [Display(Name = "Nombre Empresa")]
        public int IdEmpresa { get; set; }
        public SolicitudPractica() { }
    }
}