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
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class InformacionSerie : Form
    {
        //Atibutos
        Inicio padre;
        List<Temporada> temporadas;

        //Getters & Setters
        internal IEnumerable<TituloCinematografico> CarroCompra { get; private set; }
        public Inicio Padre { get => padre; set => padre = value; }
        internal List<Temporada> Temporadas { get => temporadas; set => temporadas = value; }

        //Constructores
        public InformacionSerie()
        {
            InitializeComponent();
            Temporadas = new List<Temporada>();
        }

        //Eventos
        private void comboBoxTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Capitulo c in Temporadas[comboBoxTemporada.SelectedIndex].Capitulos)
            {
                ListViewItem milista;
                milista = listView1.Items.Add(c.Titulo);
                milista.SubItems.Add(c.Duracion.ToString());
                milista.SubItems.Add(c.Puntuacion.ToString());
                milista.SubItems.Add(((float)(Math.Round(Convert.ToDouble(c.Precio), 2))).ToString() + "€");
            }
        }

        private void InformacionSerie_Load(object sender, EventArgs e)
        {
            Padre = Owner as Inicio;
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
            tc.Precio = Convert.ToSingle(precioTextBox.Text.Replace("€", ""));

            padre.CarroCompra.Add(tc);
        }
        //Métodos

        //Eventos Inutiles
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
