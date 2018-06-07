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
        int cont = 0;

        public MenuAdministrador()
        {
            InitializeComponent();

            pnlCatalogos.Visible = false;
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

            AbrirFormHija(new Sucursal());
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
            pnlCatalogos.Visible = false;
            

            if(cont%2 > 0)
            {
                pnlCatalogos.Visible = false;

            }
            else if(cont % 2 == 0)
            {
                pnlCatalogos.Visible = true;
            }

            cont++;


        }

        private void btnSalas_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new SALA());
        }

        private void btnPelicula_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panellfet_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Peliculas());
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Idioma());
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Clasificacion());
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Genero());
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Sucursal());
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ciudad());
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Estado());
        }

        private void btnSala_Click(object sender, EventArgs e)
        {

        }
    }
}
