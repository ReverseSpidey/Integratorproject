using System;
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
    public partial class MenuEmpleado : Form
    {
        int cont;
        public MenuEmpleado()
        {
            InitializeComponent();
            pnlCatalogos.Visible = false;

        }

        private void btnPelicula_Click(object sender, EventArgs e)
        {
            pnlCatalogos.Visible = false;


            if (cont % 2 > 0)
            {
                pnlCatalogos.Visible = false;

            }
            else if (cont % 2 == 0)
            {
                pnlCatalogos.Visible = true;
            }

            cont++;
        }
    }
}
