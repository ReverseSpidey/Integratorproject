using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDesktop.BO;
using System.Data;

namespace AppDesktop.DAO
{
    class SalaDAO
    {
        Conexion conex;
        public SalaDAO()
        {
            conex = new Conexion();
        }


        public DataTable RecupTipo()
        {
            String ComandoSQL = string.Format("SELECT * FROM tipo_sala");
            //llena el datatable con la información de la base de datos
            DataTable datos = conex.EjercutarSentecia(ComandoSQL);
            //creo un nueva fila al dataTable
            DataRow dr = datos.NewRow();
            dr["nombre_sala"] = "Seleccionar";
            dr["cod_sala"] = 0;
            //inserto la fila en la primera posición
            datos.Rows.InsertAt(dr, 0);

            return datos;
        }


        public DataTable Recuperar_Sala()
        {
            string query = string.Format("select sala.cod_sala, num_sala, tipo_sala.nombre_sala from " +
                "sala inner join tipo_sala on sala.cod_tipo = tipo_sala.cod_sala");
            return conex.EjercutarSentecia(query);
        }

        public int Alta_Tipo(SalaBO sal)
        {
            string comando = string.Format("INSERT INTO SALA (Num_sala, cod_tipo) VALUES ({0}, {1})", sal.Num_sala, sal.Cod_tipo);
            return conex.EjecutarComando(comando);

        }

        public int Modificar(SalaBO sal)
        {
            String ComandoSQL = string.Format("UPDATE sala SET num_sala = {1}, cod_tipo = " +
                "{2} WHERE cod_sala ={0}", sal.Cod_sala, sal.Num_sala, sal.Cod_tipo);
            return conex.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(SalaBO sal)
        {
            String ComandoSQL = string.Format("DELETE FROM SALA WHERE COD_SALA = {0}", sal.Cod_sala);
            return conex.EjecutarComando(ComandoSQL);
        }
    }
}
