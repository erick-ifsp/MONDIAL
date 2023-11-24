using Aula1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace site_pr2
{
    public partial class FillAddress : Form
    {
        private int id;
        public FillAddress()
        {
            InitializeComponent();
        }

        private void FillAddress_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditAddress login = new EditAddress();
            login.ShowDialog();
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
                        string numeroTelefone = address.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                        bool valido = ValidarNumeroTelefone(numeroTelefone);

                        for (; ; )
                        {
                            if (valido)
                            {
                                AddressDAO addressDAO = new AddressDAO();
                                addressDAO.InsertAddress(address);

                                string usuario = a1.Text;
                                string cep = a2.Text;
                                string telefone = a3.Text;
                                string endereco = a4.Text;
                                string numero = a5.Text;
                                string bairro = a6.Text;
                                string cidade = a7.Text;
                                string estado = a8.Text;

                                string message = "Usuario: " + usuario +
                                             "\nCep: " + cep +
                                             "\nTelefone: " + telefone +
                                             "\nEndereço: " + endereco +
                                             "\nNúmero: " + numero +
                                             "\nBairro: " + bairro +
                                             "\nCIdade: " + cidade +
                                             "\nEstado: " + estado;

                                MessageBox.Show(
                                message,
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                                MessageBox.Show(
                                "endereço adicionado com sucesso!!",
                                "MONDIAL™",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                                a1.Clear();
                                a2.Clear();
                                a3.Clear();
                                a4.Clear();
                                a5.Clear();
                                a6.Clear();
                                a7.Clear();
                                a8.Clear();
                                break;
                            }

                            else
                            {
                                MessageBox.Show(
                                "O número de telefone é inválido!",
                                "MONDIAL™",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "O nome de usuário é inválido!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        break;
                    }
                    break;
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
        private static bool VerificarUsuarioExistenteAddress(string nomeUsuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT COUNT(*) FROM CreateAddress WHERE usuario = @verificar";

            sqlCommand.Parameters.AddWithValue("@verificar", nomeUsuario);

            int count = (int)sqlCommand.ExecuteScalar();

            return count > 0;
        }
        static bool ValidarNumeroTelefone(string numero)
        {
            string padrao = @"^([1-9]{2}|[1-9]{2})9\d{8}$";

            return Regex.IsMatch(numero, padrao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario = a1.Text;
            bool usuarioExiste = VerificarUsuarioExistenteAddress(nomeUsuario);

            for (; ; )
            {
                if (usuarioExiste)
                {
                    string user, senha, cpf, email, useraddress, cepaddress, telefoneaddress, enderecoaddress, numeroaddress, bairroaddress, cidadeaddress, estadoaddress;

                    Connection connection = new Connection();
                    SqlCommand sqlCommand = new SqlCommand();

                    sqlCommand.Connection = connection.ReturnConnection();
                    sqlCommand.CommandText = "SELECT * FROM CreateAccount WHERE usuario = @user";
                    sqlCommand.Parameters.AddWithValue("@user", a1.Text);

                    if (a1.Text == "")
                    {
                        MessageBox.Show(
                        "preencha o nome de usuário!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        a1.Clear();
                    }
                    else
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            reader.Read();
                            user = (string)reader["usuario"];
                            senha = "******";
                            cpf = (string)reader["cpf"];
                            email = (string)reader["email"];
                        }

                        sqlCommand.CommandText = "SELECT * FROM CreateAddress WHERE usuario = @user";

                        using (SqlDataReader reader1 = sqlCommand.ExecuteReader())
                        {
                            reader1.Read();

                            useraddress = (string)reader1["usuario"];
                            cepaddress = (string)reader1["cep"];
                            telefoneaddress = (string)reader1["telefone"];
                            enderecoaddress = (string)reader1["endereco"];
                            numeroaddress = (string)reader1["numero"];
                            bairroaddress = (string)reader1["bairro"];
                            cidadeaddress = (string)reader1["cidade"];
                            estadoaddress = (string)reader1["estado"];
                        }
                        string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string archivename = "relatorio_" + a1.Text + ".pdf";
                        string caminhoCompleto = Path.Combine(caminho, archivename);
                        FileStream archivePDF = new FileStream(caminhoCompleto, FileMode.Create);
                        Document doc = new Document(PageSize.A4);
                        PdfWriter pdfwriter = PdfWriter.GetInstance(doc, archivePDF);

                        string dados = "";

                        Paragraph paragraph = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold));
                        paragraph.Alignment = Element.ALIGN_CENTER;
                        paragraph.Add("RELATÓRIO - MONDIAL");

                        Paragraph paragraphuser = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular));
                        paragraphuser.Alignment = Element.ALIGN_CENTER;
                        paragraphuser.Add("Dados do Usuário:\n" + "Usuário: " + user + "\nSenha: " + senha + "\n CPF: " + cpf + "\nE-mail: " + email);

                        Paragraph paragraphaddress = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular));
                        paragraphuser.Alignment = Element.ALIGN_CENTER;
                        paragraphuser.Add("\nDados do endereço:\n" + "Usuário: " + useraddress + "\nCEP: " + cepaddress + "\nTelefone: " + telefoneaddress + "\nEndereço: " + enderecoaddress + "\nNumero: " + numeroaddress + "\nBairro: " + bairroaddress + "\nCidade: " + cidadeaddress + "\nEstado: " + estadoaddress);

                        doc.Open();
                        doc.Add(paragraph);
                        doc.Add(paragraphuser);
                        doc.Add(paragraphaddress);
                        doc.Close();

                        MessageBox.Show(
                        "O relatório foi criado com sucesso e armazenado na sua área de trabalho!",
                        "MONDIAL™",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        break;
                    }
                }
                else
                {
                    MessageBox.Show(
                    "O nome de usuário é inválido!",
                    "MONDIAL™",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                }
            }
        }
    }
}