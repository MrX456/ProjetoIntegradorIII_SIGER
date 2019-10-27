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
    public partial class FrmPesquisarFornecedor : Form
    {
        Controller_Fornecedor cf = new Controller_Fornecedor();

        public FrmPesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void txtNomeFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            dgvFornecedores.DataSource = cf.GetFornecedor(txtNomeFornecedor.Text);

            //Formatação datagridview
            dgvFornecedores.Columns[0].HeaderText = "ID";
            dgvFornecedores.Columns[0].Width = 40;
            dgvFornecedores.Columns[1].HeaderText = "Nome";
            dgvFornecedores.Columns[1].Width = 180;
            dgvFornecedores.Columns[2].HeaderText = "Endereço";
            dgvFornecedores.Columns[2].Width = 180;
            dgvFornecedores.Columns[3].HeaderText = "Produto ou Serviço";
            dgvFornecedores.Columns[3].Width = 180;
            dgvFornecedores.Columns[4].HeaderText = "Valor";
            dgvFornecedores.Columns[4].DefaultCellStyle.Format = "c";
            dgvFornecedores.Columns[4].Width = 80;
            dgvFornecedores.Columns[5].HeaderText = "Telefone";
            dgvFornecedores.Columns[5].Width = 80;


        }
    }
}
