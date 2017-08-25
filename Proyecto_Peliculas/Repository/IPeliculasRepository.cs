using System.Linq;
using Proyecto_Peliculas.Modelos;

namespace Proyecto_Peliculas.Repository
{
    public interface IPeliculasRepository
    {
        Peliculas Create(Peliculas pelicula);
        Peliculas Delete(long id);
        IQueryable<Peliculas> Get();
        Peliculas Get(long id);
        void Put(Peliculas pelicula);
    }
}