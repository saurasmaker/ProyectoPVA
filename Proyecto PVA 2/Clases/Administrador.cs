using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PVA_2.Clases
{
    class Administrador:Persona
    {
        //Atriutos
        string correoElectronico, contraseña;

        //Constructores
        public Administrador()
        {

        }

        public Administrador(string correoElectronico, string contraseña)
        {
            CorreoElectronico = correoElectronico;
            Contraseña = contraseña;
        }

        //Getters & Setters
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        //Métodos
    }
}

