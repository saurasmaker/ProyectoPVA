﻿namespace Proyecto_PVA_2.Forms
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.linkLabelRegistrarse = new System.Windows.Forms.LinkLabel();
            this.linkLabelContraseñaOlvidada = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pbcerrar = new System.Windows.Forms.PictureBox();
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.buttonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAceptar.Location = new System.Drawing.Point(48, 384);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(218, 32);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Entrar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click_1);
            // 
            // linkLabelRegistrarse
            // 
            this.linkLabelRegistrarse.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.linkLabelRegistrarse.AutoSize = true;
            this.linkLabelRegistrarse.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrarse.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabelRegistrarse.Location = new System.Drawing.Point(79, 446);
            this.linkLabelRegistrarse.Name = "linkLabelRegistrarse";
            this.linkLabelRegistrarse.Size = new System.Drawing.Size(143, 19);
            this.linkLabelRegistrarse.TabIndex = 6;
            this.linkLabelRegistrarse.TabStop = true;
            this.linkLabelRegistrarse.Text = "¿Sin cuenta? Únete";
            this.linkLabelRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrarse_LinkClicked);
            // 
            // linkLabelContraseñaOlvidada
            // 
            this.linkLabelContraseñaOlvidada.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.linkLabelContraseñaOlvidada.AutoSize = true;
            this.linkLabelContraseñaOlvidada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelContraseñaOlvidada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelContraseñaOlvidada.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelContraseñaOlvidada.Location = new System.Drawing.Point(70, 337);
            this.linkLabelContraseñaOlvidada.Name = "linkLabelContraseñaOlvidada";
            this.linkLabelContraseñaOlvidada.Size = new System.Drawing.Size(187, 16);
            this.linkLabelContraseñaOlvidada.TabIndex = 4;
            this.linkLabelContraseñaOlvidada.TabStop = true;
            this.linkLabelContraseñaOlvidada.Text = "¿Has olvidado la contraseña?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 193);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(33, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.AcceptsReturn = true;
            this.textBoxContraseña.AcceptsTab = true;
            this.textBoxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContraseña.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.ForeColor = System.Drawing.Color.Gray;
            this.textBoxContraseña.Location = new System.Drawing.Point(61, 299);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(171, 19);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.Text = "Contraseña";
            this.textBoxContraseña.Click += new System.EventHandler(this.textBoxContraseña_Click);
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.AcceptsReturn = true;
            this.textBoxCorreoElectronico.AcceptsTab = true;
            this.textBoxCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.textBoxCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreoElectronico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCorreoElectronico.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoElectronico.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(61, 252);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(171, 19);
            this.textBoxCorreoElectronico.TabIndex = 1;
            this.textBoxCorreoElectronico.Text = "Correo Electrónico";
            this.textBoxCorreoElectronico.Click += new System.EventHandler(this.textBoxCorreoElectronico_Click);
            this.textBoxCorreoElectronico.TextChanged += new System.EventHandler(this.textBoxCorreoElectronico_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel2.Location = new System.Drawing.Point(33, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(33, 249);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel1.Location = new System.Drawing.Point(33, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 16;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrar.BackgroundImage")));
            this.buttonMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Location = new System.Drawing.Point(263, 298);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(20, 20);
            this.buttonMostrar.TabIndex = 3;
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            this.buttonMostrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMostrar_MouseDown);
            this.buttonMostrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMostrar_MouseUp);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(124, 474);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ahora no";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.BarraTitulo.Controls.Add(this.pbcerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(319, 42);
            this.BarraTitulo.TabIndex = 37;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pbcerrar
            // 
            this.pbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbcerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbcerrar.Image")));
            this.pbcerrar.Location = new System.Drawing.Point(298, 5);
            this.pbcerrar.Name = "pbcerrar";
            this.pbcerrar.Size = new System.Drawing.Size(16, 17);
            this.pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcerrar.TabIndex = 0;
            this.pbcerrar.TabStop = false;
            this.pbcerrar.Click += new System.EventHandler(this.Pbcerrar_Click);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.masterDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CapitulosTableAdapter = null;
            this.tableAdapterManager.FacturasTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(319, 515);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelContraseñaOlvidada);
            this.Controls.Add(this.linkLabelRegistrarse);
            this.Controls.Add(this.buttonAceptar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.LinkLabel linkLabelRegistrarse;
        private System.Windows.Forms.LinkLabel linkLabelContraseñaOlvidada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel BarraTitulo;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private masterDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pbcerrar;
    }
}