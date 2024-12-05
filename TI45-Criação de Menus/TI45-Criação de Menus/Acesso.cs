using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI45_Criação_de_Menus
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
         if(txtSenha.Text == "")
            {
                MessageBox.Show("Você deve digitar a sua Senha !!");

            }
            else
            {
                if(txtSenha.Text == "123")
                {
                    Form1 frmPrincipal = new Form1();
                    frmPrincipal.Show();
                    //Devemos esconder o formulário que está sendo executado
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Senha Inválida !!");
                    txtSenha.Clear();
                }
            }

        }
    }
}
