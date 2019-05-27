namespace Proyecto_PVA_2.Forms
{
    partial class MiCarroDeLaCompra
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
            this.buttonRealizarCompra = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.columnHeaderTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPuntuacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitulo,
            this.columnHeaderPuntuacion,
            this.columnHeaderPrecio});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 295);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonRealizarCompra
            // 
            this.buttonRealizarCompra.Location = new System.Drawing.Point(13, 415);
            this.buttonRealizarCompra.Name = "buttonRealizarCompra";
            this.buttonRealizarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonRealizarCompra.TabIndex = 1;
            this.buttonRealizarCompra.Text = "Comprar";
            this.buttonRealizarCompra.UseVisualStyleBackColor = true;
            this.buttonRealizarCompra.Click += new System.EventHandler(this.buttonRealizarCompra_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(345, 415);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // columnHeaderTitulo
            // 
            this.columnHeaderTitulo.Text = "Título";
            this.columnHeaderTitulo.Width = 239;
            // 
            // columnHeaderPuntuacion
            // 
            this.columnHeaderPuntuacion.Text = "Puntuacion";
            this.columnHeaderPuntuacion.Width = 75;
            // 
            // columnHeaderPrecio
            // 
            this.columnHeaderPrecio.Text = "Precio";
            this.columnHeaderPrecio.Width = 88;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(12, 333);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio total:";
            // 
            // MiCarroDeLaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRealizarCompra);
            this.Controls.Add(this.listView1);
            this.Name = "MiCarroDeLaCompra";
            this.Text = "MiCarroDeLaCompra";
            this.Load += new System.EventHandler(this.MiCarroDeLaCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeaderTitulo;
        private System.Windows.Forms.ColumnHeader columnHeaderPuntuacion;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecio;
        private System.Windows.Forms.Button buttonRealizarCompra;
        private System.Windows.Forms.Button buttonSalir;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}