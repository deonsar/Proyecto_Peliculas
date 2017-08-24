using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Peliculas.Modelos
{
    public class Peliculas
    {
        int id { get; set; }
        string titulo { get; set; }
        int duracion { get; set; }
        string pais { get; set; }
        string genero { get; set; }

        public Peliculas()
        {
        }

        public Peliculas(string _titulo, int _duracion, string _pais, string _genero)
        {
            this.titulo = _titulo;
            this.duracion = _duracion;
            this.pais = _pais;
            this.genero = _genero;
        }
    }
}