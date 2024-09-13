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
            if (cnx.State == ConnectionState.Closed) // Verificamos que la conexión esté cerrada
            {
                cnx.Open();
            }
            return cnx;
        }

        public SqlConnection CerrarConexion()
        {
            if (cnx.State == ConnectionState.Open) // Verificamos que la conexión esté abierta antes de cerrarla
            {
                cnx.Close();
            }
            return cnx;
        }
    }
}
