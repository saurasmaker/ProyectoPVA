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
            System.Windows.Forms.Label fondoLabel;
            this.groupBoxSeries = new System.Windows.Forms.GroupBox();
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
            this.fondoPictureBox = new System.Windows.Forms.PictureBox();
            this.seriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAñadirPortada = new System.Windows.Forms.Button();
            this.buttonAñadirFondo = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            temopradasLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            puntuacionLabel = new System.Windows.Forms.Label();
            portadaLabel = new System.Windows.Forms.Label();
            fondoLabel = new System.Windows.Forms.Label();
            this.groupBoxSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).BeginInit();
            this.seriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSeries
            // 
            this.groupBoxSeries.Controls.Add(this.buttonAñadirFondo);
            this.groupBoxSeries.Controls.Add(this.buttonAñadirPortada);
            this.groupBoxSeries.Controls.Add(this.seriesDataGridView);
            this.groupBoxSeries.Controls.Add(idLabel);
            this.groupBoxSeries.Controls.Add(this.idTextBox);
            this.groupBoxSeries.Controls.Add(tituloLabel);
            this.groupBoxSeries.Controls.Add(this.tituloTextBox);
            this.groupBoxSeries.Controls.Add(temopradasLabel);
            this.groupBoxSeries.Controls.Add(this.temopradasTextBox);
            this.groupBoxSeries.Controls.Add(estrenoLabel);
            this.groupBoxSeries.Controls.Add(this.estrenoDateTimePicker);
            this.groupBoxSeries.Controls.Add(precioLabel);
            this.groupBoxSeries.Controls.Add(this.precioTextBox);
            this.groupBoxSeries.Controls.Add(sinopsisLabel);
            this.groupBoxSeries.Controls.Add(this.sinopsisTextBox);
            this.groupBoxSeries.Controls.Add(puntuacionLabel);
            this.groupBoxSeries.Controls.Add(this.puntuacionTextBox);
            this.groupBoxSeries.Controls.Add(portadaLabel);
            this.groupBoxSeries.Controls.Add(this.portadaPictureBox);
            this.groupBoxSeries.Controls.Add(fondoLabel);
            this.groupBoxSeries.Controls.Add(this.fondoPictureBox);
            this.groupBoxSeries.Location = new System.Drawing.Point(12, 28);
            this.groupBoxSeries.Name = "groupBoxSeries";
            this.groupBoxSeries.Size = new System.Drawing.Size(773, 483);
            this.groupBoxSeries.TabIndex = 0;
            this.groupBoxSeries.TabStop = false;
            this.groupBoxSeries.Text = "Series";
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
            this.tableAdapterManager.UsuariosTableAdapter = null;
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
            this.seriesBindingNavigator.TabIndex = 1;
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
            this.seriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.seriesBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(10, 33);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(85, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(10, 59);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 2;
            tituloLabel.Text = "Titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(85, 56);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(200, 20);
            this.tituloTextBox.TabIndex = 3;
            // 
            // temopradasLabel
            // 
            temopradasLabel.AutoSize = true;
            temopradasLabel.Location = new System.Drawing.Point(10, 85);
            temopradasLabel.Name = "temopradasLabel";
            temopradasLabel.Size = new System.Drawing.Size(69, 13);
            temopradasLabel.TabIndex = 4;
            temopradasLabel.Text = "Temopradas:";
            // 
            // temopradasTextBox
            // 
            this.temopradasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Temopradas", true));
            this.temopradasTextBox.Location = new System.Drawing.Point(85, 82);
            this.temopradasTextBox.Name = "temopradasTextBox";
            this.temopradasTextBox.Size = new System.Drawing.Size(200, 20);
            this.temopradasTextBox.TabIndex = 5;
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(10, 112);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 6;
            estrenoLabel.Text = "Estreno:";
            // 
            // estrenoDateTimePicker
            // 
            this.estrenoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seriesBindingSource, "Estreno", true));
            this.estrenoDateTimePicker.Location = new System.Drawing.Point(85, 108);
            this.estrenoDateTimePicker.Name = "estrenoDateTimePicker";
            this.estrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.estrenoDateTimePicker.TabIndex = 7;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(10, 137);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 8;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(85, 134);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioTextBox.TabIndex = 9;
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Location = new System.Drawing.Point(486, 33);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(49, 13);
            sinopsisLabel.TabIndex = 10;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Sinopsis", true));
            this.sinopsisTextBox.Location = new System.Drawing.Point(541, 33);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.Size = new System.Drawing.Size(200, 69);
            this.sinopsisTextBox.TabIndex = 11;
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Location = new System.Drawing.Point(10, 189);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(64, 13);
            puntuacionLabel.TabIndex = 12;
            puntuacionLabel.Text = "Puntuacion:";
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Puntuacion", true));
            this.puntuacionTextBox.Location = new System.Drawing.Point(85, 186);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.Size = new System.Drawing.Size(200, 20);
            this.puntuacionTextBox.TabIndex = 13;
            // 
            // portadaLabel
            // 
            portadaLabel.AutoSize = true;
            portadaLabel.Location = new System.Drawing.Point(300, 33);
            portadaLabel.Name = "portadaLabel";
            portadaLabel.Size = new System.Drawing.Size(47, 13);
            portadaLabel.TabIndex = 14;
            portadaLabel.Text = "Portada:";
            // 
            // portadaPictureBox
            // 
            this.portadaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portadaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.seriesBindingSource, "Portada", true));
            this.portadaPictureBox.Location = new System.Drawing.Point(353, 30);
            this.portadaPictureBox.Name = "portadaPictureBox";
            this.portadaPictureBox.Size = new System.Drawing.Size(115, 176);
            this.portadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portadaPictureBox.TabIndex = 15;
            this.portadaPictureBox.TabStop = false;
            // 
            // fondoLabel
            // 
            fondoLabel.AutoSize = true;
            fondoLabel.Location = new System.Drawing.Point(495, 115);
            fondoLabel.Name = "fondoLabel";
            fondoLabel.Size = new System.Drawing.Size(40, 13);
            fondoLabel.TabIndex = 16;
            fondoLabel.Text = "Fondo:";
            // 
            // fondoPictureBox
            // 
            this.fondoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fondoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.seriesBindingSource, "Fondo", true));
            this.fondoPictureBox.Location = new System.Drawing.Point(541, 112);
            this.fondoPictureBox.Name = "fondoPictureBox";
            this.fondoPictureBox.Size = new System.Drawing.Size(200, 94);
            this.fondoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondoPictureBox.TabIndex = 17;
            this.fondoPictureBox.TabStop = false;
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
            this.seriesDataGridView.Location = new System.Drawing.Point(13, 238);
            this.seriesDataGridView.Name = "seriesDataGridView";
            this.seriesDataGridView.Size = new System.Drawing.Size(728, 220);
            this.seriesDataGridView.TabIndex = 18;
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
            this.dataGridViewTextBoxColumn2.Width = 185;
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
            // buttonAñadirPortada
            // 
            this.buttonAñadirPortada.Location = new System.Drawing.Point(322, 184);
            this.buttonAñadirPortada.Name = "buttonAñadirPortada";
            this.buttonAñadirPortada.Size = new System.Drawing.Size(25, 23);
            this.buttonAñadirPortada.TabIndex = 19;
            this.buttonAñadirPortada.Text = "Añadir Portada";
            this.buttonAñadirPortada.UseVisualStyleBackColor = true;
            this.buttonAñadirPortada.Click += new System.EventHandler(this.buttonAñadirPortada_Click);
            // 
            // buttonAñadirFondo
            // 
            this.buttonAñadirFondo.Location = new System.Drawing.Point(510, 184);
            this.buttonAñadirFondo.Name = "buttonAñadirFondo";
            this.buttonAñadirFondo.Size = new System.Drawing.Size(25, 23);
            this.buttonAñadirFondo.TabIndex = 20;
            this.buttonAñadirFondo.Text = "Añadir Fondo";
            this.buttonAñadirFondo.UseVisualStyleBackColor = true;
            this.buttonAñadirFondo.Click += new System.EventHandler(this.buttonAñadirFondo_Click);
            // 
            // AdministrarSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 522);
            this.Controls.Add(this.seriesBindingNavigator);
            this.Controls.Add(this.groupBoxSeries);
            this.Name = "AdministrarSeries";
            this.Text = "AdministrarSeries";
            this.Load += new System.EventHandler(this.AdministrarSeries_Load);
            this.groupBoxSeries.ResumeLayout(false);
            this.groupBoxSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).EndInit();
            this.seriesBindingNavigator.ResumeLayout(false);
            this.seriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSeries;
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
        private System.Windows.Forms.DataGridView seriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox temopradasTextBox;
        private System.Windows.Forms.DateTimePicker estrenoDateTimePicker;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox sinopsisTextBox;
        private System.Windows.Forms.TextBox puntuacionTextBox;
        private System.Windows.Forms.PictureBox portadaPictureBox;
        private System.Windows.Forms.PictureBox fondoPictureBox;
        private System.Windows.Forms.Button buttonAñadirFondo;
        private System.Windows.Forms.Button buttonAñadirPortada;
    }
}