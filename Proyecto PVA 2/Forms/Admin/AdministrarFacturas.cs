using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_PVA_2.Forms.Admin
{
    public partial class AdministrarFacturas : Form
    {
        public AdministrarFacturas()
        {
            InitializeComponent();
        }


        private void facturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdministrarFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.masterDataSet.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.masterDataSet.Facturas);
        }

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturasBindingNavigator_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
