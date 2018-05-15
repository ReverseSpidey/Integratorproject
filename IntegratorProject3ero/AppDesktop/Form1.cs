﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
            
        }

        #region ESTILOS
        
        private void UcInicio_MouseMove(object sender, MouseEventArgs e)
        {
            UcInicio.Image = Properties.Resources.HomeHover;
        }

        private void UcInicio_MouseLeave(object sender, EventArgs e)
        {
            UcInicio.Image = Properties.Resources.HomeNormal;
        }

        private void UcInicio_MouseHover(object sender, EventArgs e)
        {
            UcInicio.Image = Properties.Resources.HomeHover;

        }

        private void ucConfiguracion_MouseMove(object sender, MouseEventArgs e)
        {
            ucConfiguracion.Image = Properties.Resources.SettingHover;
        }

        private void ucConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            ucConfiguracion.Image = Properties.Resources.SettingsNormal;

        }

        private void ucConfiguracion_MouseHover(object sender, EventArgs e)
        {
            ucConfiguracion.Image = Properties.Resources.SettingHover;
        }

        private void LBLmINIMI_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LBLmINIMI_MouseMove(object sender, MouseEventArgs e)
        {
            LBLmINIMI.ForeColor = Color.White;
        }

        private void LBLmINIMI_MouseHover(object sender, EventArgs e)
        {
            LBLmINIMI.ForeColor = Color.White;
        }

        private void LBLmINIMI_MouseLeave(object sender, EventArgs e)
        {
            LBLmINIMI.ForeColor = Color.FromArgb(33, 33, 33);
        }

        private void lblCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            lblCerrar.ForeColor = Color.White;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.FromArgb(33, 33, 33);
        }

        private void lblCerrar_MouseHover(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.White;
        }

        private void userControl11_MouseMove(object sender, MouseEventArgs e)
        {
            ucUser.Image = Properties.Resources.UserHover;

        }

        private void userControl11_MouseLeave(object sender, EventArgs e)
        {
            ucUser.Image = Properties.Resources.UserNormal;
        }

        private void userControl11_MouseHover(object sender, EventArgs e)
        {
            ucUser.Image = Properties.Resources.UserHover;
            
        }

        #endregion

        private void lblSesión_MouseMove(object sender, MouseEventArgs e)
        {
            lblSesión.ForeColor = Color.White;
        }

        private void lblSesión_MouseLeave(object sender, EventArgs e)
        {
            lblSesión.ForeColor = Color.FromArgb(33,33,33);
        }

        private void lblSesión_MouseHover(object sender, EventArgs e)
        {
            lblSesión.ForeColor = Color.White;
        }
    }
}
