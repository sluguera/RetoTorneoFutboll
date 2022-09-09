using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext();
        //public Partido AddPartido(Partido partido)
        //{
        //    var partidoInsertado = _dataContext.Partidos.Add(partido);
        //    _dataContext.SaveChanges();
        //    return partidoInsertado.Entity;
        //}

        public Partido AddPartido(Partido partido, int LocalId, int VisitanteId)
        {
            var equipoLocalIdEncontrado     = _dataContext.Equipos.Find(LocalId);
            var equipoVisitanteIdEncontrado = _dataContext.Equipos.Find(VisitanteId);
            partido.Local = equipoLocalIdEncontrado;
            partido.Visitante = equipoVisitanteIdEncontrado;
            //partido.MarcadorLocal = MarcadorLocal;
            //partido.MarcadorVisitante = MarcadorVisitante;
            var partidoInsertado = _dataContext.Partidos.Add(partido);
            _dataContext.SaveChanges();
            return partidoInsertado.Entity;
        }

        public IEnumerable<Partido> GetAllPartidos()
        {
            var Partidos = _dataContext.Partidos
            .Include(e => e.Local   )
            .Include(e => e.Visitante)
            .ToList();
            return Partidos;
        }


        public Partido GetPartido(int idPartido)
        {
            throw new NotImplementedException();
        }
    }
}
