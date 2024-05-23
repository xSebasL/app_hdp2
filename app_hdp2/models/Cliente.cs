using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_hdp2.models
{
    class Cliente
    {
        private int id {  get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string direccion {  get; set; }

        public Cliente(int id, string nombre, string apellido, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
        }
        public int getId() { return this.id; }
        public string getNombre() {  return this.nombre; }
        public string getApellido() {  return this.apellido; }
        public string getDireccion() {  return this.direccion; }
    }
}
