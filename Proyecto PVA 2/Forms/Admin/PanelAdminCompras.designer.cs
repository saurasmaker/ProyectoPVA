namespace Prueba
{
    partial class PanelAdminCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdminCompras));
            this.pbcerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcerrar
            // 
            this.pbcerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbcerrar.Image")));
            this.pbcerrar.Location = new System.Drawing.Point(968, 12);
            this.pbcerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbcerrar.Name = "pbcerrar";
            this.pbcerrar.Size = new System.Drawing.Size(20, 20);
            this.pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcerrar.TabIndex = 2;
            this.pbcerrar.TabStop = false;
            this.pbcerrar.Click += new System.EventHandler(this.pbcerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // PanelAdminCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbcerrar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PanelAdminCompras";
            this.Text = "PanelAdminCompras";
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcerrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}