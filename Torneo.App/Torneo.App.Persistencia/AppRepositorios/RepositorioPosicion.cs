﻿using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public class RepositorioPosicion : IRepositorioPosicion
    {
        private readonly DataContext _dataContext = new DataContext();

        public Posicion AddPosicion(Posicion posicion)
        {
            var PosicionInsertado = _dataContext.Posiciones.Add(posicion);
            _dataContext.SaveChanges();
            return PosicionInsertado.Entity;
        }
        public IEnumerable<Posicion> GetAllPosiciones()
        {
            return _dataContext.Posiciones;
        }
        public Posicion GetPosicion(int idPosicion)
        {
            var posicionEncontrado = _dataContext.Posiciones.Find(idPosicion);
            return posicionEncontrado;
        }
        public Posicion UpdatePosicion(Posicion posicion)
        {
            var posicionEncontrado = _dataContext.Posiciones.Find(posicion.Id);
            if (posicionEncontrado != null)
            {
                posicionEncontrado.Nombre = posicion.Nombre;
                _dataContext.SaveChanges();
            }
            return posicionEncontrado;
        }
        public Posicion DeletePosicion(int idPosicion)
        {
            var posicionEncontrado = _dataContext.Posiciones.Find(idPosicion);
            if (posicionEncontrado != null)
            {
                _dataContext.Posiciones.Remove(posicionEncontrado);
                _dataContext.SaveChanges();
            }
            return posicionEncontrado;
        }
    }
}
