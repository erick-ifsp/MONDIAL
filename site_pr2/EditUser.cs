using Aula1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace site_pr2
{
    public partial class EditUser : Form
    {
        private int id;
        private int doubleclick = 0;
        public EditUser()
        {
            InitializeComponent();
            UpdateListView();
        }
        private void UpdateListView()
        {
            dados.Items.Clear();
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.SelectUser();
            try
            {
                foreach (User user in users)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Usuario);
                    lv.SubItems.Add(user.Senha);
                    lv.SubItems.Add(user.Cpf);
                    lv.SubItems.Add(user.Email);
                    dados.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
            b3.Text = dados.Items[index].SubItems[3].Text;
            b4.Text = dados.Items[index].SubItems[4].Text;
            doubleclick = 1;
        }

        private void botao_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeUsuario = b1.Text;
                bool usuarioExiste = VerificarUsuarioExistente(nomeUsuario);

                for (; ; )
                {
                    if (usuarioExiste)
                    {
                        MessageBox.Show(
                            "O nome de usuário já esta sendo utilizado!",
                            "MONDIAL™",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        b1.Clear();
                        break;
                    }

                    User user = new User(id, b1.Text, b2.Text, b3.Text, b4.Text);

                    UserDAO userDAO = new UserDAO();
                    userDAO.UpdateUser(id, user);

                    b1.Clear();
                    b2.Clear();
                    b3.Clear();
                    b4.Clear();
                    UpdateListView();

                    if (doubleclick == 1)
                    {
                        MessageBox.Show(
                        "Informações editadas com sucesso!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                        "Clique duas vezes no usuário para editá-lo!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private static bool VerificarUsuarioExistente(string nomeUsuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT COUNT(*) FROM CreateAccount WHERE usuario = @verificar";

            sqlCommand.Parameters.AddWithValue("@verificar", nomeUsuario);

            int count = (int)sqlCommand.ExecuteScalar();

            return count > 0;
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
            try
            {
                User user = new User(id, b1.Text, b2.Text, b3.Text, b4.Text);
                UserDAO userDAO = new UserDAO();
                userDAO.DeleteUser(id);
                b1.Clear();
                b2.Clear();
                b3.Clear();
                b4.Clear();
                UpdateListView();

                if (doubleclick == 1)
                {
                    MessageBox.Show(
                    "Usuário excluído com sucesso!",
                    "MONDIAL™",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                    "Clique duas vezes no usuário para excluí-lo!",
                    "MONDIAL™",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
