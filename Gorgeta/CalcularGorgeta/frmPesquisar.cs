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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            pesquisarNome();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            pesquisar();
        }
        //Limpar Campos
        public void limparCampos()
        {
           
            ltsPesquisar.Items.Clear();
        }
        public void pesquisarNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Connection = frmConexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            cbbFuncionarios.Items.Clear();
            while (DR.Read())
            {
                cbbFuncionarios.Items.Add(DR.GetString(0));
            }
            frmConexao.fecharConexao();
        }
        public void pesquisar()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select avaliacao,valorGorjeta from tbGorjeta where nome like @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = "%"+ cbbFuncionarios.Text +"%";

            comm.Connection = frmConexao.obterConexao();
            ltsPesquisar.Items.Clear();
            //Carregando dados para objeto de tabela 
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            if (DR.HasRows == false)
            {
                MessageBox.Show("Esse funcionário ainda não possui gorjeta!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            while (DR.Read())
            {

                ltsPesquisar.Items.Add("R$" + DR.GetString(1) + " " + DR.GetString(0));
            }
            frmConexao.fecharConexao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
