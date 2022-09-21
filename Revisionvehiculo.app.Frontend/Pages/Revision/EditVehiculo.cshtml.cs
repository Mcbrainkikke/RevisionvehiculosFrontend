using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Pages
{
    public class EditVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo RepositorioVehiculo;
        [BindProperty]

        public Vehiculo Vehiculo {get;set;}

        public EditVehiculoModel(IRepositorioVehiculo RepositorioVehiculo)
        {
            this.RepositorioVehiculo = RepositorioVehiculo;
        }
        public IActionResult OnGet(int? IdVehiculo)
        {
            if(IdVehiculo.HasValue)
            {
            Vehiculo = RepositorioVehiculo.GetVehiculo(IdVehiculo.Value);
            }
            else 
            {            
                Vehiculo = new Vehiculo();
            }

            if(Vehiculo == null)
            {
                return RedirectToPage("./NotFound"); 
            }
            else
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Vehiculo.Id > 0 )
            {
                Vehiculo = RepositorioVehiculo.UpdateVehiculo(Vehiculo);
            }
            else
            {
                RepositorioVehiculo.AddVehiculo(Vehiculo);
            }
            return Page();
        }
    }
}
