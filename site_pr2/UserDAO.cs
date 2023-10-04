using Aula1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_pr2
{
    internal class UserDAO
    {
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
        public void UpdateUser(int id)
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
                sqlCommand.Parameters.AddWithValue("@nome", b1.Text);
                sqlCommand.Parameters.AddWithValue("@senha", b2.Text);

                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
