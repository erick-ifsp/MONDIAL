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
        private string _nome;
        private string _senha;

        public User(int id,
                    string nome,
                    string senha
                   )
        {
            Id = id;
            Nome = nome;
            Senha = senha;
        }

        public int Id
        {
            set
            {
                _id = value;
            }
            get { return _id; }
        }
        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha todos os campos");
                _nome = value;
            }
            get { return _nome; }
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
    }
}
