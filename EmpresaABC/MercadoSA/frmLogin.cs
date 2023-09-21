//biblioteca do csharp

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MercadoSA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmEntrar_Click(object sender, EventArgs e)
        {
            //frmMenuPrincipal abrir = new frmMenuPrincipal();
            //abrir.Show();
            //this.Hide();

            //declaração das variáveis
            string usuario, senha;

            //inicializar as variáveis
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario.Equals("senac") && senha.Equals("senac"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Úsuario ou senha inválidos!!", "Mensagem do Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btmEntrar.Focus();

            }
        }
    }
}