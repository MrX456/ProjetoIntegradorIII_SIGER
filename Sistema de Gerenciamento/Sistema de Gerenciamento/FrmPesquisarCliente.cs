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
    public partial class FrmPesquisarCliente : Form
    {
        Controller_Cliente cc = new Controller_Cliente();

        public FrmPesquisarCliente()
        {
            InitializeComponent();
        }

        private void txtNomeCliente_KeyUp(object sender, KeyEventArgs e)
        {
            dgvClientes.DataSource = cc.GetCliente(txtNomeCliente.Text);

            dgvClientes.Columns[0].HeaderText = "ID";
            dgvClientes.Columns[0].Width = 40;
            dgvClientes.Columns[1].HeaderText = "Nome";
            dgvClientes.Columns[1].Width = 180;
            dgvClientes.Columns[2].HeaderText = "Endereço";
            dgvClientes.Columns[2].Width = 180;
            dgvClientes.Columns[3].HeaderText = "Telefone";
            dgvClientes.Columns[3].Width = 80;
            dgvClientes.Columns[4].HeaderText = "Email";
            dgvClientes.Columns[4].Width = 200;
        }
    }
}
