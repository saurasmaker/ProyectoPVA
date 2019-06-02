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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionSerie));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.portadaPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxEstreno = new System.Windows.Forms.TextBox();
            this.temporadasTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.buttonAñadirAlCarro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.capitulosDataGridView = new System.Windows.Forms.DataGridView();
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.comboBoxTemporada = new System.Windows.Forms.ComboBox();
            this.labelTemporada = new System.Windows.Forms.Label();
            this.capitulosTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.CapitulosTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.SeriesTableAdapter();
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
            this.pbcerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.capitulosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portadaLabel
            // 
            portadaLabel.AutoSize = true;
            portadaLabel.Location = new System.Drawing.Point(360, 9);
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
            numTempLabel.Location = new System.Drawing.Point(9, 105);
            numTempLabel.Name = "numTempLabel";
            numTempLabel.Size = new System.Drawing.Size(69, 13);
            numTempLabel.TabIndex = 35;
            numTempLabel.Text = "Temporadas:";
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Location = new System.Drawing.Point(24, 233);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(49, 13);
            sinopsisLabel.TabIndex = 25;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(9, 134);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 31;
            estrenoLabel.Text = "Estreno:";
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Location = new System.Drawing.Point(9, 53);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(64, 13);
            puntuacionLabel.TabIndex = 27;
            puntuacionLabel.Text = "Puntuacion:";
            puntuacionLabel.Click += new System.EventHandler(this.PuntuacionLabel_Click);
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(9, 79);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 29;
            precioLabel.Text = "Precio:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 405);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.ForeColor = System.Drawing.Color.White;
            this.tituloTextBox.Location = new System.Drawing.Point(48, 25);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(210, 13);
            this.tituloTextBox.TabIndex = 24;
            this.tituloTextBox.Text = "TITULO";
            // 
            // portadaPictureBox
            // 
            this.portadaPictureBox.Location = new System.Drawing.Point(336, 25);
            this.portadaPictureBox.Name = "portadaPictureBox";
            this.portadaPictureBox.Size = new System.Drawing.Size(143, 190);
            this.portadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portadaPictureBox.TabIndex = 38;
            this.portadaPictureBox.TabStop = false;
            // 
            // textBoxEstreno
            // 
            this.textBoxEstreno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.textBoxEstreno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEstreno.ForeColor = System.Drawing.Color.White;
            this.textBoxEstreno.Location = new System.Drawing.Point(76, 134);
            this.textBoxEstreno.Name = "textBoxEstreno";
            this.textBoxEstreno.ReadOnly = true;
            this.textBoxEstreno.Size = new System.Drawing.Size(143, 13);
            this.textBoxEstreno.TabIndex = 39;
            this.textBoxEstreno.Text = "5545";
            // 
            // temporadasTextBox
            // 
            this.temporadasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.temporadasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temporadasTextBox.ForeColor = System.Drawing.Color.White;
            this.temporadasTextBox.Location = new System.Drawing.Point(76, 105);
            this.temporadasTextBox.Name = "temporadasTextBox";
            this.temporadasTextBox.ReadOnly = true;
            this.temporadasTextBox.Size = new System.Drawing.Size(40, 13);
            this.temporadasTextBox.TabIndex = 36;
            this.temporadasTextBox.Text = "8";
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.sinopsisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sinopsisTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sinopsisTextBox.ForeColor = System.Drawing.Color.White;
            this.sinopsisTextBox.Location = new System.Drawing.Point(3, 263);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.ReadOnly = true;
            this.sinopsisTextBox.Size = new System.Drawing.Size(479, 139);
            this.sinopsisTextBox.TabIndex = 26;
            this.sinopsisTextBox.Text = "sinopsis";
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.precioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioTextBox.ForeColor = System.Drawing.Color.White;
            this.precioTextBox.Location = new System.Drawing.Point(76, 79);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(40, 13);
            this.precioTextBox.TabIndex = 30;
            this.precioTextBox.Text = "1.22";
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.puntuacionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puntuacionTextBox.ForeColor = System.Drawing.Color.White;
            this.puntuacionTextBox.Location = new System.Drawing.Point(76, 53);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.ReadOnly = true;
            this.puntuacionTextBox.Size = new System.Drawing.Size(40, 13);
            this.puntuacionTextBox.TabIndex = 28;
            this.puntuacionTextBox.Text = "10";
            // 
            // buttonAñadirAlCarro
            // 
            this.buttonAñadirAlCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAñadirAlCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAñadirAlCarro.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonAñadirAlCarro.Location = new System.Drawing.Point(1099, 447);
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
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(503, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 405);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capitulos";
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
            this.capitulosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.capitulosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capitulosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.capitulosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.capitulosDataGridView.ColumnHeadersHeight = 31;
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
            this.capitulosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.capitulosDataGridView.GridColor = System.Drawing.SystemColors.WindowText;
            this.capitulosDataGridView.Location = new System.Drawing.Point(3, 68);
            this.capitulosDataGridView.MultiSelect = false;
            this.capitulosDataGridView.Name = "capitulosDataGridView";
            this.capitulosDataGridView.ReadOnly = true;
            this.capitulosDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.capitulosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.capitulosDataGridView.RowHeadersVisible = false;
            this.capitulosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.capitulosDataGridView.Size = new System.Drawing.Size(679, 334);
            this.capitulosDataGridView.TabIndex = 48;
            this.capitulosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CapitulosDataGridView_CellContentClick);
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
            // comboBoxTemporada
            // 
            this.comboBoxTemporada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTemporada.FormattingEnabled = true;
            this.comboBoxTemporada.Items.AddRange(new object[] {
            "Todas"});
            this.comboBoxTemporada.Location = new System.Drawing.Point(92, 30);
            this.comboBoxTemporada.Name = "comboBoxTemporada";
            this.comboBoxTemporada.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTemporada.TabIndex = 48;
            this.comboBoxTemporada.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemporada_SelectedIndexChanged);
            // 
            // labelTemporada
            // 
            this.labelTemporada.AutoSize = true;
            this.labelTemporada.Location = new System.Drawing.Point(22, 33);
            this.labelTemporada.Name = "labelTemporada";
            this.labelTemporada.Size = new System.Drawing.Size(64, 13);
            this.labelTemporada.TabIndex = 47;
            this.labelTemporada.Text = "Temporada:";
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sinopsis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sinopsis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estreno";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estreno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn6.HeaderText = "Director";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Temporada";
            this.dataGridViewTextBoxColumn10.HeaderText = "Temporada";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // pbcerrar
            // 
            this.pbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbcerrar.Image")));
            this.pbcerrar.Location = new System.Drawing.Point(1185, 3);
            this.pbcerrar.Name = "pbcerrar";
            this.pbcerrar.Size = new System.Drawing.Size(12, 12);
            this.pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcerrar.TabIndex = 48;
            this.pbcerrar.TabStop = false;
            this.pbcerrar.Click += new System.EventHandler(this.Pbcerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.pbcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 30);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // InformacionSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1200, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAñadirAlCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformacionSerie";
            this.Text = "InformacionSerie";
            this.Load += new System.EventHandler(this.InformacionSerie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pbcerrar;
        private System.Windows.Forms.Panel panel1;
    }
}