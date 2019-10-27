using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public sealed class Cliente : Pessoa
    {

        private string email;

        public string Email 
        {
            get { return this.email; }
            set { email = value; }
        }
    }
}
