using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using MenuPrincipal;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var loginValido = usuario.LoginUser(txtUsuario.Text, txtContraseña.Text);
                    if (loginValido == true)
                    {
                        frmMenu menuPrincipal = new frmMenu();
                        menuPrincipal.Show();
                        this.Close();
                    }
                    else
                    {
                        msgError("Usuario y/o Contraseña Incorrectos");
                        txtUsuario.Focus();
                        txtContraseña.Clear();
                    }
                }
                else msgError("Ingrese una contraseña por favor.");
            }
            else msgError("Ingrese un nombre de usuario por favor.");
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
