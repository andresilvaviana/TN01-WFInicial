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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEx6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            double horas = Convert.ToDouble(txt_horas.Text);
            double mes = Convert.ToDouble(txt_mes.Text);

            double resultado = horas * mes;

            MessageBox.Show($"A renda do {nome} é R${resultado:F2}", "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
