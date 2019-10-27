using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public sealed class Usuario : Pessoa
    {

        private string login;

        private string senha;

        private string perfil;

        public string Login
        {
            get { return this.login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return this.senha; }
            set { senha = value; }
        }

        public string Perfil
        {
            get { return this.perfil; }
            set { perfil = value; }
        }
    }
}
