namespace Proyecto_PVA_2.Forms
{
    partial class AdministrarSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarSeries));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label temopradasLabel;
            System.Windows.Forms.Label estrenoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label puntuacionLabel;
            System.Windows.Forms.Label portadaLabel;
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.SeriesTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            this.seriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.seriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.temopradasTextBox = new System.Windows.Forms.TextBox();
            this.estrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.portadaPictureBox = new System.Windows.Forms.PictureBox();
            this.seriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            idLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            temopradasLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            puntuacionLabel = new System.Windows.Forms.Label();
            portadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).BeginInit();
            this.seriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.masterDataSet;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CapitulosTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = this.seriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // seriesBindingNavigator
            // 
            this.seriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.seriesBindingNavigator.BindingSource = this.seriesBindingSource;
            this.seriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.seriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.seriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.seriesBindingNavigatorSaveItem});
            this.seriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.seriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.seriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.seriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.seriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.seriesBindingNavigator.Name = "seriesBindingNavigator";
            this.seriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.seriesBindingNavigator.Size = new System.Drawing.Size(1275, 25);
            this.seriesBindingNavigator.TabIndex = 0;
            this.seriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // seriesBindingNavigatorSaveItem
            // 
            this.seriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("seriesBindingNavigatorSaveItem.Image")));
            this.seriesBindingNavigatorSaveItem.Name = "seriesBindingNavigatorSaveItem";
            this.seriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.seriesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.seriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.seriesBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 39);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(98, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(84, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(23, 65);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "Titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(98, 62);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(200, 20);
            this.tituloTextBox.TabIndex = 4;
            // 
            // temopradasLabel
            // 
            temopradasLabel.AutoSize = true;
            temopradasLabel.Location = new System.Drawing.Point(23, 169);
            temopradasLabel.Name = "temopradasLabel";
            temopradasLabel.Size = new System.Drawing.Size(69, 13);
            temopradasLabel.TabIndex = 5;
            temopradasLabel.Text = "Temopradas:";
            // 
            // temopradasTextBox
            // 
            this.temopradasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Temopradas", true));
            this.temopradasTextBox.Location = new System.Drawing.Point(98, 166);
            this.temopradasTextBox.Name = "temopradasTextBox";
            this.temopradasTextBox.Size = new System.Drawing.Size(59, 20);
            this.temopradasTextBox.TabIndex = 6;
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(23, 92);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 7;
            estrenoLabel.Text = "Estreno:";
            // 
            // estrenoDateTimePicker
            // 
            this.estrenoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seriesBindingSource, "Estreno", true));
            this.estrenoDateTimePicker.Location = new System.Drawing.Point(98, 88);
            this.estrenoDateTimePicker.Name = "estrenoDateTimePicker";
            this.estrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.estrenoDateTimePicker.TabIndex = 8;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(23, 117);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(98, 114);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(59, 20);
            this.precioTextBox.TabIndex = 10;
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Location = new System.Drawing.Point(551, 42);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(49, 13);
            sinopsisLabel.TabIndex = 11;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Sinopsis", true));
            this.sinopsisTextBox.Location = new System.Drawing.Point(626, 39);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.Size = new System.Drawing.Size(200, 173);
            this.sinopsisTextBox.TabIndex = 12;
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Location = new System.Drawing.Point(23, 143);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(64, 13);
            puntuacionLabel.TabIndex = 13;
            puntuacionLabel.Text = "Puntuacion:";
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Puntuacion", true));
            this.puntuacionTextBox.Location = new System.Drawing.Point(98, 140);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.Size = new System.Drawing.Size(59, 20);
            this.puntuacionTextBox.TabIndex = 14;
            // 
            // portadaLabel
            // 
            portadaLabel.AutoSize = true;
            portadaLabel.Location = new System.Drawing.Point(343, 39);
            portadaLabel.Name = "portadaLabel";
            portadaLabel.Size = new System.Drawing.Size(47, 13);
            portadaLabel.TabIndex = 15;
            portadaLabel.Text = "Portada:";
            // 
            // portadaPictureBox
            // 
            this.portadaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.seriesBindingSource, "Portada", true));
            this.portadaPictureBox.Location = new System.Drawing.Point(418, 39);
            this.portadaPictureBox.Name = "portadaPictureBox";
            this.portadaPictureBox.Size = new System.Drawing.Size(116, 173);
            this.portadaPictureBox.TabIndex = 16;
            this.portadaPictureBox.TabStop = false;
            // 
            // seriesDataGridView
            // 
            this.seriesDataGridView.AutoGenerateColumns = false;
            this.seriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.seriesDataGridView.DataSource = this.seriesBindingSource;
            this.seriesDataGridView.Location = new System.Drawing.Point(26, 258);
            this.seriesDataGridView.Name = "seriesDataGridView";
            this.seriesDataGridView.Size = new System.Drawing.Size(800, 220);
            this.seriesDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Temopradas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Temopradas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estreno";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estreno";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 155;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Puntuacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Puntuacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seriesDataGridView);
            this.groupBox1.Controls.Add(this.portadaPictureBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(portadaLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.puntuacionTextBox);
            this.groupBox1.Controls.Add(tituloLabel);
            this.groupBox1.Controls.Add(puntuacionLabel);
            this.groupBox1.Controls.Add(this.tituloTextBox);
            this.groupBox1.Controls.Add(this.sinopsisTextBox);
            this.groupBox1.Controls.Add(temopradasLabel);
            this.groupBox1.Controls.Add(sinopsisLabel);
            this.groupBox1.Controls.Add(this.temopradasTextBox);
            this.groupBox1.Controls.Add(this.precioTextBox);
            this.groupBox1.Controls.Add(estrenoLabel);
            this.groupBox1.Controls.Add(precioLabel);
            this.groupBox1.Controls.Add(this.estrenoDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 503);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Series";
            // 
            // AdministrarSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seriesBindingNavigator);
            this.Name = "AdministrarSeries";
            this.Text = "AdministrarSeries";
            this.Load += new System.EventHandler(this.AdministrarSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).EndInit();
            this.seriesBindingNavigator.ResumeLayout(false);
            this.seriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private masterDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator seriesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton seriesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox temopradasTextBox;
        private System.Windows.Forms.DateTimePicker estrenoDateTimePicker;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox sinopsisTextBox;
        private System.Windows.Forms.TextBox puntuacionTextBox;
        private System.Windows.Forms.PictureBox portadaPictureBox;
        private System.Windows.Forms.DataGridView seriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}