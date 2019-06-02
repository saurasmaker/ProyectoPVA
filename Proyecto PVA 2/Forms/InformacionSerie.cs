using Proyecto_PVA_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class InformacionSerie : Form
    {
        //Atibutos
        Inicio padre;
        int idSerie;

        //Getters & Setters
        internal IEnumerable<TituloCinematografico> CarroCompra { get; private set; }
        public Inicio Padre { get => padre; set => padre = value; }
        public int IdSerie { get => idSerie; set => idSerie = value; }

        //Constructores
        public InformacionSerie()
        {
            InitializeComponent();
        }

        //Librería Capture
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Eventos
        private void capitulosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.capitulosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void comboBoxTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTemporada.SelectedIndex!=0)
                capitulosTableAdapter.FillByIdyTemporada(masterDataSet.Capitulos,IdSerie, comboBoxTemporada.SelectedIndex);
           else
                capitulosTableAdapter.FillByIdSerie(masterDataSet.Capitulos, IdSerie);


        }

        private void InformacionSerie_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Series' Puede moverla o quitarla según sea necesario.
            this.seriesTableAdapter.Fill(this.masterDataSet.Series);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Capitulos' Puede moverla o quitarla según sea necesario.
            this.capitulosTableAdapter.Fill(this.masterDataSet.Capitulos);
            Padre = Owner as Inicio;

            capitulosTableAdapter.FillByIdSerie(masterDataSet.Capitulos,IdSerie);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAñadirAlCarro_Click(object sender, EventArgs e)
        {
            if (!padre.InicioSesion)
            {
                MessageBox.Show("Debe de estar logeado para acceder a esta opción.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TituloCinematografico tc = new TituloCinematografico();
            tc.Titulo = tituloTextBox.Text;
            tc.Sinopsis = sinopsisTextBox.Text;
            tc.Estreno = Convert.ToDateTime(textBoxEstreno.Text);
            tc.Puntuacion = Convert.ToSingle(puntuacionTextBox.Text);
            tc.Precio = Convert.ToDecimal(precioTextBox.Text.Replace("€", ""));

            padre.CarroCompra.Add(tc);
        }

        //Métodos


        //Eventos Inutiles
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CapitulosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PuntuacionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
