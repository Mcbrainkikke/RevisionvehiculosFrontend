using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Persistencia
{
    public class RepositorioMecanico : IRepositorioMecanico
    {
         List<Mecanico> mecanicos;

        public RepositorioMecanico()
        {
            mecanicos = new List<Mecanico>()
            {
                new Mecanico{Id=1,Nombre=" ",Apellido=" ",Telefono=" ",Direccion=" ",NivelEstudios=" "}
                
            };
        }

        public Mecanico AddMecanico(Mecanico mecanicoNuevo)
        {
            mecanicoNuevo.Id = mecanicos.Max(h => h.Id) +1;
            mecanicos.Add(mecanicoNuevo);
            return mecanicoNuevo;
        }

        public void DeleteMecanico(int idMecanico)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mecanico>GetAllMecanicos()
        {
            return mecanicos;
        }

        public Mecanico GetMecanico(int IdMecanico)
        {
            return mecanicos.SingleOrDefault(a=>a.Id == IdMecanico);
        }

        public Mecanico UpdadteMecanico(Mecanico mecanicoEditado)
        {
             var mecanicoedit = mecanicos.SingleOrDefault(e => e.Id == mecanicoEditado.Id);
            if(mecanicoedit!=null)
            {
                mecanicoedit.Nombre = mecanicoEditado.Nombre;
                mecanicoedit.Apellido = mecanicoEditado.Apellido;
                mecanicoedit.Telefono = mecanicoEditado.Telefono;
                mecanicoedit.Direccion = mecanicoEditado.Direccion;
                mecanicoedit.NivelEstudios = mecanicoEditado.NivelEstudios;
            }
            return mecanicoedit;
        }

        /*public Mecanico UpdateMecanico(Mecanico mecanicoEditado)
        {            
           

        }*/

       
    }
}