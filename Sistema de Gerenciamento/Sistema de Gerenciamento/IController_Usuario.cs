using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Tools;

namespace Sistema_de_Gerenciamento
{
    public interface IController_Usuario
    {

        void Login(string login, string senha, Form f);

        void CadastrarUsuario(Usuario usuario);

        DataTable GetUsuario(string nomeLike);
    }
}
