using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Revisionvehiculo.app.Dominio
{
    public class Duenio
    {
        public int Id {get;set;}
        [Required, StringLength(50)]
        public string Nombre {get;set;}
        [Required, StringLength(50)]
        public string Apellido {get;set;}
        [Required, StringLength(50)]
        public string Telefono {get;set;}
        [Required, StringLength(50)]
        public string Ciudad {get;set;}
        [Required, StringLength(50)]
        [EmailAddress]
        public string Correo {get;set;}
        
    }
}