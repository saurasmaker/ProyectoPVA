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
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.buttonCambiarImagenPerfil = new System.Windows.Forms.Button();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.textBoxBiografia = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.round1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.textBoxAlias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlias.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.textBoxAlias.Location = new System.Drawing.Point(3, 172);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(197, 29);
            this.textBoxAlias.TabIndex = 2;
            this.textBoxAlias.Text = "@ammar";
            this.textBoxAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAlias.TextChanged += new System.EventHandler(this.textBoxAlias_TextChanged);
            // 
            // buttonCambiarImagenPerfil
            // 
            this.buttonCambiarImagenPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCambiarImagenPerfil.BackgroundImage")));
            this.buttonCambiarImagenPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCambiarImagenPerfil.FlatAppearance.BorderSize = 0;
            this.buttonCambiarImagenPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiarImagenPerfil.Location = new System.Drawing.Point(144, 132);
            this.buttonCambiarImagenPerfil.Name = "buttonCambiarImagenPerfil";
            this.buttonCambiarImagenPerfil.Size = new System.Drawing.Size(18, 23);
            this.buttonCambiarImagenPerfil.TabIndex = 3;
            this.buttonCambiarImagenPerfil.UseVisualStyleBackColor = true;
            this.buttonCambiarImagenPerfil.Click += new System.EventHandler(this.buttonCambiarImagenPerfil_Click);
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(8, 20);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(304, 27);
            this.dateTimePickerFechaNacimiento.TabIndex = 13;
            this.dateTimePickerFechaNacimiento.Value = new System.DateTime(1994, 4, 28, 17, 7, 0, 0);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.Location = new System.Drawing.Point(7, 22);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(305, 23);
            this.textBoxDireccion.TabIndex = 12;
            this.textBoxDireccion.Text = "Venice Beach, LA";
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxApellido2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido2.ForeColor = System.Drawing.Color.Black;
            this.textBoxApellido2.Location = new System.Drawing.Point(8, 23);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(149, 23);
            this.textBoxApellido2.TabIndex = 8;
            this.textBoxApellido2.Text = "Brag";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.Black;
            this.textBoxNombre.Location = new System.Drawing.Point(11, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(301, 23);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.Text = "Ammar ";
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.textBoxCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreoElectronico.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoElectronico.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(3, 207);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(197, 20);
            this.textBoxCorreoElectronico.TabIndex = 6;
            this.textBoxCorreoElectronico.Text = "example@email.com";
            this.textBoxCorreoElectronico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBiografia
            // 
            this.textBoxBiografia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.textBoxBiografia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBiografia.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBiografia.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxBiografia.Location = new System.Drawing.Point(14, 248);
            this.textBoxBiografia.Multiline = true;
            this.textBoxBiografia.Name = "textBoxBiografia";
            this.textBoxBiografia.Size = new System.Drawing.Size(173, 134);
            this.textBoxBiografia.TabIndex = 8;
            this.textBoxBiografia.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.";
            this.textBoxBiografia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonModificarDatosPersonales
            // 
            this.buttonModificarDatosPersonales.Location = new System.Drawing.Point(324, 359);
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
            this.buttonRestablecerDatos.Location = new System.Drawing.Point(207, 359);
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
            this.buttonCambiarContraseña.Location = new System.Drawing.Point(354, 398);
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
            this.panel1.Controls.Add(this.buttonCambiarImagenPerfil);
            this.panel1.Controls.Add(this.textBoxAlias);
            this.panel1.Controls.Add(this.textBoxCorreoElectronico);
            this.panel1.Controls.Add(this.textBoxBiografia);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 435);
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
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.BarraTitulo.Controls.Add(this.buttonSalir);
            this.BarraTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BarraTitulo.Location = new System.Drawing.Point(201, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(343, 24);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(214, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 54);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre";
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxApellido1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido1.ForeColor = System.Drawing.Color.Black;
            this.textBoxApellido1.Location = new System.Drawing.Point(9, 22);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(301, 23);
            this.textBoxApellido1.TabIndex = 6;
            this.textBoxApellido1.Text = "Kandil";
            this.textBoxApellido1.TextChanged += new System.EventHandler(this.textBoxApellido1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.textBoxApellido1);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.groupBox2.Location = new System.Drawing.Point(215, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 54);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primer Apellido";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.textBoxApellido2);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.groupBox3.Location = new System.Drawing.Point(214, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 54);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Segundo Apellido";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.groupBox4.Location = new System.Drawing.Point(214, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 54);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha de nacimiento";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Controls.Add(this.textBoxDireccion);
            this.groupBox5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.groupBox5.Location = new System.Drawing.Point(214, 281);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 54);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dirección";
            // 
            // PerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 433);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCambiarContraseña);
            this.Controls.Add(this.buttonRestablecerDatos);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonModificarDatosPersonales);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.round1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Button buttonCambiarImagenPerfil;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.TextBox textBoxBiografia;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}