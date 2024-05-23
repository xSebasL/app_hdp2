using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_hdp2.models
{
    internal class VentasDB
    {
        private string connectionString = "Data Source=sebasl;Initial Catalog=app_hdp2;User=sa;Password=123456";

        public List<Venta> GetAll()
        {
            var ventas = new List<Venta>();
            string query = "select id,producto,fecha,cliente from venta";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int producto = reader.GetInt32(1);
                    DateTime fecha = reader.GetDateTime(2);
                    int cliente = reader.GetInt32(3);
                    Venta venta = new Venta(id, producto,fecha.ToString(), cliente);
                    ventas.Add(venta);
                }
                reader.Close();

                connection.Close();
            }
            return ventas;
        }
        public void Add(Venta venta)
        {
            string query = "insert into venta (producto,fecha,cliente) values (@producto,@fecha,@cliente);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@producto", venta.getProducto());
                command.Parameters.AddWithValue("@fecha", venta.getFecha());
                command.Parameters.AddWithValue("@cliente", venta.getCliente());

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
