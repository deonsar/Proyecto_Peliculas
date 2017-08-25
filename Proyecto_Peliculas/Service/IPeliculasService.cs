using System.Linq;
using Proyecto_Peliculas.Modelos;

namespace Proyecto_Peliculas.Service
{
    public interface IPeliculasService
    {
        Peliculas Create(Peliculas peliculas);
        Peliculas create(Peliculas entrada);
        Peliculas Delete(long id);
        IQueryable<Peliculas> Get();
        Peliculas Get(long id);
        void Put(Peliculas peliculas);
    }
}