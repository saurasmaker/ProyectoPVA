using Proyecto_PVA_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class InfoPaquete : Form
    {
        //Atributos
        List<Pelicula> tc;
        Inicio padre;

        //Constructores
        public InfoPaquete()
        {
            InitializeComponent();
        }


        //Getters & Setters
        internal List<Pelicula> Tc { get => tc; set => tc = value; }
        public Inicio Padre { get => padre; set => padre = value; }

        //Eventos
        private void InfoPaquete_Load(object sender, EventArgs e)
        {
            ListViewItem milista;

            Padre = Owner as Inicio;

            foreach (Pelicula c in Tc)
            {
                milista = listView1.Items.Add(c.Titulo);
                milista.SubItems.Add(c.Puntuacion.ToString());
                milista.SubItems.Add(c.Direct);
                milista.SubItems.Add(c.Estreno.ToString());
                milista.SubItems.Add(((float)(Math.Round(Convert.ToDouble(c.Precio), 2))).ToString() + "€");
            }
        }
    }
}
