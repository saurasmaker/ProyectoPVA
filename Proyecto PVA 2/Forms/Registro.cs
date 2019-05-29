using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class Registro : Form
    {

        //Atributos
        IniciarSesion padre;

        //Cnstructores
        public Registro()
        {
            InitializeComponent();
        }

        //Eventos
        private void Registro_Load(object sender, EventArgs e)
        {
            padre = Owner as IniciarSesion;
            padre.Visible = false;
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.masterDataSet.Usuarios);

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void usuariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            if (textBoxCorreoElectronico.Text == "")
                MessageBox.Show("Rellene el campo de correo electrónico para continuar.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (textBoxContraseña.Text == "")
                MessageBox.Show("Rellene el campo de contraseña para continuar.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (textBoxRepetirContraseña.Text == "")
                MessageBox.Show("Rellene el campo de repetir contraseña para continuar.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!ValidarEmail())
                MessageBox.Show("Formato de correo electrónico no válido.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!CoincidenContraseñas())
                MessageBox.Show("Las contraseñas no coinciden", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                usuariosTableAdapter.InsertQuery(masterDataSet.Usuarios.Count + 10000001, textBoxCorreoElectronico.Text, null, textBoxContraseña.Text, null, null, null, null, null, null, null);
                MessageBox.Show("Usuario Registrado con Exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Métodos
        bool CoincidenContraseñas()
        {
            if (textBoxContraseña.Text == textBoxRepetirContraseña.Text)
                return true;

            return false; ;
        }

        public bool ValidarEmail()
        {
            string email = textBoxCorreoElectronico.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (match.Success)
                return true;
            else
                return false;
        }

        //Eventos Inutiles
        private void textBoxCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            padre.Visible = true;
            Close();
        }


    }
}
