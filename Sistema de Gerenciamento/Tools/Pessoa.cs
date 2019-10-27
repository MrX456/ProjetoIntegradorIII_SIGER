using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public class Pessoa
    {

        private int id;

        private string nome;

        private string endereco;

        private string telefone;

        public int Id 
        {
            get { return this.id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return this.endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return this.telefone; }
            set { telefone = value; }
        }
    }
}
