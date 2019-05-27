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
    public partial class MiCarroDeLaCompra : Form
    {
        //Atributos
        Inicio padre;

        //Constructores
        public MiCarroDeLaCompra()
        {
            InitializeComponent();
        }

        //Eventos
        private void MiCarroDeLaCompra_Load(object sender, EventArgs e)
        {
            padre = Owner as Inicio;
            CalcularPrecioFinal();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0] != null)
            {
                padre.CarroCompra.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                CalcularPrecioFinal();
            }
            else
                MessageBox.Show("Debe seleccionar un elemento de la lista para poder eliminarlo.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRealizarCompra_Click(object sender, EventArgs e)
        {
            //Agregar funcion de compra.
        }

        //Métodos
        void CalcularPrecioFinal()
        {
            float total = 0; ;

            foreach (TituloCinematografico t in padre.CarroCompra)
            {
                total += t.Precio;
            }

            textBox1.Text = ((float)(Math.Round(Convert.ToDouble(total),2))).ToString() + "€";

            return;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listView1.SelectedItems[0] != null)
            {
                padre.CarroCompra.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                CalcularPrecioFinal();
            }
            else
                MessageBox.Show("Debe seleccionar un elemento de la lista para poder eliminarlo.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
