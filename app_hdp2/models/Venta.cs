using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_hdp2.models
{
    class Venta
    {
        private int id { get; set; }
        private int producto { get; set; }
        private string fecha {  get; set; }
        private int cliente { get; set; }

        public Venta(int id, int producto, string fecha, int cliente)
        {
            this.id = id;
            this.producto = producto;
            this.fecha = fecha;
            this.cliente = cliente;
        }
        public int getId() { return this.id; }
        public int getProducto() { return this.producto; }
        public string getFecha() {  return this.fecha; }
        public int getCliente() {  return this.cliente; }
    }
}
