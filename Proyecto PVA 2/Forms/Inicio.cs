﻿using Proyecto_PVA_2.Clases;
using Proyecto_PVA_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2
{
    public partial class Inicio : Form
    {
        //Conexion base de datos
        SqlConnection conexionBaseDatos = new SqlConnection("Data Source = localhost\\SQLEXPRESS02; Initial Catalog = master; Integrated Security = True");

        //Atributos
        Usuario user;
        Administrador admin;
        List<TituloCinematografico> carroCompra;
        List<Panel> pelis;
        List<PictureBox> portadas;
        List<Label> titulos;
        bool inicioSesion = false;
        bool inicioSesionAdmin = false;
        bool panel1Encogido = false;

        //Constructores
        public Inicio()
        {
            InitializeComponent();
            Pelis = new List<Panel>();
            Portadas = new List<PictureBox>();
            Titulos = new List<Label>();
        }

        //Getters & Setters
        public bool InicioSesion { get => inicioSesion; set => inicioSesion = value; }
        public bool Panel1Encogido { get => panel1Encogido; set => panel1Encogido = value; }
        public List<Panel> Pelis { get => pelis; set => pelis = value; }
        public List<PictureBox> Portadas { get => portadas; set => portadas = value; }
        public List<Label> Titulos { get => titulos; set => titulos = value; }
        public bool InicioSesionAdmin { get => inicioSesionAdmin; set => inicioSesionAdmin = value; }
        internal Usuario User { get => user; set => user = value; }
        internal Administrador Admin { get => admin; set => admin = value; }

        //Eventos
        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.masterDataSet.Peliculas);
            //Ajustes de Carga
            ReajustarPanelCentral();
            ReajustarToolStripInicio();

            //Quitamos Scroll Horizontal del panel central
            tableLayoutPanelCentro.HorizontalScroll.Visible = false;
        }

        //--Barra Herramientas Inicio
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (InicioSesionAdmin)
            {
                PanelDeControlAdmin panelAdmin = new PanelDeControlAdmin();
                panelAdmin.Show();
            }
            else if (InicioSesion)
            {
                PerfilUsuario perfil = new PerfilUsuario();
                perfil.Show();
            }
            else
            {
                IniciarSesion inicioSesion = new IniciarSesion();
                AddOwnedForm(inicioSesion);

                inicioSesion.ShowDialog();
            }
        }

        //--Panel Izquierdo
        private void ButtonDesplegar_Click(object sender, EventArgs e)
        {
            if (!Panel1Encogido)
            {
                panelIzquierda.Size = new Size(buttonDesplegar.Width, panelIzquierda.Height);
                Panel1Encogido = true;
                buttonDesplegar.Dock = DockStyle.Left;
                OcultarGeneros();
                ReajustarPanelCentral();
            }
            else
            {
                panelIzquierda.Size = new Size(174, panelIzquierda.Height);
                Panel1Encogido = false;
                buttonDesplegar.Dock = DockStyle.None;
                MostrarGeneros();
                ReajustarPanelCentral();
            }

        }

        //--Panel Central
        private void Inicio_Resize(object sender, EventArgs e)
        {
            ReajustarPanelCentral();
            ReajustarToolStripInicio();
        }

        //--Panel Derecho
        private void buttonAdministrarPeliculas_Click_1(object sender, EventArgs e)
        {
            AdministrarPeliculas adminPelis = new AdministrarPeliculas();
            adminPelis.ShowDialog();
        }

        //Eventos inútiles
        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //Métodos
        void OcultarGeneros()
        {
            labelGeneros.Visible = false;
            buttonGeneroAccion.Visible = false;
            buttonGeneroAventura.Visible = false;
            buttonGeneroCienciaFiccion.Visible = false;
            buttonGeneroComedia.Visible = false;
            buttonGeneroCrimen.Visible = false;
            buttonGeneroDeporte.Visible = false;
            buttonGeneroDibujosAnimados.Visible = false;
            buttonGeneroDocumentales.Visible = false;
            buttonGeneroDrama.Visible = false;
            buttonGeneroFamiliar.Visible = false;

            return;
        }

        void MostrarGeneros()
        {
            labelGeneros.Visible = true;
            buttonGeneroAccion.Visible = true;
            buttonGeneroAventura.Visible = true;
            buttonGeneroCienciaFiccion.Visible = true;
            buttonGeneroComedia.Visible = true;
            buttonGeneroCrimen.Visible = true;
            buttonGeneroDeporte.Visible = true;
            buttonGeneroDibujosAnimados.Visible = true;
            buttonGeneroDocumentales.Visible = true;
            buttonGeneroDrama.Visible = true;
            buttonGeneroFamiliar.Visible = true;
            return;
        }

        public void MostrarOpcionesAdmin()
        {
            panelAdmin.Visible = true;
            toolStripButtonPerfil.Text = "Admin";
            return;
        }

        public void OcultarOpcionesAdmin()
        {
            panelAdmin.Visible = false;

            return;
        }

        public void OpcionesUsuario()
        {
            panelAdmin.Visible = false;
            toolStripButtonPerfil.Text = "Perfil";
        }

        void ReajustarPanelCentral()
        {
            int espacio = tableLayoutPanelCentro.Width / 210;

            Pelis.Clear();
            for (int i = 0; i < masterDataSet.Peliculas.Count; i++)
                Pelis.Add(crearCartelPelicula(i));

            //Establecemos cantidad de columnas y filas
            tableLayoutPanelCentro.Controls.Clear();
            tableLayoutPanelCentro.ColumnCount = espacio;
            tableLayoutPanelCentro.RowCount = 0;

            //Establecemos estilo de tamaño de las columnas
            TableLayoutColumnStyleCollection styles = this.tableLayoutPanelCentro.ColumnStyles;
            foreach (ColumnStyle style in styles)
                style.SizeType = 0;

            //Añadimos carteles de peliculas en el LayOut
            foreach (Panel p in Pelis)
                tableLayoutPanelCentro.Controls.Add(p);

            //Establecemos estilo de tamaño de las filas
            TableLayoutRowStyleCollection styleRow = this.tableLayoutPanelCentro.RowStyles;
            foreach (ColumnStyle style in styles)
                style.SizeType = 0;

        }

        void ReajustarToolStripInicio()
        {
            toolStripButtonPeliculas.Margin = new Padding((tableLayoutPanelCentro.Size.Width - 360) / 2 , 1, 0, 2);
            return;
        }

        Panel crearCartelPelicula(int i)
        {
            //Creamos Portada del Cartel
            PictureBox portada = new PictureBox();
            portada.Size = new Size(150, 210);
            portada.Location = new Point(9, 7);
            portada.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                MemoryStream ms = new MemoryStream(masterDataSet.Peliculas[i].Portada.ToArray());
                portada.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }
            portada.BorderStyle = BorderStyle.FixedSingle;
            portada.Visible = true;

            //Creamos Titulo del Cartel
            Label titulo = new Label();
            titulo.Font = new Font("Bahnschrift", 10);
            titulo.ForeColor = Color.White;
            titulo.Text = masterDataSet.Peliculas[i].Titulo;
            titulo.Padding = new Padding(5,0,2,0);
            titulo.Dock = DockStyle.Bottom;
            titulo.Visible = true;

            Panel cartel = new Panel();
            cartel.Size = new Size(170, 264);
            cartel.Margin = new Padding(20, 20, 20, 20);
            cartel.BackColor = Color.FromArgb(195, 27, 57);
            cartel.Visible = true;

            //Creamos eventos de los carteles-------------------------------
            void CambioColorCartel(Object sender, EventArgs e)
            {
                cartel.BackColor = Color.FromArgb(100, 0, 200);
                return;
            }
            void Cartel_Click(object sender, EventArgs e)
            {
                
                InformaciónPelicula infoPeli = new InformaciónPelicula();
                cartel.BackColor = Color.FromArgb(195, 27, 57);
                Cursor = Cursors.Default;
                infoPeli.Show();

                return;
            }
            void MouseAMano(Object sender, EventArgs e)
            {
                Cursor = Cursors.Hand;
                cartel.BackColor = Color.FromArgb(170, 0, 0);

                return;
            }
            void MouseAFlecha(Object sender, EventArgs e)
            {
                Cursor = Cursors.Default;
                cartel.BackColor = Color.FromArgb(195, 27, 57);
                return;
            }
                //Añadimos Eventos a portada
            portada.Click += new EventHandler(Cartel_Click);
            portada.MouseDown += new MouseEventHandler(CambioColorCartel);
            portada.MouseHover += new EventHandler(MouseAMano);
            portada.MouseLeave += new EventHandler(MouseAFlecha);

            //Añadimos Eventos a Titulo
            titulo.Click += new EventHandler(Cartel_Click);
            titulo.MouseDown += new MouseEventHandler(CambioColorCartel);
            titulo.MouseHover += new EventHandler(MouseAMano);
            titulo.MouseLeave += new EventHandler(MouseAFlecha);
            //--------------------------------------------------------------

            //Añadimos elementos creados al cartel.
            cartel.Controls.Add(portada);
            Portadas.Add(portada);
            cartel.Controls.Add(titulo);
            Titulos.Add(titulo);

            return cartel;
        }


        //Eventos Inútiles
        private void TableLayoutPanelCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonPeliculas_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSeries_Click(object sender, EventArgs e)
        {

        }

        
    }

}
