using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI45_Maior_de_6
{
    public partial class FrmMaiorDe6 : Form
    {
        public FrmMaiorDe6()
        {
            InitializeComponent();
        }
        #region Botão sair do programa

        private void btnSair_Click(object sender, EventArgs e)
        {
            string nome = "Deseja mesmo sair do programa?";
            string titulo = "**** SAINDO DO PROGRAMA ****";
            if (MessageBox.Show(nome, titulo, MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close(); 
            }
        }
        #endregion

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtN1.Text = string.Empty;
            txtN2.Text = string.Empty;
            txtN3.Text = string.Empty;
            txtN4.Text = string.Empty;
            txtN5.Text = string.Empty;
            txtN6.Text = string.Empty;
            lblResultado.Text = string.Empty;

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, n5, n6, maior;
            string mensagem = " ";
            try // Quando está tudo sob normalidade
            {
                n1 = int.Parse(txtN1.Text);
                n2 = int.Parse(txtN2.Text);
                n3 = int.Parse(txtN3.Text);
                n4 = int.Parse(txtN4.Text);
                n5 = int.Parse(txtN5.Text);
                n6 = int.Parse(txtN6.Text);
                if(n1>n2 && n1>n3 && n1>n4 && n1>n5 && n1 > n6)
                {
                    maior = n1;
                    mensagem = "O maior número é " + maior.ToString();
                }
                if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5 && n2 > n6)
                {
                    maior = n2;
                    mensagem = "O maior número é " + maior.ToString();
                }
                if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5 && n3 > n6)
                {
                    maior = n3;
                    mensagem = "O maior número é " + maior.ToString();
                }
                if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5 && n4 > n6)
                {
                    maior = n4;
                    mensagem = "O maior número é " + maior.ToString();
                }
                if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4 && n5 > n6)
                {
                    maior = n5;
                    mensagem = "O maior número é " + maior.ToString();
                }
                if (n6 > n1 && n6 > n2 && n6> n3 && n6 > n4 && n6 > n5)
                {
                    maior = n6;
                    mensagem = "O maior número é " + maior.ToString();
                }
                lblResultado.Text = mensagem;
                
            }
            catch (Exception erro)//Tratamento do erro 
            {
                MessageBox.Show(erro.Message+"Sequência de entrada não está em formato correto!\nTente novamente...", "*****ERRO*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1.Clear();
                txtN2.Clear();
                txtN3.Clear();
                txtN4.Clear();
                txtN5.Clear();
                txtN6.Clear();
                lblResultado.Text = string.Empty;
            }
        }

        private void txtN1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtN2.Focus();
            }
        }

        private void txtN2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtN3.Focus();
            }
        }

        private void txtN3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtN4.Focus();
            }
        }

        private void txtN4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtN5.Focus();
            }
        }

        private void txtN5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtN6.Focus();
            }
        }

        private void txtN6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVerifica.Focus();
            }
        }
    }
}
