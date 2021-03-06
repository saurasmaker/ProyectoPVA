﻿using Proyecto_PVA_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_PVA_2.Forms
{
    public partial class InformaciónPelicula : Form
    {
        Inicio padre;

        public InformaciónPelicula()
        {
            InitializeComponent();
        }

        //Librería Capture
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void duracionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformaciónPelicula_Load(object sender, EventArgs e)
        {
           padre = Owner as Inicio;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAñadirAlCarro_Click(object sender, EventArgs e)
        {
            if (!padre.InicioSesion)
            {
                MessageBox.Show("Debe de estar logeado para acceder a esta opción.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TituloCinematografico tc = new TituloCinematografico();
            tc.Titulo = tituloTextBox.Text;
            tc.Sinopsis = sinopsisTextBox.Text;
            tc.Estreno = Convert.ToDateTime(textBoxEstreno.Text);
            tc.Puntuacion = Convert.ToSingle(puntuacionTextBox.Text);
            tc.Precio = Convert.ToDecimal(precioTextBox.Text.Replace("€",""));

            padre.CarroCompra.Add(tc);
        }

        private void portadaPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void portadaPictureBox_Click_1(object sender, EventArgs e)
        {

        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
