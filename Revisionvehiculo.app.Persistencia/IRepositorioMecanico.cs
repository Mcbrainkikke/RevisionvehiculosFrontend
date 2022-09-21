using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Revisionvehiculo.app.Dominio;

namespace Revisionvehiculo.app.Persistencia
{
    public interface IRepositorioMecanico
    {
        IEnumerable<Mecanico> GetAllMecanicos();

        Mecanico AddMecanico(Mecanico mecanico);
        Mecanico UpdadteMecanico(Mecanico mecanicoEditado);
        void DeleteMecanico(int idMecanico);
        Mecanico GetMecanico(int IdMecanico);
    }
}