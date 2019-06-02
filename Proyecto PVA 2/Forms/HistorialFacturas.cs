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
    public partial class HistorialFacturas : Form
    {
        //Atributos
        PerfilUsuario padre;

        //Constructores
        public HistorialFacturas()
        {
            InitializeComponent();
        }

        public PerfilUsuario Padre { get => padre; set => padre = value; }

        //Eventos
        private void facturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void HistorialFacturas_Load(object sender, EventArgs e)
        {
            Padre = Owner as PerfilUsuario;
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.masterDataSet.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.FillByIdUsuario(this.masterDataSet.Facturas,Padre.User.Id);

        }

        private void facturasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem milista;
            string compra;
            string[] comprados;
            string[] idTit_sop;

            MessageBox.Show("" + masterDataSet.Facturas.Count);

            for (int i = 0; i < masterDataSet.Facturas.Count; i++)
                if (masterDataSet.Facturas[i].Id == Convert.ToInt32(facturasDataGridView.SelectedRows[0].Cells[1].Value))
                {
                    compra = masterDataSet.Facturas[i].Compra;
                    comprados = compra.Split(';');

                    foreach (string s in comprados)
                    {
                        idTit_sop = s.Split(',');
                        if (idTit_sop[1] == "1")
                            for (int j = 0; j < masterDataSet.Peliculas.Count; j++)
                                if (masterDataSet.Peliculas[j].Id.ToString() == idTit_sop[0])
                                {
                                    milista = listView1.Items.Add(masterDataSet.Peliculas[j].Titulo);
                                    milista.SubItems.Add(masterDataSet.Peliculas[j].Precio.ToString());
                                    milista.SubItems.Add("Pelicula");
                                }
                                else if (idTit_sop[1] == "2")
                                    for (int k = 0; j < masterDataSet.Peliculas.Count; k++)
                                        if (masterDataSet.Peliculas[k].Id.ToString() == idTit_sop[0])
                                        {
                                            milista = listView1.Items.Add(masterDataSet.Series[j].Titulo);
                                            milista.SubItems.Add(masterDataSet.Series[k].Precio.ToString());
                                            milista.SubItems.Add("Serie");
                                        }
                    }

                    return;
                }
        }

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
