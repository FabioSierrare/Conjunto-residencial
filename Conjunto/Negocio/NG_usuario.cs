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

        public bool VerificarUser(string numero_documento, string contraseña)
        {
            n = log.VerificarUsuario(numero_documento, contraseña);
            return n;
        }
        public void Registrar(string usuario, string email, string contraseña, string tipo_documento, string numero_documento)
        {
            log.Registro(usuario,email,contraseña,tipo_documento,numero_documento);
        }
        public bool documentVer(string numero_documento)
        {
            n = log.documentoEx(numero_documento);
            return n;

        }

    }
}
