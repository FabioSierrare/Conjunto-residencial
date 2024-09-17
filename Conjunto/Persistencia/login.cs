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

        public bool VerificarUsuario(string numero_documento, string contraseña)
        {
            command.CommandText = "SPSelecionarUsuario";
            command.Connection = conexion.AbrirConexion();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            command.Parameters.Clear();

            while (reader.Read()) {
                if (reader[5].ToString() == numero_documento && reader[3].ToString() == contraseña)
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
        
        public bool documentoEx(string numero_documento)
        {
            command.CommandText = "SPSelecionarUsuario";
            command.Connection = conexion.AbrirConexion();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            command.Parameters.Clear();

            while (reader.Read())
            {
                if (reader[5].ToString() == numero_documento)
                {
                    n = true; break;
                }
            }

            conexion.CerrarConexion();

            return n;
        }


        //Propiedad

        //Añadir propiedad

        public void NuevaPropiedad(string direccion, string tipo, string tamaño, int num_habitaciones, int
num_banos, double precio, string estado)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "spCrearPropiedad";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@direccion", direccion);
            command.Parameters.AddWithValue("@tipo", tipo);
            command.Parameters.AddWithValue("@tamano", tamaño);
            command.Parameters.AddWithValue("@num_habitaciones", num_habitaciones);
            command.Parameters.AddWithValue("@num_banos", num_banos);
            command.Parameters.AddWithValue("@precio", precio);
            command.Parameters.AddWithValue("@estado", estado);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }


}
