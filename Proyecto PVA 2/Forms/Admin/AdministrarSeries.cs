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
    public partial class AdministrarSeries : Form
    {
        //Atributos
        
        //Constructores
        public AdministrarSeries()
        {
            InitializeComponent();
        }

        //Eventos
        private void seriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.capitulosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdministrarSeries_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Capitulos' Puede moverla o quitarla según sea necesario.
            this.capitulosTableAdapter.Fill(this.masterDataSet.Capitulos);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Series' Puede moverla o quitarla según sea necesario.
            this.seriesTableAdapter.Fill(this.masterDataSet.Series);

            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Series' Puede moverla o quitarla según sea necesario.
            this.seriesTableAdapter.Fill(this.masterDataSet.Series);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Capitulos' Puede moverla o quitarla según sea necesario.
            this.capitulosTableAdapter.Fill(this.masterDataSet.Capitulos);
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            id_SerieTextBox.Text = seriesDataGridView.SelectedCells[0].Value.ToString();
            idTextBox1.Text = (masterDataSet.Capitulos.Count + 10000001).ToString();
            
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            string titulo = tituloTextBox1.Text, sinopsis = sinopsisTextBox1.Text, director = directorTextBox.Text, duracion = duracionTextBox.Text, estreno = estrenoDateTimePicker1.Text;
            int temporada = 0;
            decimal precio;
            double puntuacion;
            if (titulo == "")
                titulo = null;
            if (sinopsis == "")
                sinopsis = null;
            if (director == "")
                director = null;
            if (duracion == "")
                duracion = "00:00:00";
            if (precioTextBox1.Text == "")
                precio = 0;
            else precio = Convert.ToDecimal(precioTextBox1.Text);
            if (puntuacionTextBox1.Text == "")
                puntuacion = 0;
            else puntuacion = Convert.ToDouble(puntuacionTextBox1.Text);
            if (temporadaTextBox.Text == "")
                temporada = 1;
            else temporada = Convert.ToInt16(temporadaTextBox.Text);

            try
            {
                capitulosTableAdapter.InsertQuery(Convert.ToInt32(idTextBox1.Text), titulo, sinopsis, duracion, estreno, director, puntuacion, precio, Convert.ToInt32(id_SerieTextBox.Text), temporada);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor siga las instrucciones de subida de datos en el manual para administradores del programa.", "Error base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            capitulosDataGridView.Update();
            capitulosDataGridView.Refresh();
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
                fondoPictureBox.Image = Image.FromFile(ofd.FileName);
        }

        private void seriesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            idTextBox.Text = (masterDataSet.Series.Count + 10000000).ToString();
        }

        private void buttonEditarId_Click(object sender, EventArgs e)
        {
            idTextBox.Enabled = true;
        }

        private void buttonEditarIdSerie_Click(object sender, EventArgs e)
        {
            id_SerieTextBox.Enabled = true;
        }

        private void buttonEditarIdCap_Click(object sender, EventArgs e)
        {
            idTextBox1.Enabled = true;
        }

        private void seriesDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                capitulosTableAdapter.FillByIdSerie(masterDataSet.Capitulos, Convert.ToInt32(seriesDataGridView.SelectedRows[0].Cells[0].Value));
            }
            catch (Exception)
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            idTextBox1.Text = (masterDataSet.Capitulos.Count + 10000000).ToString();
            try
            {
                id_SerieTextBox.Text = seriesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una serie a la que añadirle un capitulo. Si no lo hace, puede que el capitlo a añadir se pierda en la base de datos.", "Posible error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        //Métodos
    }
}
