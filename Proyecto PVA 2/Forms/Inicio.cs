using Proyecto_PVA_2.Clases;
using Proyecto_PVA_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2
{
    public partial class Inicio : Form
    {
        //Atributos
        Usuario user;
        Administrador admin;
        List<Panel> peliculas;
        List<PictureBox> portadas;
        List<Label> titulos;
        bool inicioSesion = false;
        bool inicioSesionAdmin = false;
        bool panel1Encogido = false;

        //Constructores
        public Inicio()
        {
            InitializeComponent();
            Peliculas = new List<Panel>();
            Portadas = new List<PictureBox>();
            Titulos = new List<Label>();
        }

        //Getters & Setters
        public bool InicioSesion { get => inicioSesion; set => inicioSesion = value; }
        public bool Panel1Encogido { get => panel1Encogido; set => panel1Encogido = value; }
        public List<Panel> Peliculas { get => peliculas; set => peliculas = value; }
        public List<PictureBox> Portadas { get => portadas; set => portadas = value; }
        public List<Label> Titulos { get => titulos; set => titulos = value; }
        public bool InicioSesionAdmin { get => inicioSesionAdmin; set => inicioSesionAdmin = value; }
        internal Usuario User { get => user; set => user = value; }
        internal Administrador Admin { get => admin; set => admin = value; }


        //------------------------------------------------------------------------------
        //Eventos

        //--Barra Herramientas Inicio
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (InicioSesionAdmin)
            {
                
            }
            else if (InicioSesion)
            {

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
                panel1.Size = new Size(buttonDesplegar.Width, panel1.Height);
                Panel1Encogido = true;
                buttonDesplegar.Dock = DockStyle.Left;
                OcultarGeneros();
            }
            else
            {
                panel1.Size = new Size(164, panel1.Height);
                Panel1Encogido = false;
                buttonDesplegar.Dock = DockStyle.None;
                MostrarGeneros();
            }

        }


        //--Panel Central
        private void Inicio_Resize(object sender, EventArgs e)
        {
            Peliculas.Clear();
            for(int i = 0; i<20; i++)
                Peliculas.Add(crearCartelPelicula());

            MessageBox.Show("" + Peliculas.Count, "Cantidad");

            ReajustarPanelCentral(Peliculas.Count);
        }

        //--Panel Derecho
        private void ButtonAdministrarPeliculas_Click(object sender, EventArgs e)
        {
            AdministrarPeliculas adminPelis = new AdministrarPeliculas();
            adminPelis.ShowDialog();
        }


        //-------------------------------------------------------------------------
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

        void ReajustarPanelCentral(int elementos)
        {
            int espacio = tableLayoutPanelCentro.Width / 160;

            //Establecemos cantidad de columnas y filas
            tableLayoutPanelCentro.Controls.Clear();
            tableLayoutPanelCentro.ColumnCount = espacio;
            tableLayoutPanelCentro.RowCount = 0;

            //Establecemos estilo de tamaño de las columnas
            TableLayoutColumnStyleCollection styles = this.tableLayoutPanelCentro.ColumnStyles;
            foreach (ColumnStyle style in styles)
                style.SizeType = 0;

            //Añadimos carteles de peliculas en el LayOut
            foreach(Panel p in Peliculas)
                tableLayoutPanelCentro.Controls.Add(p);

            //Establecemos estilo de tamaño de las filas
            TableLayoutRowStyleCollection styleRow = this.tableLayoutPanelCentro.RowStyles;
            foreach (ColumnStyle style in styles)
                style.SizeType = 0;

            //Actualizamos LayOut
            tableLayoutPanelCentro.Update();
        }

        Panel crearCartelPelicula()
        {
            PictureBox portada = new PictureBox();
            portada.Size = new Size(100,140);
            portada.Location = new Point(7,7);
            portada.Visible = true;

            Label titulo = new Label();
            titulo.Text = "Ejemplo titulo";
            titulo.Location = new Point(4,157);
            titulo.Visible = true;

            Panel cartel = new Panel();
            cartel.Size = new Size(113, 176);
            cartel.Margin = new Padding(20, 20, 20, 20);
            cartel.BackColor = Color.FromName("Info");
            cartel.Visible = true;

            cartel.Controls.Add(portada);
            Portadas.Add(portada);
            cartel.Controls.Add(titulo);
            Titulos.Add(titulo);

            return cartel;
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
        private void TableLayoutPanelCentro_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

    }
}
