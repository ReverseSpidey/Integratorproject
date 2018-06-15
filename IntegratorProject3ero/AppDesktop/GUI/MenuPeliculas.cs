using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Modelo;
using Datos_Org.Servicios;
using Datos_Org.Entidades;

namespace AppDesktop.GUI
{
    public partial class MenuPeliculas : Form
    {
        int Contador = 0;
        string name = "Deadpool 2";
        public MenuPeliculas()
        {
            InitializeComponent();
            banner.Enabled = true;
        }

        private void banner_Tick(object sender, EventArgs e)
        {
            Contador++;

            if (Contador == 1)
                picBanner.Image = Properties.Resources.waar;
            else if (Contador == 2)
                picBanner.Image = Properties.Resources.overboard;
            else if (Contador == 3)
            {
                picBanner.Image = Properties.Resources.deadpool;
            }
            else {
                picBanner.Image = Properties.Resources.tsubasa;
                Contador = 0;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            HorariosGUI hora = new HorariosGUI(name);
            hora.ShowDialog();
        }
    }
}
