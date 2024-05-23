using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace app_hdp2.models
{
    class UsuariosDB
    {
        private string connectionString = "Data Source=sebasl;Initial Catalog=app_hdp2;User=sa;Password=123456";

        public List<Usuario> GetAll()
        {
            var usuarios = new List<Usuario>();
            string query = "select id,usuario,clave,nombre,apellido,roll from usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string usuario = reader.GetString(1);
                    string clave = reader.GetString(2);
                    string nombre = reader.GetString(3);
                    string apellido = reader.GetString(4);
                    int roll = reader.GetInt32(5);
                    Usuario user = new Usuario(id, usuario, clave, nombre, apellido, roll);
                    usuarios.Add(user);
                }
                reader.Close();

                connection.Close();

                return usuarios;
            }
        } 
        public Usuario Get(string nombreUsuario)
        {
            Usuario user = null;
            string query = "select id,usuario,clave,nombre,apellido,roll from usuario where usuario=@nombreUsuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    int id_user = reader.GetInt32(0);
                    string usuario = reader.GetString(1);
                    string clave = reader.GetString(2);
                    string nombre = reader.GetString(3);
                    string apellido = reader.GetString(4);
                    int roll = reader.GetInt32(5);
                    user = new Usuario(id_user, usuario, clave, nombre, apellido, roll);
                }
                reader.Close();

                connection.Close();

            }
            return user;
        }

        public void Add(Usuario user)
        {
            string query = "insert into usuario (usuario,clave,nombre,apellido,roll) values (@usuario,@clave,@nombre,@apellido,@roll);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", user.getUsuario());
                command.Parameters.AddWithValue("@clave", user.getClave());
                command.Parameters.AddWithValue("@nombre", user.getNombre());
                command.Parameters.AddWithValue("@apellido", user.getApellido());
                command.Parameters.AddWithValue("@roll", user.getRoll());

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Update(Usuario user, int Id)
        {
            string query = "update usuario set usuario=@usuario, clave=@clave, nombre=@nombre, apellido=@apellido, roll=@roll where id=@id;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", user.getUsuario());
                command.Parameters.AddWithValue("@clave", user.getClave());
                command.Parameters.AddWithValue("@nombre", user.getNombre());
                command.Parameters.AddWithValue("@apellido", user.getApellido());
                command.Parameters.AddWithValue("@roll", user.getRoll());
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int Id)
        {
            string query = "delete from usuario where id=@id;";
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
