using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppDesktop.DAO
{
    class ConexionSQL
    {
        SqlCommand cmd;//comando para transacciones sql
        SqlDataAdapter adapt;//crea una variable adapter para una conexion a bdd y para un conjunt de datos del dataset
        SqlConnection conex;//establece una conexion a una bdd
        DataSet data;//conjunto completo de datos
        public SqlConnection Establecer_Conex()
        {
            //datos del usuario para la eocnexion 
            string instancia = "Data source = .\\SQLEXPRESS; Initial Catalog = CINEMA_PROJECT; Integrated Security = True";
            conex = new SqlConnection(instancia);
            return conex;
        }

        public SqlConnection Establecer_Conex(string QUERY)
        {
            string instancia = QUERY;
            conex = new SqlConnection(instancia);
            return conex;
        }
        public void AbrirConex()
        {
            conex.Open();
        }
        public void CerrarConex()
        {
            conex.Close();
        }
        public int EjecutarComando(string command)
        {
            string ComandoSQL = command;
            adapt = new SqlDataAdapter();//creo la instancia del SQLADAPTER
            cmd = new SqlCommand();//instancia del comandoSQL
            cmd.Connection = this.Establecer_Conex();
            this.AbrirConex();
            cmd.CommandText = ComandoSQL;//establece introducción SQL que se va a ejecutar
            int id = Convert.ToInt32(cmd.ExecuteScalar());//ejecuta la instrucción SQL
            this.CerrarConex();
            return id;
        }
        public DataSet EjecutarSentencia(string QUERY)
        {
            cmd = new SqlCommand();
            adapt = new SqlDataAdapter();
            data = new DataSet();

            string cmdSQL = QUERY;
            cmd.CommandText = cmdSQL;
            cmd.Connection = this.Establecer_Conex();
            this.AbrirConex();

            adapt.SelectCommand = cmd;
            adapt.Fill(data);
            this.CerrarConex();
            return data;

        }
    }
    
}
