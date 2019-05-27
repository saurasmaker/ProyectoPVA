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
            this.estrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.portadaPictureBox = new System.Windows.Forms.PictureBox();
            sinopsisLabel = new System.Windows.Forms.Label();
            puntuacionLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            portadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Location = new System.Drawing.Point(409, 20);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(49, 13);
            sinopsisLabel.TabIndex = 25;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Location = new System.Drawing.Point(15, 90);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(64, 13);
            puntuacionLabel.TabIndex = 27;
            puntuacionLabel.Text = "Puntuacion:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(15, 116);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 29;
            precioLabel.Text = "Precio:";
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(15, 171);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 31;
            estrenoLabel.Text = "Estreno:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(15, 194);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(47, 13);
            directorLabel.TabIndex = 33;
            directorLabel.Text = "Director:";
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.Location = new System.Drawing.Point(15, 142);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(53, 13);
            duracionLabel.TabIndex = 35;
            duracionLabel.Text = "Duracion:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(12, 19);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 23;
            tituloLabel.Text = "Titulo:";
            // 
            // portadaLabel
            // 
            portadaLabel.AutoSize = true;
            portadaLabel.Location = new System.Drawing.Point(254, 20);
            portadaLabel.Name = "portadaLabel";
            portadaLabel.Size = new System.Drawing.Size(47, 13);
            portadaLabel.TabIndex = 37;
            portadaLabel.Text = "Portada:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 227);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(15, 36);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(143, 20);
            this.tituloTextBox.TabIndex = 24;
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.Location = new System.Drawing.Point(412, 36);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.ReadOnly = true;
            this.sinopsisTextBox.Size = new System.Drawing.Size(224, 174);
            this.sinopsisTextBox.TabIndex = 26;
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.Location = new System.Drawing.Point(82, 87);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.ReadOnly = true;
            this.puntuacionTextBox.Size = new System.Drawing.Size(40, 20);
            this.puntuacionTextBox.TabIndex = 28;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(82, 113);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(40, 20);
            this.precioTextBox.TabIndex = 30;
            // 
            // estrenoDateTimePicker
            // 
            this.estrenoDateTimePicker.Enabled = false;
            this.estrenoDateTimePicker.Location = new System.Drawing.Point(82, 165);
            this.estrenoDateTimePicker.Name = "estrenoDateTimePicker";
            this.estrenoDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.estrenoDateTimePicker.TabIndex = 32;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(82, 191);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.ReadOnly = true;
            this.directorTextBox.Size = new System.Drawing.Size(143, 20);
            this.directorTextBox.TabIndex = 34;
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.Location = new System.Drawing.Point(82, 139);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.ReadOnly = true;
            this.duracionTextBox.Size = new System.Drawing.Size(93, 20);
            this.duracionTextBox.TabIndex = 36;
            this.duracionTextBox.TextChanged += new System.EventHandler(this.duracionTextBox_TextChanged);
            // 
            // portadaPictureBox
            // 
            this.portadaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portadaPictureBox.Location = new System.Drawing.Point(257, 37);
            this.portadaPictureBox.Name = "portadaPictureBox";
            this.portadaPictureBox.Size = new System.Drawing.Size(116, 173);
            this.portadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portadaPictureBox.TabIndex = 38;
            this.portadaPictureBox.TabStop = false;
            // 
            // InformaciónPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 249);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(sinopsisLabel);
            this.Controls.Add(this.sinopsisTextBox);
            this.Controls.Add(puntuacionLabel);
            this.Controls.Add(this.puntuacionTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(estrenoLabel);
            this.Controls.Add(this.estrenoDateTimePicker);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(duracionLabel);
            this.Controls.Add(this.duracionTextBox);
            this.Controls.Add(portadaLabel);
            this.Controls.Add(this.portadaPictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Name = "InformaciónPelicula";
            this.Text = "InformaciónPelicula";
            this.Load += new System.EventHandler(this.InformaciónPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.TextBox tituloTextBox;
        public System.Windows.Forms.TextBox sinopsisTextBox;
        public System.Windows.Forms.TextBox puntuacionTextBox;
        public System.Windows.Forms.TextBox precioTextBox;
        public System.Windows.Forms.DateTimePicker estrenoDateTimePicker;
        public System.Windows.Forms.TextBox directorTextBox;
        public System.Windows.Forms.TextBox duracionTextBox;
        public System.Windows.Forms.PictureBox portadaPictureBox;
    }
}