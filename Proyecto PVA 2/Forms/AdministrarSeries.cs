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
    public partial class AdministrarSeries : Form
    {
        public AdministrarSeries()
        {
            InitializeComponent();
        }

        private void seriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdministrarSeries_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Series' Puede moverla o quitarla según sea necesario.
            this.seriesTableAdapter.Fill(this.masterDataSet.Series);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Series' Puede moverla o quitarla según sea necesario.
            this.seriesTableAdapter.Fill(this.masterDataSet.Series);

        }

        private void seriesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void buttonAñadirPortada_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
                portadaPictureBox.Image = Image.FromFile(ofd.FileName);
        }

        private void buttonAñadirFondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
                portadaPictureBox.Image = Image.FromFile(ofd.FileName);
        }
    }
}
