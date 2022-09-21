using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Frontend.Pages
{
    public class DetailsMecanicosModel : PageModel
    {
        private readonly IRepositorioMecanico RepositorioMecanico;

        public Mecanico Mecanico {get;set;}

        public DetailsMecanicosModel(IRepositorioMecanico RepositorioMecanico)
        {
            this.RepositorioMecanico = RepositorioMecanico;
        }
   

        public IActionResult OnGet(int idMecanico)
        {
            Mecanico = RepositorioMecanico.GetMecanico(idMecanico);
            if(Mecanico == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
        
    }
}
