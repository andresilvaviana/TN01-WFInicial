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
    public partial class FormEx4 : Form
    {
        public FormEx4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_numero1.Text);
            int num2 = int.Parse(txt_numero2.Text);
            int num3 = int.Parse(txt_numero3.Text);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            string mesagem = $"O numero {maior} é o maior valor!";

            MessageBox.Show(mesagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
