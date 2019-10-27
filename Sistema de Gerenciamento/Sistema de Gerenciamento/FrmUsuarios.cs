using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools;

namespace Sistema_de_Gerenciamento
{
    public partial class FrmUsuarios : Form
    {
        Controller_Operacoes op = new Controller_Operacoes();
        Controller_Usuario us = new Controller_Usuario();
        Usuario usuario = new Usuario();

        public FrmUsuarios()
        {
            InitializeComponent();
            cboPerfil.SelectedItem = "administrador";
        }

        private Usuario SetUsuario(string nome, string login, string senha, string perfil) 
        {
            usuario.Nome = nome;
            usuario.Login = login;
            usuario.Senha = senha;
            usuario.Perfil = perfil;

            return usuario;

        }

        private void SetDefaultState() 
        {
            txtNomeUsuario.Text = null;
            txtUsuario.Text = null;
            txtLogin.Text = null;
            txtSenha.Text = null;
            cboPerfil.SelectedItem = "administrador";

            dgvUsuarios.DataSource = null;

            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (op.Validar(txtUsuario.Text, txtLogin.Text, txtSenha.Text)) 
            {
                this.SetUsuario(txtUsuario.Text, txtLogin.Text, txtSenha.Text, cboPerfil.SelectedItem.ToString());
                us.CadastrarUsuario(usuario);
                this.SetDefaultState();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
             
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.SetDefaultState();
        }

        private void txtNomeUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            dgvUsuarios.DataSource = us.GetUsuario(txtNomeUsuario.Text);
            dgvUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
        }

    }
}
