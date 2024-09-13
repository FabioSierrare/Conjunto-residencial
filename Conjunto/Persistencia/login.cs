using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class login
    {
        private Conexion conexion = new Conexion();

        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader = null;
        private bool n = false;

        public bool VerificarUsuario(string email, string contraseña)
        {
            command.CommandText = "SPSelecionarUsuario";
            command.Connection = conexion.AbrirConexion();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            command.Parameters.Clear();

            while (reader.Read()) {
                if (reader[2].ToString() == email && reader[3].ToString() == contraseña)
                {
                    n = true; break;
                }
            }

            return n;
        }
    }
}
