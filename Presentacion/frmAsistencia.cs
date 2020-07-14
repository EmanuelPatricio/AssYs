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
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            MostrarAsistenciaToday();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowTemplate.Height = 35;
        }

        private void AsistenciaData(string date, int number)
        {
            Asistencia assist = new Asistencia();
            switch (number)
            {
                case 1:
                    dataGridView1.DataSource = assist.assistList(date, 1);
                    break;
                case 7:
                    dataGridView1.DataSource = assist.assistList(date, 7);
                    break;
                case 14:
                    dataGridView1.DataSource = assist.assistList(date, 14);
                    break;
            }
        }
        private void MostrarAsistenciaToday()
        {
            AsistenciaData(DateTime.Now.ToString("yyyy-MM-dd"), 1);
        }

        private void btnOneDay_Click(object sender, EventArgs e)
        {
            AsistenciaData(dateTimePicker1.Value.ToString("yyyy-MM-dd"), 1);
        }

        private void btn7Days_Click(object sender, EventArgs e)
        {
            AsistenciaData(dateTimePicker1.Value.ToString("yyyy-MM-dd"), 7);
        }

        private void btn14Days_Click(object sender, EventArgs e)
        {
            AsistenciaData(dateTimePicker1.Value.ToString("yyyy-MM-dd"), 14);
        }
    }
}
