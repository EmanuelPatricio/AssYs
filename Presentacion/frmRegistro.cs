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

namespace Presentacion
{
    public partial class frmRegistro : Form
    {
        private Timer time = new Timer();
        private Random random = new Random();
        public frmRegistro()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
                    lblError.Visible = false;
            if(txtEmployeeId.Text != "")
            {
                Empleado employee = new Empleado();
                string name = employee.entryCheck(txtEmployeeId.Text);
                if(name != "")
                {
                    string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    employee._Employee_no = Convert.ToInt32(txtEmployeeId.Text);
                    employee.entry(time);
                    int temperatura_rdm = random.Next(30, 38);
                    lblTemperatura.Text = temperatura_rdm.ToString() + "°C";
                    lblGreet.Text = "Bienvenido! " + name + " , su hora de entrada hoy es: " + DateTime.Now.ToString("h:mm tt");
                    lblGreet.Visible = true;
                    lblProgressBar.Visible = true;
                    progressBar1.Visible = true;
                    InitializeMyTimer();
                }
                else
                {
                    msgError("Empleado no encontrado");
                }
            }
            else
            {
                msgError("Por favor ingrese un numero de empleado");
            }
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void InitializeMyTimer()
        {
            time.Interval = 500;
            time.Tick += new EventHandler(IncreaseProgressBar);
            time.Start();
        }
        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                time.Stop();
                lblGreet.Visible = false;
                lblProgressBar.Visible = false;
                progressBar1.Visible = false;
                lblTemperatura.Text = "00°C";
                txtEmployeeId.Text = "";
                time.Stop();
            }
            else
            {
                progressBar1.Value += 10;
            }
        }
    }
}
