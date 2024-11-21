using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI45__IMC
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {

        }

        private void txtSituacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIMC_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string nome = "Deseja sair do programa?";
            string titulo = "**** SAINDO DO PROGRAMA ****";
            if (MessageBox.Show(nome,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtSituacao.Clear();
            txtIMC.Clear();
            //Focus coloca o cursor no objeto à esquera dele
            txtPeso.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = double.Parse(txtPeso.Text);
            altura=double.Parse(txtAltura.Text);
            imc = peso / Math.Pow(altura, 2);
            txtIMC.Text = Math.Round(imc,1).ToString();
            if (imc < 20)
            {
                
                txtSituacao.Text = "ABAIXO DO PESO!!!";
            }
            else if (imc <= 25)
            {
                
                txtSituacao.Text = "PESO NORMAL!!!";
            }
            else if (imc <= 30)
            {
                
                txtSituacao.Text = "SOBREPESO!!!";
            }
            else if (imc <= 40)
            {

                txtSituacao.Text = "OBESO!!!";
            }
            else
            {
                txtSituacao.Text = "OBESO MÓRBIDO!!!";
            }
        }
    }
}
