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
    public partial class EmpleadoCinema : Form
    {
        int cont = 0;
        public EmpleadoCinema()
        {
            InitializeComponent();
            pnlCompra.Visible = false;
        }

        private void btnPelicula_Click(object sender, EventArgs e)
        {

            if (cont % 2 > 0)
            {
                pnlCompra.Visible = false;

            }
            else if (cont % 2 == 0)
            {
                pnlCompra.Visible = true;
            }

            cont++;
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

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new NuevaCompra());
        }
    }
}
