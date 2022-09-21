using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Frontend.Pages
{
    public class ListVehiculoModel : PageModel
    {

        private readonly IRepositorioVehiculo RepositorioVehiculo;

        public IEnumerable<Vehiculo> Vehiculos { get; set; }

        public ListVehiculoModel(IRepositorioVehiculo RepositorioVehiculo)
        {
            this.RepositorioVehiculo = RepositorioVehiculo;
        }
        public void OnGet()
        {
            Vehiculos = RepositorioVehiculo.GetAllVehiculos();
        }
    }
}
