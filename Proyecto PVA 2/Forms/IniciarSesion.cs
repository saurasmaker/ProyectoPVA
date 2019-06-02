using Proyecto_PVA_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class IniciarSesion : Form
    {
        //Librería Capture
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Atributos
        bool tbCorreoClicked = false;
        bool tbContraseñaClicked = false;

        //Getters & Setters
        public bool TbCorreoClicked { get => tbCorreoClicked; set => tbCorreoClicked = value; }
        public bool TbContraseñaClicked { get => tbContraseñaClicked; set => tbContraseñaClicked = value; }

        //Constructores
        public IniciarSesion()
        {
            InitializeComponent();
        }

        //Eventos
        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            if (textBoxCorreoElectronico.Text == "")
                MessageBox.Show("Rellene el campo de correo electrónico para continuar.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (textBoxContraseña.Text == "")
                MessageBox.Show("Rellene el campo de contraseña para continuar.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (EsAdmin())
            {
                MessageBox.Show("Inicio de sesión como administrador.", "Inicio Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login(1);
                Close();
            }
            else if (ValidarEmail())
            {
                Login(0);
                Close();
            }
            else
                MessageBox.Show("Formato de correo electrónico no válido.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void textBoxCorreoElectronico_Click(object sender, EventArgs e)
        {
            if (!TbCorreoClicked)
            {
                textBoxCorreoElectronico.Clear();
                textBoxCorreoElectronico.ForeColor = Color.FromArgb(241, 239, 241);
            }

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

        private void buttonMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxContraseña.UseSystemPasswordChar = false;
        }

        private void buttonMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxContraseña.UseSystemPasswordChar = true;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            //buttonMostrar.BackgroundImage = 
        }

        private void linkLabelRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registrar = new Registro();
            AddOwnedForm(registrar);
            registrar.ShowDialog();
            Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        //Métodos
        public bool EsAdmin()
        {
            string email = textBoxCorreoElectronico.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@(vc\.admin)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
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

        public void Login(int caso)
        {
            Inicio papa = Owner as Inicio;

            switch (caso)
            {
                case 0:
                    
                    for (int i = 0; i < masterDataSet.Usuarios.Count; i++)
                    {
                        if (masterDataSet.Usuarios[i].CorreoElectronico == textBoxCorreoElectronico.Text)
                        {
                            if (masterDataSet.Usuarios[i].Contrasenya == textBoxContraseña.Text)
                            {
                                papa.User = new Usuario();

                                papa.User.Id = masterDataSet.Usuarios[i].Id;

                                papa.User.CorreoElectronico = masterDataSet.Usuarios[i].CorreoElectronico;

                                try
                                {
                                    papa.User.Alias = masterDataSet.Usuarios[i].Alias;
                                }
                                catch (Exception)
                                {

                                }

                                papa.User.Contraseña = masterDataSet.Usuarios[i].Contrasenya;

                                try
                                {
                                    papa.User.Nombre = masterDataSet.Usuarios[i].Nombre;
                                }
                                catch (Exception)
                                {

                                }

                                try
                                { 
                                    papa.User.Apellido1 = masterDataSet.Usuarios[i].Apellido1;
                                }
                                catch (Exception)
                                {

                                }

                                try { 
                                    papa.User.Apellido2 = masterDataSet.Usuarios[i].Apellido2;
                                }
                                catch (Exception)
                                {

                                }

                                try { 
                                    papa.User.Direccion = masterDataSet.Usuarios[i].Direccion;
                                }
                                catch (Exception)
                                {

                                }

                                try
                                {
                                    papa.User.FotoPerfil = new MemoryStream(masterDataSet.Usuarios[i].FotoPerfil.ToArray());
                                }
                                catch (Exception)
                                {

                                }

                                try { 
                                    papa.User.Nacimiento = masterDataSet.Usuarios[i].FechaNacimiento;
                                }
                                catch (Exception)
                                {

                                }

                                try {
                                    papa.User.Biografia = masterDataSet.Usuarios[i].Biografia;
                                }
                                catch (Exception)
                                {

                                }
                                papa.User.FecAlta = masterDataSet.Usuarios[i].FechaAlta;


                                papa.OpcionesUsuario();
                                if (papa.User.Alias != "") MessageBox.Show("Bienvenid@ " + papa.User.Alias);
                                else MessageBox.Show("Bienvenid@ " + papa.User.CorreoElectronico);
                                papa.InicioSesion = true;
                                papa.InicioSesionAdmin = false;
                            }
                            else
                                MessageBox.Show("La cuenta es existente. Sin embargo, la contraseña no coincide.", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                            MessageBox.Show("No existe un usuario con ese correo electrónico. Registrése para tener una cuenta y poder optar a todos los servicios.","Usuario no encontrado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    

                    break;
                case 1:
                    papa.InicioSesion = true;
                    papa.InicioSesionAdmin = true;
                    papa.Admin = new Administrador(textBoxCorreoElectronico.Text, textBoxContraseña.Text);
                    papa.MostrarOpcionesAdmin();

                    break;
                default:
                    MessageBox.Show("Opción no válida. Error en el código. Si le aparece este error como usuario contecte con el servicio técnico de la web.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
            return;
        }


        //Events inútiles
        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.masterDataSet.Usuarios);

        }

        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
