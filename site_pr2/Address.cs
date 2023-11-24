using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_pr2
{
    internal class Address
    {
        private int _id;
        private string _usuario;
        private string _cep;
        private string _telefone;
        private string _endereco;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;

        public Address(
                    int id,
                    string usuario,
                    string cep,
                    string telefone,
                    string endereco,
                    string numero,
                    string bairro,
                    string cidade,
                    string estado
                   )
        {
            Id = id;
            Usuario = usuario;
            Cep = cep;
            Telefone = telefone;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;

        }
        public int Id
        {
            set
            {
                _id = value;
            }
            get { return _id; }
        }
        public string Usuario
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _usuario = value;
            }
            get { return _usuario; }
        }
        public string Cep
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _cep = value;
            }
            get { return _cep; }
        }
        public string Telefone
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _telefone = value;
            }
            get { return _telefone; }
        }
        public string Endereco
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _endereco = value;
            }
            get { return _endereco; }
        }
        public string Numero
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _numero = value;
            }
            get { return _numero; }
        }
        public string Bairro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _bairro = value;
            }
            get { return _bairro; }
        }
        public string Cidade
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _cidade = value;
            }
            get { return _cidade; }
        }
        public string Estado
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _estado = value;
            }
            get { return _estado; }
        }
    }
}
