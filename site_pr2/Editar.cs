using Aula1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace site_pr2
{
    public partial class Editar : Form
    {
        private int id;
        public Editar()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            dados.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM CreateAccount";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string name = (string)dr["nome"];
                    string pass = (string)dr["senha"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(pass);
                    dados.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void dados_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = dados.FocusedItem.Index;
            id = int.Parse(dados.Items[index].SubItems[0].Text);
            b1.Text = dados.Items[index].SubItems[1].Text;
            b2.Text = dados.Items[index].SubItems[2].Text;
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string pront = b2.Text;

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


            if (b1.Text == "" || b2.Text == "" || b1.Text == "" & b2.Text == "")
            {
                MessageBox.Show(
                "Clique na informação que deseja editar ou excluir!",
                "MONDIAL™",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            b1.Clear();
            b2.Clear();

            UpdateListView();
        }

        private void b1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            b1.Clear();
            b2.Clear();

            UpdateListView();
        }
    }
}
