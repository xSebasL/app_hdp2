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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
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
            dtgProductos.Rows.Clear();
            ClearData();
            ProductosDB productosDB = new ProductosDB();
            List<Producto> productos = productosDB.GetAll();
            foreach (Producto producto in productos)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgProductos);
                row.Cells[0].Value = producto.getId();
                row.Cells[1].Value = producto.getNombre();
                row.Cells[2].Value = producto.getPrecio();
                dtgProductos.Rows.Add(row);
            }
        }

        private void ClearData()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto newProducto = new Producto(1, txtNombre.Text,double.Parse(txtPrecio.Text));
            ProductosDB productosDB = new ProductosDB();
            productosDB.Add(newProducto);
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
            Producto newProducto = new Producto(int.Parse(txtId.Text), txtNombre.Text, double.Parse(txtPrecio.Text));
            ProductosDB productosDB = new ProductosDB();
            productosDB.Update(newProducto, int.Parse(txtId.Text));
            Actualizar();
            btnActualizar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductosDB productosDB = new ProductosDB();
            productosDB.Delete(int.Parse(txtId.Text));
            Actualizar();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbFormulario.Enabled = false;
            txtId.Text = dtgProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dtgProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrecio.Text = dtgProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
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
