using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisionvehiculo.app.Dominio
{
    public class Mecanico
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Telefono {get;set;}
        public string Direccion {get;set;}
        public string NivelEstudios {get;set;}
    }
}