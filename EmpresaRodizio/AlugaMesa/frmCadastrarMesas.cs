using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlugaMesa
{
    public partial class frmCadastrarMesas : Form
    {
        public frmCadastrarMesas()
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
        //Habilitar campos
        public void desabilitarCampos()
        {
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;       
            btnLimpar.Enabled = false;
            txtIdentDaMesa.Enabled = false;
            txtQntdDeCad.Enabled = false;
            rdbDisponivel.Enabled = false;
            rdbIndisponivel.Enabled = false;
        }
        public void habilitarCampos()
        {
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            txtIdentDaMesa.Enabled = true;
            txtQntdDeCad.Enabled = true;
            rdbDisponivel.Enabled = true;
            rdbIndisponivel.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
        public void limparCampos()
        {
            txtIdentDaMesa.Clear();
            txtQntdDeCad.Clear();
            rdbDisponivel.Checked = false;
            rdbIndisponivel.Checked = false;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }
    }
}
