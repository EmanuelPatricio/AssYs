using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Datos;
using Dominio;

namespace Presentacion
{
    public partial class frmEmployeeInput : Form
    {
        Empleado objetoCN1 = new Empleado();
        private int employee_id;
        frmEmpleados frmEmpleados;

        public frmEmployeeInput(frmEmpleados _frmEmpleados)
        {
            InitializeComponent();
            frmEmpleados = _frmEmpleados;
        }
        private void frmEmployeeInput_Load_1(object sender, EventArgs e)
        {
            ListarCategorias();
            if (frmEmpleados.FormEdit == true)
            {
                btnAction.Text = "Editar";
                btnAction.BackColor = Color.SkyBlue;
                lblTitle.Text = "Editar Empleado";
                txtName.Text = frmEmpleados.objetoCN._Name;
                txtEmployeeId.Text = frmEmpleados.objetoCN._Employee_no.ToString();
                txtEmail.Text = frmEmpleados.objetoCN._Email;
                cmbPosition.Text = frmEmpleados.objetoCN._Position;
                birthdayDatePicker.Value = DateTime.Parse(frmEmpleados.objetoCN._Birthday);
                employee_id = frmEmpleados.objetoCN._Id;

            }
            else
            {
                btnAction.Text = "Guardar";
                btnAction.BackColor = Color.SteelBlue;
                lblTitle.Text = "Agregar Empleado";
            }
        }

        private void ListarCategorias()
        {
            ModeloEmpleado objeto = new ModeloEmpleado();
            cmbPosition.DataSource = objeto.ListCargo();
            cmbPosition.DisplayMember = "position";
            cmbPosition.ValueMember = "id_position";
        }
        private void btnAction_Click(object sender, EventArgs e)
        {
            if(frmEmpleados.FormEdit == false)
            {
                try
                {
                    objetoCN1._Name = txtName.Text;
                    objetoCN1._Employee_no = Convert.ToInt32(txtEmployeeId.Text);
                    objetoCN1._Birthday = birthdayDatePicker.Value.ToString("yyyy/MM/dd");
                    objetoCN1._Email = txtEmail.Text;
                    objetoCN1._Position = cmbPosition.SelectedValue.ToString();
                    objetoCN1.Insertar();
                    MessageBox.Show("Se inserto correctamente");
                    MostrarEmpleados();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                    throw;
                }
            }
            else
            {
                try
                {
                    objetoCN1._Name = txtName.Text;
                    objetoCN1._Employee_no = Convert.ToInt32(txtEmployeeId.Text);
                    objetoCN1._Birthday = birthdayDatePicker.Value.ToString("yyyy/MM/dd");
                    objetoCN1._Email = txtEmail.Text;
                    objetoCN1._Position = cmbPosition.SelectedValue.ToString();
                    objetoCN1._Id = employee_id;
                    objetoCN1.Editar();
                    MessageBox.Show("Se edito correctamente");
                    MostrarEmpleados();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                    throw;
                }
            }
        }
        private void MostrarEmpleados()
        {
            ModeloEmpleado objeto = new ModeloEmpleado();
            frmEmpleados.dataGridView1.DataSource = objeto.MostrarEmple();
        }



    }
}
