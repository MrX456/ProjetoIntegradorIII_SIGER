using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public sealed class Controller_Operacoes : IController_Operacoes
    {

        public bool Validar(string nome, string login, string senha)
        {
            if(nome.Trim() == string.Empty || nome.Length > 80)
            {
                MessageBox.Show("Impossivel inserir nome!", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (login.Trim() == string.Empty || login.Length > 80)
            {
                MessageBox.Show("Impossivel inserir login!", "Login inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (senha.Trim() == string.Empty || senha.Length > 15)
            {
                MessageBox.Show("Impossivel inserir senha!", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
