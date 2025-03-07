namespace WFInicial
{
    partial class FormEx8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_numero1 = new Label();
            txt_numero1 = new TextBox();
            txt_numero2 = new TextBox();
            lbl_numero2 = new Label();
            gbx_operacao = new GroupBox();
            rdb_radiciacao = new RadioButton();
            rdb_potenciacao = new RadioButton();
            rdb_divisao = new RadioButton();
            rdb_multiplicacao = new RadioButton();
            rdb_subtracao = new RadioButton();
            rdb_soma = new RadioButton();
            btn_calcular = new Button();
            gbx_operacao.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_numero1
            // 
            lbl_numero1.AutoSize = true;
            lbl_numero1.Location = new Point(28, 22);
            lbl_numero1.Name = "lbl_numero1";
            lbl_numero1.Size = new Size(63, 15);
            lbl_numero1.TabIndex = 0;
            lbl_numero1.Text = "Numero 1:";
            lbl_numero1.Click += label1_Click;
            // 
            // txt_numero1
            // 
            txt_numero1.Location = new Point(28, 39);
            txt_numero1.Name = "txt_numero1";
            txt_numero1.Size = new Size(100, 23);
            txt_numero1.TabIndex = 1;
            // 
            // txt_numero2
            // 
            txt_numero2.Location = new Point(28, 114);
            txt_numero2.Name = "txt_numero2";
            txt_numero2.Size = new Size(100, 23);
            txt_numero2.TabIndex = 3;
            // 
            // lbl_numero2
            // 
            lbl_numero2.AutoSize = true;
            lbl_numero2.Location = new Point(28, 96);
            lbl_numero2.Name = "lbl_numero2";
            lbl_numero2.Size = new Size(63, 15);
            lbl_numero2.TabIndex = 2;
            lbl_numero2.Text = "Numero 2:";
            // 
            // gbx_operacao
            // 
            gbx_operacao.Controls.Add(rdb_radiciacao);
            gbx_operacao.Controls.Add(rdb_potenciacao);
            gbx_operacao.Controls.Add(rdb_divisao);
            gbx_operacao.Controls.Add(rdb_multiplicacao);
            gbx_operacao.Controls.Add(rdb_subtracao);
            gbx_operacao.Controls.Add(rdb_soma);
            gbx_operacao.ImeMode = ImeMode.Disable;
            gbx_operacao.Location = new Point(246, 19);
            gbx_operacao.Name = "gbx_operacao";
            gbx_operacao.Size = new Size(111, 179);
            gbx_operacao.TabIndex = 4;
            gbx_operacao.TabStop = false;
            gbx_operacao.Text = "Operação";
            // 
            // rdb_radiciacao
            // 
            rdb_radiciacao.AutoSize = true;
            rdb_radiciacao.Location = new Point(6, 149);
            rdb_radiciacao.Name = "rdb_radiciacao";
            rdb_radiciacao.Size = new Size(82, 19);
            rdb_radiciacao.TabIndex = 5;
            rdb_radiciacao.Text = "Radiciação";
            rdb_radiciacao.UseVisualStyleBackColor = true;
            // 
            // rdb_potenciacao
            // 
            rdb_potenciacao.AutoSize = true;
            rdb_potenciacao.Location = new Point(6, 124);
            rdb_potenciacao.Name = "rdb_potenciacao";
            rdb_potenciacao.Size = new Size(90, 19);
            rdb_potenciacao.TabIndex = 4;
            rdb_potenciacao.Text = "Potenciação";
            rdb_potenciacao.UseVisualStyleBackColor = true;
            // 
            // rdb_divisao
            // 
            rdb_divisao.AutoSize = true;
            rdb_divisao.Location = new Point(6, 99);
            rdb_divisao.Name = "rdb_divisao";
            rdb_divisao.Size = new Size(63, 19);
            rdb_divisao.TabIndex = 3;
            rdb_divisao.Text = "Divisão";
            rdb_divisao.UseVisualStyleBackColor = true;
            // 
            // rdb_multiplicacao
            // 
            rdb_multiplicacao.AutoSize = true;
            rdb_multiplicacao.Location = new Point(6, 74);
            rdb_multiplicacao.Name = "rdb_multiplicacao";
            rdb_multiplicacao.Size = new Size(97, 19);
            rdb_multiplicacao.TabIndex = 2;
            rdb_multiplicacao.Text = "Multiplicação";
            rdb_multiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdb_subtracao
            // 
            rdb_subtracao.AutoSize = true;
            rdb_subtracao.Location = new Point(6, 49);
            rdb_subtracao.Name = "rdb_subtracao";
            rdb_subtracao.Size = new Size(78, 19);
            rdb_subtracao.TabIndex = 1;
            rdb_subtracao.Text = "Subtração";
            rdb_subtracao.UseVisualStyleBackColor = true;
            // 
            // rdb_soma
            // 
            rdb_soma.Checked = true;
            rdb_soma.Location = new Point(6, 24);
            rdb_soma.Name = "rdb_soma";
            rdb_soma.Size = new Size(55, 19);
            rdb_soma.TabIndex = 0;
            rdb_soma.Text = "Soma";
            rdb_soma.UseVisualStyleBackColor = true;
            rdb_soma.CheckedChanged += rdb_soma_CheckedChanged;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(35, 195);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(93, 26);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // FormEx8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 265);
            Controls.Add(btn_calcular);
            Controls.Add(gbx_operacao);
            Controls.Add(txt_numero2);
            Controls.Add(lbl_numero2);
            Controls.Add(txt_numero1);
            Controls.Add(lbl_numero1);
            Name = "FormEx8";
            Text = "FormEx8";
            gbx_operacao.ResumeLayout(false);
            gbx_operacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_numero1;
        private TextBox txt_numero1;
        private TextBox txt_numero2;
        private Label lbl_numero2;
        private GroupBox gbx_operacao;
        private RadioButton rdb_radiciacao;
        private RadioButton rdb_potenciacao;
        private RadioButton rdb_divisao;
        private RadioButton rdb_multiplicacao;
        private RadioButton rdb_subtracao;
        private RadioButton rdb_soma;
        private Button btn_calcular;
    }
}