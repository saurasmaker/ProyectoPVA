﻿namespace Proyecto_PVA_2
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.statusStripInicio = new System.Windows.Forms.StatusStrip();
            this.toolStripInicio = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpciones = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPeliculas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSeries = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIniciarSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCarroCompra = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRecomendaciones = new System.Windows.Forms.ToolStripButton();
            this.panelIzquierda = new System.Windows.Forms.Panel();
            this.buttonGeneroFamiliar = new System.Windows.Forms.Button();
            this.buttonGeneroDrama = new System.Windows.Forms.Button();
            this.buttonGeneroDocumentales = new System.Windows.Forms.Button();
            this.buttonGeneroDibujosAnimados = new System.Windows.Forms.Button();
            this.buttonGeneroDeporte = new System.Windows.Forms.Button();
            this.buttonGeneroCrimen = new System.Windows.Forms.Button();
            this.buttonGeneroComedia = new System.Windows.Forms.Button();
            this.buttonGeneroCienciaFiccion = new System.Windows.Forms.Button();
            this.buttonGeneroAventura = new System.Windows.Forms.Button();
            this.buttonGeneroAccion = new System.Windows.Forms.Button();
            this.labelGeneros = new System.Windows.Forms.Label();
            this.buttonDesplegar = new System.Windows.Forms.Button();
            this.tableLayoutPanelCentro = new System.Windows.Forms.TableLayoutPanel();
            this.panelDerecha = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.buttonAdministrarPeliculas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdminUsuarios = new System.Windows.Forms.Button();
            this.buttonAbrirPanelAdmin = new System.Windows.Forms.Button();
            this.masterDataSet = new Proyecto_PVA_2.masterDataSet();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.PeliculasTableAdapter();
            this.tableAdapterManager = new Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager();
            this.seriesTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.SeriesTableAdapter();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Proyecto_PVA_2.masterDataSetTableAdapters.UsuariosTableAdapter();
            this.toolStripInicio.SuspendLayout();
            this.panelIzquierda.SuspendLayout();
            this.panelDerecha.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripInicio
            // 
            this.statusStripInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.statusStripInicio, "statusStripInicio");
            this.statusStripInicio.Name = "statusStripInicio";
            // 
            // toolStripInicio
            // 
            resources.ApplyResources(this.toolStripInicio, "toolStripInicio");
            this.toolStripInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.toolStripInicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripButtonOpciones,
            this.toolStripButtonPeliculas,
            this.toolStripButtonSeries,
            this.toolStripButtonIniciarSesion,
            this.toolStripButtonCarroCompra,
            this.toolStripButtonRecomendaciones});
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButtonInicio
            // 
            resources.ApplyResources(this.toolStripButtonInicio, "toolStripButtonInicio");
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInicio.Name = "toolStripButtonInicio";
            this.toolStripButtonInicio.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // toolStripButtonOpciones
            // 
            resources.ApplyResources(this.toolStripButtonOpciones, "toolStripButtonOpciones");
            this.toolStripButtonOpciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolStripButtonOpciones.Name = "toolStripButtonOpciones";
            this.toolStripButtonOpciones.Click += new System.EventHandler(this.toolStripButtonPerfil_Click);
            // 
            // toolStripButtonPeliculas
            // 
            this.toolStripButtonPeliculas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonPeliculas, "toolStripButtonPeliculas");
            this.toolStripButtonPeliculas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButtonPeliculas.Margin = new System.Windows.Forms.Padding(188, 1, 0, 2);
            this.toolStripButtonPeliculas.Name = "toolStripButtonPeliculas";
            this.toolStripButtonPeliculas.Click += new System.EventHandler(this.toolStripButtonPeliculas_Click);
            // 
            // toolStripButtonSeries
            // 
            this.toolStripButtonSeries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonSeries, "toolStripButtonSeries");
            this.toolStripButtonSeries.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButtonSeries.Name = "toolStripButtonSeries";
            this.toolStripButtonSeries.Click += new System.EventHandler(this.toolStripButtonSeries_Click);
            // 
            // toolStripButtonIniciarSesion
            // 
            this.toolStripButtonIniciarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonIniciarSesion, "toolStripButtonIniciarSesion");
            this.toolStripButtonIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButtonIniciarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonIniciarSesion.Name = "toolStripButtonIniciarSesion";
            this.toolStripButtonIniciarSesion.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButtonCarroCompra
            // 
            this.toolStripButtonCarroCompra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonCarroCompra, "toolStripButtonCarroCompra");
            this.toolStripButtonCarroCompra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCarroCompra.Name = "toolStripButtonCarroCompra";
            this.toolStripButtonCarroCompra.Click += new System.EventHandler(this.toolStripButtonCarroCompra_Click);
            // 
            // toolStripButtonRecomendaciones
            // 
            this.toolStripButtonRecomendaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonRecomendaciones, "toolStripButtonRecomendaciones");
            this.toolStripButtonRecomendaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButtonRecomendaciones.Name = "toolStripButtonRecomendaciones";
            this.toolStripButtonRecomendaciones.Click += new System.EventHandler(this.toolStripButtonRecomendaciones_Click);
            // 
            // panelIzquierda
            // 
            this.panelIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.panelIzquierda.Controls.Add(this.buttonGeneroFamiliar);
            this.panelIzquierda.Controls.Add(this.buttonGeneroDrama);
            this.panelIzquierda.Controls.Add(this.buttonGeneroDocumentales);
            this.panelIzquierda.Controls.Add(this.buttonGeneroDibujosAnimados);
            this.panelIzquierda.Controls.Add(this.buttonGeneroDeporte);
            this.panelIzquierda.Controls.Add(this.buttonGeneroCrimen);
            this.panelIzquierda.Controls.Add(this.buttonGeneroComedia);
            this.panelIzquierda.Controls.Add(this.buttonGeneroCienciaFiccion);
            this.panelIzquierda.Controls.Add(this.buttonGeneroAventura);
            this.panelIzquierda.Controls.Add(this.buttonGeneroAccion);
            this.panelIzquierda.Controls.Add(this.labelGeneros);
            this.panelIzquierda.Controls.Add(this.buttonDesplegar);
            resources.ApplyResources(this.panelIzquierda, "panelIzquierda");
            this.panelIzquierda.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonGeneroFamiliar
            // 
            resources.ApplyResources(this.buttonGeneroFamiliar, "buttonGeneroFamiliar");
            this.buttonGeneroFamiliar.FlatAppearance.BorderSize = 0;
            this.buttonGeneroFamiliar.Name = "buttonGeneroFamiliar";
            this.buttonGeneroFamiliar.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroDrama
            // 
            resources.ApplyResources(this.buttonGeneroDrama, "buttonGeneroDrama");
            this.buttonGeneroDrama.FlatAppearance.BorderSize = 0;
            this.buttonGeneroDrama.Name = "buttonGeneroDrama";
            this.buttonGeneroDrama.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroDocumentales
            // 
            resources.ApplyResources(this.buttonGeneroDocumentales, "buttonGeneroDocumentales");
            this.buttonGeneroDocumentales.FlatAppearance.BorderSize = 0;
            this.buttonGeneroDocumentales.Name = "buttonGeneroDocumentales";
            this.buttonGeneroDocumentales.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroDibujosAnimados
            // 
            resources.ApplyResources(this.buttonGeneroDibujosAnimados, "buttonGeneroDibujosAnimados");
            this.buttonGeneroDibujosAnimados.FlatAppearance.BorderSize = 0;
            this.buttonGeneroDibujosAnimados.Name = "buttonGeneroDibujosAnimados";
            this.buttonGeneroDibujosAnimados.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroDeporte
            // 
            resources.ApplyResources(this.buttonGeneroDeporte, "buttonGeneroDeporte");
            this.buttonGeneroDeporte.FlatAppearance.BorderSize = 0;
            this.buttonGeneroDeporte.Name = "buttonGeneroDeporte";
            this.buttonGeneroDeporte.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroCrimen
            // 
            resources.ApplyResources(this.buttonGeneroCrimen, "buttonGeneroCrimen");
            this.buttonGeneroCrimen.FlatAppearance.BorderSize = 0;
            this.buttonGeneroCrimen.Name = "buttonGeneroCrimen";
            this.buttonGeneroCrimen.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroComedia
            // 
            resources.ApplyResources(this.buttonGeneroComedia, "buttonGeneroComedia");
            this.buttonGeneroComedia.FlatAppearance.BorderSize = 0;
            this.buttonGeneroComedia.Name = "buttonGeneroComedia";
            this.buttonGeneroComedia.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroCienciaFiccion
            // 
            resources.ApplyResources(this.buttonGeneroCienciaFiccion, "buttonGeneroCienciaFiccion");
            this.buttonGeneroCienciaFiccion.FlatAppearance.BorderSize = 0;
            this.buttonGeneroCienciaFiccion.Name = "buttonGeneroCienciaFiccion";
            this.buttonGeneroCienciaFiccion.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroAventura
            // 
            resources.ApplyResources(this.buttonGeneroAventura, "buttonGeneroAventura");
            this.buttonGeneroAventura.FlatAppearance.BorderSize = 0;
            this.buttonGeneroAventura.Name = "buttonGeneroAventura";
            this.buttonGeneroAventura.UseVisualStyleBackColor = true;
            // 
            // buttonGeneroAccion
            // 
            resources.ApplyResources(this.buttonGeneroAccion, "buttonGeneroAccion");
            this.buttonGeneroAccion.FlatAppearance.BorderSize = 0;
            this.buttonGeneroAccion.Name = "buttonGeneroAccion";
            this.buttonGeneroAccion.UseVisualStyleBackColor = true;
            // 
            // labelGeneros
            // 
            resources.ApplyResources(this.labelGeneros, "labelGeneros");
            this.labelGeneros.Name = "labelGeneros";
            // 
            // buttonDesplegar
            // 
            this.buttonDesplegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.buttonDesplegar, "buttonDesplegar");
            this.buttonDesplegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDesplegar.FlatAppearance.BorderSize = 0;
            this.buttonDesplegar.Name = "buttonDesplegar";
            this.buttonDesplegar.UseVisualStyleBackColor = false;
            this.buttonDesplegar.Click += new System.EventHandler(this.ButtonDesplegar_Click);
            // 
            // tableLayoutPanelCentro
            // 
            resources.ApplyResources(this.tableLayoutPanelCentro, "tableLayoutPanelCentro");
            this.tableLayoutPanelCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.tableLayoutPanelCentro.Name = "tableLayoutPanelCentro";
            this.tableLayoutPanelCentro.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanelCentro_Paint);
            // 
            // panelDerecha
            // 
            this.panelDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.panelDerecha.Controls.Add(this.panelAdmin);
            resources.ApplyResources(this.panelDerecha, "panelDerecha");
            this.panelDerecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panelDerecha.Name = "panelDerecha";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.buttonAdministrarPeliculas);
            this.panelAdmin.Controls.Add(this.button1);
            this.panelAdmin.Controls.Add(this.buttonAdminUsuarios);
            this.panelAdmin.Controls.Add(this.buttonAbrirPanelAdmin);
            resources.ApplyResources(this.panelAdmin, "panelAdmin");
            this.panelAdmin.Name = "panelAdmin";
            // 
            // buttonAdministrarPeliculas
            // 
            resources.ApplyResources(this.buttonAdministrarPeliculas, "buttonAdministrarPeliculas");
            this.buttonAdministrarPeliculas.FlatAppearance.BorderSize = 0;
            this.buttonAdministrarPeliculas.ForeColor = System.Drawing.Color.White;
            this.buttonAdministrarPeliculas.Name = "buttonAdministrarPeliculas";
            this.buttonAdministrarPeliculas.UseVisualStyleBackColor = true;
            this.buttonAdministrarPeliculas.Click += new System.EventHandler(this.buttonAdministrarPeliculas_Click_1);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdminUsuarios
            // 
            resources.ApplyResources(this.buttonAdminUsuarios, "buttonAdminUsuarios");
            this.buttonAdminUsuarios.FlatAppearance.BorderSize = 0;
            this.buttonAdminUsuarios.ForeColor = System.Drawing.Color.White;
            this.buttonAdminUsuarios.Name = "buttonAdminUsuarios";
            this.buttonAdminUsuarios.UseVisualStyleBackColor = true;
            this.buttonAdminUsuarios.Click += new System.EventHandler(this.buttonAdminUsuarios_Click);
            // 
            // buttonAbrirPanelAdmin
            // 
            this.buttonAbrirPanelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.buttonAbrirPanelAdmin, "buttonAbrirPanelAdmin");
            this.buttonAbrirPanelAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAbrirPanelAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAbrirPanelAdmin.Name = "buttonAbrirPanelAdmin";
            this.buttonAbrirPanelAdmin.UseVisualStyleBackColor = false;
            this.buttonAbrirPanelAdmin.Click += new System.EventHandler(this.buttonAbrirPanelAdmin_Click);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "Peliculas";
            this.peliculasBindingSource.DataSource = this.masterDataSet;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CapitulosTableAdapter = null;
            this.tableAdapterManager.FacturasTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.SeriesTableAdapter = this.seriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_PVA_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.masterDataSet;
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
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.tableLayoutPanelCentro);
            this.Controls.Add(this.panelDerecha);
            this.Controls.Add(this.panelIzquierda);
            this.Controls.Add(this.statusStripInicio);
            this.Controls.Add(this.toolStripInicio);
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Resize += new System.EventHandler(this.Inicio_Resize);
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            this.panelIzquierda.ResumeLayout(false);
            this.panelIzquierda.PerformLayout();
            this.panelDerecha.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripInicio;
        private System.Windows.Forms.ToolStrip toolStripInicio;
        private System.Windows.Forms.Panel panelIzquierda;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonPeliculas;
        private System.Windows.Forms.ToolStripButton toolStripButtonSeries;
        private System.Windows.Forms.Button buttonDesplegar;
        private System.Windows.Forms.ToolStripButton toolStripButtonIniciarSesion;
        private System.Windows.Forms.Button buttonGeneroDeporte;
        private System.Windows.Forms.Button buttonGeneroCrimen;
        private System.Windows.Forms.Button buttonGeneroComedia;
        private System.Windows.Forms.Button buttonGeneroCienciaFiccion;
        private System.Windows.Forms.Button buttonGeneroAventura;
        private System.Windows.Forms.Button buttonGeneroAccion;
        private System.Windows.Forms.Label labelGeneros;
        private System.Windows.Forms.Button buttonGeneroFamiliar;
        private System.Windows.Forms.Button buttonGeneroDrama;
        private System.Windows.Forms.Button buttonGeneroDocumentales;
        private System.Windows.Forms.Button buttonGeneroDibujosAnimados;
        private System.Windows.Forms.ToolStripButton toolStripButtonCarroCompra;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCentro;
        private System.Windows.Forms.Panel panelDerecha;
        private System.Windows.Forms.Button buttonAdminUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdministrarPeliculas;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecomendaciones;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private masterDataSetTableAdapters.PeliculasTableAdapter peliculasTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private masterDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private masterDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button buttonAbrirPanelAdmin;
        private System.Windows.Forms.Panel panelAdmin;
    }
}

