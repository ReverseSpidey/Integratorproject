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

        public int AgregarPeli(PeliculaBO peli)
        {
            string comando = string.Format("insert into pelicula (nombre_pelicula, duracion, sinopsis, id_genero, cod_idioma, id_clasif, imagen) " +
                "values ('{0}','{1}','{2}',{3},{4},{5},'{6}')",peli.Nombre_peli, peli.Duracion_peli, peli.Sinopsis, peli.Id_genero, peli.Cod_idioma, peli.Id_clasif, peli.Image);
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

