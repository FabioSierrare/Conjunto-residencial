using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Persistencia
{
    public class Conexion
    {
        private SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public SqlConnection AbrirConexion()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }
            return cnx;
        }

        public SqlConnection CerrarConexion()
        {
            if (cnx.State == ConnectionState.Open) 
            {
                cnx.Close();
            }
            return cnx;
        }
    }
}
