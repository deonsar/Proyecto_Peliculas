using Proyecto_Peliculas.Exceptions;
using Proyecto_Peliculas.Modelos;
using Proyecto_Peliculas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto_Peliculas.Repository
{
    public class PeliculasRepository : IPeliculasRepository
    {
        public Peliculas Create(Peliculas pelicula)
        {
            return ApplicationDbContext.applicationDbContext.peliculas.Add(pelicula);
        }

        public Peliculas Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.peliculas.Find(id);
        }

        public IQueryable<Peliculas> Get()
        {
            IList<Peliculas> lista = new List<Peliculas>(ApplicationDbContext.applicationDbContext.peliculas);

            return lista.AsQueryable();
        }


        public void Put(Peliculas pelicula)
        {
            if (ApplicationDbContext.applicationDbContext.peliculas.Count(e => e.id == pelicula.id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(pelicula).State = EntityState.Modified;
        }

        public Peliculas Delete(long id)
        {
            Peliculas pelicula = ApplicationDbContext.applicationDbContext.peliculas.Find(id);
            if (pelicula == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.peliculas.Remove(pelicula);
            return pelicula;
        }

    }
}