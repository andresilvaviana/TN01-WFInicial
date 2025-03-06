namespace WFInicial
{
    partial class FormEx7
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
            btb_cadastrar = new Button();
            lbl_produtos = new Label();
            txt_produtos = new TextBox();
            txt_valores = new TextBox();
            lbl_valores = new Label();
            SuspendLayout();
            // 
            // btb_cadastrar
            // 
            btb_cadastrar.Location = new Point(118, 102);
            btb_cadastrar.Name = "btb_cadastrar";
            btb_cadastrar.Size = new Size(75, 23);
            btb_cadastrar.TabIndex = 0;
            btb_cadastrar.Text = "Cadastrar";
            btb_cadastrar.UseVisualStyleBackColor = true;
            btb_cadastrar.Click += button1_Click;
            // 
            // lbl_produtos
            // 
            lbl_produtos.AutoSize = true;
            lbl_produtos.Location = new Point(34, 32);
            lbl_produtos.Name = "lbl_produtos";
            lbl_produtos.Size = new Size(58, 15);
            lbl_produtos.TabIndex = 1;
            lbl_produtos.Text = "Produtos:";
            // 
            // txt_produtos
            // 
            txt_produtos.Location = new Point(93, 24);
            txt_produtos.Name = "txt_produtos";
            txt_produtos.Size = new Size(100, 23);
            txt_produtos.TabIndex = 2;
            // 
            // txt_valores
            // 
            txt_valores.Location = new Point(93, 63);
            txt_valores.Name = "txt_valores";
            txt_valores.Size = new Size(100, 23);
            txt_valores.TabIndex = 4;
            txt_valores.TextChanged += textBox1_TextChanged;
            // 
            // lbl_valores
            // 
            lbl_valores.AutoSize = true;
            lbl_valores.Location = new Point(34, 71);
            lbl_valores.Name = "lbl_valores";
            lbl_valores.Size = new Size(47, 15);
            lbl_valores.TabIndex = 3;
            lbl_valores.Text = "Valores:";
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 183);
            Controls.Add(txt_valores);
            Controls.Add(lbl_valores);
            Controls.Add(txt_produtos);
            Controls.Add(lbl_produtos);
            Controls.Add(btb_cadastrar);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btb_cadastrar;
        private Label lbl_produtos;
        private TextBox txt_produtos;
        private TextBox txt_valores;
        private Label lbl_valores;
    }
}