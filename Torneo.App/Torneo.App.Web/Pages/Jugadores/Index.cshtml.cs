using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Frontend.Pages.Jugadores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public IEnumerable<Jugador> Jugadores { get; set; }
        public IndexModel(IRepositorioJugador repoJugador)
        {
            _repoJugador=repoJugador;
        }

        public void OnGet()
        {
            Jugadores=_repoJugador.GetAllJugador();
        }
    }
}
