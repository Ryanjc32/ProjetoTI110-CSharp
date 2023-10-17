using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace MercadoSA
{
    public partial class frmCadastroUsuarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadastroUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmCadastroUsuarios(string nome)
        {
            desabilitarCampos();
            txtNome.Text = nome;
            carregaUsuarios(nome);
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //carrega o código do usário
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu+1 from tbUsuarios order by codUsu desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetString(0));

            conexao.fecharConexao();
        }

        // Cadastro de usuario
        public int cadastraUsuarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(usuario,senha,codFunc)values(@usuario,@senha,@codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario",MySqlDbType.VarChar,30).Value = txtNome.Text;
            comm.Parameters.Add("@senha",MySqlDbType.VarChar,10).Value = txtSenha.Text;
            comm.Parameters.Add("@codFunc",MySqlDbType.Int32).Value = codFunc ;

            comm.Connection = conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();
            return res;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                if (cadastraUsuarios(Convert.ToInt32(txtCodFunc.Text)) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso !!!", "Messagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCamposNovo();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar !!!", "Messagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error,
                  MessageBoxDefaultButton.Button1);
                }
                cadastraUsuarios(Convert.ToInt32(txtCodFunc.Text));
            }
            else
            {
                MessageBox.Show("Senha não confere !!!", "Messagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }

        //carrega funcionarios

        public void carregaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios order by nome asc";
            comm.CommandType = CommandType.Text;

            comm.Connection = conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstFuncSemUsu.Items.Clear();

            while (DR.Read())
            {
                lstFuncSemUsu.Items.Add(DR.GetString(0));
            }
            conexao.fecharConexao();
        }

        //carrega funcionarios sem usuarios
        public void carregaCodigoFuncionarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbfuncionarios where nome = @nome";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodFunc.Text = Convert.ToString(DR.GetString(0));

            conexao.fecharConexao();
        }




        //carrega usuarios
        public void carregaUsuarios( string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.usuario, usu.senha, func.codFunc from tbFuncionarios as func inner join tbUsuarios as usu on func.codFunc = usu.codFunc where func.nome = @nome;";
            comm.CommandType = CommandType.Text;


            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            try
            {
                txtNome.Text = DR.GetString(0);
                txtSenha.Text = DR.GetString(1);

                txtCodFunc.Text = DR.GetString(2).ToString();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Funcionário não possui", "Messagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

                //carregar o código do funcionário

                txtNome.Clear();
                txtSenha.Clear();
                txtCodigo.Clear();
                txtNome.Focus();

                //carrega o código do funcionário sem usuário

                carregaCodigoFuncionarios(lstFuncSemUsu.SelectedItem.ToString());
            }
        }
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();
        }
        public void HabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtRepetirSenha.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
        }

        //Limpar campos geral
        public void limparTudo()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            txtNome.Focus();
            lstFuncSemUsu.Items.Clear();
        }

        //criando método de limpar campos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            carregaFuncionarios();
            HabilitarCampos();
            carregaCodigo();
        }

        private void lstFuncSemUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lstFuncSemUsu.SelectedItem.ToString();

            carregaUsuarios(nome);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTudo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarUsuarios(Convert.ToInt32(txtCodigo.Text))== 1)
            {
                MessageBox.Show("Usúario alterado com sucesso!!!", "Messagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("erro ao alterar", "Messagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }

        }
        //Alterar Usúarios
        public int alterarUsuarios(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update into tbUsuarios set usuario = @usuario, senha = @senha where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;
            comm.Parameters.Add("@codUsu", MySqlDbType.VarChar, 10).Value = codigo;

            comm.Connection = conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            conexao.fecharConexao();

            return res;
        }
    }
}
