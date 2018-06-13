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
    public partial class NuevaSala : Form
    {
        SALA frm_sala;
        srvSala serv = new srvSala();
        public bool nuevo;
        Sala sal;
        public NuevaSala(SALA frm)
        {
            InitializeComponent();
            nuevo = true;
            frm_sala = frm;
        }
        public NuevaSala(Sala obj, SALA frm)
        {
            InitializeComponent();
            nuevo = false;
            frm_sala = frm;
            this.sal = obj;
            DatosInterface();

        }
        private void DatosInterface()
        {
            txtNumSala.Text = sal.Num_sala.ToString();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaSala_Load(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                cboTipo.DataSource = serv.getlistTipo_Sala();
                cboTipo.DisplayMember = "nombre_sala";
                cboTipo.ValueMember = "cod_sala";
            }
            else
            {
                cboTipo.DataSource = serv.getlistTipo_Sala();
                cboTipo.DisplayMember = "nombre_sala";
                cboTipo.ValueMember = "cod_sala";
                cboTipo.SelectedValue = sal.cod_tipo;

            }

        }

        private void limpiar()
        {
            txtFilas.Clear();
            txtNumSala.Clear();
            cboTipo.SelectedIndex = 0;
        }


        public Sala RecuperarDatos()
        {
            sal = new Sala();
            sal.cod_tipo = Convert.ToInt32(cboTipo.SelectedValue);
            sal.Num_sala = Convert.ToInt32(txtNumSala.Text);
            return sal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                serv.AgregarSala(RecuperarDatos());
                frm_sala.Listar();
                this.Close();
            }
            else
            {
                serv.ModificarSala(RecuperarDatos());
                frm_sala.Listar();
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            serv.BorrarSala(this.sal);//le estoy diciendo que los datos que va a borrar son los mostrados o recuperados de esta interfaz
            frm_sala.Listar();
            this.Close();
        }
    }
}
