using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI45_ParouImparVisual
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string nome = "Deseja sair do programa?";
            string titulo = "**** FINALIZANDO ****";
            if (MessageBox.Show(nome, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lblResultado.Text = string.Empty;
            txtNumero.Focus();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtNumero.Text);
            if (n % 2 == 0)
            {
                lblResultado.Text = "O nº " + n.ToString() + " é PAR!";
                
            }
            else
            {
                lblResultado.Text = "O nº " + n.ToString() + " é ÍMPAR!";
            }
        }
    }
}
