using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class NG_usuario
    {
        private login log = new login();
        bool n = false;

        public bool VerificarUser(string email, string contraseña)
        {
            n = log.VerificarUsuario(email, contraseña);
            return n;
        }
    }
}
