using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class ModeloUsuario
    {
        Usuario usuario = new Usuario();
        public bool LoginUser(string user, string pass)
        {
            return usuario.Login(user, pass);
        }
    }
}
