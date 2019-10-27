using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using DAL;
using System.Windows.Forms;
using Tools;

namespace Sistema_de_Gerenciamento
{
    class Controller_Usuario : IController_Usuario
    {

        // Precisamos retornar perfil e nome
        private static string[] sessao = new string[2];

        public static string[] Sessao
        {
            get { return sessao; }
        }

        public void Login(string login, string senha, Form f)
        {
            SQLiteDataReader dr;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = Controller_Command.VerificarLogin + " COLLATE NOCASE";
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    cmd.Connection = ConnectionFactory.RequestConnection();

                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        Window.TelaInicial();
                        sessao[0] = dr[1].ToString(); // nome
                        sessao[1] = dr[4].ToString(); // perfil(para liberar opções restritas)
                        f.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha inválidos");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public void CadastrarUsuario(Usuario usuario) 
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = Controller_Command.NovoUsuario;
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@login", usuario.Login);
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@perfil", usuario.Perfil);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public DataTable GetUsuario(string nomeLike) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = Controller_Command.GetUsuario + nomeLike + "%' COLLATE NOCASE";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }
    }
}
