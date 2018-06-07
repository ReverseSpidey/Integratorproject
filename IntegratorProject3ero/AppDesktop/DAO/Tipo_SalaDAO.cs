using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDesktop.BO;
using System.Data;

namespace AppDesktop.DAO
{
    class Tipo_SalaDAO
    {
        Conexion conex;
        public Tipo_SalaDAO()
        {
            conex = new Conexion();
        }

        public DataTable Recup_Tipo()
        {
            string query = string.Format("SELECT * FROM TIPO_SALA");
            return conex.EjercutarSentecia(query);
        }

        public int Alta_Tipo(Tipo_SalaBO tipo)
        {
            string comando = string.Format("INSERT INTO TIPO_SALA (NOMBRE_SALA, PRECIO) VALUES ('{0}', {1})", tipo.Nombre_tipo, tipo.Precio_tipo);
            return conex.EjecutarComando(comando);

        }

        public int Modificar(Tipo_SalaBO tipo)
        {
            String ComandoSQL = string.Format("UPDATE Tipo_sala SET nombre_sala = '{1}', precio = " +
                "{2} WHERE cod_sala ={0}", tipo.Codigo_tipo, tipo.Nombre_tipo, tipo.Precio_tipo);
            return conex.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(Tipo_SalaBO tipo)
        {
            String ComandoSQL = string.Format("DELETE FROM TIPO_SALA WHERE COD_SALA = {0}", tipo.Codigo_tipo);
            return conex.EjecutarComando(ComandoSQL);
        }

    }
}
