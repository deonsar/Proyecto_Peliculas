using Proyecto_Peliculas.Modelos;
using Proyecto_Peliculas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Peliculas.Service
{
    public class PeliculasService : IPeliculasService
    {
        private IPeliculasRepository PeliculasRepository;

        public PeliculasService(IPeliculasRepository _peliculasRepository)
        {
            this.PeliculasRepository = _peliculasRepository;
        }

        public Peliculas Get(long id)
        {
            return PeliculasRepository.Get(id);
        }

        public IQueryable<Peliculas> Get()
        {
            return PeliculasRepository.Get();
        }

        public Peliculas Create(Peliculas peliculas)
        {
            return PeliculasRepository.Create(peliculas);
        }

        public void Put(Peliculas peliculas)
        {
            PeliculasRepository.Put(peliculas);
        }

        public Peliculas Delete(long id)
        {
            return PeliculasRepository.Delete(id);
        }

        public Peliculas create(Peliculas peliculas)
        {
            throw new NotImplementedException();
        }
    }
}