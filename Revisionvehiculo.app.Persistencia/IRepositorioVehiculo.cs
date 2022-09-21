using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Revisionvehiculo.app.Dominio;

namespace Revisionvehiculo.app.Persistencia
{
    public interface IRepositorioVehiculo 
    {
        IEnumerable<Vehiculo> GetAllVehiculos();

        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculoEditado);
        void DeleteVehiculo(int idVehiculo);
        Vehiculo GetVehiculo(int IdVehiculo);
    }
}