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
        private int id;
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
            try
            {
                User user = new User(id, b1.Text, b2.Text);

                UserDAO userDAO = new UserDAO();
                userDAO.InsertUser(user);

                string nome = b1.Text;
                string senha = b2.Text;

                string message = "Nome: " + nome +
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
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
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
