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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }
        public int cadastrarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome,senha)values(@nome,@senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;


            comm.Connection = frmConexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            frmConexao.fecharConexao();
            return res;
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarFuncionarios();
        }
        //Limpar Campos
        public void limparCampos()
        {
            txtNomeFunc.Clear();
            txtSenha.Clear();
        }
        public void pesquisarNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome like '%" + txtPesquisarNome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("nome", MySqlDbType.VarChar, 100).Value = txtPesquisarNome.Text;

            comm.Connection = frmConexao.obterConexao();

            //Carregando dados para objeto de tabela 

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            lstFuncionarios.Items.Clear();
            while (DR.Read())
            {
                lstFuncionarios.Items.Add(DR.GetString(0));
            }

            frmConexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarNome();
        }
    }
}
