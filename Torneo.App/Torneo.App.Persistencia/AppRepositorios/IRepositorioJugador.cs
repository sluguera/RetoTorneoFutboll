using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioJugador
    {
        public Jugador AddJugador(Jugador jugador, int idEquipo, int idPosicion);
        public IEnumerable<Jugador> GetAllJugador();
        public Jugador GetJugador(int idJugador);
        public Jugador UpdateJugador(Jugador jugador, int idEquipo, int idPosicion);
    }
}
