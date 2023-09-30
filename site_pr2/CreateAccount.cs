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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace site_pr2
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenssage_Click(object sender, EventArgs e)
        {
            for (int i = 0; ;)
            {
                if (b1.Text == "" || b2.Text == "" || b1.Text == "" & b2.Text == "")
                {
                    MessageBox.Show(
                    "Preencha todos os campos para continuar",
                    "MONDIAL™",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                }

                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO CreateAccount VALUES
            (@nome, @senha)";

                sqlCommand.Parameters.AddWithValue("@nome", b1.Text);
                sqlCommand.Parameters.AddWithValue("@senha", b2.Text);

                sqlCommand.ExecuteNonQuery();

                string nome = b1.Text;
                string senha = b2.Text;

                string message = "Login: " + nome +
                             "\nSenha: " + senha;

                MessageBox.Show(
                    message,
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MessageBox.Show(
                    "Bem-vindo!",
                    "MONDIAL™",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                b1.Clear();
                b2.Clear();

                break;
            }
        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void senha_Click(object sender, EventArgs e)
        {

        }

        private void b1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Editar login = new Editar();
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
