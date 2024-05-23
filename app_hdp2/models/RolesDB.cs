using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_hdp2.models
{
    class RolesDB
    {
        private string connectionString = "Data Source=sebasl;Initial Catalog=app_hdp2;User=sa;Password=123456";

        public List<Roll> GetAll()
        {
            var roles = new List<Roll>();
            string query = "select id,descripcion from roll";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string descripcion = reader.GetString(1);
                    Roll roll = new Roll(id, descripcion);
                    roles.Add(roll);
                }
                reader.Close();

                connection.Close();

            }
            return roles;
        }
        public Roll Get(string nombreDescripcion)
        {
            Roll roll = null;
            string query = "select id,descripcion from roll where descripcion=@descripcion";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                command.Parameters.AddWithValue("@descripcion", nombreDescripcion);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string descripcion = reader.GetString(1);
                    roll = new Roll(id,descripcion);
                }
                reader.Close();

                connection.Close();

            }
            return roll;
        }

        public void Add(Roll roll)
        {
            string query = "insert into roll (descripcion) values (@descripcion);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@descripcion", roll.getDescripcion());

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Update(Roll roll, int Id)
        {
            string query = "update roll set descripcion=@descripcion where id=@id;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@descripcion", roll.getDescripcion());
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int Id)
        {
            string query = "delete from roll where id=@id;";
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
                MessageBox.Show("No se puede eliminar porque existen usuarios registrados con este roll");
            }
        }
    }
}
