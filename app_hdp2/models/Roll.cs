using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_hdp2.models
{
    class Roll
    {
        private int id {  get; set; }
        private string descripcion { get; set; }
        public Roll(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
        public int getId() { return id; }
        public string getDescripcion() { return this.descripcion; }
    }
}
