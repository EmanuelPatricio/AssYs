using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Cache;

namespace Datos
{
    public class Usuario : ConexionSQL
    {
        public bool Login(string user, string pass)
        {
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@pass", pass);
                    comando.CommandText = "SELECT * FROM users WHERE [user] = @user and pass = @pass";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            CacheUsuario.id = lector.GetInt32(0);
                            CacheUsuario.name = lector.GetString(3);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
