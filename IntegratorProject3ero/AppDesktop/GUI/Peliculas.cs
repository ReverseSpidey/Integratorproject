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
using System.IO;

namespace AppDesktop.GUI
{
    public partial class Peliculas : Form
    {
        string RutaImg = "";
        PeliculaDAO peliDAO = new PeliculaDAO();
        PeliculaBO peliBO = new PeliculaBO();
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

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            picPelicula.SizeMode = PictureBoxSizeMode.StretchImage;
            using (OpenFileDialog opl = new OpenFileDialog())
            {
                opl.Title = "Abrir Imagen";
                opl.Filter = "jpeg files (*.jpg)|*.jpg";
                if (opl.ShowDialog() == DialogResult.OK)
                {
                    picPelicula.Image = Image.FromFile(opl.FileName);
                    RutaImg = opl.FileName;
                }
            }
        }
        private byte[] ImagenConf()
        {
            MemoryStream mem = new MemoryStream();
            picPelicula.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] abyte = mem.ToArray();
            return abyte;
        }

        private PeliculaBO RecuperarInf()
        {
            peliBO.Nombre_peli = txtNombre.Text;
            peliBO.Duracion_peli = txtDuracion.Text;
            peliBO.Sinopsis = txtSinopsis.Text;
            peliBO.Id_genero = Convert.ToInt32(cboGenero.SelectedValue);
            peliBO.Id_clasif = Convert.ToInt32(cboClasif.SelectedValue);
            peliBO.Cod_idioma = Convert.ToInt32(cboIdioma.SelectedValue);
            peliBO.Image = ImagenConf();



            return peliBO;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (peliDAO.AgregarPeli(RecuperarInf()) == 1)
            {
                MessageBox.Show("Registro agregado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDuracion.Clear();
            txtNombre.Clear();
            txtSinopsis.Clear();
            cboClasif.SelectedIndex = 0;
            cboIdioma.SelectedIndex = 0;
            cboGenero.SelectedIndex = 0;
            picPelicula.Image = null;
        }
    }
}
