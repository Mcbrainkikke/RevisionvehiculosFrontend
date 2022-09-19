using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Revisionvehiculo.app.Dominio;

namespace Revisionvehiculo.app.Persistencia
{
    public interface IRepositorioDuenio
    {
        IEnumerable<Duenio> GetAll();
        Duenio AddDuenio(Duenio duenio);
        //Duenio UpdateDuenio(Duenio duenioEditado);
        Duenio UpdateDuenio(Duenio duenioEditado);
        void DeleteDuenio(int idDuenio);
        Duenio GetDuenio(int IdDuenio);
    } 
}