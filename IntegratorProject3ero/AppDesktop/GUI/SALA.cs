using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDesktop.DAO;
using AppDesktop.BO;

namespace AppDesktop.GUI
{
    public partial class SALA : Form
    {
        SalaBO sal = new SalaBO();
        SalaDAO salDAO = new SalaDAO();
        int cod = 0;
        public SALA()
        {
            InitializeComponent();
            dgvSala.ReadOnly = true;
            dgvSala.DataSource = salDAO.Recuperar_Sala().Tables[0];

            #region Combo
            cboTipoSala.DataSource = salDAO.RecupTipo();
            cboTipoSala.DisplayMember = "nombre_sala";
            cboTipoSala.ValueMember = "cod_sala";
            #endregion
        }


        private SalaBO RecuperarInfo()
        {
            sal.Num_sala = int.Parse(txtNumsala.Text);
            sal.Cod_tipo = Convert.ToInt32(cboTipoSala.SelectedValue);
            sal.Cod_sala = cod;
            return sal;
        }


        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (salDAO.Alta_Tipo(RecuperarInfo()) == 1)
            
                MessageBox.Show("Registro agregado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dgvSala.DataSource = salDAO.Recuperar_Sala().Tables[0];
        }

        private void dgvSala_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila_sel = e.RowIndex;

            cod = int.Parse(dgvSala.Rows[fila_sel].Cells[0].Value.ToString());
            txtNumsala.Text = dgvSala.Rows[fila_sel].Cells[1].Value.ToString();
            cboTipoSala.Text = dgvSala.Rows[fila_sel].Cells[2].Value.ToString();
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            salDAO.Modificar(RecuperarInfo());
            
                MessageBox.Show("Registro agregado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvSala.DataSource = salDAO.Recuperar_Sala().Tables[0];
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro? El cambio será permanente", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                // se la información se agrega mostramos un mensaje
                salDAO.Eliminar(RecuperarInfo());
                    MessageBox.Show("Registro Borrado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvSala.DataSource = salDAO.Recuperar_Sala().Tables[0];
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumsala.Clear();
            cboTipoSala.SelectedIndex = 0;
        }
    }
}
