using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Propiedad
    {
        private Conexion conexion = new Conexion();

        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader = null;
        private bool n = false;

        public SqlDataReader DetallesPropiedad(int numero_propiedad)
        {
            command.CommandText = "spObtenerPropiedadPorID";
            command.Connection = conexion.AbrirConexion();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numero_propiedad", numero_propiedad);
            reader = command.ExecuteReader();
            command.Parameters.Clear();
            conexion.CerrarConexion();
            return reader;
        }
    }
}
