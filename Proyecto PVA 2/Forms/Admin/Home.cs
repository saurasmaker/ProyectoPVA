using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void capitulosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.masterDataSet.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Series' Puede moverla o quitarla según sea necesario.
            this.seriesTableAdapter.Fill(this.masterDataSet.Series);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.masterDataSet.Peliculas);

            contusuarios.Text = masterDataSet.Usuarios.Count.ToString();
            contseries.Text = masterDataSet.Series.Count.ToString();
            contpeliculas.Text = masterDataSet.Peliculas.Count.ToString();
        }
    }
}
