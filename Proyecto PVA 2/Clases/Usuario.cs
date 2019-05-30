using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PVA_2.Clases
{
    class Usuario:Persona
    {
        //Atriutos
        string correoElectronico, contraseña, alias;
        MemoryStream fotoPerfil;
        DateTime fecAlta;
        int id;

        //Constructores
        public Usuario()
        {

        }

        public Usuario(string correoElectronico, string contraseña)
        {
            CorreoElectronico = correoElectronico;
            Contraseña = contraseña;
        }

        //Getters & Setters
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime FecAlta { get => fecAlta; set => fecAlta = value; }
        public int Id { get => id; set => id = value; }
        public string Alias { get => alias; set => alias = value; }
        public MemoryStream FotoPerfil { get => fotoPerfil; set => fotoPerfil = value; }

        //Métodos
    }
}
