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
    public partial class Tipo_Sala : Form
    {
        Tipo_SalaBO tipoBO = new Tipo_SalaBO();
        Tipo_SalaDAO tiDAO = new Tipo_SalaDAO();
        int codigo = 0;
        public Tipo_Sala()
        {
            InitializeComponent();
            dgvTipo_Sala.DataSource = tiDAO.Recup_Tipo().Tables[0];
            dgvTipo_Sala.ReadOnly = true;
            dgvTipo_Sala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipo_Sala.ReadOnly = true;
            dgvTipo_Sala.AllowUserToAddRows = false;
        }

        private Tipo_SalaBO Recuperar_Info()
        {
            tipoBO.Codigo_tipo = codigo;
            tipoBO.Nombre_tipo = txtNombre.Text;
            tipoBO.Precio_tipo = Convert.ToDouble(txtPrecio.Text);
            return tipoBO;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            tiDAO.Alta_Tipo(Recuperar_Info());
            
                MessageBox.Show("Registro agregado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dgvTipo_Sala.DataSource = tiDAO.Recup_Tipo().Tables[0];

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            tiDAO.Modificar(Recuperar_Info());
                MessageBox.Show("Registro modificado exitosamente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dgvTipo_Sala.DataSource = tiDAO.Recup_Tipo().Tables[0];

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro? El cambio será permanente", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                // se la información se agrega mostramos un mensaje
                tiDAO.Eliminar(Recuperar_Info());
                
                    MessageBox.Show("Registro Borrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                dgvTipo_Sala.DataSource = tiDAO.Recup_Tipo().Tables[0];
            }
            

        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila_sel = e.RowIndex;
            txtNombre.Text =  dgvTipo_Sala.Rows[fila_sel].Cells[1].Value.ToString();
            txtPrecio.Text =  dgvTipo_Sala.Rows[fila_sel].Cells[2].Value.ToString();
            codigo = int.Parse(dgvTipo_Sala.Rows[fila_sel].Cells[0].Value.ToString());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
        }
    }
}

