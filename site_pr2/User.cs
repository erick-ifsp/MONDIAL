using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_pr2
{
    internal class User
    {
        private string _nome;
        private string _senha;

        public User(string nome,
                    string senha
                   )
        {
            Nome = nome;
            Senha = senha;
        }
        public string Nome
        {
            set { Nome = value; }
            get { return _nome; }
        }
        public string Senha
        {
            set { Senha = value; }
            get { return _senha; }
        }
    }
}
