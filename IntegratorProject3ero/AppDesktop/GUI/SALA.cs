using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Servicios;
using Datos_Org.Modelo;
namespace AppDesktop.GUI
{
    public partial class SALA : Form
    {
        srvSala srv = new srvSala();
        public SALA()
        {
            InitializeComponent();


        }
        private void SALA_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            dgvSala.AutoGenerateColumns = false;
            dgvSala.DataSource = srv.Salas();
        }


    }
}
