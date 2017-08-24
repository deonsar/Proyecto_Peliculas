using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Peliculas.Modelos
{
    public class Entradas
    {
        public int id { get; set; }
        public string salon { get; set; }
        public int fila { get; set; }
        public int asiento { get; set; }

        public Entradas()
        {
        }
             
        public Entradas(string _salon, int _fila, int _asiento)
        {
            this.salon = _salon;
            this.fila = _fila;
            this.asiento = _asiento;
        } 

    }
}