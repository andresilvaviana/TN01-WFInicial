namespace WFInicial
{
    public partial class FormInicial : System.Windows.Forms.Form
    {
        public FormInicial()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show(
                    "Aprovado",
                    "Ok",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (media < 5)
            {
                MessageBox.Show(
                    "Reprovado",
                    "Deu Ruim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                    "Recupera��o",
                    "Aten��o!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
               
            }
        }
    }
}
