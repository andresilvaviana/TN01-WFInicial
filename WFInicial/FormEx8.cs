using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double resultado, numero1, numero2;
            bool ehValidadoNum1 = double.TryParse(txt_numero1.Text, out numero1);
            bool ehValidadoNum2 = double.TryParse(txt_numero2.Text, out numero2);

            if (ehValidadoNum1 == false || ehValidadoNum2 == false)
            {
                MessageBox.Show("Os valores digitados não são números ",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            if (rdb_soma.Checked == true)
            {
                resultado = numero1 + numero2;
                string mensagem = $"A soma de {numero1} + {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb_subtracao.Checked == true)
            {
                resultado = numero1 - numero2;
                string mensagem = $"A subtração de {numero1} - {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb_multiplicacao.Checked == true)
            {
                resultado = numero1 * numero2;
                string mensagem = $"A multiplicação de {numero1} * {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb_divisao.Checked == true)
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("O denominador não pode ser 0!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    resultado = numero1 / numero2;
                    string mensagem = $"A multiplicação de {numero1} / {numero2} = {resultado:F2}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdb_potenciacao.Checked == true)
            {
                resultado = Math.Pow(numero1, numero2);
                string mensagem = $"A Potenciação de {numero1} ^ {numero2} = {(int)resultado}";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb_radiciacao.Checked == true)
            {
                if (numero2 == 0)
                {
                    resultado = 1;
                }
                else
                {
                    resultado = Math.Pow(numero1, (1 / numero2));


                    resultado = Math.Pow(numero1, (1 / numero2));
                    string mensagem = $"A Raiz de {numero1} ^ {numero2} = {resultado:F2}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Escolha alguma operação!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void rdb_soma_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
