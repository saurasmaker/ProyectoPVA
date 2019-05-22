namespace Proyecto_PVA_2.Forms
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
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.checkBoxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelRegistrarse = new System.Windows.Forms.LinkLabel();
            this.linkLabelContraseñaOlvidada = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(12, 29);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(115, 13);
            this.labelCorreo.TabIndex = 0;
            this.labelCorreo.Text = "Correo electrónico:";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(12, 79);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(75, 13);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(15, 45);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(201, 20);
            this.textBoxCorreo.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(15, 95);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(201, 20);
            this.textBoxContraseña.TabIndex = 3;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // checkBoxMostrarContraseña
            // 
            this.checkBoxMostrarContraseña.AutoSize = true;
            this.checkBoxMostrarContraseña.Location = new System.Drawing.Point(15, 121);
            this.checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            this.checkBoxMostrarContraseña.Size = new System.Drawing.Size(120, 17);
            this.checkBoxMostrarContraseña.TabIndex = 4;
            this.checkBoxMostrarContraseña.Text = "Mostrar contraseña.";
            this.checkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Si ha olvidado la contraseña pinche";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(34, 240);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(121, 240);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Si aún no tiene una cuenta pinche";
            // 
            // linkLabelRegistrarse
            // 
            this.linkLabelRegistrarse.AutoSize = true;
            this.linkLabelRegistrarse.Location = new System.Drawing.Point(178, 192);
            this.linkLabelRegistrarse.Name = "linkLabelRegistrarse";
            this.linkLabelRegistrarse.Size = new System.Drawing.Size(32, 13);
            this.linkLabelRegistrarse.TabIndex = 10;
            this.linkLabelRegistrarse.TabStop = true;
            this.linkLabelRegistrarse.Text = "aquí.";
            // 
            // linkLabelContraseñaOlvidada
            // 
            this.linkLabelContraseñaOlvidada.AutoSize = true;
            this.linkLabelContraseñaOlvidada.Location = new System.Drawing.Point(183, 162);
            this.linkLabelContraseñaOlvidada.Name = "linkLabelContraseñaOlvidada";
            this.linkLabelContraseñaOlvidada.Size = new System.Drawing.Size(32, 13);
            this.linkLabelContraseñaOlvidada.TabIndex = 11;
            this.linkLabelContraseñaOlvidada.TabStop = true;
            this.linkLabelContraseñaOlvidada.Text = "aquí.";
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 278);
            this.Controls.Add(this.linkLabelContraseñaOlvidada);
            this.Controls.Add(this.linkLabelRegistrarse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMostrarContraseña);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelCorreo);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.CheckBox checkBoxMostrarContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelRegistrarse;
        private System.Windows.Forms.LinkLabel linkLabelContraseñaOlvidada;
        public System.Windows.Forms.TextBox textBoxCorreo;
        public System.Windows.Forms.TextBox textBoxContraseña;
    }
}