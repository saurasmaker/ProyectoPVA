using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PVA_2.Clases
{
    class Pelicula:TituloCinematografico
    {
        //Atributos
        TimeSpan duracion; 
        Director direct;

        //Getters & Setters
        public TimeSpan Duracion { get => duracion; set => duracion = value; }
        internal Director Direct { get => direct; set => direct = value; }

        //Constructores
        public Pelicula()
        {

        }

        //Métodos
    }
}
