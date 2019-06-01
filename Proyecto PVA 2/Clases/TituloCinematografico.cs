using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PVA_2.Clases
{
    class TituloCinematografico
    {

        //Atributos
        int id;
        string titulo, sinopsis;
        float puntuacion;
        decimal precio;
        DateTime estreno;
        MemoryStream portada;
        List<string> generos;
        List<Actor> reparto;

        //Constructores
        public TituloCinematografico()
        {

        }


        //Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public float Puntuacion { get => puntuacion; set => puntuacion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public DateTime Estreno { get => estreno; set => estreno = value; }
        public List<string> Generos { get => generos; set => generos = value; }
        public MemoryStream Portada { get => portada; set => portada = value; }
        internal List<Actor> Reparto { get => reparto; set => reparto = value; }

        //Metodos

    }
}
