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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionSerie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.textBoxEstreno = new System.Windows.Forms.TextBox();
            this.temporadasTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.buttonAñadirAlCarro = new System.Windows.Forms.Button();
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.capitulosTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.CapitulosTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.SeriesTableAdapter();
            this.pbcerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTemporada = new System.Windows.Forms.Label();
            this.comboBoxTemporada = new System.Windows.Forms.ComboBox();
            this.capitulosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tituloTextBox.Location = new System.Drawing.Point(26, 36);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(231, 39);
            this.tituloTextBox.TabIndex = 24;
            this.tituloTextBox.Text = "BREAKING BAD";
            // 
            // textBoxEstreno
            // 
            this.textBoxEstreno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.textBoxEstreno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEstreno.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstreno.ForeColor = System.Drawing.Color.Silver;
            this.textBoxEstreno.Location = new System.Drawing.Point(190, 79);
            this.textBoxEstreno.Name = "textBoxEstreno";
            this.textBoxEstreno.ReadOnly = true;
            this.textBoxEstreno.Size = new System.Drawing.Size(143, 20);
            this.textBoxEstreno.TabIndex = 39;
            this.textBoxEstreno.Text = "20 de enero, 2008";
            // 
            // temporadasTextBox
            // 
            this.temporadasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.temporadasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temporadasTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporadasTextBox.ForeColor = System.Drawing.Color.Silver;
            this.temporadasTextBox.Location = new System.Drawing.Point(72, 79);
            this.temporadasTextBox.Name = "temporadasTextBox";
            this.temporadasTextBox.ReadOnly = true;
            this.temporadasTextBox.Size = new System.Drawing.Size(111, 20);
            this.temporadasTextBox.TabIndex = 36;
            this.temporadasTextBox.Text = "8 temporadas";
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.precioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioTextBox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.ForeColor = System.Drawing.Color.White;
            this.precioTextBox.Location = new System.Drawing.Point(266, 47);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(66, 26);
            this.precioTextBox.TabIndex = 30;
            this.precioTextBox.Text = "15,99€";
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.puntuacionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puntuacionTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionTextBox.ForeColor = System.Drawing.Color.Silver;
            this.puntuacionTextBox.Location = new System.Drawing.Point(26, 79);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.ReadOnly = true;
            this.puntuacionTextBox.Size = new System.Drawing.Size(40, 20);
            this.puntuacionTextBox.TabIndex = 28;
            this.puntuacionTextBox.Text = "9/10";
            // 
            // buttonAñadirAlCarro
            // 
            this.buttonAñadirAlCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.buttonAñadirAlCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAñadirAlCarro.FlatAppearance.BorderSize = 0;
            this.buttonAñadirAlCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadirAlCarro.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirAlCarro.ForeColor = System.Drawing.Color.White;
            this.buttonAñadirAlCarro.Location = new System.Drawing.Point(503, 49);
            this.buttonAñadirAlCarro.Name = "buttonAñadirAlCarro";
            this.buttonAñadirAlCarro.Size = new System.Drawing.Size(110, 23);
            this.buttonAñadirAlCarro.TabIndex = 43;
            this.buttonAñadirAlCarro.Text = "Añadir al carro";
            this.buttonAñadirAlCarro.UseVisualStyleBackColor = false;
            this.buttonAñadirAlCarro.Click += new System.EventHandler(this.buttonAñadirAlCarro_Click);
            // 
            // capitulosBindingSource
            // 
            this.capitulosBindingSource.DataMember = "Capitulos";
            this.capitulosBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pbcerrar
            // 
            this.pbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcerrar.BackgroundImage")));
            this.pbcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbcerrar.Location = new System.Drawing.Point(610, 6);
            this.pbcerrar.Name = "pbcerrar";
            this.pbcerrar.Size = new System.Drawing.Size(20, 20);
            this.pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcerrar.TabIndex = 48;
            this.pbcerrar.TabStop = false;
            this.pbcerrar.Click += new System.EventHandler(this.Pbcerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.pbcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 30);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelTemporada
            // 
            this.labelTemporada.AutoSize = true;
            this.labelTemporada.Location = new System.Drawing.Point(350, 36);
            this.labelTemporada.Name = "labelTemporada";
            this.labelTemporada.Size = new System.Drawing.Size(64, 13);
            this.labelTemporada.TabIndex = 47;
            this.labelTemporada.Text = "Temporada:";
            // 
            // comboBoxTemporada
            // 
            this.comboBoxTemporada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.comboBoxTemporada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTemporada.FormattingEnabled = true;
            this.comboBoxTemporada.Items.AddRange(new object[] {
            "Todas"});
            this.comboBoxTemporada.Location = new System.Drawing.Point(353, 51);
            this.comboBoxTemporada.Name = "comboBoxTemporada";
            this.comboBoxTemporada.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTemporada.TabIndex = 48;
            this.comboBoxTemporada.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemporada_SelectedIndexChanged);
            // 
            // capitulosDataGridView
            // 
            this.capitulosDataGridView.AllowUserToAddRows = false;
            this.capitulosDataGridView.AllowUserToDeleteRows = false;
            this.capitulosDataGridView.AllowUserToResizeColumns = false;
            this.capitulosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.capitulosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.capitulosDataGridView.AutoGenerateColumns = false;
            this.capitulosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.capitulosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.capitulosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capitulosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.capitulosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.capitulosDataGridView.ColumnHeadersHeight = 31;
            this.capitulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.capitulosDataGridView.DataSource = this.capitulosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.capitulosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.capitulosDataGridView.GridColor = System.Drawing.SystemColors.WindowText;
            this.capitulosDataGridView.Location = new System.Drawing.Point(353, 93);
            this.capitulosDataGridView.MultiSelect = false;
            this.capitulosDataGridView.Name = "capitulosDataGridView";
            this.capitulosDataGridView.ReadOnly = true;
            this.capitulosDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.capitulosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.capitulosDataGridView.RowHeadersVisible = false;
            this.capitulosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.capitulosDataGridView.Size = new System.Drawing.Size(260, 304);
            this.capitulosDataGridView.TabIndex = 48;
            this.capitulosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CapitulosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Puntuacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Puntuacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_Serie";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id_Serie";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(65, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(183, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 25);
            this.panel3.TabIndex = 51;
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.sinopsisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sinopsisTextBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinopsisTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.sinopsisTextBox.Location = new System.Drawing.Point(26, 122);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.ReadOnly = true;
            this.sinopsisTextBox.Size = new System.Drawing.Size(264, 190);
            this.sinopsisTextBox.TabIndex = 52;
            this.sinopsisTextBox.Text = "El aventurero capitán Jack Sparrow piratea en aguas caribeñas, pero su andanzas t" +
    "erminan cuando su enemigo, el Capitán Barbossa, después de robarle su barco, el " +
    "Perla Negra.";
            // 
            // InformacionSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(635, 418);
            this.Controls.Add(this.sinopsisTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.capitulosDataGridView);
            this.Controls.Add(this.comboBoxTemporada);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(this.labelTemporada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxEstreno);
            this.Controls.Add(this.temporadasTextBox);
            this.Controls.Add(this.buttonAñadirAlCarro);
            this.Controls.Add(this.puntuacionTextBox);
            this.Controls.Add(this.precioTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformacionSerie";
            this.Text = "InformacionSerie";
            this.Load += new System.EventHandler(this.InformacionSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.capitulosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tituloTextBox;
        public System.Windows.Forms.TextBox textBoxEstreno;
        public System.Windows.Forms.TextBox temporadasTextBox;
        public System.Windows.Forms.TextBox precioTextBox;
        public System.Windows.Forms.TextBox puntuacionTextBox;
        private System.Windows.Forms.Button buttonAñadirAlCarro;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource capitulosBindingSource;
        private masterDataSetTableAdapters.CapitulosTableAdapter capitulosTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private masterDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.PictureBox pbcerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTemporada;
        public System.Windows.Forms.ComboBox comboBoxTemporada;
        private System.Windows.Forms.DataGridView capitulosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox sinopsisTextBox;
    }
}