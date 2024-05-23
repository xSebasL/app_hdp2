using app_hdp2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_hdp2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UsuariosDB usuariosDB = new UsuariosDB();
            Usuario user = usuariosDB.Get(txtUsuario.Text);

            if (user != null)
            {
                if (user.getClave() == txtClave.Text)
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();
                }
                else
                {
                    lblPrueba.Text = "contraseña incorrecta";
                }
            }
            else
            {
                lblPrueba.Text = "usuario incorrecto";
            }
        }
        private bool validarFormulario(string usuario, string clave)
        {
            return usuario == txtUsuario.Text && clave == txtClave.Text;
        }
    }
}
