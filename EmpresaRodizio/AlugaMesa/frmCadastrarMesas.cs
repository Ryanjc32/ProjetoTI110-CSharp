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
        //desabilitar campos
        public void desabilitarCampos()
        {
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            txtQntdDeCad.Enabled = true;



            rdbDisponiveis.Enabled = true;
            rdbIndisponiveis.Enabled = true;
            lstPesquisar.Enabled = true;
            btnPesquisar.Enabled = true;
        }


        //habilitar campos
        public void habilitarCampos()
        {
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            txtQntdDeCad.Enabled = true;

        }

        //desabilitar botão novo

        public void desabilitarNovo()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            rdbDisponiveis.Enabled = false;
            rdbIndisponiveis.Enabled = false;
        }

        //Habilitar campos pesquisar
        public void habilitarCamposPesquisar()
        {
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnLimpar.Enabled = true;


            txtQntdDeCad.Enabled = true;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            desabilitarNovo();

        }
        public void limparCampos()
        {

            txtQntdDeCad.Clear();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            botaoCadastar();
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

        private void gpbPesquisarMesas_Enter(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarMesa();
            habilitarCamposPesquisar();
        }

        //Função botão cadastrar
        public int botaoCadastar()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbMesa(qtdCad,status)values(@qtdCad,@status);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@status", MySqlDbType.VarChar, 15).Value = txtStatus.Text;
            comm.Parameters.Add("@qtdCad", MySqlDbType.Int32).Value = txtQntdDeCad.Text;

            comm.Connection = conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();
            return res;
        }
        public void pesquisarMesa()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idMesa, qtdCad from tbMesa where status = 'DISPONIVEL';";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.obterConexao();

            //Carregando dados para objeto de tabela 
            MySqlDataReader DR;


            DR = comm.ExecuteReader();
            lstPesquisar.Items.Clear();
            while (DR.Read())
            {
                lstPesquisar.Items.Add(DR.GetString(0));
            }

            conexao.fecharConexao();

        }

    }
}
