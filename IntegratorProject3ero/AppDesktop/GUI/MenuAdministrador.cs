﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop.GUI
{
    public partial class MenuAdministrador : Form
    {
        int posY = 0;
        int posX = 0;

        public MenuAdministrador()
        {
            InitializeComponent();
        }





        private void AbrirFormHija(object formhija)
        {
            if (this.panelcine.Controls.Count > 0)
                this.panelcine.Controls.RemoveAt(0);
            Form frm = formhija as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelcine.Controls.Add(frm);
        
            this.panelcine.Tag = frm;
            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panellfet.Height = btnUsuarios.Height;
            panellfet.Top = btnUsuarios.Top;
            AbrirFormHija(new frm_PERSONA());
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            panellfet.Height = btnDatos.Height;
            panellfet.Top = btnDatos.Top;
            AbrirFormHija(new Datos());
        }

        private void MenuAdministrador_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posY = e.Y;
                posX = e.X;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        

        private void panelcine_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posY = e.Y;
                posX = e.X;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panellfet.Height = btnPelicula.Height;
            panellfet.Top = btnPelicula.Top;
            AbrirFormHija(new Peliculas());


        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            panellfet.Height = btnSalas.Height;
            panellfet.Top = btnSalas.Top;
            AbrirFormHija(new SALA());
        }
    }
}