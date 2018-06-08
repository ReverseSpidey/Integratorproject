using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDesktop.BO;
using System.Data;
namespace AppDesktop.DAO
{
    class PeliculaDAO
    {
        Conexion conex;
        public PeliculaDAO()
        {
            conex = new Conexion();
        }


        public DataTable RecuperarGenero()
        {
            String ComandoSQL = string.Format("SELECT * FROM Genero");
            //llena el datatable con la información de la base de datos
            DataTable datos = conex.EjercutarSentecia(ComandoSQL);
            //creo un nueva fila al dataTable
            DataRow dr = datos.NewRow();
            dr["nombre_gen"] = "Seleccionar";
            dr["id_genero"] = 0;
            //inserto la fila en la primera posición
            datos.Rows.InsertAt(dr, 0);

            return datos;
        }

        public DataTable RecuperarIdioma()
        {
            String ComandoSQL = string.Format("SELECT * FROM idioma");
            //llena el datatable con la información de la base de datos
            DataTable datos = conex.EjercutarSentecia(ComandoSQL);
            //creo un nueva fila al dataTable
            DataRow dr = datos.NewRow();
            dr["nombre_idioma"] = "Seleccionar";
            dr["cod_idioma"] = 0;
            //inserto la fila en la primera posición
            datos.Rows.InsertAt(dr, 0);

            return datos;
        }

        public DataTable RecuperarClasif()
        {
            string ComandoSQL = string.Format("SELECT id_clasif, nombre_clasif FROM clasificacion");
            //llena el datatable con la información de la base de datos
            DataTable datos = conex.EjercutarSentecia(ComandoSQL);
            //creo un nueva fila al dataTable
            DataRow dr = datos.NewRow();
            dr["nombre_clasif"] = "Seleccionar";
            dr["id_clasif"] = 0;
            //inserto la fila en la primera posición
            datos.Rows.InsertAt(dr, 0);

            return datos;
        }


        public DataTable Recuperar_Sala()
        {
            string query = string.Format("");
            return conex.EjercutarSentecia(query);
        }

        public int Alta_Tipo(PeliculaBO peli)
        {
            string comando = string.Format("");
            return conex.EjecutarComando(comando);

        }

        public int Modificar(PeliculaBO peli)
        {
            String ComandoSQL = string.Format("");
            return conex.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(PeliculaBO peli)
        {
            String ComandoSQL = string.Format("");
            return conex.EjecutarComando(ComandoSQL);
        }
    }
}

