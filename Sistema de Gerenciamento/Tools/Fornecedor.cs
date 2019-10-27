using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public sealed class Fornecedor : Pessoa
    {

        private string produto;

        private decimal preco;

        public string Produto
        {
            get { return this.produto; }
            set { produto = value; }
        }

        public decimal Preco
        {
            get { return this.preco; }
            set { preco = value; }
        }
    }
}
