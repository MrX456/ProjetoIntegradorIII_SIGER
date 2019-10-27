using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public class Window
    {
        // Este método abre a tela login
        public static void TelaLogin()
        {
            Thread t1 = new Thread(AbrirTelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private static void AbrirTelaLogin(Object obj)
        {
            Application.Run(new FrmLogin());

        }

        // Este método abre a tela inicial
        public static void TelaInicial()
        {
            Thread t1 = new Thread(AbrirTelaInicial);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private static void AbrirTelaInicial(Object obj)
        {
            Application.Run(new FrmInicio());

        }

        // Estes métodos abrem formularios filhos da tela principal[Instância unica]
        public static void TelaCadastrarFornecedor(Form f)
        {
            foreach(Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmCadastrarFornecedor)) 
                {
                    form.Activate();
                    return;
                }
            }

            FrmCadastrarFornecedor cf = new FrmCadastrarFornecedor();
            cf.MdiParent = f;
            cf.Dock = DockStyle.Fill;
            cf.Show();
                        
        }

        public static void TelaPesquisarFornecedor(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmPesquisarFornecedor))
                {
                    form.Activate();
                    return;
                }
            }

            FrmPesquisarFornecedor pf = new FrmPesquisarFornecedor();
            pf.MdiParent = f;
            pf.Dock = DockStyle.Fill;
            pf.Show();
        }

        public static void TelaCadastrarCliente(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmCadastrarCliente))
                {
                    form.Activate();
                    return;
                }
            }

            FrmCadastrarCliente cc = new FrmCadastrarCliente();
            cc.MdiParent = f;
            cc.Dock = DockStyle.Fill;
            cc.Show();
        }

        public static void TelaPesquisarCliente(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmPesquisarCliente))
                {
                    form.Activate();
                    return;
                }
            }

            FrmPesquisarCliente pc = new FrmPesquisarCliente();
            pc.MdiParent = f;
            pc.Dock = DockStyle.Fill;
            pc.Show();
        }

        public static void TelaCadastrarVenda(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmCadastrarVenda))
                {
                    form.Activate();
                    return;
                }
            }

            FrmCadastrarVenda cv = new FrmCadastrarVenda();
            cv.MdiParent = f;
            cv.Dock = DockStyle.Fill;
            cv.Show();
        }

        public static void TelaPesquisarVenda(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmPesquisarVendas))
                {
                    form.Activate();
                    return;
                }
            }

            FrmPesquisarVendas pv = new FrmPesquisarVendas();
            pv.MdiParent = f;
            pv.Dock = DockStyle.Fill;
            pv.Show();
        }
        public static void TelaUsuarios(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmUsuarios))
                {
                    form.Activate();
                    return;
                }
            }

            FrmUsuarios u = new FrmUsuarios();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }
    }
}
