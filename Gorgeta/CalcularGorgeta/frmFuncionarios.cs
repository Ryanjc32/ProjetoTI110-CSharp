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
            if (txtNomeFunc.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!!", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {

                try
                {
                    if (convercao() == false)
                    {
                        throw new FormatException();
                    }
                    
                    if (cadastrarFuncionarios() == 1)
                    {
                        MessageBox.Show("Confirmado com sucesso.", "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao confirmar", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    limparCampos();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Esse usúario já existe", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (FormatException)
                {
                    MessageBox.Show("O nome de usuário deve ser apenas texto!", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }


            }
        }
        //Limpar Campos
        public void limparCampos()
        {

            txtNomeFunc.Clear();
            txtSenha.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void txtNomeFunc_KeyDown(object sender, KeyEventArgs e)
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
                btnCadastrar.Focus();
            }
        }
        public bool convercao() { // true = a string e false == a numero
            try
            {
                Convert.ToInt32(txtNomeFunc.Text);

                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
