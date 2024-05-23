using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_hdp2.models
{
    class ClientesDB
    {
        private string connectionString = "Data Source=sebasl;Initial Catalog=app_hdp2;User=sa;Password=123456";

        public List<Cliente> GetAll()
        {
            var clientes = new List<Cliente>();
            string query = "select id,nombre,apellido,direccion from cliente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string direccion = reader.GetString(3);
                    Cliente cliente = new Cliente(id, nombre, apellido, direccion);
                    clientes.Add(cliente);
                }
                reader.Close();

                connection.Close();

                return clientes;
            }
        }
        public Cliente Get(string nombreCliente)
        {
            Cliente cliente = null;
            string query = "select id,nombre,apellido,direccion from cliente where nombre=@nombreCliente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                command.Parameters.AddWithValue("@nombreCliente", nombreCliente);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    int id_user = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string direccion = reader.GetString(3);
                    cliente = new Cliente(id_user, nombre, apellido, direccion);
                }
                reader.Close();

                connection.Close();

            }
            return cliente;
        }

        public void Add(Cliente cliente)
        {
            string query = "insert into cliente (nombre,apellido,direccion) values (@nombre,@apellido,@direccion);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cliente.getNombre());
                command.Parameters.AddWithValue("@apellido", cliente.getApellido());
                command.Parameters.AddWithValue("@direccion", cliente.getDireccion());

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Update(Cliente cliente, int Id)
        {
            string query = "update cliente set nombre=@nombre, apellido=@apellido, direccion=@direccion where id=@id;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cliente.getNombre());
                command.Parameters.AddWithValue("@apellido", cliente.getApellido());
                command.Parameters.AddWithValue("@direccion", cliente.getDireccion());
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int Id)
        {
            string query = "delete from cliente where id=@id;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
