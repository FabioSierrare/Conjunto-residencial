using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

            conexion.CerrarConexion();

            return n;
        }

        public void Registro(string usuario, string email, string contraseña, string tipo_documento, string numero_documento)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "spCrearUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@usuario",usuario);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@contraseña", contraseña);
            command.Parameters.AddWithValue("@tipo_documento", tipo_documento);
            command.Parameters.AddWithValue("@numero_documento", numero_documento);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
