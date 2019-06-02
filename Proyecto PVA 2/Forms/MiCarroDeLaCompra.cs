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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Cerrar
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
            //try
            {
                InsertarFactura();
                generarFactura();
                MessageBox.Show("Factura Añadida con exito");
            }
            /*catch (Exception)
            {
                MessageBox.Show("Error al añadir la factura. ");
            }*/

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Eliminar del carro de la compra.
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

        //Métodos
        decimal CalcularPrecioFinal()
        {
            decimal total = 0; ;

            foreach (TituloCinematografico t in Padre.CarroCompra)
            {
                total += t.Precio;
            }

            textBox1.Text = ((float)(Math.Round(Convert.ToDouble(total),2))).ToString() + "€";

            return total;
        }

        void InsertarFactura()
        {
            string objetosComprados = "";

            foreach (TituloCinematografico t in Padre.CarroCompra)
            {
                if (t is Pelicula)
                    objetosComprados += t.Id + ",1;";
                else if (t is Serie)
                    objetosComprados += t.Id + ",2;";
            }

            facturasTableAdapter.InsertQuery(masterDataSet.Facturas.Count + 10000000, Padre.User.Id, DateTime.Today.ToString(), CalcularPrecioFinal(), objetosComprados);
        }

        void generarFactura()
        {
            SaveFileDialog guardarFactura = new SaveFileDialog();
            guardarFactura.Filter = "Excel (*.xlsx) | .*xlsx ";

            Excel.Application objExcel = new Excel.Application();
            Excel.Range objRango;
            Excel.Workbook objLibro = objExcel.Workbooks.Add(Missing.Value);

            string formula = "=SUMA(";
            int ini, cont; 
            ini = cont = 4;
            
            Excel.Worksheet objHoja = (Excel.Worksheet)objLibro.Worksheets.get_Item(1);

            objHoja.Cells[1,1] = "Factura VideoClub";
            objHoja.Cells[1, cont - 1] = "Titulo"; objHoja.Cells[2, cont - 1] = "Estreno"; objHoja.Cells[3, cont - 1] = "Puntuacion"; objHoja.Cells[4, cont - 1] = "Precio";

            foreach (TituloCinematografico tc in Padre.CarroCompra)
            {
                objHoja.Cells[1, cont] = tc.Titulo; objHoja.Cells[2, cont] = tc.Estreno.ToString(); objHoja.Cells[3, cont] = tc.Puntuacion; objHoja.Cells[4, cont] = tc.Precio;
                formula += "D" + cont + ":";
                cont++;
            }
            formula.TrimEnd(','); formula += ")";

            cont++;
            objRango = objHoja.get_Range(objHoja.Cells[2, cont], Missing.Value);
            objHoja.Cells[1, cont] = "Precio total: ";  objRango.FormulaLocal = formula; objHoja.Cells[4, cont] = "Fecha: "; objHoja.Cells[5, cont] = DateTime.Today.ToString(); cont++;
            objHoja.Cells[4, cont] = "Para: "; objHoja.Cells[5, cont] = Padre.User.CorreoElectronico;
            if (guardarFactura.ShowDialog() == DialogResult.OK)
            {
                objLibro.SaveAs(guardarFactura.FileName);
                objLibro.Close();
            }


            return;
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

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
