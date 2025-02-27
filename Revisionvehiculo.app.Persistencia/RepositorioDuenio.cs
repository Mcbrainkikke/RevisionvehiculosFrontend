using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Persistencia
{
    public class RepositorioDuenio : IRepositorioDuenio
    {
        List<Duenio> duenios;

        public RepositorioDuenio()
        {
            duenios = new List<Duenio>()
            {
                new Duenio{Id=1,Nombre=" ",Apellido=" ",Telefono=" ",Ciudad=" ",Correo=" "}
                
            };
        }

        public Duenio AddDuenio(Duenio duenioNuevo)
        {
            duenioNuevo.Id = duenios.Max(h => h.Id) +1;
            duenios.Add(duenioNuevo);
            return duenioNuevo;
        }

        public void DeleteDuenio(int idDuenio)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Duenio>GetAll()
        {
            return duenios;
        }

        public Duenio GetDuenio(int IdDuenio)
        {
            return duenios.SingleOrDefault(s=>s.Id == IdDuenio);
        }

        public Duenio UpdateDuenio(Duenio duenioEditado)
        {            
            var duenioedit = duenios.SingleOrDefault(e => e.Id == duenioEditado.Id);
            if(duenioedit!=null)
            {
                duenioedit.Nombre = duenioEditado.Nombre;
                duenioedit.Apellido = duenioEditado.Apellido;
                duenioedit.Telefono = duenioEditado.Telefono;
                duenioedit.Ciudad = duenioEditado.Ciudad;
                duenioedit.Correo = duenioEditado.Correo;
            }
            return duenioedit;

        }
    }
}