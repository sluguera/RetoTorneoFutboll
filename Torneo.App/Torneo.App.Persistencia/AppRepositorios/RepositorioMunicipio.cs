using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia.AppRepositorios
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly DataContext _dataContext = new DataContext();
        #region Agregar un Municipio
        public Municipio AddMunicipio(Municipio municipio)
        {
            var municipioInsertado = _dataContext.Municipios.Add(municipio);
            _dataContext.SaveChanges();
            return municipioInsertado.Entity;
        }
        #endregion

        #region Consultar todos los municipios
        public IEnumerable<Municipio> GetAllMunicipios()
        {
            var municipios = _dataContext.Municipios
               .Include(m => m.Equipos)
               .ToList();
            return municipios;
        }
        #endregion

        #region Consultar un Municipio
        public Municipio GetMunicipio(int idMunicipio)
        {
            var municipioEncontrado = _dataContext.Municipios.Find(idMunicipio);
            return municipioEncontrado;
        }
        #endregion

        #region Actualizar un Municipio
        public Municipio UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado = _dataContext.Municipios.Find(municipio.Id);
            if (municipioEncontrado != null)
            {
                municipioEncontrado.Nombre = municipio.Nombre;
                _dataContext.SaveChanges();
            }
            return municipioEncontrado;
        }
        #endregion

        #region Borrar un Municipio
        public Municipio DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado = _dataContext.Municipios.Find(idMunicipio);
            if (municipioEncontrado != null)
            {
                _dataContext.Municipios.Remove(municipioEncontrado);
                _dataContext.SaveChanges();
            }
            return municipioEncontrado;
        }
        #endregion 
    }
}
