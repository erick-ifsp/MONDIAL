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
using System.Xml.Linq;

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
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.SelectUser();

            try
            {
                foreach (User user in users)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Senha);
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
            b2.Text = dados.Items[index].SubItems[2].Text;
            string b_name = b1.Text;
        }

        private void botao_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(id, b1.Text, b2.Text);

                UserDAO userDAO = new UserDAO();
                userDAO.UpdateUser(id, user);

                b1.Clear();
                b2.Clear();

                MessageBox.Show(
                    "Usuário editado com sucesso!",
                    "MONDIAL™",
                    MessageBoxButtons.OK,

                    MessageBoxIcon.Information);
                UpdateListView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
                User user = new User(id, b1.Text, b2.Text);

                UserDAO userDAO = new UserDAO();
                userDAO.DeleteUser(id, user);

                b1.Clear();
                b2.Clear();

                MessageBox.Show(
                    "Usuário excluido com sucesso!",
                    "MONDIAL™",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateListView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
