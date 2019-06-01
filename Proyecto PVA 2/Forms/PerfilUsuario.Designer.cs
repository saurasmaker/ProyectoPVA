namespace Proyecto_PVA_2.Forms
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
            this.labelAlias = new System.Windows.Forms.Label();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.buttonCambiarImagenPerfil = new System.Windows.Forms.Button();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.labelCorreoElectronico = new System.Windows.Forms.Label();
            this.textBoxBiografia = new System.Windows.Forms.TextBox();
            this.labelBiografia = new System.Windows.Forms.Label();
            this.buttonModificarDatosPersonales = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonRestablecerDatos = new System.Windows.Forms.Button();
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.buttonCambiarContraseña = new System.Windows.Forms.Button();
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.round1 = new Proyecto_PVA_2.Forms.Round();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.round1)).BeginInit();
            this.SuspendLayout();
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
            this.buttonCambiarImagenPerfil.Location = new System.Drawing.Point(187, 222);
            this.buttonCambiarImagenPerfil.Name = "buttonCambiarImagenPerfil";
            this.buttonCambiarImagenPerfil.Size = new System.Drawing.Size(128, 23);
            this.buttonCambiarImagenPerfil.TabIndex = 3;
            this.buttonCambiarImagenPerfil.Text = "Cambiar";
            this.buttonCambiarImagenPerfil.UseVisualStyleBackColor = true;
            this.buttonCambiarImagenPerfil.Click += new System.EventHandler(this.buttonCambiarImagenPerfil_Click);
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(335, 209);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 13;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(335, 260);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(125, 20);
            this.textBoxDireccion.TabIndex = 12;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(164, 263);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 11;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(332, 193);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(112, 13);
            this.labelFechaNac.TabIndex = 9;
            this.labelFechaNac.Text = "Fecha de nacimiento: ";
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(335, 160);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(125, 20);
            this.textBoxApellido2.TabIndex = 8;
            // 
            // labelApellido2
            // 
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Location = new System.Drawing.Point(237, 163);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(92, 13);
            this.labelApellido2.TabIndex = 7;
            this.labelApellido2.Text = "Segundo apellido:";
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(335, 107);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(125, 20);
            this.textBoxApellido1.TabIndex = 6;
            // 
            // labelApellido1
            // 
            this.labelApellido1.AutoSize = true;
            this.labelApellido1.Location = new System.Drawing.Point(237, 110);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(78, 13);
            this.labelApellido1.TabIndex = 5;
            this.labelApellido1.Text = "Primer apellido:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(335, 62);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(125, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
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
            // textBoxBiografia
            // 
            this.textBoxBiografia.Location = new System.Drawing.Point(15, 298);
            this.textBoxBiografia.Multiline = true;
            this.textBoxBiografia.Name = "textBoxBiografia";
            this.textBoxBiografia.Size = new System.Drawing.Size(219, 95);
            this.textBoxBiografia.TabIndex = 8;
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
            // imageListIconos
            // 
            this.imageListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconos.ImageStream")));
            this.imageListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconos.Images.SetKeyName(0, "cerrar.png");
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.round1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 435);
            this.panel1.TabIndex = 39;
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
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.buttonSalir);
            this.BarraTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BarraTitulo.Location = new System.Drawing.Point(299, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(245, 24);
            this.BarraTitulo.TabIndex = 38;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // round1
            // 
            this.round1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("round1.BackgroundImage")));
            this.round1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.round1.Location = new System.Drawing.Point(40, 35);
            this.round1.Name = "round1";
            this.round1.Size = new System.Drawing.Size(120, 120);
            this.round1.TabIndex = 1;
            this.round1.TabStop = false;
            // 
            // PerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(544, 433);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.buttonCambiarImagenPerfil);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.buttonCambiarContraseña);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.buttonRestablecerDatos);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxApellido2);
            this.Controls.Add(this.buttonModificarDatosPersonales);
            this.Controls.Add(this.labelApellido2);
            this.Controls.Add(this.textBoxBiografia);
            this.Controls.Add(this.textBoxApellido1);
            this.Controls.Add(this.labelBiografia);
            this.Controls.Add(this.labelApellido1);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCorreoElectronico);
            this.Controls.Add(this.textBoxAlias);
            this.Controls.Add(this.labelAlias);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.round1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Button buttonCambiarImagenPerfil;
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
        private System.Windows.Forms.TextBox textBoxBiografia;
        private System.Windows.Forms.Label labelBiografia;
        private System.Windows.Forms.Button buttonModificarDatosPersonales;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonRestablecerDatos;
        private System.Windows.Forms.Button buttonCambiarContraseña;
        private System.Windows.Forms.ImageList imageListIconos;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private masterDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel BarraTitulo;
        private Round round1;
    }
}