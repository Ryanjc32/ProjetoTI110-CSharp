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
    public partial class frmAlugarMesa : Form
    {
        public frmAlugarMesa()
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
        //Desabilitar campos
        public void desabilitarCampos()
        {
            btnAlugar.Enabled = false;
            btnLiberar.Enabled = false;
            btnLimpar.Enabled = false;
            txtCodMesa.Enabled = false;
            txtNomeCli.Enabled = false;
            txtStatusDoAluguel.Enabled = false;
        }
        //Habilitar campos disponivel
        public void habilitarCamposDisponivel()
        {

            txtNomeCli.Enabled = true;
            txtCodMesa.Enabled = true;
            btnAlugar.Enabled = true;
            btnLimpar.Enabled = true;
        }
        //Habilitar campos Indisponivel
        public void habilitarCamposIndisponivel()
        {
            btnLiberar.Enabled = true;
            btnLimpar.Enabled = true;
            txtNomeCli.Enabled = true;
            txtCodMesa.Enabled = true;
        }
        //Limpar Campos
        public void limparCampos()
        {
            txtNomeCli.Clear();
            txtCodMesa.Clear();
            txtStatusDoAluguel.Clear();
            rdbDisponivel.Checked = false;
            rdbIndisponivel.Checked = false;
        }

        //Desabilitar Botão liberar quando clicar em disponível
        public void desabilitarBotao()
        {
            btnAlugar.Enabled = false;
            btnLiberar.Enabled = true;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbDisponivel.Checked == true)
            {
                limparCampos();
                desabilitarCampos();
                habilitarCamposDisponivel();
                
            }
            else if (rdbIndisponivel.Checked == true)
            {
                limparCampos();
                desabilitarCampos();
                habilitarCamposIndisponivel();
               
                txtStatusDoAluguel.Text = "INDISPONIVEL";
            }
            else
            {
                MessageBox.Show("Escolha pelo menos uma opção", "Mensagem do sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            limparCampos();
        }
    }
}
