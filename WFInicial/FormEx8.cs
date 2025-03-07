using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx8 : Form
    {
        public FormEx8()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double resultado, numero1, numero2 = 0;
            bool ehValidonum1 = double.TryParse(txtnumero1.Text, out numero1);
            bool ehValidonum2 = double.TryParse(txtnumero2.Text, out numero2);

            if (ehValidonum1 == false || ehValidonum2 == false)
            {
                MessageBox.Show("Os valores digitados não são um número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rdbSoma.Checked == true)
            {
                resultado = numero1 + numero2;
                string mensagem = $"A soma de {numero1} + {numero2} = {resultado}";
                MessageBox.Show(mensagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbSubtracao.Checked == true)
            {
                resultado = numero1 - numero2;
                string mensagem = $"A subtração de {numero1} - {numero2} = {resultado}";
                MessageBox.Show(mensagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbmultiplicacao.Checked == true)
            {
                resultado = numero1 * numero2;
                string mensagem = $"A multiplicação de {numero1} * {numero2} = {resultado}";
                MessageBox.Show(mensagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbdivisao.Checked == true)
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("O denominador não pode ser zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resultado = numero1 / numero2;
                    string mensagem = $"A divisão de {numero1} / {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdbpotenciacao.Checked == true)
            {
                resultado = Math.Pow(numero1, numero2);
                string mensagem = $"A potencia de numero {numero1} ^ {numero2} = {resultado}";
                MessageBox.Show(mensagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbradiciacao.Checked == true)
            {
                if (numero2 == 0)
                    resultado = 1;

                else
                    resultado = Math.Pow(numero1, 1 / numero2);

                string mensagem = $"A raiz de {numero1} ^ {1 / numero2} = {resultado}";
                MessageBox.Show(mensagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Voce deve esolher uma operação!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}