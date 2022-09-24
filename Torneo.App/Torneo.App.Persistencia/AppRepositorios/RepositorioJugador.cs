﻿using Microsoft.EntityFrameworkCore;
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

        public Jugador AddJugador(Jugador jugador, int idEquipo, int idPosicion)
        {
            var equipoEncontrado = _dataContext.Equipos.Find(idEquipo);
            var posicionEncontrado = _dataContext.Posiciones.Find(idPosicion);
            jugador.Equipo = equipoEncontrado;
            jugador.Posicion = posicionEncontrado;
            var jugadorInsertado = _dataContext.Jugadores.Add(jugador);
            _dataContext.SaveChanges();
            return jugadorInsertado.Entity;
        }

        public IEnumerable<Jugador> GetAllJugador()
        {
            var jugador = _dataContext.Jugadores
                .Include(e => e.Equipo)
                .Include(e => e.Posicion)
                .ToList();
            return jugador;
        }
        public Jugador GetJugador(int idJugador)
        {
            var jugadorEncontrado = _dataContext.Jugadores
            .Where(e => e.Id == idJugador)
            .Include(e => e.Equipo)
            .Include(e => e.Posicion)
            .FirstOrDefault();
            return jugadorEncontrado;
        }

        public Jugador UpdateJugador(Jugador jugador, int idEquipo, int idPosicion)
        {
            var jugadorEncontrado = GetJugador(jugador.Id);
            var equipoEncontrado = _dataContext.Equipos.Find(idEquipo);
            var posicionEncontrado = _dataContext.Posiciones.Find(idPosicion);
            jugadorEncontrado.Nombre = jugador.Nombre;
            jugadorEncontrado.Numero = jugador.Numero;
            jugadorEncontrado.Equipo = equipoEncontrado;
            jugadorEncontrado.Posicion = posicionEncontrado;
            _dataContext.SaveChanges();
            return jugadorEncontrado;
        }
    }
}
