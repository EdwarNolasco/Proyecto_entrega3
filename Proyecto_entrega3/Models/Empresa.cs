using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Empresa
    {
        [Display(Name = "Id Empresa")]
        [Key] public int IdEmpresa { get; set; }
        [Required(ErrorMessage = "El nombre de la empresa es requerido.")]
        [Display(Name = "Nombre")]
        public string nombreempresa { get; set; }
        [Display(Name = "Teléfono")]
        public int telefonoempresa { get; set; }
        [Display(Name = "Correo Electrónico")]
        public string correoempresa { get; set; }
        [Display(Name = "Dirección")]
        public string direccionempresa { get; set; }
        public Empresa() { }
    }
}