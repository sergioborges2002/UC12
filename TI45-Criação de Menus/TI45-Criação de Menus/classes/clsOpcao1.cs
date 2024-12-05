using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Criação_de_Menus.classes
{
    internal class clsOpcao1
    {
        public string Saudar(string nome)
        {
            string saudacao;
            saudacao = "Bom dia " + nome + ", como vai você hoje??";
            return saudacao;
        }
    }
}
