using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDesktop.GUI;

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
        #endregion


        private void lblSesión_Click(object sender, EventArgs e)
        {
            frm_PERSONA obj = new frm_PERSONA();
            obj.ShowDialog();
        }
        
        private void AbrirFormHija(object formhija)
        {
            if (this.pnl_Contenedor.Controls.Count > 0)
                this.pnl_Contenedor.Controls.RemoveAt(0);
            Form fhe = formhija as Form;
            fhe.TopLevel = false;
            fhe.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(fhe);
            this.pnl_Contenedor.Tag = fhe;
            fhe.Show();
        }

        private void ucUser_Click(object sender, EventArgs e)
        {
            LOGIN obj = new LOGIN();
            obj.ShowDialog();
        }

        private void ucConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmConfiguración());
        }

        private void ucCompra_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picUsuario_MouseMove(object sender, MouseEventArgs e)
        {
           picUsuario.Image = Properties.Resources.usuario2;
        }

        private void picUsuario_MouseLeave(object sender, EventArgs e)
        {
            picUsuario.Image = Properties.Resources.usuario;
        }

        private void picUsuario_MouseHover(object sender, EventArgs e)
        {
            picUsuario.Image = Properties.Resources.usuario2;
        }

        private void picTicktekt_MouseLeave(object sender, EventArgs e)
        {
            picTicktekt.Image = Properties.Resources.Ticket2;
        }

        private void picTicktekt_MouseMove(object sender, MouseEventArgs e)
        {
            picTicktekt.Image = Properties.Resources.Ticket1;
        }

        private void picTicktekt_MouseHover(object sender, EventArgs e)
        {
            picTicktekt.Image = Properties.Resources.Ticket1;
        }

        private void picReserva_MouseLeave(object sender, EventArgs e)
        {
            picReserva.Image = Properties.Resources.Detective_50px;
        }

        private void picReserva_MouseMove(object sender, MouseEventArgs e)
        {
            picReserva.Image = Properties.Resources.Detective2_50px;
        }

        private void picReserva_MouseHover(object sender, EventArgs e)
        {
            picReserva.Image = Properties.Resources.Detective2_50px;
        }

        private void lblReserva_MouseLeave(object sender, EventArgs e)
        {
            lblReserva.ForeColor = Color.FromArgb(33, 33, 33);
        }

        private void lblReserva_MouseHover(object sender, EventArgs e)
        {
            lblReserva.ForeColor = Color.White;
        }

        private void lblReserva_MouseMove(object sender, MouseEventArgs e)
        {
            lblReserva.ForeColor = Color.White;
        }

        private void lblBoleto_MouseLeave(object sender, EventArgs e)
        {
            lblBoleto.ForeColor = Color.FromArgb(33, 33, 33);
        }

        private void lblBoleto_MouseMove(object sender, MouseEventArgs e)
        {
            lblBoleto.ForeColor = Color.White;
        }

        private void lblBoleto_MouseHover(object sender, EventArgs e)
        {
            lblBoleto.ForeColor = Color.White;
        }

        private void picTicktekt_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmConfiguración());
        }

        private void pnl_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
