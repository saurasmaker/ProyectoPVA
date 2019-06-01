using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PVA_2.Clases
{
    class Serie:TituloCinematografico
    {
        //Atributos
        List<Temporada> temporadas;
        int numTemporadas;

        //Constructor
        public Serie()
        {
            Temporadas = new List<Temporada>();
        }

        public int NumTemporadas { get => numTemporadas; set => numTemporadas = value; }
        internal List<Temporada> Temporadas { get => temporadas; set => temporadas = value; }

        //Getters & Setters

        //Métodos
    }
}
