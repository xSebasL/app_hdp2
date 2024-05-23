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
    public partial class frmVender : Form
    {
        public frmVender()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarProductos();
        }

        private void cargarClientes()
        {
            ClientesDB clientesDB = new ClientesDB();
            List<Cliente> clientes = clientesDB.GetAll();

            foreach (Cliente cliente in clientes)
            {
                cbCliente.Items.Add(cliente.getNombre());
            }
        }

        private void cargarProductos()
        {
            ProductosDB productosDB = new ProductosDB();
            List<Producto> productos = productosDB.GetAll();

            foreach(Producto producto in productos)
            {
                cbProducto.Items.Add(producto.getNombre());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductosDB productosDB = new ProductosDB();
            Producto producto = productosDB.Get(cbProducto.SelectedItem.ToString());
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dtgCarrito);
            row.Cells[0].Value = producto.getNombre();
            row.Cells[1].Value = producto.getPrecio();
            dtgCarrito.Rows.Add(row);
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            ProductosDB productosDB= new ProductosDB();
            ClientesDB clientesDB = new ClientesDB();
            VentasDB ventasDB = new VentasDB();

            for(int i = 0; i<dtgCarrito.Rows.Count-1; i++)
            {
                int producto = productosDB.Get(dtgCarrito.Rows[i].Cells[0].Value.ToString()).getId();
                DateTime currentDate = DateTime.Now;
                string fecha = currentDate.ToString("yyyy-MM-dd");
                int cliente = clientesDB.Get(cbCliente.SelectedItem.ToString()).getId();
                Venta venta = new Venta(1,producto, fecha, cliente);
                ventasDB.Add(venta);
            }
            dtgCarrito.Rows.Clear();
        }
    }
}
