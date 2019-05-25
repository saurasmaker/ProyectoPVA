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
        List<List<int>> capitulos;

        //Constructor
        public Serie()
        {

        }

        //Getters & Setters
        public List<List<int>> Capitulos { get => capitulos; set => capitulos = value; }

        //Métodos
    }
}
