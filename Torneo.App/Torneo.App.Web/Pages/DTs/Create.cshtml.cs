using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Frontend.Pages.DTs
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDT;
        public DirectorTecnico dt {get; set;}

        public CreateModel(IRepositorioDirectorTecnico repoDT)
        {
            _repoDT = repoDT;
        }

        public void OnGet()
        {
            dt = new DirectorTecnico();
        }

        public IActionResult OnPost(DirectorTecnico dt)
        {
            if(ModelState.IsValid)
            {
                _repoDT.AddDT(dt);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
