using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_Gerenciamento
{
    public class Controller_Command
    {
        private const string verificarLogin = "SELECT * FROM tbl_usuarios WHERE login = @login AND senha = @senha";

        private const string novoUsuario = "INSERT INTO tbl_usuarios (nome, login, senha, perfil) VALUES (@nome, @login, @senha, @perfil)";

        private const string getUsuario = "SELECT * FROM tbl_usuarios WHERE nome LIKE '%";

        private const string getFornecedor = "SELECT * FROM tbl_fornecedores WHERE nome_fornecedor LIKE '%";

        private const string getCliente = "SELECT * FROM tbl_clientes WHERE nome_cliente LIKE '%";

        public static string VerificarLogin
        {
            get { return verificarLogin; }
        }

        public static string NovoUsuario
        {
            get { return novoUsuario; }
        }

        public static string GetUsuario
        {
            get { return getUsuario; }
        }

        public static string GetFornecedor
        {
            get { return getFornecedor; }
        }

        public static string GetCliente
        {
            get { return getCliente; }
        }
    }
}
