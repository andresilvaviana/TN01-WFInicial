using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx7 : Form
    {
        public string[] nomes = new string[2];
        public double[] valores = new double[2];
        public int contador = 0;

        public FormEx7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            nomes[contador - 1] = txt_produtos.Text;
            valores[contador - 1] = Convert.ToDouble(txt_valores.Text);

            txt_produtos.Text = "";
            txt_valores.Text = "";

            if (contador == 2)
            {
                double menor = valores.Min();
                int pos_menor = Array.IndexOf(valores, menor);
                string mensagem = $"O produto mais barato é é {nomes[pos_menor]} de valor R$ {menor:F2}";
                MessageBox.Show(mensagem);
            }
        }
    }
}
