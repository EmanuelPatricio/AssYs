using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Dominio;

namespace Presentacion
{
    public partial class frmEmpleados : Form
    {
        public static Empleado objetoCN = new Empleado();
        private string idEmpleado = null;
        public static bool FormEdit = false;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowTemplate.Height = 35;

        }

        private void MostrarEmpleados()
        {
            ModeloEmpleado objeto = new ModeloEmpleado();
            dataGridView1.DataSource = objeto.MostrarEmple();
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FormEdit = false;
            frmEmployeeInput configemployeesform = new frmEmployeeInput(this);
            configemployeesform.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objetoCN._Name = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                objetoCN._Birthday = dataGridView1.CurrentRow.Cells["Birthday"].Value.ToString();
                objetoCN._Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                objetoCN._Position = dataGridView1.CurrentRow.Cells["Posicion"].Value.ToString();
                objetoCN._Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                objetoCN._Employee_no = Convert.ToInt32(dataGridView1.CurrentRow.Cells["No. Institucional"].Value.ToString());

                FormEdit = true;
                frmEmployeeInput configemployeesform = new frmEmployeeInput(this);
                configemployeesform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar por favor");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                        if (dataGridView1.SelectedRows.Count > 0)
            {
                idEmpleado = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                objetoCN._Id = Convert.ToInt32(idEmpleado);
                objetoCN.Eliminar();
                MessageBox.Show("Empleado eliminado correctamente");
                MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
