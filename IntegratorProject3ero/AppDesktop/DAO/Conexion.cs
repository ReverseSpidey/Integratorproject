using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppDesktop.DAO
{
    class Conexion
    {
        MySqlConnection conn; MySqlCommand comando;

        public Conexion()
        {
            string servidor = "localhost";
            string userid = "root";
            string pass = "Jubarmas100";
            string bd = "cinema_project";

            conn = new MySqlConnection("Server=" + servidor + "; User ID=" + userid + "; Persist Security info=true; password=" + pass + "; Database=" + bd);
            comando = new MySqlCommand();

        }
        public void AbrirConexion() { this.conn.Open(); }
        public void CerarConexion() { this.conn.Close(); }

        public int EjecutarComando(string comandoSQL) // INSERT , UPDATE, DELETE
        {
            try
            {
                this.comando.CommandText = comandoSQL;
                this.comando.Connection = this.conn;
                this.AbrirConexion();
                this.comando.ExecuteNonQuery();
                this.CerarConexion();
                return 1;
            }
            catch (MySqlException)
            {
                return 0;
            }
            finally
            {
                this.CerarConexion();
            }
        }
        public DataTable EjercutarSentecia(String comandoSQL)
        {  // SELECT 
            MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSQL, this.conn);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}
