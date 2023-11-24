using Aula1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace site_pr2
{
    internal class UserDAO
    {
        public List<User> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM CreateAccount";

            List<User> users = new List<User>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    User objeto = new User(
                    (int)dr["id"],
                    (string)dr["usuario"],
                    (string)dr["senha"],
                    (string)dr["cpf"],
                    (string)dr["email"]
                    );

                    users.Add(objeto);
                }
                dr.Close();
            }
            catch (Exception)
            {
                throw new Exception("erro na leitura");
            }
            finally
            {
                conn.CloseConnection();
            }
            return users;
        }
        public void UpdateUser(int id, User user)
        {
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(user.Senha));
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    string sha256string = sb.ToString();

                    Connection connection = new Connection();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = connection.ReturnConnection();
                    sqlCommand.CommandText = @"UPDATE CreateAccount SET
                    usuario = @usuario,
                    senha = @senha,
                    cpf = @cpf,
                    email = @email
                    WHERE id = @id";

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@usuario", user.Usuario);
                    sqlCommand.Parameters.AddWithValue("@senha", sha256string);
                    sqlCommand.Parameters.AddWithValue("@cpf", user.Cpf);
                    sqlCommand.Parameters.AddWithValue("@email", user.Email);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void InsertUser(User user)
        {
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(user.Senha));
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    string sha256string = sb.ToString();

                    Connection connection = new Connection();
                    SqlCommand sqlCommand = new SqlCommand();

                    sqlCommand.Connection = connection.ReturnConnection();
                    sqlCommand.CommandText = @"INSERT INTO CreateAccount VALUES
                    (@usuario, @senha, @cpf, @email)";

                    sqlCommand.Parameters.AddWithValue("@usuario", user.Usuario);
                    sqlCommand.Parameters.AddWithValue("@senha", sha256string);
                    sqlCommand.Parameters.AddWithValue("@cpf", user.Cpf);
                    sqlCommand.Parameters.AddWithValue("@email", user.Email);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void DeleteUser(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM CreateAccount WHERE id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}