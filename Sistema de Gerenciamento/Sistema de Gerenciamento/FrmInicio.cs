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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            this.Text = "SIGER - Tela Principal - " + Controller_Usuario.Sessao[0];
            this.ChecarPerfil(Controller_Usuario.Sessao[1]);
        }

        private void ChecarPerfil(string perfil) 
        {
            if(perfil == "administrador")
            {
                usuariosToolStripMenuItem.Visible = true;
                relatóriosToolStripMenuItem.Visible = true;
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.TelaCadastrarFornecedor(this);
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.TelaPesquisarFornecedor(this);
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Window.TelaCadastrarCliente(this);
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Window.TelaPesquisarCliente(this);
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.TelaCadastrarVenda(this);
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Window.TelaPesquisarVenda(this);
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Window.TelaUsuarios(this);
        }

        
    }
}
