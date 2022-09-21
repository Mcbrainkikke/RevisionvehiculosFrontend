using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;



namespace Revisionvehiculo.app.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        
         List<Vehiculo> vehiculos;

        public RepositorioVehiculo()
        {
            vehiculos = new List<Vehiculo>()
            {
                new Vehiculo{Id=1,Placa=" ",Tipo=" ",Marca=" ",AnioModelo=" ",Capacidad=" "}
                
            };
        }

        public Vehiculo AddVehiculo(Vehiculo vehiculoNuevo)
        {
            vehiculoNuevo.Id = vehiculos.Max(h => h.Id) +1;
            vehiculos.Add(vehiculoNuevo);
            return vehiculoNuevo;
        }

        public void DeleteVehiculo(int idMecanico)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehiculo>GetAllVehiculos()
        {
            return vehiculos;
        }

        public Vehiculo GetVehiculo(int IdVehiculo)
        {
            return vehiculos.SingleOrDefault(a=>a.Id == IdVehiculo);
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculoEditado)
        {
             var vehiculoedit = vehiculos.SingleOrDefault(e => e.Id == vehiculoEditado.Id);
            if(vehiculoedit!=null)
            {
                vehiculoedit.Placa = vehiculoEditado.Placa;
                vehiculoedit.Tipo = vehiculoEditado.Tipo;
                vehiculoedit.Marca = vehiculoEditado.Marca;
                vehiculoedit.AnioModelo = vehiculoEditado.AnioModelo;
                vehiculoedit.Capacidad = vehiculoEditado.Capacidad;
            }
            return vehiculoedit;
        }
    }
}