using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Propieda
    {
        Conexion conx = new Conexion();
        
        public SqlDataReader ver()
        {
            SqlDataReader r = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText("");
        }
    }
}
