using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Frontend.Pages
{
    public class EditMecanicoModel : PageModel
    {
        private readonly IRepositorioMecanico RepositorioMecanico;
        [BindProperty]

        public Mecanico Mecanico {get;set;}

        public EditMecanicoModel(IRepositorioMecanico RepositorioMecanico)
        {
            this.RepositorioMecanico = RepositorioMecanico;
        }
        public IActionResult OnGet(int? IdMecanico)
        {
            if(IdMecanico.HasValue)
            {
            Mecanico = RepositorioMecanico.GetMecanico(IdMecanico.Value);
            }
            else 
            {            
                Mecanico = new Mecanico();
            }

            if(Mecanico == null)
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
            if(Mecanico.Id > 0 )
            {
                Mecanico = RepositorioMecanico.UpdadteMecanico(Mecanico);
            }
            else
            {
                RepositorioMecanico.AddMecanico(Mecanico);
            }
            return Page();
        }
    }
}
