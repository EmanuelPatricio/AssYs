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
using System.Windows.Media;


namespace MenuPrincipal
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            setEmployees();
            Gauge();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Gauge()
        {
            Asistencia assist = new Asistencia();
            var a = assist.initGauge();

            solidGauge1.Uses360Mode = true;
            solidGauge1.From = 0;
            solidGauge1.To = a.to;
            solidGauge1.Value = a.value;

        }
        private void setEmployees()
        {
            Asistencia assist = new Asistencia();
            var a = assist.getFirst();
            lblHoraPrimer.Text = a.time;
            lblNombrePrimer.Text = a.name;
            lblPosicionPrimer.Text = a.position;

            var b = assist.getLast();
            lblPosicionUltimo.Text = b.position;
            lblNombreUltimo.Text = b.name;
            lblHoraUltimo.Text = b.time;
        }
        private void solidGauge1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
