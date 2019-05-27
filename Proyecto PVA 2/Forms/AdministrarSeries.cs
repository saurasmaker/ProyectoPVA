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

        }
    }
}
