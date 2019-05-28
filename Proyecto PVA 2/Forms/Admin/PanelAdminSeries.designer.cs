namespace Prueba
{
    partial class PanelAdminSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdminSeries));
            this.pbcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcerrar
            // 
            this.pbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbcerrar.Image")));
            this.pbcerrar.Location = new System.Drawing.Point(968, 12);
            this.pbcerrar.Name = "pbcerrar";
            this.pbcerrar.Size = new System.Drawing.Size(20, 20);
            this.pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcerrar.TabIndex = 3;
            this.pbcerrar.TabStop = false;
            this.pbcerrar.Click += new System.EventHandler(this.Pbcerrar_Click);
            // 
            // PanelAdminSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pbcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelAdminSeries";
            this.Text = "PanelAdminSeries";
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcerrar;
    }
}