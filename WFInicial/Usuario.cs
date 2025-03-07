using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFInicial
{
    class Usuario
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }

        public bool EfetuarLogin()
        {
           if (Nome == Senha)
            {
                MessageBox.Show(
                    "A Senha e o Usuário não podem ser iguais!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
           else
            {
                return true;
            }
        }

    }
}
