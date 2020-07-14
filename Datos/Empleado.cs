using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Empleado : ConexionSQL
    {

        private int id;
        private string name;
        private string birthday;
        private string email;
        private string position;
        private int employee_no;

        public int _Id
        {
            get { return id; }
            set { id = value; }
        }
        public string _Name
        {
            get { return name; }
            set { name = value; }
        }

        public string _Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string _Email
        {
            get { return email; }
            set { email = value; }
        }

        public string _Position
        {
            get { return position; }
            set { position = value; }
        }

        public int _Employee_no
        {
            get { return employee_no;  }
            set { employee_no = value; }
        }

        public DataTable Cargar(string proc)
        {
            DataTable tabla = new DataTable();
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    SqlDataReader leer;
                    comando.Connection = conexion;
                    comando.CommandText = proc;
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        public void Insertar()
        {
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insertEmployee";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@name", _Name);
                    comando.Parameters.AddWithValue("@birthday", _Birthday);
                    comando.Parameters.AddWithValue("@email", _Email);
                    comando.Parameters.AddWithValue("@position", _Position);
                    comando.Parameters.AddWithValue("@employee_no", _Employee_no);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            }
        }

        public void Editar()
        {
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "editEmployee";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@name", _Name);
                    comando.Parameters.AddWithValue("@birthday", _Birthday);
                    comando.Parameters.AddWithValue("@email", _Email);
                    comando.Parameters.AddWithValue("@position", _Position);
                    comando.Parameters.AddWithValue("@id", _Id);
                    comando.Parameters.AddWithValue("@employee_no", _Employee_no);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            }
        }

        public void Eliminar()
        {
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "deleteEmployee";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", _Id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }

        public string entryCheck(string employee_no)
        {
            string employee = "";
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@employee_no", employee_no);
                    comando.CommandText = "SELECT * FROM employees WHERE employee_no = @employee_no";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            employee = lector.GetString(2);
                        }
                        return employee;
                    }
                    else
                        return employee;
                }
            }
        }

        public void entry(string time)
        {
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "entryProc";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@employee_no", _Employee_no);
                    comando.Parameters.AddWithValue("@time", time);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }
    }
}
