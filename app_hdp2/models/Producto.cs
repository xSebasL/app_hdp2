using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_hdp2.models
{
    class Producto
    {
        private int id {  get; set; }
        private string nombre { get; set; }
        private double precio { get; set; }

        public Producto(int id, string nombre, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }
        public int getId() { return id; }
        public string getNombre() {  return nombre; }
        public double getPrecio() {  return precio; }

    }
}
