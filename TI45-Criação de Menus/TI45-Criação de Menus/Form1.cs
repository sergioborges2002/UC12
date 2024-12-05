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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opção1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.frmOpcao1 frmOpcao1 = new formularios.frmOpcao1();
            frmOpcao1.Show();
        }

        private void opção2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.frmOpcao2 frmOpcao2 = new formularios.frmOpcao2();
            frmOpcao2.Show();
        }
    }
}
