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
        private int termosdeuso = 0;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenssage_Click(object sender, EventArgs e)
        {
            if (termosdeuso == 0)
            {
                MessageBox.Show(
                "Aceite os termos de uso para continuar!",
                "ATENÇÃO!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    User user = new User(id, b1.Text, b2.Text, b3.Text, b4.Text);
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

                        for (; ; )
                        {
                            int[] vetorcpf = new int[11];
                            int parte1 = 0, parte2 = 0;
                            int num1 = 0;
                            int num2 = 0;
                            decimal numcpf = Convert.ToDecimal(user.Cpf.Replace(".", "").Replace("-", ""));

                            if (numcpf < 10000000000 || numcpf > 99999999999)
                            {
                                MessageBox.Show(
                                "CPF inválido!!",
                                "MONDIAL™",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                b3.Clear();
                                break;
                            }

                            else
                            {
                                for (int i = 10; i >= 0; i--)
                                {
                                    vetorcpf[i] = (int)(numcpf % 10);
                                    numcpf /= 10;
                                }
                            }
                            num1 = (((((((((vetorcpf[0] * 10) + vetorcpf[1] * 9) + vetorcpf[2] * 8) + vetorcpf[3] * 7) + vetorcpf[4] * 6) + vetorcpf[5] * 5) + vetorcpf[6] * 4) + vetorcpf[7] * 3) + vetorcpf[8] * 2) * 10;

                            if (num1 % 11 == vetorcpf[9])
                            {
                                parte1 = 1;
                            }

                            num2 = ((((((((((vetorcpf[0] * 11) + vetorcpf[1] * 10) + vetorcpf[2] * 9) + vetorcpf[3] * 8) + vetorcpf[4] * 7) + vetorcpf[5] * 6) + vetorcpf[6] * 5) + vetorcpf[7] * 4) + vetorcpf[8] * 3) + vetorcpf[9] * 2) * 10;

                            if (num2 % 11 == vetorcpf[10])
                            {
                                parte2 = 1;
                            }

                            if (parte1 == 1 && parte2 == 1)
                            {
                                if (b2.Text == Confirmb2.Text)
                                {
                                    UserDAO userDAO = new UserDAO();
                                    userDAO.InsertUser(user);

                                    string usuario = b1.Text;
                                    string senha = b2.Text;
                                    string cpf = b3.Text;
                                    string email = b4.Text;

                                    string message = "Nome: " + usuario +
                                                 "\nSenha: " + senha +
                                                 "\nCPF: " + cpf +
                                                 "\nE-mail: " + email;

                                    MessageBox.Show(
                                        message,
                                        "Atenção",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                    MessageBox.Show(
                                        "Conta criada com sucesso!!",
                                        "MONDIAL™",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                    b1.Clear();
                                    b2.Clear();
                                    b3.Clear();
                                    Close();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show(
                                    "As senhas não coincidem!",
                                    "MONDIAL™",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                    b2.Clear();
                                    Confirmb2.Clear();
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                "CPF inválido!",
                                "MONDIAL™",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                b3.Clear();
                                break;
                            }
                        }
                        break;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
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

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void senha_Click(object sender, EventArgs e)
        {

        }

        private void b1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
            "Me da um 10, marquito!",
            "TERMOS DE USO!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            termosdeuso = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            termosdeuso = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void b4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
