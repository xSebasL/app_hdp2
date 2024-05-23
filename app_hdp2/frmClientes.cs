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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Actualizar();
        }
        private void Actualizar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnModificar.Enabled = false;
            gbFormulario.Enabled = true;
            dtgClientes.Rows.Clear();
            ClearData();
            ClientesDB clientesDB = new ClientesDB();
            List<Cliente> clientes = clientesDB.GetAll();
            foreach (Cliente cliente in clientes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgClientes);
                row.Cells[0].Value = cliente.getId();
                row.Cells[1].Value = cliente.getNombre();
                row.Cells[2].Value = cliente.getApellido();
                row.Cells[3].Value = cliente.getDireccion();
                dtgClientes.Rows.Add(row);
            }
        }

        private void ClearData()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente newCliente = new Cliente(1, txtNombre.Text, txtApellido.Text,txtDireccion.Text);
            ClientesDB clientesDB = new ClientesDB();
            clientesDB.Add(newCliente);
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            gbFormulario.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente newCliente = new Cliente(int.Parse(txtId.Text), txtNombre.Text,txtApellido.Text,txtDireccion.Text);
            ClientesDB clientesDB = new ClientesDB();
            clientesDB.Update(newCliente, int.Parse(txtId.Text));
            Actualizar();
            btnActualizar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClientesDB clientesDB = new ClientesDB();
            clientesDB.Delete(int.Parse(txtId.Text));
            Actualizar();
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbFormulario.Enabled = false;
            txtId.Text = dtgClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dtgClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApellido.Text = dtgClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDireccion.Text = dtgClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
