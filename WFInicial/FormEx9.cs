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
    public partial class FormEx9 : Form
    {
        public FormEx9()
        {
            InitializeComponent();
        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Usuario us1 = new Usuario();
            bool entrou = true;
            us1.Nome = txt_usuario.Text;
            us1.Senha = txt_senha.Text;

            entrou = us1.EfetuarLogin();
            if (entrou == false)
            {
                txt_usuario.Text = "";
                txt_senha.Text = " ";

            }
            else
            {
                MessageBox.Show("Bem Vindo ao Sistema!", "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                this.Dispose();
            }
        }
    }
}
