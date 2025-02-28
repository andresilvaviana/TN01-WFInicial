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
    public partial class FormEx5 : Form
    {
        public FormEx5()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
            int num1 = int.Parse(txt_numero1.Text);
            int num2 = int.Parse(txt_numero2.Text);
            int num3 = int.Parse(txt_numero3.Text);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            int menor = Math.Min(num1, num2);
            menor = Math.Min(menor, num3);

            MessageBox.Show($"O numero {maior} é maior numero!", "infor",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            MessageBox.Show($"O numero {menor} é o menor numero!", "infor",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
