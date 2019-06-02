using Proyecto_PVA_2.Clases;
using Proyecto_PVA_2.Forms;
using Proyecto_PVA_2.Forms.Admin;
using Prueba;
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
        //Paquetes de Peliculas
        List<Pelicula> Piratas_del_Caribe = new List<Pelicula>();
        List<Pelicula> StarWar = new List<Pelicula>();

        //Constantes
        static int modoPelicula = 0;
        static int modoSerie = 1;
        static int modoRecomendaciones = 2;

        //Atributos
        int mode = 0;
        Usuario user;
        Administrador admin;
        List<TituloCinematografico> carroCompra;
        List<Panel> carteles;
        bool inicioSesion = false;
        bool inicioSesionAdmin = false;
        bool panel1Encogido = false;

        //Constructores
        public Inicio()
        {
            InitializeComponent();
            Carteles = new List<Panel>();
        }

        //Getters & Setters
        public bool InicioSesion { get => inicioSesion; set => inicioSesion = value; }
        public bool Panel1Encogido { get => panel1Encogido; set => panel1Encogido = value; }
        internal Usuario User { get => user; set => user = value; }
        internal Administrador Admin { get => admin; set => admin = value; }
        internal List<TituloCinematografico> CarroCompra { get => carroCompra; set => carroCompra = value; }
        public bool InicioSesionAdmin { get => inicioSesionAdmin; set => inicioSesionAdmin = value; }
        public int Mode { get => mode; set => mode = value; }
        public List<Panel> Carteles { get => carteles; set => carteles = value; }
        internal List<Pelicula> Piratas_del_Caribe1 { get => Piratas_del_Caribe; set => Piratas_del_Caribe = value; }
        internal List<Pelicula> StarWar1 { get => StarWar; set => StarWar = value; }

        //Eventos
        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.masterDataSet.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Series' Puede moverla o quitarla según sea necesario.
            this.seriesTableAdapter.Fill(this.masterDataSet.Series);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.masterDataSet.Peliculas);
            
            //Ajustes de Carga;
            ReajustarPanelCentral();
            ReajustarToolStripInicio();

            GenerarPaquetesPeliculas();
        }

        //--Barra Herramientas Inicio
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (InicioSesion)
            {
                PerfilUsuario perfil = new PerfilUsuario();
                perfil.User = User;
                perfil.ShowDialog();
            }
            else
            {
                IniciarSesion inicioSesion = new IniciarSesion();
                AddOwnedForm(inicioSesion);
                inicioSesion.ShowDialog();

            }
        }

        private void toolStripButtonCarroCompra_Click(object sender, EventArgs e)
        {
            if (!InicioSesion)
            {
                MessageBox.Show("Debe de estar logeado para acceder a esta opción.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MiCarroDeLaCompra mcdlc = new MiCarroDeLaCompra();
            AddOwnedForm(mcdlc);

            foreach (TituloCinematografico t in CarroCompra)
            {
                ListViewItem milista;
                milista = mcdlc.listView1.Items.Add(t.Titulo);
                milista.SubItems.Add(t.Puntuacion.ToString());
                milista.SubItems.Add(((float)(Math.Round(Convert.ToDouble(t.Precio),2))).ToString() + "€");
            }
            mcdlc.ShowDialog();

        }

        private void toolStripButtonPeliculas_Click(object sender, EventArgs e)
        {
            Mode = modoPelicula;
            ReajustarPanelCentral();
        }

        private void toolStripButtonSeries_Click(object sender, EventArgs e)
        {
            Mode = modoSerie;
            ReajustarPanelCentral();
        }

        private void toolStripButtonRecomendaciones_Click(object sender, EventArgs e)
        {
            Mode = modoRecomendaciones;
            ReajustarPanelCentral();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdministrarSeries adminSeries = new AdministrarSeries();
            adminSeries.ShowDialog();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void buttonAdminUsuarios_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios administrarUsuarios = new AdministrarUsuarios();
            administrarUsuarios.Show();
        }

        private void buttonAbrirPanelAdmin_Click(object sender, EventArgs e)
        {
            PanelAdmin pa = new PanelAdmin();
            pa.ShowDialog();
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
            toolStripButtonIniciarSesion.Text = "Admin";
            CarroCompra = new List<TituloCinematografico>();
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
            toolStripButtonIniciarSesion.Text = "Perfil";
            CarroCompra = new List<TituloCinematografico>();
        }

        void ReajustarPanelCentral()
        {
            int espacio = tableLayoutPanelCentro.Width / 210;

            Carteles.Clear();
            if (Mode == modoPelicula)
                for (int i = 0; i < masterDataSet.Peliculas.Count; i++)
                    Carteles.Add(crearCartel(i));

            else if (Mode == modoSerie)
                for (int i = 0; i < masterDataSet.Series.Count; i++)
                    Carteles.Add(crearCartel(i));

            else if (Mode == modoRecomendaciones)
            {
                Carteles.Add(crearCartelR(Piratas_del_Caribe, "Piratas del Caribe"));
                Carteles.Add(crearCartelR(StarWar, "Star War"));
            }

            //Establecemos cantidad de columnas y filas
            tableLayoutPanelCentro.Controls.Clear();
            tableLayoutPanelCentro.ColumnCount = espacio;
            tableLayoutPanelCentro.RowCount = 0;

            //Establecemos estilo de tamaño de las columnas
            TableLayoutColumnStyleCollection styles = this.tableLayoutPanelCentro.ColumnStyles;
            foreach (ColumnStyle style in styles)
                style.SizeType = 0;

            //Añadimos carteles de peliculas en el LayOut
            foreach (Panel p in Carteles)
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

        Panel crearCartel(int i)
        {
            //Creamos Portada del Cartel
            PictureBox portada = new PictureBox();
            portada.Size = new Size(150, 210);
            portada.Location = new Point(9, 7);
            portada.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Mode == modoPelicula)
                try
                {
                MemoryStream ms = new MemoryStream(masterDataSet.Peliculas[i].Portada.ToArray());
                    portada.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {

                }
            else if(Mode == modoSerie)
                try
                {
                    MemoryStream ms = new MemoryStream(masterDataSet.Series[i].Portada.ToArray());
                    portada.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {

                }

            portada.BorderStyle = BorderStyle.FixedSingle;
            portada.Visible = true;

            Label titulo = new Label();
            titulo.Font = new Font("Bahnschrift", 10);
            titulo.ForeColor = Color.White;
            if(Mode == modoPelicula)
                titulo.Text = masterDataSet.Peliculas[i].Titulo;
            else if(Mode == modoSerie)
                titulo.Text = masterDataSet.Series[i].Titulo;
            titulo.Padding = new Padding(6, 0, 2, 0);
            titulo.Dock = DockStyle.Bottom;
            titulo.Visible = true;

            Label precio = new Label();
            precio.Font = new Font("Bahnschrift", 10);
            precio.ForeColor = Color.Green;
            if (Mode == modoPelicula)
                precio.Text = (((float)(Math.Round(Convert.ToDouble(masterDataSet.Peliculas[i].Precio), 2))).ToString() + "€");
            else if (Mode == modoSerie)
                precio.Text = (((float)(Math.Round(Convert.ToDouble(masterDataSet.Series[i].Precio), 2))).ToString() + "€");
            precio.Dock = DockStyle.Bottom;
            precio.Padding = new Padding(6, 0, 2, 0);
            precio.Visible = true;

            Button añadirAlCarro = new Button();
            añadirAlCarro.Size = new Size(20,20);
            añadirAlCarro.Text = "Añadir al carro de la compra";
            añadirAlCarro.Location = new Point(140,220);
            añadirAlCarro.Visible = true;

            Panel cartel = new Panel();
            cartel.Size = new Size(170, 270);
            cartel.Margin = new Padding(20, 20, 20, 20);
            cartel.BackColor = Color.FromArgb(195, 27, 57);
            cartel.Visible = true;

            //Creamos eventos de los carteles-------------------------------
            void CambioColorCartel(Object sender, EventArgs e)
            {
                cartel.BackColor = Color.FromArgb(100, 0, 200);
                return;
            }

            void CartelPeli_Click(object sender, EventArgs e)
            {
                InformaciónPelicula infoPeli = new InformaciónPelicula();

                AddOwnedForm(infoPeli);

                infoPeli.tituloTextBox.Text = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Titulo;

                try//Añadimos la sinopsis
                {
                    infoPeli.sinopsisTextBox.Text = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Sinopsis;
                }
                catch (Exception)
                {

                }

                try//Añadimos la puntuacion
                {
                    infoPeli.puntuacionTextBox.Text = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Puntuacion.ToString();
                }
                catch (Exception)
                {

                }

                try//Añadimos la duracion
                {
                    infoPeli.duracionTextBox.Text = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Duracion.ToString();
                }
                catch (Exception)
                {

                }

                try//Añadimos el estreno
                {
                    infoPeli.textBoxEstreno.Text = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Estreno.ToString();
                }
                catch (Exception)
                {

                }

                try//Añadimos el director
                {
                    infoPeli.directorTextBox.Text = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Director;
                }
                catch (Exception)
                {

                }

                try//Añadir precio
                {
                    infoPeli.precioTextBox.Text = (((float)(Math.Round(Convert.ToDouble(masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Precio), 2))).ToString() + "€");
                }
                catch (Exception)
                {

                }

                try//Añadir portada
                {
                    MemoryStream ms = new MemoryStream(masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Fondo.ToArray());
                    infoPeli.portadaPictureBox.Image = Image.FromStream(ms);

                }
                catch (Exception)
                {

                }

                infoPeli.Show();

                return;
            }

            void CartelSerie_Click(object sender, EventArgs e)
            {
                InformacionSerie infoSerie = new InformacionSerie();

                AddOwnedForm(infoSerie);

                infoSerie.tituloTextBox.Text = masterDataSet.Series[Carteles.IndexOf(cartel)].Titulo;

                try//Añadimos la sinopsis
                {
                    infoSerie.sinopsisTextBox.Text = masterDataSet.Series[Carteles.IndexOf(cartel)].Sinopsis;
                }
                catch (Exception)
                {

                }

                try//Añadimos la puntuacion
                {
                    infoSerie.puntuacionTextBox.Text = masterDataSet.Series[Carteles.IndexOf(cartel)].Puntuacion.ToString();
                }
                catch (Exception)
                {

                }

                try//Añadimos las temporadas
                {
                    infoSerie.temporadasTextBox.Text = masterDataSet.Series[Carteles.IndexOf(cartel)].Temopradas.ToString();
                }
                catch (Exception)
                {

                }

                try//Añadimos el estreno
                {
                    infoSerie.textBoxEstreno.Text = masterDataSet.Series[Carteles.IndexOf(cartel)].Estreno.ToString();
                }
                catch (Exception)
                {

                }

                try//Añadir precio
                {
                    infoSerie.precioTextBox.Text = (((float)(Math.Round(Convert.ToDouble(masterDataSet.Series[Carteles.IndexOf(cartel)].Precio), 2))).ToString() + "€");
                }
                catch (Exception)
                {

                }

                try//Añadir portada
                {
                    MemoryStream ms = new MemoryStream(masterDataSet.Series[Carteles.IndexOf(cartel)].Portada.ToArray());
                    infoSerie.portadaPictureBox.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {

                }

                infoSerie.IdSerie = masterDataSet.Series[Carteles.IndexOf(cartel)].Id;

                for(int j = 1; j <  masterDataSet.Series[Carteles.IndexOf(cartel)].Temopradas; j++)
                    infoSerie.comboBoxTemporada.Items.Add("Temporada " + j);

                MessageBox.Show("jola");
                infoSerie.Show();

                return;
            }

            void MouseAMano(Object sender, EventArgs e)
            {
                Cursor = Cursors.Hand;
                cartel.BackColor = Color.FromArgb(170, 0, 0);

                return;
            }
            void MouseAFlecha(Object sender, EventArgs el)
            {
                Cursor = Cursors.Default;
                cartel.BackColor = Color.FromArgb(195, 27, 57);
                return;
            }

            void AñadirAlCarro(Object sender, EventArgs e)
            {
                if (!InicioSesion)
                {
                    MessageBox.Show("Debe de estar logeado para acceder a esta opción.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TituloCinematografico tc = new TituloCinematografico();

                if (Mode == modoPelicula)
                {
                    tc.Titulo = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Titulo;
                    tc.Sinopsis = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Sinopsis;
                    tc.Estreno = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Estreno;
                    tc.Puntuacion = Convert.ToSingle(masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Puntuacion);
                    tc.Precio = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Precio;
                    tc.Id = masterDataSet.Peliculas[Carteles.IndexOf(cartel)].Id;

                    MessageBox.Show("Pelicula añadida a la cesta correctamente", "Añadir a la cesta",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Mode == modoSerie)
                {
                    tc.Titulo = masterDataSet.Series[Carteles.IndexOf(cartel)].Titulo;
                    tc.Sinopsis = masterDataSet.Series[Carteles.IndexOf(cartel)].Sinopsis;
                    tc.Estreno = masterDataSet.Series[Carteles.IndexOf(cartel)].Estreno;
                    tc.Puntuacion = Convert.ToSingle(masterDataSet.Series[Carteles.IndexOf(cartel)].Puntuacion);
                    tc.Precio = masterDataSet.Series[Carteles.IndexOf(cartel)].Precio;
                    tc.Id = masterDataSet.Series[Carteles.IndexOf(cartel)].Id;

                    MessageBox.Show("Serie añadida a la cesta correctamente", "Añadir a la cesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CarroCompra.Add(tc);

                return;
            }

            //Añadimos Eventos a portada
            if (mode == modoPelicula)
                portada.Click += new EventHandler(CartelPeli_Click);
            else
                portada.Click += new EventHandler(CartelSerie_Click);

            portada.MouseDown += new MouseEventHandler(CambioColorCartel);
            portada.MouseHover += new EventHandler(MouseAMano);
            portada.MouseLeave += new EventHandler(MouseAFlecha);

                //Añadimos Eventos a Titulo
            if(mode == modoPelicula)
                titulo.Click += new EventHandler(CartelPeli_Click);
            else
                titulo.Click += new EventHandler(CartelSerie_Click);

            titulo.MouseDown += new MouseEventHandler(CambioColorCartel);
            titulo.MouseHover += new EventHandler(MouseAMano);
            titulo.MouseLeave += new EventHandler(MouseAFlecha);

                //Añadimo Eventos a botonAñadir
            añadirAlCarro.Click += new EventHandler(AñadirAlCarro);

            //--------------------------------------------------------------

            //Añadimos elementos creados al cartel.
            cartel.Controls.Add(añadirAlCarro);
            cartel.Controls.Add(precio);
            cartel.Controls.Add(portada);
            cartel.Controls.Add(titulo);
            

            return cartel;
        }

        Panel crearCartelR(List<Pelicula> saga, string sSaga)
        {
            //Creamos Portada del Cartel
            PictureBox portada = new PictureBox();
            portada.Size = new Size(150, 210);
            portada.Location = new Point(9, 7);
            portada.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                portada.Image = Image.FromStream(saga[0].Portada);
            }
            catch (Exception)
            {

            }

            portada.BorderStyle = BorderStyle.FixedSingle;
            portada.Visible = true;

            Label titulo = new Label();
            titulo.Font = new Font("Bahnschrift", 10);
            titulo.ForeColor = Color.White;
            titulo.Text = "Paquete " + sSaga;
            titulo.Padding = new Padding(6, 0, 2, 0);
            titulo.Dock = DockStyle.Bottom;
            titulo.Visible = true;

            Label precio = new Label();
            decimal cant = 0;
            precio.Font = new Font("Bahnschrift", 10);
            precio.ForeColor = Color.Green;
            foreach (TituloCinematografico t in saga)
                cant += t.Precio;
            precio.Text = (((float)(Math.Round(Convert.ToDouble(cant), 2))).ToString() + "€");
            precio.Dock = DockStyle.Bottom;
            precio.Padding = new Padding(6, 0, 2, 0);
            precio.Visible = true;

            Button añadirAlCarro = new Button();
            añadirAlCarro.Size = new Size(20, 20);
            añadirAlCarro.Text = "Añadir al carro de la compra";
            añadirAlCarro.Location = new Point(140, 220);
            añadirAlCarro.Visible = true;

            Panel cartel = new Panel();
            cartel.Size = new Size(170, 270);
            cartel.Margin = new Padding(20, 20, 20, 20);
            cartel.BackColor = Color.FromArgb(195, 27, 57);
            cartel.Visible = true;

            //Creamos eventos de los carteles-------------------------------
            void CambioColorCartel(Object sender, EventArgs e)
            {
                cartel.BackColor = Color.FromArgb(100, 0, 200);
                return;
            }

            void CartelPeli_Click(object sender, EventArgs e)
            {
                InfoPaquete infoPack = new InfoPaquete();
                AddOwnedForm(infoPack);
                infoPack.Tc = saga;
                infoPack.Show();

                return;
            }          

            void MouseAMano(Object sender, EventArgs e)
            {
                cartel.BackColor = Color.FromArgb(170, 0, 0);

                return;
            }
            void MouseAFlecha(Object sender, EventArgs el)
            {
                cartel.BackColor = Color.FromArgb(195, 27, 57);
                return;
            }

            void AñadirAlCarro(Object sender, EventArgs e)
            {
                if (!InicioSesion)
                {
                    MessageBox.Show("Debe de estar logeado para acceder a esta opción.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach(TituloCinematografico tc in saga)
                    CarroCompra.Add(tc);

                MessageBox.Show("Paquete añadido correctamente.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            //Añadimos Eventos a portada
            portada.Click += new EventHandler(CartelPeli_Click);
            portada.MouseDown += new MouseEventHandler(CambioColorCartel);
            portada.Cursor = Cursors.Hand;
            portada.MouseHover += new EventHandler(MouseAMano);
            portada.MouseLeave += new EventHandler(MouseAFlecha);

            //Añadimos Eventos a Titulo
            titulo.Click += new EventHandler(CartelPeli_Click);
            titulo.MouseDown += new MouseEventHandler(CambioColorCartel);
            titulo.Cursor = Cursors.Hand;
            titulo.MouseHover += new EventHandler(MouseAMano);
            titulo.MouseLeave += new EventHandler(MouseAFlecha);

            //Añadimo Eventos a botonAñadir
            añadirAlCarro.Click += new EventHandler(AñadirAlCarro);

            //--------------------------------------------------------------

            //Añadimos elementos creados al cartel.
            cartel.Controls.Add(añadirAlCarro);
            cartel.Controls.Add(precio);
            cartel.Controls.Add(portada);
            cartel.Controls.Add(titulo);


            return cartel;
        }

        void GenerarPaquetesPeliculas()
        {
            for (int i = 0; i < masterDataSet.Peliculas.Count; i++)
                if (masterDataSet.Peliculas[i].Titulo.Contains("Piratas del Caribe"))
                {
                    Piratas_del_Caribe.Add(new Pelicula());
                    Piratas_del_Caribe.Last().Titulo = masterDataSet.Peliculas[i].Titulo;
                    Piratas_del_Caribe.Last().Sinopsis = masterDataSet.Peliculas[i].Sinopsis;
                    Piratas_del_Caribe.Last().Estreno = masterDataSet.Peliculas[i].Estreno;
                    Piratas_del_Caribe.Last().Puntuacion = Convert.ToSingle(masterDataSet.Peliculas[i].Puntuacion);
                    Piratas_del_Caribe.Last().Precio = masterDataSet.Peliculas[i].Precio / 5 * 4;
                    Piratas_del_Caribe.Last().Id = masterDataSet.Peliculas[i].Id;
                    Piratas_del_Caribe.Last().Portada = new MemoryStream(masterDataSet.Peliculas[i].Portada.ToArray());

                }

            for (int i = 0; i < masterDataSet.Peliculas.Count; i++)
                if (masterDataSet.Peliculas[i].Titulo.Contains("Star War"))
                {
                    StarWar.Add(new Pelicula());
                    StarWar.Last().Titulo = masterDataSet.Peliculas[i].Titulo;
                    StarWar.Last().Sinopsis = masterDataSet.Peliculas[i].Sinopsis;
                    StarWar.Last().Estreno = masterDataSet.Peliculas[i].Estreno;
                    StarWar.Last().Puntuacion = Convert.ToSingle(masterDataSet.Peliculas[i].Puntuacion);
                    StarWar.Last().Precio = masterDataSet.Peliculas[i].Precio / 5 * 4;
                    StarWar.Last().Id = masterDataSet.Peliculas[i].Id;
                    StarWar.Last().Portada = new MemoryStream(masterDataSet.Peliculas[i].Portada.ToArray());
                }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonPerfil_Click(object sender, EventArgs e)
        {

        }

        
    }

}
