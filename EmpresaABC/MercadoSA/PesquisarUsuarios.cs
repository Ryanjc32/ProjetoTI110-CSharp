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

namespace MercadoSA
{
    public partial class PesquisarUsuarios : Form
    {
        public PesquisarUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        //desabilitar campos
        public void desabilitarCampos()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;

            txtDescricao.Enabled = false;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;

        } //Habilitar campos
        public void habilitarCampos()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }
        //limpar campos
        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Enabled = false;

            //limpa a lista
            ltbPesquisar.Items.Clear();
        }
        //Pesquisar por código
        public void pesquisaCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usuario from tbUsuarios where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = codigo;

            comm.Connection = conexao.obterConexao();

            //Carregando dados para objeto de tabela 
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();
            ltbPesquisar.Items.Clear();

            ltbPesquisar.Items.Add(DR.GetString(1));

            conexao.fecharConexao();
        }

        //Pesquisar por nome
        public void pesquisarNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usuario from tbUsuarios where usuario like'%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = nome;

            comm.Connection = conexao.obterConexao();

            //Carregando dados para objeto de tabela 

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            ltbPesquisar.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(0));
            }

            conexao.fecharConexao();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                pesquisaCodigo(Convert.ToInt32(txtDescricao.Text));
            }
            if (rdbNome.Checked)
            {
                pesquisarNome(txtDescricao.Text);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisar.SelectedItem == null)
            {
                MessageBox.Show("Favor selecionar um item.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nome = ltbPesquisar.SelectedItem.ToString();
                frmFuncinarios abrir = new frmFuncinarios(nome);
                abrir.Show();
                this.Hide();
            }
        }
    }
}
