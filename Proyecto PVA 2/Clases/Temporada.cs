using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PVA_2.Clases
{
    class Temporada
    {
        //Atributos
        int num;
        int cantCapitulos;
        float puntuacion;
        float precio;
        List<Capitulo> capitulos;

        //Constructores
        public Temporada()
        {
            Capitulos = new List<Capitulo>();
        }

        //Gettters & Setters
        public int Num { get => num; set => num = value; }
        public int CantCapitulos { get => cantCapitulos; set => cantCapitulos = value; }
        public float Puntuacion { get => puntuacion; set => puntuacion = value; }
        public float Precio { get => precio; set => precio = value; }
        internal List<Capitulo> Capitulos { get => capitulos; set => capitulos = value; }

        //Métodos

    }
}
