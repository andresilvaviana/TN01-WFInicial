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
    public partial class FormEx11 : Form
    {
        public double[] salariosbruto = new double[5];
        public int contatador = 0;
        public FormEx11()
        {
            InitializeComponent();
        }

        private void txt_salariobruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

           // int cont = salariosbruto.Length;
            if (contatador < 5)
            {
                double salariobruto = double.Parse(txt_salariobruto.Text);   
                double salarioliquido = salariobruto * 0.88;

                salariosbruto[contatador] = salariobruto;

                txt_resultado.Text +=
                    $"Valor Bruto: {salariobruto:F2} \n " +
                    $"valor Liquido: {salarioliquido:F2} \n ";

            }
            else
            {
                MessageBox.Show("Quantidade Maxima!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            contatador++;
        }
    }
}
