using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisionvehiculo.app.Dominio
{
    public class Vehiculo
    {
         public int Id {get;set;}
        public string Placa {get;set;}
        public string Tipo {get;set;}
        public string Marca {get;set;}
        public string AnioModelo {get;set;}
        public string Capacidad {get;set;}
    }
}