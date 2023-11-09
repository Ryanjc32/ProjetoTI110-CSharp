using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CalcularGorgeta
{
    public partial class frmGorjeta : Form
    {
        public frmGorjeta()
        {
            InitializeComponent();
            carregaCodigo();
            pesquisarNome();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }
        //DesabilitarCampos
        public void desabilitarCampos()
        {

            txtValorGorjeta.Enabled = false;
            txtValorTotal.Enabled = false;
            txtCodigo.Enabled = false;
            btnSalvar.Enabled = false;
        }

        // Habilitar Campos

        public void habilitarCampos()
        {
            btnSalvar.Enabled = true;
        }


        private void gpbCalculadoraGorjeta_Enter(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void btnCalcularGorjeta_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToInt32(txtValorDaConta.Text);
                if (cbbQualidade.SelectedIndex == 0)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.10);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.10));

                }
                if (cbbQualidade.SelectedIndex == 1)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.08);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.08));

                }
                if (cbbQualidade.SelectedIndex == 2)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.05);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.05));

                }
                if (cbbQualidade.SelectedIndex == 3)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.02);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.02));

                }
                desabilitarCampos();
                habilitarCampos();
                

            }
            catch
            {
                MessageBox.Show("Selecione os campos acima!!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        //Limpar Campos

        public void limparCampos()
        {
            txtValorDaConta.Clear();
            txtValorDaConta.Clear();
            txtValorGorjeta.Clear();
            txtValorTotal.Clear();
        }


        //carrega código
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codConta+1 from tbGorjeta order by codConta desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = frmConexao.obterConexao();
            MySqlDataReader DR = comm.ExecuteReader();
           
            DR.Read();
            txtCodigo.Text = Convert.ToString(DR.GetString(0));

            frmConexao.fecharConexao();

        }
        // Salvar no Banco de Dados
        public int salvarNoBanco()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbGorjeta(avaliacao,nome,valorConta,valorGorjeta,valorTotal)values(@avaliacao,@nome,@valorConta,@valorGorjeta,@valorTotal);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@avaliacao", MySqlDbType.VarChar, 100).Value = cbbQualidade.Text;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value =cbbNomeFunc.Text;
            comm.Parameters.Add("@valorConta", MySqlDbType.VarChar, 100).Value = txtValorDaConta.Text;
            comm.Parameters.Add("@valorGorjeta", MySqlDbType.VarChar, 100).Value = txtValorGorjeta.Text;
            comm.Parameters.Add("@valorTotal", MySqlDbType.VarChar, 100).Value = txtValorTotal.Text;

            comm.Connection = frmConexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            frmConexao.fecharConexao();

            return res;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Equals("") || txtValorGorjeta.Text.Equals("") || txtValorTotal.Text.Equals("") || txtValorDaConta.Text.Equals("") || cbbQualidade.SelectedIndex.Equals(-1) || cbbNomeFunc.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor preencher os campos!!!", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (salvarNoBanco() == 1)
                {
                    MessageBox.Show("Confirmado com sucesso.", "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Erro ao confirmar", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                limparCampos();
            }

            }
        public void excluirCodConta(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
          //  comm.CommandText = "delete from tbGorjeta where codConta = @codConta;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codConta", MySqlDbType.Int32).Value = codigo;

            comm.Connection = frmConexao.obterConexao();
            comm.ExecuteNonQuery();

            frmConexao.fecharConexao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja excluir?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if ( resp == DialogResult.Yes)
            {
                excluirCodConta(Convert.ToInt32(txtCodigo.Text));
                limparCampos();
            }
            else
            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        //carrega nome
        public void pesquisarNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Connection = frmConexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            cbbNomeFunc.Items.Clear();
            while (DR.Read()){
                cbbNomeFunc.Items.Add(DR.GetString(0));
            }
            frmConexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
              frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }
    }
}
