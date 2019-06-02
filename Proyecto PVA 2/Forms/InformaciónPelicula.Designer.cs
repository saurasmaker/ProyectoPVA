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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buttonAñadirAlCarro = new System.Windows.Forms.Button();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.textBoxEstreno = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.portadaPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buttonAñadirAlCarro
            // 
            this.buttonAñadirAlCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.buttonAñadirAlCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAñadirAlCarro.FlatAppearance.BorderSize = 0;
            this.buttonAñadirAlCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadirAlCarro.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirAlCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.buttonAñadirAlCarro.Location = new System.Drawing.Point(540, 29);
            this.buttonAñadirAlCarro.Name = "buttonAñadirAlCarro";
            this.buttonAñadirAlCarro.Size = new System.Drawing.Size(122, 23);
            this.buttonAñadirAlCarro.TabIndex = 40;
            this.buttonAñadirAlCarro.Text = "Añadir al carro";
            this.buttonAñadirAlCarro.UseVisualStyleBackColor = false;
            this.buttonAñadirAlCarro.Click += new System.EventHandler(this.buttonAñadirAlCarro_Click);
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.puntuacionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puntuacionTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionTextBox.ForeColor = System.Drawing.Color.Silver;
            this.puntuacionTextBox.Location = new System.Drawing.Point(23, 61);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.ReadOnly = true;
            this.puntuacionTextBox.Size = new System.Drawing.Size(40, 20);
            this.puntuacionTextBox.TabIndex = 28;
            this.puntuacionTextBox.Text = "8/10";
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.precioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioTextBox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.precioTextBox.Location = new System.Drawing.Point(344, 29);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(59, 26);
            this.precioTextBox.TabIndex = 30;
            this.precioTextBox.Text = "2,24€";
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.sinopsisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sinopsisTextBox.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinopsisTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.sinopsisTextBox.Location = new System.Drawing.Point(23, 99);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.ReadOnly = true;
            this.sinopsisTextBox.Size = new System.Drawing.Size(264, 190);
            this.sinopsisTextBox.TabIndex = 26;
            this.sinopsisTextBox.Text = "El aventurero capitán Jack Sparrow piratea en aguas caribeñas, pero su andanzas t" +
    "erminan cuando su enemigo, el Capitán Barbossa, después de robarle su barco, el " +
    "Perla Negra.";
            // 
            // directorTextBox
            // 
            this.directorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.directorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directorTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorTextBox.ForeColor = System.Drawing.Color.Silver;
            this.directorTextBox.Location = new System.Drawing.Point(293, 61);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.ReadOnly = true;
            this.directorTextBox.Size = new System.Drawing.Size(143, 20);
            this.directorTextBox.TabIndex = 34;
            this.directorTextBox.Text = "Gore Verbinski";
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.duracionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duracionTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionTextBox.ForeColor = System.Drawing.Color.Silver;
            this.duracionTextBox.Location = new System.Drawing.Point(69, 61);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.ReadOnly = true;
            this.duracionTextBox.Size = new System.Drawing.Size(109, 20);
            this.duracionTextBox.TabIndex = 36;
            this.duracionTextBox.Text = "143 minutos";
            this.duracionTextBox.TextChanged += new System.EventHandler(this.duracionTextBox_TextChanged);
            // 
            // textBoxEstreno
            // 
            this.textBoxEstreno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.textBoxEstreno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEstreno.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstreno.ForeColor = System.Drawing.Color.Silver;
            this.textBoxEstreno.Location = new System.Drawing.Point(171, 61);
            this.textBoxEstreno.Name = "textBoxEstreno";
            this.textBoxEstreno.ReadOnly = true;
            this.textBoxEstreno.Size = new System.Drawing.Size(116, 20);
            this.textBoxEstreno.TabIndex = 39;
            this.textBoxEstreno.Text = "9 de julio, 2003";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tituloTextBox.Location = new System.Drawing.Point(23, 20);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(315, 39);
            this.tituloTextBox.TabIndex = 24;
            this.tituloTextBox.Text = "PIRATAS DEL CARIBE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(62, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 25);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(162, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Location = new System.Drawing.Point(286, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 25);
            this.panel3.TabIndex = 44;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // portadaPictureBox
            // 
            this.portadaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.portadaPictureBox.Location = new System.Drawing.Point(165, 29);
            this.portadaPictureBox.Name = "portadaPictureBox";
            this.portadaPictureBox.Size = new System.Drawing.Size(509, 311);
            this.portadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portadaPictureBox.TabIndex = 45;
            this.portadaPictureBox.TabStop = false;
            this.portadaPictureBox.Click += new System.EventHandler(this.portadaPictureBox_Click_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.Location = new System.Drawing.Point(20, 303);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(48, 16);
            this.linkLabel2.TabIndex = 46;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cerrar";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 15);
            this.panel4.TabIndex = 47;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseDown);
            // 
            // InformaciónPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(674, 363);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(this.buttonAñadirAlCarro);
            this.Controls.Add(this.textBoxEstreno);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.duracionTextBox);
            this.Controls.Add(this.puntuacionTextBox);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.sinopsisTextBox);
            this.Controls.Add(this.portadaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformaciónPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformaciónPelicula";
            this.Load += new System.EventHandler(this.InformaciónPelicula_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonAñadirAlCarro;
        public System.Windows.Forms.TextBox puntuacionTextBox;
        public System.Windows.Forms.TextBox precioTextBox;
        public System.Windows.Forms.TextBox sinopsisTextBox;
        public System.Windows.Forms.TextBox directorTextBox;
        public System.Windows.Forms.TextBox duracionTextBox;
        public System.Windows.Forms.TextBox textBoxEstreno;
        public System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.PictureBox portadaPictureBox;
        private System.Windows.Forms.Panel panel4;
    }
}