﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new PanelAdminCompras());
        }

        private void AbrirFormPanel(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new PanelAdminUsuarios());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Home());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button4_Click(null, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new PanelAdminPeliculas());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new PanelAdminSeries());
        }
    }
}
