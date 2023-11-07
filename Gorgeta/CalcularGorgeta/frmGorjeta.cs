﻿using System;
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
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.01);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.1));

                }
                if (cbbQualidade.SelectedIndex == 1)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.08);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.8));

                }
                if (cbbQualidade.SelectedIndex == 2)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.05);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.5));

                }
                if (cbbQualidade.SelectedIndex == 3)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.02);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.2));

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
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
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
            salvarNoBanco();
            limparCampos();
        }
    }
}
