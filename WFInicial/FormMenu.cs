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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_x1_Click(object sender, EventArgs e)
        {
            FormInicial formEx1 = new FormInicial();
            formEx1.ShowDialog();

        }

        private void btn_ex2_Click(object sender, EventArgs e)
        {
            FormEx2 formEx2 = new FormEx2();
            formEx2.ShowDialog();
        }

        private void btn_ex3_Click(object sender, EventArgs e)
        {
            FormEx3 formEx3 = new FormEx3();
            formEx3.ShowDialog();
        }

        private void btn_ex4_Click(object sender, EventArgs e)
        {
            FormEx4 formEx4 = new FormEx4();
            formEx4.ShowDialog();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            FormEx5 formEx5 = new FormEx5();
            formEx5.ShowDialog();
        }

        private void btn_ex6_Click(object sender, EventArgs e)
        {
            FormEx6 formEx6 = new FormEx6();
            formEx6.ShowDialog();
        }

        private void btn_ex7_Click(object sender, EventArgs e)
        {
            FormEx7 formEx7 = new FormEx7();
            formEx7.ShowDialog();
        }

        private void btn_ex8_Click(object sender, EventArgs e)
        {
            FormEx8 formEx8 = new FormEx8();
            formEx8.ShowDialog();
        }

        private void btn_ex9_Click(object sender, EventArgs e)
        {
            FormEx9 formEx9 = new FormEx9();
            formEx9.ShowDialog();
        }

        private void btn_ex10_Click(object sender, EventArgs e)
        {
            FormEx10 formEx10 = new FormEx10();
            formEx10.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEx11 formEx11 = new FormEx11();
            formEx11.ShowDialog();
        }

        private void btn_ex12_Click(object sender, EventArgs e)
        {
            FormEx12 formEx12 = new FormEx12();
            formEx12.ShowDialog();
        }
    }
}
