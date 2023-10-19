using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlugaMesa
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            frmCadastrarMesas abrir = new frmCadastrarMesas();
            abrir.Show();
            this.Hide();

        }

        private void bntAluguel_Click(object sender, EventArgs e)
        {
            frmAlugarMesa abrir = new frmAlugarMesa();
            abrir.Show();
            this.Hide();

        }
      
    }
}
