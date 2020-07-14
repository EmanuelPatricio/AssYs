using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Dominio
{
    public class ModeloEmpleado
    {
        private Empleado objetoCD = new Empleado();
        public DataTable MostrarEmple()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Cargar("employeeList");
            return tabla;
        }

        public DataTable ListCargo()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Cargar("listPositions");
            return tabla;
        }

        public DataTable AsistenciaToday()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Cargar("todayAssist");
            return tabla;
        }
    }
}
