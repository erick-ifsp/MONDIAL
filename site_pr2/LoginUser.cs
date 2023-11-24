using Aula1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace site_pr2
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void FillAddress_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount login = new CreateAccount();
            login.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditUser login = new EditUser();
            login.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botao_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT * FROM CreateAccount WHERE usuario = @pk";
            sqlCommand.Parameters.AddWithValue("@pk", b1.Text);

            if (b1.Text == "")
            {
                MessageBox.Show(
                "Usuário/Senha incorreto(a)!",
                "MONDIAL™",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                b2.Clear();
            }

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string senhasgbd = (string)reader["senha"];

                    string senhalogin = b2.Text;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senhalogin));
                        StringBuilder sb = new StringBuilder();
                        foreach (byte b in bytes)
                        {
                            sb.Append(b.ToString("x2"));
                        }
                        string sha256login = sb.ToString();

                        if (senhasgbd == sha256login)
                        {
                            MessageBox.Show(
                            "Bem vindo!",
                            "MONDIAL™",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            b1.Clear();
                            b2.Clear();


                            FillAddress login = new FillAddress();
                            login.ShowDialog();
                        }

                        else
                        {
                            MessageBox.Show(
                            "Usuário/Senha incorreto(a)!",
                            "MONDIAL™",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            b2.Clear();
                        }
                    }
                }
            }
        }
        static byte[] CalcularSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                return sha256.ComputeHash(bytes);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
