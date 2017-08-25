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
    public class EntradasRepository : IEntradasRepository
    {
        public Entradas Create(Entradas entrada)
        {
            return ApplicationDbContext.applicationDbContext.entradas.Add(entrada);
        }

        public Entradas Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.entradas.Find(id);
        }

        public IQueryable<Entradas> Get()
        {
            IList<Entradas> lista = new List<Entradas>(ApplicationDbContext.applicationDbContext.entradas);

            return lista.AsQueryable();
        }


        public void Put(Entradas entrada)
        {
            if (ApplicationDbContext.applicationDbContext.entradas.Count(e => e.id == entrada.id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(entrada).State = EntityState.Modified;
        }

        public Entradas Delete(long id)
        {
            Entradas entrada = ApplicationDbContext.applicationDbContext.entradas.Find(id);
            if (entrada == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.entradas.Remove(entrada);
            return entrada;
        }
    }
}