﻿namespace Proyecto_PVA_2.Forms
{
    partial class PerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilUsuario));
            this.pictureBoxImagenPerfil = new System.Windows.Forms.PictureBox();
            this.labelAlias = new System.Windows.Forms.Label();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.buttonCambiarImagenPerfil = new System.Windows.Forms.Button();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.labelCorreoElectronico = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBiografia = new System.Windows.Forms.Label();
            this.buttonModificarDatosPersonales = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonRestablecerDatos = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonCambiarContraseña = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPerfil)).BeginInit();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagenPerfil
            // 
            this.pictureBoxImagenPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagenPerfil.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxImagenPerfil.Name = "pictureBoxImagenPerfil";
            this.pictureBoxImagenPerfil.Size = new System.Drawing.Size(128, 120);
            this.pictureBoxImagenPerfil.TabIndex = 0;
            this.pictureBoxImagenPerfil.TabStop = false;
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(12, 189);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(35, 13);
            this.labelAlias.TabIndex = 1;
            this.labelAlias.Text = "Alias: ";
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Location = new System.Drawing.Point(15, 205);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(125, 20);
            this.textBoxAlias.TabIndex = 2;
            // 
            // buttonCambiarImagenPerfil
            // 
            this.buttonCambiarImagenPerfil.Location = new System.Drawing.Point(12, 149);
            this.buttonCambiarImagenPerfil.Name = "buttonCambiarImagenPerfil";
            this.buttonCambiarImagenPerfil.Size = new System.Drawing.Size(128, 23);
            this.buttonCambiarImagenPerfil.TabIndex = 3;
            this.buttonCambiarImagenPerfil.Text = "Cambiar";
            this.buttonCambiarImagenPerfil.UseVisualStyleBackColor = true;
            this.buttonCambiarImagenPerfil.Click += new System.EventHandler(this.buttonCambiarImagenPerfil_Click);
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatosPersonales.Controls.Add(this.labelDireccion);
            this.groupBoxDatosPersonales.Controls.Add(this.labelFechaNac);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxApellido2);
            this.groupBoxDatosPersonales.Controls.Add(this.labelApellido2);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxApellido1);
            this.groupBoxDatosPersonales.Controls.Add(this.labelApellido1);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.label1);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(262, 30);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(271, 267);
            this.groupBoxDatosPersonales.TabIndex = 4;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            this.groupBoxDatosPersonales.Enter += new System.EventHandler(this.groupBoxDatosPersonales_Enter);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(6, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(125, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(6, 87);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(125, 20);
            this.textBoxApellido1.TabIndex = 6;
            // 
            // labelApellido1
            // 
            this.labelApellido1.AutoSize = true;
            this.labelApellido1.Location = new System.Drawing.Point(3, 71);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(78, 13);
            this.labelApellido1.TabIndex = 5;
            this.labelApellido1.Text = "Primer apellido:";
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(6, 140);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(125, 20);
            this.textBoxApellido2.TabIndex = 8;
            // 
            // labelApellido2
            // 
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Location = new System.Drawing.Point(3, 124);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(92, 13);
            this.labelApellido2.TabIndex = 7;
            this.labelApellido2.Text = "Segundo apellido:";
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(3, 173);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(112, 13);
            this.labelFechaNac.TabIndex = 9;
            this.labelFechaNac.Text = "Fecha de nacimiento: ";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(6, 240);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(125, 20);
            this.textBoxDireccion.TabIndex = 12;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(3, 224);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 11;
            this.labelDireccion.Text = "Dirección:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(6, 189);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 13;
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(15, 251);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(219, 20);
            this.textBoxCorreoElectronico.TabIndex = 6;
            // 
            // labelCorreoElectronico
            // 
            this.labelCorreoElectronico.AutoSize = true;
            this.labelCorreoElectronico.Location = new System.Drawing.Point(12, 235);
            this.labelCorreoElectronico.Name = "labelCorreoElectronico";
            this.labelCorreoElectronico.Size = new System.Drawing.Size(99, 13);
            this.labelCorreoElectronico.TabIndex = 5;
            this.labelCorreoElectronico.Text = "Correo electrónico: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 298);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 95);
            this.textBox1.TabIndex = 8;
            // 
            // labelBiografia
            // 
            this.labelBiografia.AutoSize = true;
            this.labelBiografia.Location = new System.Drawing.Point(12, 282);
            this.labelBiografia.Name = "labelBiografia";
            this.labelBiografia.Size = new System.Drawing.Size(56, 13);
            this.labelBiografia.TabIndex = 7;
            this.labelBiografia.Text = "Biografía: ";
            // 
            // buttonModificarDatosPersonales
            // 
            this.buttonModificarDatosPersonales.Location = new System.Drawing.Point(386, 303);
            this.buttonModificarDatosPersonales.Name = "buttonModificarDatosPersonales";
            this.buttonModificarDatosPersonales.Size = new System.Drawing.Size(147, 23);
            this.buttonModificarDatosPersonales.TabIndex = 9;
            this.buttonModificarDatosPersonales.Text = "Modificar datos personales";
            this.buttonModificarDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(15, 402);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 10;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonRestablecerDatos
            // 
            this.buttonRestablecerDatos.Location = new System.Drawing.Point(217, 402);
            this.buttonRestablecerDatos.Name = "buttonRestablecerDatos";
            this.buttonRestablecerDatos.Size = new System.Drawing.Size(111, 23);
            this.buttonRestablecerDatos.TabIndex = 12;
            this.buttonRestablecerDatos.Text = "Restablecer datos";
            this.buttonRestablecerDatos.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Maroon;
            this.buttonSalir.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSalir.ImageIndex = 0;
            this.buttonSalir.ImageList = this.imageListIconos;
            this.buttonSalir.Location = new System.Drawing.Point(519, -1);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(28, 26);
            this.buttonSalir.TabIndex = 13;
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonCambiarContraseña
            // 
            this.buttonCambiarContraseña.Location = new System.Drawing.Point(422, 402);
            this.buttonCambiarContraseña.Name = "buttonCambiarContraseña";
            this.buttonCambiarContraseña.Size = new System.Drawing.Size(111, 23);
            this.buttonCambiarContraseña.TabIndex = 14;
            this.buttonCambiarContraseña.Text = "Cambiar contraseña";
            this.buttonCambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.buttonSalir);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(544, 24);
            this.BarraTitulo.TabIndex = 38;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // imageListIconos
            // 
            this.imageListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconos.ImageStream")));
            this.imageListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconos.Images.SetKeyName(0, "cerrar.png");
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
            this.tableAdapterManager.PeliculasTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // PerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 433);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.buttonCambiarContraseña);
            this.Controls.Add(this.buttonRestablecerDatos);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonModificarDatosPersonales);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBiografia);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.labelCorreoElectronico);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Controls.Add(this.buttonCambiarImagenPerfil);
            this.Controls.Add(this.textBoxAlias);
            this.Controls.Add(this.labelAlias);
            this.Controls.Add(this.pictureBoxImagenPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPerfil)).EndInit();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagenPerfil;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Button buttonCambiarImagenPerfil;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.Label labelApellido1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.Label labelCorreoElectronico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBiografia;
        private System.Windows.Forms.Button buttonModificarDatosPersonales;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonRestablecerDatos;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonCambiarContraseña;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.ImageList imageListIconos;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private masterDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}