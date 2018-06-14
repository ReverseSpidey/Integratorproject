using AppDesktop.GUI;
using System;
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
    public partial class frmAsiento : Form
    {
        public frmAsiento()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            newAsiento obj = new newAsiento();
            obj.ShowDialog();
        }
    }
}
