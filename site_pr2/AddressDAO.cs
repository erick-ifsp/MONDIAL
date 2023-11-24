using Aula1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace site_pr2
{
    internal class AddressDAO
    {
        public List<Address> SelectAddress()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM CreateAddress";

            List<Address> addresses = new List<Address>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    Address objeto = new Address(
                    (int)dr["id"],
                    (string)dr["usuario"],
                    (string)dr["cep"],
                    (string)dr["telefone"],
                    (string)dr["endereco"],
                    (string)dr["numero"],
                    (string)dr["bairro"],
                    (string)dr["cidade"],
                    (string)dr["estado"]
                    );

                    addresses.Add(objeto);
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
            return addresses;
        }
        public void UpdateAddress(int id, Address address)
        {
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"UPDATE CreateAddress SET
                usuario = @usuario,
                cep = @cep,
                telefone = @telefone,
                endereco = @endereco,
                numero = @numero,
                bairro = @bairro,
                cidade = @cidade,
                estado = @estado
                WHERE id = @id";
                
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@usuario", address.Usuario);
                sqlCommand.Parameters.AddWithValue("@cep", address.Cep);
                sqlCommand.Parameters.AddWithValue("@telefone", address.Telefone);
                sqlCommand.Parameters.AddWithValue("@endereco", address.Endereco);
                sqlCommand.Parameters.AddWithValue("@numero", address.Numero);
                sqlCommand.Parameters.AddWithValue("@bairro", address.Bairro);
                sqlCommand.Parameters.AddWithValue("@cidade", address.Cidade);
                sqlCommand.Parameters.AddWithValue("@estado", address.Estado);

                sqlCommand.ExecuteNonQuery();
            }
        }
        public void InsertAddress(Address address)
        {
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO CreateAddress VALUES
            (@usuario, @cep, @telefone, @endereco, @numero, @bairro, @cidade, @estado)";

                sqlCommand.Parameters.AddWithValue("@usuario", address.Usuario);
                sqlCommand.Parameters.AddWithValue("@cep", address.Cep);
                sqlCommand.Parameters.AddWithValue("@telefone", address.Telefone);
                sqlCommand.Parameters.AddWithValue("@endereco", address.Endereco);
                sqlCommand.Parameters.AddWithValue("@numero", address.Numero);
                sqlCommand.Parameters.AddWithValue("@bairro", address.Bairro);
                sqlCommand.Parameters.AddWithValue("@cidade", address.Cidade);
                sqlCommand.Parameters.AddWithValue("@estado", address.Estado);

                sqlCommand.ExecuteNonQuery();
            }
        }
        public void DeleteAddress(Address address)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM CreateAddress WHERE usuario = @usuario";
            sqlCommand.Parameters.AddWithValue("@usuario", address.Usuario);

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
