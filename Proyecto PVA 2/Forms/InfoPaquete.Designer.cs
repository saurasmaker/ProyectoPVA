﻿namespace Proyecto_PVA_2.Forms
{
    partial class InfoPaquete
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPuntuacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDirector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEstreno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitulo,
            this.columnHeaderPuntuacion,
            this.columnHeaderDirector,
            this.columnHeaderEstreno,
            this.columnHeadPrecio});
            this.listView1.Location = new System.Drawing.Point(24, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 344);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitulo
            // 
            this.columnHeaderTitulo.Text = "Titulo";
            this.columnHeaderTitulo.Width = 293;
            // 
            // columnHeaderPuntuacion
            // 
            this.columnHeaderPuntuacion.Text = "Puntuacion";
            this.columnHeaderPuntuacion.Width = 81;
            // 
            // columnHeaderDirector
            // 
            this.columnHeaderDirector.Text = "Director";
            this.columnHeaderDirector.Width = 172;
            // 
            // columnHeaderEstreno
            // 
            this.columnHeaderEstreno.Text = "Estreno";
            this.columnHeaderEstreno.Width = 136;
            // 
            // columnHeadPrecio
            // 
            this.columnHeadPrecio.Text = "Precio";
            // 
            // InfoPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.listView1);
            this.Name = "InfoPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPaquete";
            this.Load += new System.EventHandler(this.InfoPaquete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTitulo;
        private System.Windows.Forms.ColumnHeader columnHeaderPuntuacion;
        private System.Windows.Forms.ColumnHeader columnHeaderDirector;
        private System.Windows.Forms.ColumnHeader columnHeaderEstreno;
        private System.Windows.Forms.ColumnHeader columnHeadPrecio;
    }
}