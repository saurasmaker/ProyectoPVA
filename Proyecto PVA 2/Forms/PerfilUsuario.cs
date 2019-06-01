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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class PerfilUsuario : Form
    {
        //Librería Capture
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Atributos
        Usuario user;

        //Getters & Setters
        internal Usuario User { get => user; set => user = value; }

        //Constructores
        public PerfilUsuario()
        {
            InitializeComponent();
        }

        //Eventos
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si continua con esta acción se cambiarán los datos permanentemente sin posibilidad de volver atrás.\n¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MemoryStream image = new MemoryStream();

                try
                {
                    pictureBoxImagenPerfil.Image.Save(image, pictureBoxImagenPerfil.Image.RawFormat);
                    usuariosTableAdapter.UpdateQueryById(textBoxCorreoElectronico.Text, textBoxAlias.Text, User.Contraseña, textBoxNombre.Text, textBoxApellido1.Text, textBoxApellido2.Text, textBoxDireccion.Text, image.ToArray(), dateTimePickerFechaNacimiento.Text, textBoxBiografia.Text, User.Id);
                }
                catch (Exception)
                {
                    usuariosTableAdapter.UpdateQueryById(textBoxCorreoElectronico.Text, textBoxAlias.Text, User.Contraseña, textBoxNombre.Text, textBoxApellido1.Text, textBoxApellido2.Text, textBoxDireccion.Text, null, dateTimePickerFechaNacimiento.Text, textBoxBiografia.Text, User.Id);
                }
                MessageBox.Show("ACTUALIZADO");
            }
        }

        private void buttonCambiarImagenPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBoxImagenPerfil.Image = Image.FromFile(ofd.FileName);
        }

        //Métodos


        //Eventos inútiles
        private void groupBoxDatosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.masterDataSet.Usuarios);
            try{
                pictureBoxImagenPerfil.Image = Image.FromStream(User.FotoPerfil);
            }
            catch (Exception)
            {

            }
            try
            {
                textBoxAlias.Text = User.Alias;
            }
            catch (Exception)
            {

            }
            try { 
                textBoxCorreoElectronico.Text = User.CorreoElectronico;
            }
            catch (Exception)
            {

            }
            try { 
                textBoxNombre.Text = User.Nombre;
            }
            catch (Exception)
            {

            }
            try { 
                textBoxApellido1.Text = User.Apellido1;
            }
            catch (Exception)
            {

            }
            try { 
                textBoxApellido2.Text = User.Apellido2;
            }
            catch (Exception)
            {

            }
            try
            {
                textBoxDireccion.Text = User.Direccion;
            }
            catch (Exception)
            {

            }
            try { 
                dateTimePickerFechaNacimiento.Text = User.Nacimiento.ToString();
            }
            catch (Exception)
            {

            }
            try { 
                textBoxBiografia.Text = User.Biografia;
            }
            catch (Exception)
            {

            }
        }

        private void textBoxAlias_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
