using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoSA
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //declarando variável para recever o botão pressionado



            DialogResult resp = MessageBox.Show("Desaj sair?", "Mensagem do Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button3);
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;

            num1 = Convert.ToDouble(txtVariavel1.Text);
            num2 = Convert.ToDouble(txtVariavel2.Text);

            if (rdbAdicao.Checked)
            {
                resultado = num1 + num2;

            }
            if (rdbSubtracao.Checked)
            {
                resultado = num1 - num2;

            }
            if (rdbMultiplicacao.Checked)
            {
                resultado = num1 * num2;

            }
            if (rdbDivisao.Checked)
            {
                if (num2==0)
                {
                    MessageBox.Show("Impossível dividir por zero!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error,
                  MessageBoxDefaultButton.Button1);
                    
                }
                else
                {
                    resultado = num1 / num2;
                }
                

            }

            lblResultado.Text = resultado.ToString();
        }
    }
}
