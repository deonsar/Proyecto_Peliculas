using System.Linq;
using Proyecto_Peliculas.Modelos;

namespace Proyecto_Peliculas.Service
{
    public interface IEntradasService
    {
        Entradas Create(Entradas entrada);
        Entradas create(Entradas entrada);
        Entradas Delete(long id);
        IQueryable<Entradas> Get();
        Entradas Get(long id);
        void Put(Entradas entrada);
    }
}