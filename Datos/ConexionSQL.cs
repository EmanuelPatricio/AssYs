using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class ConexionSQL
    {
        private readonly string conexion;
        public ConexionSQL()
        {
            conexion = "Server=(localdb)\\DBEngine;DataBase=ProyectoProgramacion1;Integrated Security=true";
        }

        protected SqlConnection AbrirConexion()
        {
            return new SqlConnection(conexion);
        }
    }
}
