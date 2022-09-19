using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Revisionvehiculo.app.Dominio;

namespace Revisionvehiculo.app.Persistencia
{
    public interface IRepositorioDuenio
    {
        //Obtiene todos los valores (dueños)
        IEnumerable<Duenio> GetAll();
        //Añade Dueños a la lista
        Duenio AddDuenio(Duenio duenioNuevo);   
        //Modifica datos de los dueños     
        Duenio UpdateDuenio(Duenio duenioEditado);
        //Borra la informacion del dueño
        void DeleteDuenio(int idDuenio);
        //obtiene los datos de un dueño especifico
        Duenio GetDuenio(int IdDuenio);
    } 
}