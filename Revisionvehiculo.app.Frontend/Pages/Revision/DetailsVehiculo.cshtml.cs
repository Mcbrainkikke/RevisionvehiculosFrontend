using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Persistencia;
using Revisionvehiculo.app.Dominio;

namespace Revisionvehiculo.app.Frontend.Pages
{
    public class DetailsVehiculoModel : PageModel
    {private readonly IRepositorioVehiculo RepositorioVehiculo;

        public Vehiculo Vehiculo {get;set;}

        public DetailsVehiculoModel(IRepositorioVehiculo RepositorioVehiculo)
        {
            this.RepositorioVehiculo = RepositorioVehiculo;
        }
   

        public IActionResult OnGet(int IdVehiculo)
        {
            Vehiculo = RepositorioVehiculo.GetVehiculo(IdVehiculo);
            if(Vehiculo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
