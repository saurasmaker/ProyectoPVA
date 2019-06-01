using Proyecto_PVA_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PVA_2.Forms
{
    public partial class MiCarroDeLaCompra : Form
    {
        //Librería Capture
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Atributos
        Inicio padre;

        //Getters & Setters
        public Inicio Padre { get => padre; set => padre = value; }

        //Constructores
        public MiCarroDeLaCompra()
        {
            InitializeComponent();
        }

        //Eventos
        private void MiCarroDeLaCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.masterDataSet.Facturas);
            Padre = Owner as Inicio;
            CalcularPrecioFinal();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0] != null && listView1.SelectedItems.Count == 1)
            {
                Padre.CarroCompra.RemoveAt(listView1.SelectedItems[0].Index);
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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonRealizarCompra_Click(object sender, EventArgs e)
        {
            //Agregar funcion de compra.
        }

        //Métodos
        void CalcularPrecioFinal()
        {
            float total = 0; ;

            foreach (TituloCinematografico t in Padre.CarroCompra)
            {
                total += t.Precio;
            }

            textBox1.Text = ((float)(Math.Round(Convert.ToDouble(total),2))).ToString() + "€";

            return;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            if (listView1.SelectedItems[0] != null)
            {
                Padre.CarroCompra.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                CalcularPrecioFinal();
            }
            else
                MessageBox.Show("Debe seleccionar un elemento de la lista para poder eliminarlo.", "Error de campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void facturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        //Eventos Inútiles
        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

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


    }
}
