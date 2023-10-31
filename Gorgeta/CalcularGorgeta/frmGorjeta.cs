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
            txtValorDaGorjeta.Enabled = false;
            txtValorTotal.Enabled = false;
            txtCodigo.Enabled = false;
        }

        private void gpbCalculadoraGorjeta_Enter(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void btnCalcularGorjeta_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToInt32(txtValorDaConta.Text);
            if (cbbQualidade.SelectedIndex == 0)
            {
                txtValorDaGorjeta.Text = Convert.ToString(valor * 0.01);
                txtValorTotal.Text = Convert.ToString(valor +(valor * 0.1));

            }
            if (cbbQualidade.SelectedIndex == 1)
            {
                txtValorDaGorjeta.Text = Convert.ToString(valor * 0.08);
                txtValorTotal.Text = Convert.ToString(valor + (valor * 0.8));

            }
            if (cbbQualidade.SelectedIndex == 2)
            {
                txtValorDaGorjeta.Text = Convert.ToString(valor * 0.05);
                txtValorTotal.Text = Convert.ToString(valor + (valor * 0.5));

            }
            if (cbbQualidade.SelectedIndex == 3)
            {
                txtValorDaGorjeta.Text = Convert.ToString(valor * 0.02);
                txtValorTotal.Text = Convert.ToString(valor + (valor * 0.2));

            }
        }
        // carrega código
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codGorjeta+1 from tbFuncionarios order by codFunc desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = frmConexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetString(0));

            frmConexao.fecharConexao();

        }
    }
}
