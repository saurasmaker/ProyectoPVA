using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class Registro : Form
    {
        //Librería Capture
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Atributos
        IniciarSesion padre;
        bool tbCorreoClicked = false;
        bool tbContraseñaClicked = false;
        bool tbRepetiContrClicked = false;

        //Getters & Setters
        public IniciarSesion Padre { get => padre; set => padre = value; }
        public bool TbCorreoClicked { get => tbCorreoClicked; set => tbCorreoClicked = value; }
        public bool TbContraseñaClicked { get => tbContraseñaClicked; set => tbContraseñaClicked = value; }
        public bool TbRepetiContrClicked { get => tbRepetiContrClicked; set => tbRepetiContrClicked = value; }

        //Cnstructores
        public Registro()
        {
            InitializeComponent();
        }

        //Eventos
        private void Registro_Load(object sender, EventArgs e)
        {
            Padre = Owner as IniciarSesion;
            Padre.Visible = false;
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
                usuariosTableAdapter.InsertQuery(masterDataSet.Usuarios.Count + 10000001, textBoxCorreoElectronico.Text, null, textBoxContraseña.Text, null, null, null, null, null, null, DateTime.Now.ToString());
                MessageBox.Show("Usuario Registrado con Exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Cerrar ventana
        {
            Padre.Visible = true;
            Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxCorreoElectronico_Click(object sender, EventArgs e)
        {

            if (!TbCorreoClicked)
            {
                textBoxCorreoElectronico.Clear();
                textBoxCorreoElectronico.ForeColor = Color.FromArgb(241, 239, 241);
            }

            textBoxContraseña.UseSystemPasswordChar = true;
            TbCorreoClicked = true;

        }

        private void textBoxContraseña_Click(object sender, EventArgs e)
        {
            if (!TbContraseñaClicked)
            {
                textBoxContraseña.Clear();
                textBoxContraseña.ForeColor = Color.FromArgb(241, 239, 241);
            }

            textBoxContraseña.UseSystemPasswordChar = true;
            TbContraseñaClicked = true;
        }

        private void textBoxRepetirContraseña_Click(object sender, EventArgs e)
        {
            if (!TbRepetiContrClicked)
            {
                textBoxRepetirContraseña.Clear();
                textBoxRepetirContraseña.ForeColor = Color.FromArgb(241, 239, 241);
            }

            TbRepetiContrClicked = true;
        }

        private void buttonMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxContraseña.UseSystemPasswordChar = false;
        }

        private void buttonMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxContraseña.UseSystemPasswordChar = true;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxRepetirContraseña.UseSystemPasswordChar = false;

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxRepetirContraseña.UseSystemPasswordChar = true;

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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {

        }

        
    }
}
