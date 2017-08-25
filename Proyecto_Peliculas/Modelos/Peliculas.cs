using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Peliculas.Modelos
{
    public class Peliculas
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public int duracion { get; set; }
        public string pais { get; set; }
        public string genero { get; set; }

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