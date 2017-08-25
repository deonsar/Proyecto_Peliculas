using System.Linq;
using Proyecto_Peliculas.Modelos;

namespace Proyecto_Peliculas.Repository
{
    public interface IEntradasRepository
    {
        Entradas Create(Entradas entrada);
        Entradas Delete(long id);
        IQueryable<Entradas> Get();
        Entradas Get(long id);
        void Put(Entradas entrada);
    }
}