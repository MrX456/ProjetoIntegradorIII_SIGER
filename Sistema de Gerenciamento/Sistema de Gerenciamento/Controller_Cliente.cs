using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using DAL;

namespace Sistema_de_Gerenciamento
{
    public class Controller_Cliente : IController_Cliente
    {
        public DataTable GetCliente(string nomeLike)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = Controller_Command.GetCliente + nomeLike + "%' COLLATE NOCASE";
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
