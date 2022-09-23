using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Frontend.Pages.Posiciones
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPosicion _repoPosicion;
        public IEnumerable<Posicion> posiciones{ get; set; }
        public bool ErrorEliminar { get; set; }

        public IndexModel(IRepositorioPosicion repoPosicion)
        {
            _repoPosicion = repoPosicion;
        }

        public void OnGet()
        {
            posiciones = _repoPosicion.GetAllPosiciones();
            ErrorEliminar = false;
/*
            foreach (var municipio in municipios)
            {
                Console.WriteLine(municipio.Nombre);
                foreach (var equipo in municipio.Equipos)
                {
                    Console.WriteLine("\t" + equipo.Nombre);
                }
            }
*/
        }

        public IActionResult OnPostDelete(int id)
        {
            try{
                _repoPosicion.DeletePosicion(id);
                posiciones = _repoPosicion.GetAllPosiciones();
                return Page();
            }
            catch (Exception ex){
                posiciones = _repoPosicion.GetAllPosiciones();
                ErrorEliminar = true;
                return Page();
            }
        }

    }

}
