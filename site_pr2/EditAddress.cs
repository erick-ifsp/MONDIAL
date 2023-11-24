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
    public partial class EditAddress : Form
    {
        private int id;
        private int doubleclick = 0;
        public EditAddress()
        {
            InitializeComponent();
            UpdateListView();
        }
        private void UpdateListView()
        {
            dados.Items.Clear();
            AddressDAO addressDAO = new AddressDAO();
            List<Address> addresses = addressDAO.SelectAddress();
            try
            {
                foreach (Address address in addresses)
                {
                    ListViewItem lv = new ListViewItem(address.Id.ToString());
                    lv.SubItems.Add(address.Usuario);
                    lv.SubItems.Add(address.Cep);
                    lv.SubItems.Add(address.Telefone);
                    lv.SubItems.Add(address.Endereco);
                    lv.SubItems.Add(address.Numero);
                    lv.SubItems.Add(address.Bairro);
                    lv.SubItems.Add(address.Cidade);
                    lv.SubItems.Add(address.Estado);
                    dados.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void dados_DoubleClick_1(object sender, EventArgs e)
        {
            int index;
            index = dados.FocusedItem.Index;
            id = int.Parse(dados.Items[index].SubItems[0].Text);
            a1.Text = dados.Items[index].SubItems[1].Text;
            a2.Text = dados.Items[index].SubItems[2].Text;
            a3.Text = dados.Items[index].SubItems[3].Text;
            a4.Text = dados.Items[index].SubItems[4].Text;
            a5.Text = dados.Items[index].SubItems[5].Text;
            a6.Text = dados.Items[index].SubItems[6].Text;
            a7.Text = dados.Items[index].SubItems[7].Text;
            a8.Text = dados.Items[index].SubItems[8].Text;
            doubleclick = 1;
        }
        private void EditAddress_Load(object sender, EventArgs e)
        {

        }
        private void EditAddress_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeUsuario = a1.Text;
                bool usuarioExiste = VerificarUsuarioExistente(nomeUsuario);

                for (; ; )
                {
                    if (usuarioExiste)
                    {


                        Address address = new Address(id, a1.Text, a2.Text, a3.Text, a4.Text, a5.Text, a6.Text, a7.Text, a8.Text);
                        AddressDAO addressDAO = new AddressDAO();
                        addressDAO.UpdateAddress(id, address);
                        a1.Clear();
                        a2.Clear();
                        a3.Clear();
                        a4.Clear();
                        a5.Clear();
                        a6.Clear();
                        a7.Clear();
                        a8.Clear();
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
                            "Clique duas vezes no endereço para editá-lo!",
                            "MONDIAL™",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "O nome de usuário está incorreto!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        a1.Clear();
                        break;
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
        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario = a1.Text;
            bool usuarioExiste = VerificarUsuarioExistente(nomeUsuario);

            for (; ; )
            {
                if (usuarioExiste)
                {


                    Address address = new Address(id, a1.Text, a2.Text, a3.Text, a4.Text, a5.Text, a6.Text, a7.Text, a8.Text);
                    AddressDAO addressDAO = new AddressDAO();
                    addressDAO.DeleteAddress(address);
                    a1.Clear();
                    a2.Clear();
                    a3.Clear();
                    a4.Clear();
                    a5.Clear();
                    a6.Clear();
                    a7.Clear();
                    a8.Clear();
                    UpdateListView();

                    if (doubleclick == 1)
                    {
                        MessageBox.Show(
                        "Informações excluídas com sucesso!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                        "Clique duas vezes no endereço para excluí-lo!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void dados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

