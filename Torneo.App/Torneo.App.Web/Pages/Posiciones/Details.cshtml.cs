using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Frontend.Pages.Posiciones
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPosicion _repoPosicion;
        public Posicion posicion { get; set; }
        
        public DetailsModel(IRepositorioPosicion repoPosicion)
        {
            _repoPosicion = (IRepositorioPosicion)repoPosicion;
        }

        public IActionResult OnGet(int id)
        {
            posicion = _repoPosicion.GetPosicion(id);
            if (posicion == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
