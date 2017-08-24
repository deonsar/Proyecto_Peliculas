using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Peliculas.Modelos
{
    public class Entradas
    {
        public int id { get; set; }
        public int sala { get; set; }
        public int fila { get; set; }
        public int asiento { get; set; }

        public Entradas()
        {
        }
             
        public Entradas(int _sala, int _fila, int _asiento)
        {
            this.sala = _sala;
            this.fila = _fila;
            this.asiento = _asiento;
        } 

    }
}