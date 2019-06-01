namespace Proyecto_PVA_2.Forms
{
    partial class InformacionSerie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label portadaLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label numTempLabel;
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label estrenoLabel;
            System.Windows.Forms.Label puntuacionLabel;
            System.Windows.Forms.Label precioLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.portadaPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxEstreno = new System.Windows.Forms.TextBox();
            this.temporadasTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAñadirAlCarro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTemporada = new System.Windows.Forms.ComboBox();
            this.labelTemporada = new System.Windows.Forms.Label();
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capitulosTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.CapitulosTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.SeriesTableAdapter();
            this.capitulosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            portadaLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            numTempLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            puntuacionLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // portadaLabel
            // 
            portadaLabel.AutoSize = true;
            portadaLabel.Location = new System.Drawing.Point(248, 26);
            portadaLabel.Name = "portadaLabel";
            portadaLabel.Size = new System.Drawing.Size(47, 13);
            portadaLabel.TabIndex = 37;
            portadaLabel.Text = "Portada:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(6, 25);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 23;
            tituloLabel.Text = "Titulo:";
            // 
            // numTempLabel
            // 
            numTempLabel.AutoSize = true;
            numTempLabel.Location = new System.Drawing.Point(9, 173);
            numTempLabel.Name = "numTempLabel";
            numTempLabel.Size = new System.Drawing.Size(69, 13);
            numTempLabel.TabIndex = 35;
            numTempLabel.Text = "Temporadas:";
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Location = new System.Drawing.Point(9, 231);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(49, 13);
            sinopsisLabel.TabIndex = 25;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(9, 202);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 31;
            estrenoLabel.Text = "Estreno:";
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Location = new System.Drawing.Point(9, 121);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(64, 13);
            puntuacionLabel.TabIndex = 27;
            puntuacionLabel.Text = "Puntuacion:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(9, 147);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 29;
            precioLabel.Text = "Precio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tituloTextBox);
            this.groupBox1.Controls.Add(this.portadaPictureBox);
            this.groupBox1.Controls.Add(portadaLabel);
            this.groupBox1.Controls.Add(this.textBoxEstreno);
            this.groupBox1.Controls.Add(this.temporadasTextBox);
            this.groupBox1.Controls.Add(tituloLabel);
            this.groupBox1.Controls.Add(numTempLabel);
            this.groupBox1.Controls.Add(sinopsisLabel);
            this.groupBox1.Controls.Add(this.sinopsisTextBox);
            this.groupBox1.Controls.Add(estrenoLabel);
            this.groupBox1.Controls.Add(puntuacionLabel);
            this.groupBox1.Controls.Add(this.precioTextBox);
            this.groupBox1.Controls.Add(this.puntuacionTextBox);
            this.groupBox1.Controls.Add(precioLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 397);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(9, 42);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(210, 20);
            this.tituloTextBox.TabIndex = 24;
            // 
            // portadaPictureBox
            // 
            this.portadaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portadaPictureBox.Location = new System.Drawing.Point(251, 43);
            this.portadaPictureBox.Name = "portadaPictureBox";
            this.portadaPictureBox.Size = new System.Drawing.Size(116, 173);
            this.portadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portadaPictureBox.TabIndex = 38;
            this.portadaPictureBox.TabStop = false;
            // 
            // textBoxEstreno
            // 
            this.textBoxEstreno.Location = new System.Drawing.Point(76, 196);
            this.textBoxEstreno.Name = "textBoxEstreno";
            this.textBoxEstreno.ReadOnly = true;
            this.textBoxEstreno.Size = new System.Drawing.Size(143, 20);
            this.textBoxEstreno.TabIndex = 39;
            // 
            // temporadasTextBox
            // 
            this.temporadasTextBox.Location = new System.Drawing.Point(76, 170);
            this.temporadasTextBox.Name = "temporadasTextBox";
            this.temporadasTextBox.ReadOnly = true;
            this.temporadasTextBox.Size = new System.Drawing.Size(40, 20);
            this.temporadasTextBox.TabIndex = 36;
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.Location = new System.Drawing.Point(12, 247);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.ReadOnly = true;
            this.sinopsisTextBox.Size = new System.Drawing.Size(355, 139);
            this.sinopsisTextBox.TabIndex = 26;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(76, 144);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(40, 20);
            this.precioTextBox.TabIndex = 30;
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.Location = new System.Drawing.Point(76, 118);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.ReadOnly = true;
            this.puntuacionTextBox.Size = new System.Drawing.Size(40, 20);
            this.puntuacionTextBox.TabIndex = 28;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(12, 415);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 44;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonAñadirAlCarro
            // 
            this.buttonAñadirAlCarro.Location = new System.Drawing.Point(770, 415);
            this.buttonAñadirAlCarro.Name = "buttonAñadirAlCarro";
            this.buttonAñadirAlCarro.Size = new System.Drawing.Size(86, 23);
            this.buttonAñadirAlCarro.TabIndex = 43;
            this.buttonAñadirAlCarro.Text = "Añadir al carro";
            this.buttonAñadirAlCarro.UseVisualStyleBackColor = true;
            this.buttonAñadirAlCarro.Click += new System.EventHandler(this.buttonAñadirAlCarro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.capitulosDataGridView);
            this.groupBox2.Controls.Add(this.comboBoxTemporada);
            this.groupBox2.Controls.Add(this.labelTemporada);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 405);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capitulos";
            // 
            // comboBoxTemporada
            // 
            this.comboBoxTemporada.FormattingEnabled = true;
            this.comboBoxTemporada.Items.AddRange(new object[] {
            "Todas"});
            this.comboBoxTemporada.Location = new System.Drawing.Point(85, 364);
            this.comboBoxTemporada.Name = "comboBoxTemporada";
            this.comboBoxTemporada.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTemporada.TabIndex = 48;
            this.comboBoxTemporada.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemporada_SelectedIndexChanged);
            // 
            // labelTemporada
            // 
            this.labelTemporada.AutoSize = true;
            this.labelTemporada.Location = new System.Drawing.Point(15, 367);
            this.labelTemporada.Name = "labelTemporada";
            this.labelTemporada.Size = new System.Drawing.Size(64, 13);
            this.labelTemporada.TabIndex = 47;
            this.labelTemporada.Text = "Temporada:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capitulosBindingSource
            // 
            this.capitulosBindingSource.DataMember = "Capitulos";
            this.capitulosBindingSource.DataSource = this.masterDataSet;
            // 
            // capitulosTableAdapter
            // 
            this.capitulosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CapitulosTableAdapter = this.capitulosTableAdapter;
            this.tableAdapterManager.FacturasTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.masterDataSet;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // capitulosDataGridView
            // 
            this.capitulosDataGridView.AutoGenerateColumns = false;
            this.capitulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.capitulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.capitulosDataGridView.DataSource = this.capitulosBindingSource;
            this.capitulosDataGridView.Location = new System.Drawing.Point(18, 24);
            this.capitulosDataGridView.Name = "capitulosDataGridView";
            this.capitulosDataGridView.Size = new System.Drawing.Size(476, 334);
            this.capitulosDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sinopsis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sinopsis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estreno";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estreno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn6.HeaderText = "Director";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Puntuacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Puntuacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_Serie";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id_Serie";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Temporada";
            this.dataGridViewTextBoxColumn10.HeaderText = "Temporada";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // InformacionSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAñadirAlCarro);
            this.Name = "InformacionSerie";
            this.Text = "InformacionSerie";
            this.Load += new System.EventHandler(this.InformacionSerie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tituloTextBox;
        public System.Windows.Forms.PictureBox portadaPictureBox;
        public System.Windows.Forms.TextBox textBoxEstreno;
        public System.Windows.Forms.TextBox temporadasTextBox;
        public System.Windows.Forms.TextBox sinopsisTextBox;
        public System.Windows.Forms.TextBox precioTextBox;
        public System.Windows.Forms.TextBox puntuacionTextBox;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonAñadirAlCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTemporada;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource capitulosBindingSource;
        private masterDataSetTableAdapters.CapitulosTableAdapter capitulosTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.ComboBox comboBoxTemporada;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private masterDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.DataGridView capitulosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}