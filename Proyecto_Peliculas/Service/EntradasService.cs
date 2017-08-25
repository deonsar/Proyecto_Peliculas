using Proyecto_Peliculas.Modelos;
using Proyecto_Peliculas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Peliculas.Service
{
    public class EntradasService : IEntradasService
    {
        private IEntradasRepository EntradasRepository;

        public EntradasService(IEntradasRepository _entradasRepository)
        {
            this.EntradasRepository = _entradasRepository;
        }

        public Entradas Get(long id)
        {
            return EntradasRepository.Get(id);
        }

        public IQueryable<Entradas> Get()
        {
            return EntradasRepository.Get();
        }

        public Entradas Create(Entradas entrada)
        {
            return EntradasRepository.Create(entrada);
        }

        public void Put(Entradas entrada)
        {
            EntradasRepository.Put(entrada);
        }

        public Entradas Delete(long id)
        {
            return EntradasRepository.Delete(id);
        }

        public Entradas create(Entradas entrada)
        {
            throw new NotImplementedException();
        }
    }
}