using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace Sistema_de_Gerenciamento
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            Controller_Usuario c = new Controller_Usuario();
            c.Login(txtLogin.Text, txtSenha.Text, this);
           
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
