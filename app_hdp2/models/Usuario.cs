using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_hdp2.models
{
    class Usuario
    {
        private int id { get; set; }
        private string usuario { get; set; }
        private string clave { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int roll { get; set; }
        public Usuario(int id, string usuario, string clave, string nombre, string apellido, int roll)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.apellido = apellido;
            this.roll = roll;
        }
        public int getId()
        {
            return this.id;
        }

        public string getUsuario()
        {
            return this.usuario;
        }
        public string getClave()
        {
            return this.clave;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public int getRoll()
        {
            return this.roll;
        }
    }
}
