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
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            double valorHora = Convert.ToDouble(txtvalorhora.Text);
            int quantHoras = Convert.ToInt32(txtquanthoras.Text);
            double resultado = valorHora * quantHoras;

            string mensagem = $"A renda total de {nome} é R$ {resultado:F2}";

            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
