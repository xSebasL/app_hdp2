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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            VentasDB ventasDB = new VentasDB();
            List<Venta> ventas = ventasDB.GetAll();
            foreach (Venta venta in ventas)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgVentas);
                row.Cells[0].Value = venta.getId();
                row.Cells[1].Value = venta.getProducto();
                row.Cells[2].Value = venta.getFecha();
                row.Cells[3].Value = venta.getCliente();
                dtgVentas.Rows.Add(row);
            }
        }
    }
}
