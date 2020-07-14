using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Asistencia : ConexionSQL
    {
        public DataTable assistList(string date, int number_days)
        {
            using (var conexion = AbrirConexion())
            {
                DataTable table = new DataTable();
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    SqlDataReader read;
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@date", date);
                    comando.Parameters.AddWithValue("@days", number_days);
                    comando.CommandText = "asssistList";
                    comando.CommandType = CommandType.StoredProcedure;
                    read = comando.ExecuteReader();
                    table.Load(read);
                    return table;
                }
            }
        }

        public class Gauge
        {
            public int to { get; set; }
            public int value { get; set; }
            public Gauge(int _To, int _Value)
            {
                to = _To;
                value = _Value;
            }
        }

        public class EmployeeInit
        {
            public string name { get; set; }
            public string position { get; set; }
            public string time { get; set; }
            public EmployeeInit(string _Name, string _Position, string _Time)
            {
                name = _Name;
                position = _Position;
                time = _Time;
            }
        }


        public Gauge initGauge()
        {
            using (var conexion = AbrirConexion())
            {
                
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "initGauge";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader lector = comando.ExecuteReader();
                    int to = '0', value = '0';
                    while (lector.Read())
                    {
                        to = lector.GetInt32(0);
                        value = lector.GetInt32(1);
                    }

                    Gauge gauge = new Gauge(to, value);
                    return gauge;

                }
            }
        }

        public EmployeeInit getFirst()
        {
            using (var conexion = AbrirConexion())
            {
                
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "getFirstEmployee";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader lector = comando.ExecuteReader();
                    string name = "", position = "", time = "";
                    while (lector.Read())
                    {
                        name = lector.GetString(0);
                        position = lector.GetString(1);
                        time = lector.GetString(2);
                    }

                    EmployeeInit employee = new EmployeeInit(name, position, time);
                    return employee;

                }
            }
        }

        public EmployeeInit getLast()
        {
            using (var conexion = AbrirConexion())
            {

                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "getLastEmployee";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader lector = comando.ExecuteReader();
                    string name = "", position = "", time = "";
                    while (lector.Read())
                    {
                        name = lector.GetString(0);
                        position = lector.GetString(1);
                        time = lector.GetString(2);
                    }

                    EmployeeInit employee = new EmployeeInit(name, position, time);
                    return employee;

                }
            }
        }

    }
}
