using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_entrega3.Models
{
    public class Supervisor:Persona
    {
        [Display(Name = "Id Supervisor")]
        [Key] public int IdSupervisor { get; set; }

        public Supervisor() { }
    }
}