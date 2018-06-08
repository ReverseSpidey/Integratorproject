using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDesktop.BO;
using AppDesktop.DAO;

namespace AppDesktop.GUI
{
    public partial class Peliculas : Form
    {
        PeliculaDAO peliDAO = new PeliculaDAO();
        public Peliculas()
        {
            InitializeComponent();
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            cboGenero.DataSource = peliDAO.RecuperarGenero();
            cboGenero.DisplayMember = "nombre_gen";
            cboGenero.ValueMember = "id_genero";

            cboIdioma.DataSource = peliDAO.RecuperarIdioma();
            cboIdioma.DisplayMember = "nombre_idioma";
            cboIdioma.ValueMember = "cod_idioma";

            cboClasif.DataSource = peliDAO.RecuperarClasif();
            cboClasif.DisplayMember = "nombre_clasif";
            cboClasif.ValueMember = "id_clasif";
        }



    }
}
