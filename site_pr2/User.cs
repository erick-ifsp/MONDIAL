using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_pr2
{
    internal class User
    {
        private int _id;
        private string _usuario;
        private string _senha;
        private string _cpf;
        private string _email;

        public User(
                    int id,
                    string usuario,
                    string senha,
                    string cpf,
                    string email
                   )
        {
            Id = id;
            Usuario = usuario;
            Senha = senha;
            Cpf = cpf;
            Email = email;
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
        public string Senha
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Preencha todos os campos");
                _senha = value;
            }
            get { return _senha; }
        }
        public string Cpf
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Preencha todos os campos");
                _cpf = value;
            }
            get { return _cpf; }
        }
        public string Email
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Preencha todos os campos");
                _email = value;
            }
            get { return _email; }
        }
    }
}
