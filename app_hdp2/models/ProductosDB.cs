using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_hdp2.models
{
    class ProductosDB
    {
        private string connectionString = "Data Source=sebasl;Initial Catalog=app_hdp2;User=sa;Password=123456";

        public List<Producto> GetAll()
        {
            var productos = new List<Producto>();
            string query = "select id,nombre,precio from producto";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    int precio = reader.GetInt32(2);
                    Producto producto = new Producto(id, nombre,precio);
                    productos.Add(producto);
                }
                reader.Close();

                connection.Close();

            }
            return productos;
        }
        public Producto Get(string nombreProducto)
        {
            Producto producto = null;
            string query = "select id,nombre,precio from producto where nombre=@nombreProducto";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                command.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    int precio = reader.GetInt32(2);

                    producto = new Producto(id,nombre,precio);
                }
                reader.Close();

                connection.Close();

            }
            return producto;
         }

        public void Add(Producto producto)
        {
            string query = "insert into producto (nombre,precio) values (@nombre,@precio);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", producto.getNombre());
                command.Parameters.AddWithValue("@precio", producto.getPrecio());

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Update(Producto producto, int Id)
        {
            string query = "update producto set nombre=@nombre, precio=@precio where id=@id;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", producto.getNombre());
                command.Parameters.AddWithValue("@precio", producto.getPrecio());
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int Id)
        {
            string query = "delete from producto where id=@id;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("No se puede eliminar");
            }
        }
    }
}
