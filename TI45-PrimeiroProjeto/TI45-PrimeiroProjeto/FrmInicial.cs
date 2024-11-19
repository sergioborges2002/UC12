using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI45_PrimeiroProjeto
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Esta forma o formulário em uso atual
            this.Close();
            //Esta forma fecha TODA a aplicação
            //Application.Exit();
        }

        private void btnOla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, "+txtNome.Text, "Saudações da TI45 ",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
        }
    }
}
