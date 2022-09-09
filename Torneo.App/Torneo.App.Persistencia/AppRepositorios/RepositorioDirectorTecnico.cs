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
        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoInsertado = _dataContext.DirectoresTecnicos.Add(directorTecnico);
            _dataContext.SaveChanges();
            return directorTecnicoInsertado.Entity;
        }
        public IEnumerable<DirectorTecnico> GetAllDirectoresTecnicos()
        {
            return _dataContext.DirectoresTecnicos;
        }

    }
}
