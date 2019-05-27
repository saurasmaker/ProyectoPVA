using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PVA_2.Clases
{
    class Persona
    {
        //Atributos
        string nombre, apellido1, apellido2;
        DateTime nacimiento;

        //Constructor
        public Persona()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }

        //Métodos
    }
}
