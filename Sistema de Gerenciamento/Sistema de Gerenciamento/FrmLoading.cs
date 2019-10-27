using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private void timLoad_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value < 100)
            {
                pbLoading.Value += 2;

                if (pbLoading.Value == 100) 
                {
                    Window.TelaLogin();
                    this.Dispose();
                }
            }
            else 
            {
                timLoad.Enabled = false;
            }
        }
    }
}
