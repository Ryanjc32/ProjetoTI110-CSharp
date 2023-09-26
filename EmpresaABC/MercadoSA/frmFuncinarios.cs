using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MercadoSA
{
    public partial class frmFuncinarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncinarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimapr_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        //criando método limpar campos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            mskCEP.Clear();
            mskCPF.Clear();
            cbbEstado.Items.Clear();
            cbbEstado.Text = "";
            txtNome.Focus();



        }

        // Desabilitar campos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtEmail.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;
            cbbEstado.Enabled = false;
            txtNome.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;



        }
        // Desabilitar campos Novo
        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtEmail.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;
            cbbEstado.Enabled = false;
            txtNome.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();



        }// Habilitar campos
        public void HabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtEmail.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            cbbEstado.Enabled = true;
            cbbEstado.Enabled = true;
            txtNome.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtEndereco.Text.Equals("") || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("") || mskCPF.Text.Equals("   .   .   -") || mskCEP.Text.Equals("      -") || cbbEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!");
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso.    ");
                desabilitarCamposNovo();
            }

            desabilitarCamposNovo();
        }

        private void frmFuncinarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.ShowDialog();
        }
    }

}

