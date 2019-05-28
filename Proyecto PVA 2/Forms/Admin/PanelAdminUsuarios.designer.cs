namespace Prueba
{
    partial class PanelAdminUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdminUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.pbcerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(314, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURACIÓN DE USUARIOS";
            // 
            // pbcerrar
            // 
            this.pbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbcerrar.Image")));
            this.pbcerrar.Location = new System.Drawing.Point(968, 12);
            this.pbcerrar.Name = "pbcerrar";
            this.pbcerrar.Size = new System.Drawing.Size(20, 20);
            this.pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcerrar.TabIndex = 1;
            this.pbcerrar.TabStop = false;
            this.pbcerrar.Click += new System.EventHandler(this.Pbcerrar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 2;
            this.button1.Text = "AÑADIR USUARIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button2.Location = new System.Drawing.Point(345, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 3;
            this.button2.Text = "MODIFICAR USUARIO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button3.Location = new System.Drawing.Point(501, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.TabIndex = 4;
            this.button3.Text = "ELIMINAR USUARIO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button4.Location = new System.Drawing.Point(657, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 150);
            this.button4.TabIndex = 5;
            this.button4.Text = "LISTAR USUARIOS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(189, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 220);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(500, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 220);
            this.panel2.TabIndex = 7;
            // 
            // PanelAdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbcerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelAdminUsuarios";
            this.Text = "PanelAdminUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbcerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}