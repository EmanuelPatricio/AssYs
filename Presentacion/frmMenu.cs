using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Comun.Cache;
using Presentacion;

namespace MenuPrincipal
{
    public partial class frmMenu : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottonRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public frmMenu()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnInicio.Height;
            pnlNav.Top = btnInicio.Top;
            pnlNav.Left = btnInicio.Left;

            this.pnlFormLoader.Controls.Clear();
            frmInicio frmInicio_Ctrls = new frmInicio() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Ctrls.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmInicio_Ctrls);
            frmInicio_Ctrls.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblNombre.Text = CacheUsuario.name;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnInicio.Height;
            pnlNav.Top = btnInicio.Top;
            pnlNav.Left = btnInicio.Left;

            this.pnlFormLoader.Controls.Clear();
            frmInicio frmInicio_Ctrls = new frmInicio() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Ctrls.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmInicio_Ctrls);
            frmInicio_Ctrls.Show();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAsistencia.Height;
            pnlNav.Top = btnAsistencia.Top;
            pnlNav.Left = btnAsistencia.Left;

            this.pnlFormLoader.Controls.Clear();
            frmAsistencia frmInicio_Ctrls = new frmAsistencia() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Ctrls.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmInicio_Ctrls);
            frmInicio_Ctrls.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEmpleados.Height;
            pnlNav.Top = btnEmpleados.Top;
            pnlNav.Left = btnEmpleados.Left;

            this.pnlFormLoader.Controls.Clear();
            frmEmpleados frmEmpleados_Ctrls = new frmEmpleados() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEmpleados_Ctrls.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEmpleados_Ctrls);
            frmEmpleados_Ctrls.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Close();
        }
    }
}
