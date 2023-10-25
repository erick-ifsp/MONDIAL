using Aula1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    User objeto = new User(
                    (int)dr["id"],
                    (string)dr["nome"],
                    (string)dr["senha"]
                    );

                    users.Add(objeto);
                }
                dr.Close();
                return users;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }
        public void UpdateUser(int id, User user)
        {
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"UPDATE CreateAccount SET
                nome = @nome,
                senha = @senha
                WHERE id = @id";

                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@nome", user.Nome);
                sqlCommand.Parameters.AddWithValue("@senha", user.Senha);

                sqlCommand.ExecuteNonQuery();
            }
        }
        public void InsertUser(User user)
        {
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO CreateAccount VALUES
            (@nome, @senha)";

                sqlCommand.Parameters.AddWithValue("@nome", user.Nome);
                sqlCommand.Parameters.AddWithValue("@senha", user.Senha);

                sqlCommand.ExecuteNonQuery();
            }
        }
        public void DeleteUser(int id, User user)
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