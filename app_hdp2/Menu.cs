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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRoll roles = new frmRoll();
            roles.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVender ventas = new frmVender();
            ventas.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
        }
    }
}
