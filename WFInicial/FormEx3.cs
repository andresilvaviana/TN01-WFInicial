﻿using System;
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
    public partial class FormEx3 : Form
    {
        public FormEx3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_numero1.Text);
            int num2 = int.Parse(txt_numero2.Text);
            int maior = Math.Max(num1, num2);
            string menssagem = $"0 numero {maior} é o mair numero!";

            MessageBox.Show(menssagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void FormEx3_Load(object sender, EventArgs e)
        {

        }
    }
}
