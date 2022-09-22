using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public  class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly DataContext _dataContext = new DataContext();

        public DirectorTecnico AddDT(DirectorTecnico directorTecnico)
        {
            var dtInsertado = _dataContext.DirectoresTecnicos.Add(directorTecnico);
            _dataContext.SaveChanges();
            return dtInsertado.Entity;
        }

        public IEnumerable<DirectorTecnico> GetAllDTs()
        {
            return _dataContext.DirectoresTecnicos;
        }

        public DirectorTecnico GetDT(int idDT)
        {
            var dtEncontrado = _dataContext.DirectoresTecnicos.Find(idDT);
            return dtEncontrado;
        }

        public DirectorTecnico UpdateDT(DirectorTecnico dt)
        {
            var dtEncontrado = _dataContext.DirectoresTecnicos.Find(dt.Id);
            if (dtEncontrado != null)
            {
                dtEncontrado.Nombre = dt.Nombre;
                dtEncontrado.Documento = dt.Documento;
                dtEncontrado.Telefono = dt.Telefono;
                _dataContext.SaveChanges();
            }
            return dtEncontrado;
        }

    }
}