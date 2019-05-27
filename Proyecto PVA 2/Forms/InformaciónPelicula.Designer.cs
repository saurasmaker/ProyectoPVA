namespace Proyecto_PVA_2.Forms
{
    partial class InformaciónPelicula
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
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label puntuacionLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label estrenoLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label duracionLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label portadaLabel;
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.portadaPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxEstreno = new System.Windows.Forms.TextBox();
            this.buttonAñadirAlCarro = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            sinopsisLabel = new System.Windows.Forms.Label();
            puntuacionLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            portadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Location = new System.Drawing.Point(414, 31);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(49, 13);
            sinopsisLabel.TabIndex = 25;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Location = new System.Drawing.Point(20, 101);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(64, 13);
            puntuacionLabel.TabIndex = 27;
            puntuacionLabel.Text = "Puntuacion:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(20, 127);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 29;
            precioLabel.Text = "Precio:";
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(20, 182);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 31;
            estrenoLabel.Text = "Estreno:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(20, 208);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(47, 13);
            directorLabel.TabIndex = 33;
            directorLabel.Text = "Director:";
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.Location = new System.Drawing.Point(20, 153);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(53, 13);
            duracionLabel.TabIndex = 35;
            duracionLabel.Text = "Duracion:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(17, 30);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 23;
            tituloLabel.Text = "Titulo:";
            // 
            // portadaLabel
            // 
            portadaLabel.AutoSize = true;
            portadaLabel.Location = new System.Drawing.Point(259, 31);
            portadaLabel.Name = "portadaLabel";
            portadaLabel.Size = new System.Drawing.Size(47, 13);
            portadaLabel.TabIndex = 37;
            portadaLabel.Text = "Portada:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 286);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(20, 47);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(210, 20);
            this.tituloTextBox.TabIndex = 24;
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.Location = new System.Drawing.Point(417, 47);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.ReadOnly = true;
            this.sinopsisTextBox.Size = new System.Drawing.Size(224, 174);
            this.sinopsisTextBox.TabIndex = 26;
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.Location = new System.Drawing.Point(87, 98);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.ReadOnly = true;
            this.puntuacionTextBox.Size = new System.Drawing.Size(40, 20);
            this.puntuacionTextBox.TabIndex = 28;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(87, 124);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(40, 20);
            this.precioTextBox.TabIndex = 30;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(87, 202);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.ReadOnly = true;
            this.directorTextBox.Size = new System.Drawing.Size(143, 20);
            this.directorTextBox.TabIndex = 34;
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.Location = new System.Drawing.Point(87, 150);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.ReadOnly = true;
            this.duracionTextBox.Size = new System.Drawing.Size(93, 20);
            this.duracionTextBox.TabIndex = 36;
            this.duracionTextBox.TextChanged += new System.EventHandler(this.duracionTextBox_TextChanged);
            // 
            // portadaPictureBox
            // 
            this.portadaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portadaPictureBox.Location = new System.Drawing.Point(262, 48);
            this.portadaPictureBox.Name = "portadaPictureBox";
            this.portadaPictureBox.Size = new System.Drawing.Size(116, 173);
            this.portadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portadaPictureBox.TabIndex = 38;
            this.portadaPictureBox.TabStop = false;
            // 
            // textBoxEstreno
            // 
            this.textBoxEstreno.Location = new System.Drawing.Point(87, 176);
            this.textBoxEstreno.Name = "textBoxEstreno";
            this.textBoxEstreno.ReadOnly = true;
            this.textBoxEstreno.Size = new System.Drawing.Size(143, 20);
            this.textBoxEstreno.TabIndex = 39;
            // 
            // buttonAñadirAlCarro
            // 
            this.buttonAñadirAlCarro.Location = new System.Drawing.Point(587, 258);
            this.buttonAñadirAlCarro.Name = "buttonAñadirAlCarro";
            this.buttonAñadirAlCarro.Size = new System.Drawing.Size(86, 23);
            this.buttonAñadirAlCarro.TabIndex = 40;
            this.buttonAñadirAlCarro.Text = "Añadir al carro";
            this.buttonAñadirAlCarro.UseVisualStyleBackColor = true;
            this.buttonAñadirAlCarro.Click += new System.EventHandler(this.buttonAñadirAlCarro_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(12, 258);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 41;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tituloTextBox);
            this.groupBox1.Controls.Add(this.portadaPictureBox);
            this.groupBox1.Controls.Add(portadaLabel);
            this.groupBox1.Controls.Add(this.textBoxEstreno);
            this.groupBox1.Controls.Add(this.duracionTextBox);
            this.groupBox1.Controls.Add(tituloLabel);
            this.groupBox1.Controls.Add(duracionLabel);
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
            this.groupBox1.Size = new System.Drawing.Size(661, 240);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // InformaciónPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAñadirAlCarro);
            this.Controls.Add(this.statusStrip1);
            this.Name = "InformaciónPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformaciónPelicula";
            this.Load += new System.EventHandler(this.InformaciónPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.TextBox tituloTextBox;
        public System.Windows.Forms.TextBox sinopsisTextBox;
        public System.Windows.Forms.TextBox puntuacionTextBox;
        public System.Windows.Forms.TextBox precioTextBox;
        public System.Windows.Forms.TextBox directorTextBox;
        public System.Windows.Forms.TextBox duracionTextBox;
        public System.Windows.Forms.PictureBox portadaPictureBox;
        public System.Windows.Forms.TextBox textBoxEstreno;
        private System.Windows.Forms.Button buttonAñadirAlCarro;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}