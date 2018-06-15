using Datos_Org.Servicios;
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
    public partial class HorariosGUI : Form
    {
        srvFuncion fun = new srvFuncion();
        public HorariosGUI(string nombre)
        {
            InitializeComponent();
            dgvHorarios.AutoGenerateColumns = false;
            dgvHorarios.DataSource = fun.Horario(nombre);
            dgvHorarios.Columns[0].Visible = false;
        }

        private void CrearBoton()
        {
            Button but = new Button();
            dgvHorarios.Controls.Add(but);
        }

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int sala = Convert.ToInt32(dgvHorarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                MessageBox.Show(" " + sala);
                SeccionAsientos asi = new SeccionAsientos(sala);
                asi.Show();
            }
        }
    }
}
