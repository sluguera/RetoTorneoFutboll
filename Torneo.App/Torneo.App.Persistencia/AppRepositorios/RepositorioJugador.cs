using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly DataContext _dataContext = new DataContext();
        public Jugador AddJugador(Jugador jugador, int EquipoId, int PosicionId )
        {
            var equipoEncontrado = _dataContext.Equipos.Find(EquipoId);
            var posicionEncontrado = _dataContext.Posiciones.Find(PosicionId);
            jugador.Equipo = equipoEncontrado;
            jugador.Posicion = posicionEncontrado;
            var jugadorInsertado = _dataContext.Jugadores.Add(jugador);
            _dataContext.SaveChanges();
            return jugadorInsertado.Entity;
        }

        public IEnumerable<Jugador> GetAllJugadores()
        {
            var jugadores  = _dataContext.Jugadores
            .Include(e => e.Equipo )
            .Include(e => e.Posicion)
            .ToList();
            return jugadores;
        }

        //public Equipo GetEquipo(int idEquipo)
        //{
        //    var equipoEncontrado = _dataContext.Equipos
        //    .Where(e => e.Id == idEquipo)
        //    .Include(e => e.Municipio)
        //    .Include(e => e.DirectorTecnico)
        //    .FirstOrDefault();
        //    return equipoEncontrado;
        //}

        Jugador IRepositorioJugador.GetJugador(int idJugador)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Jugador> GetAllJugadores()
        //{
        //    return _dataContext.Jugadores;

        //}

        //public Jugador GetJugador(int idJugador)
        //{
        //    var jugadorEncontrado = _dataContext.Jugadores.Find(idJugador);
        //    return jugadorEncontrado;
        //}
    }
}
