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
            System.Windows.Forms.Label portadaLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label numcapLabel;
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label estrenoLabel;
            System.Windows.Forms.Label puntuacionLabel;
            System.Windows.Forms.Label precioLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.portadaPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxEstreno = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAñadirAlCarro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPuntuacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEstreno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTemporada = new System.Windows.Forms.Label();
            this.comboBoxTemporada = new System.Windows.Forms.ComboBox();
            portadaLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            numcapLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            puntuacionLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tituloTextBox);
            this.groupBox1.Controls.Add(this.portadaPictureBox);
            this.groupBox1.Controls.Add(portadaLabel);
            this.groupBox1.Controls.Add(this.textBoxEstreno);
            this.groupBox1.Controls.Add(this.duracionTextBox);
            this.groupBox1.Controls.Add(tituloLabel);
            this.groupBox1.Controls.Add(numcapLabel);
            this.groupBox1.Controls.Add(this.directorTextBox);
            this.groupBox1.Controls.Add(sinopsisLabel);
            this.groupBox1.Controls.Add(directorLabel);
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
            // portadaLabel
            // 
            portadaLabel.AutoSize = true;
            portadaLabel.Location = new System.Drawing.Point(248, 26);
            portadaLabel.Name = "portadaLabel";
            portadaLabel.Size = new System.Drawing.Size(47, 13);
            portadaLabel.TabIndex = 37;
            portadaLabel.Text = "Portada:";
            // 
            // textBoxEstreno
            // 
            this.textBoxEstreno.Location = new System.Drawing.Point(76, 171);
            this.textBoxEstreno.Name = "textBoxEstreno";
            this.textBoxEstreno.ReadOnly = true;
            this.textBoxEstreno.Size = new System.Drawing.Size(143, 20);
            this.textBoxEstreno.TabIndex = 39;
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.Location = new System.Drawing.Point(76, 145);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.ReadOnly = true;
            this.duracionTextBox.Size = new System.Drawing.Size(40, 20);
            this.duracionTextBox.TabIndex = 36;
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
            // numcapLabel
            // 
            numcapLabel.AutoSize = true;
            numcapLabel.Location = new System.Drawing.Point(9, 148);
            numcapLabel.Name = "numcapLabel";
            numcapLabel.Size = new System.Drawing.Size(53, 13);
            numcapLabel.TabIndex = 35;
            numcapLabel.Text = "Capitulos:";
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(76, 197);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.ReadOnly = true;
            this.directorTextBox.Size = new System.Drawing.Size(143, 20);
            this.directorTextBox.TabIndex = 34;
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
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(9, 203);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(47, 13);
            directorLabel.TabIndex = 33;
            directorLabel.Text = "Director:";
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
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(9, 177);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 31;
            estrenoLabel.Text = "Estreno:";
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Location = new System.Drawing.Point(9, 96);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(64, 13);
            puntuacionLabel.TabIndex = 27;
            puntuacionLabel.Text = "Puntuacion:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(76, 119);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(40, 20);
            this.precioTextBox.TabIndex = 30;
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.Location = new System.Drawing.Point(76, 93);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.ReadOnly = true;
            this.puntuacionTextBox.Size = new System.Drawing.Size(40, 20);
            this.puntuacionTextBox.TabIndex = 28;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(9, 122);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 29;
            precioLabel.Text = "Precio:";
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
            this.groupBox2.Controls.Add(this.comboBoxTemporada);
            this.groupBox2.Controls.Add(this.labelTemporada);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 397);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capitulos";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitulo,
            this.columnHeaderDuracion,
            this.columnHeaderEstreno,
            this.columnHeaderPuntuacion,
            this.columnHeaderPrecio});
            this.listView1.Location = new System.Drawing.Point(15, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 324);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderTitulo
            // 
            this.columnHeaderTitulo.Text = "Titulo";
            this.columnHeaderTitulo.Width = 162;
            // 
            // columnHeaderDuracion
            // 
            this.columnHeaderDuracion.Text = "Duracion";
            // 
            // columnHeaderPuntuacion
            // 
            this.columnHeaderPuntuacion.DisplayIndex = 2;
            this.columnHeaderPuntuacion.Text = "Puntuacion";
            this.columnHeaderPuntuacion.Width = 68;
            // 
            // columnHeaderPrecio
            // 
            this.columnHeaderPrecio.DisplayIndex = 3;
            this.columnHeaderPrecio.Text = "Precio";
            // 
            // columnHeaderEstreno
            // 
            this.columnHeaderEstreno.DisplayIndex = 4;
            this.columnHeaderEstreno.Text = "Estreno";
            this.columnHeaderEstreno.Width = 89;
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
            // comboBoxTemporada
            // 
            this.comboBoxTemporada.FormattingEnabled = true;
            this.comboBoxTemporada.Location = new System.Drawing.Point(85, 364);
            this.comboBoxTemporada.Name = "comboBoxTemporada";
            this.comboBoxTemporada.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTemporada.TabIndex = 48;
            this.comboBoxTemporada.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemporada_SelectedIndexChanged);
            // 
            // InformacionSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tituloTextBox;
        public System.Windows.Forms.PictureBox portadaPictureBox;
        public System.Windows.Forms.TextBox textBoxEstreno;
        public System.Windows.Forms.TextBox duracionTextBox;
        public System.Windows.Forms.TextBox directorTextBox;
        public System.Windows.Forms.TextBox sinopsisTextBox;
        public System.Windows.Forms.TextBox precioTextBox;
        public System.Windows.Forms.TextBox puntuacionTextBox;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonAñadirAlCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTitulo;
        private System.Windows.Forms.ColumnHeader columnHeaderDuracion;
        private System.Windows.Forms.ColumnHeader columnHeaderPuntuacion;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecio;
        private System.Windows.Forms.ColumnHeader columnHeaderEstreno;
        private System.Windows.Forms.ComboBox comboBoxTemporada;
        private System.Windows.Forms.Label labelTemporada;
    }
}