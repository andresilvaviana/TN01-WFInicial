namespace WFInicial
{
    partial class FormEx11
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
            btn_calcular = new Button();
            lbl_salariobruto = new Label();
            txt_salariobruto = new TextBox();
            txt_resultado = new RichTextBox();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(21, 58);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(183, 23);
            btn_calcular.TabIndex = 0;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // lbl_salariobruto
            // 
            lbl_salariobruto.AutoSize = true;
            lbl_salariobruto.Location = new Point(21, 27);
            lbl_salariobruto.Name = "lbl_salariobruto";
            lbl_salariobruto.Size = new Size(77, 15);
            lbl_salariobruto.TabIndex = 1;
            lbl_salariobruto.Text = "Salario Bruto:";
            // 
            // txt_salariobruto
            // 
            txt_salariobruto.Location = new Point(104, 24);
            txt_salariobruto.Name = "txt_salariobruto";
            txt_salariobruto.Size = new Size(100, 23);
            txt_salariobruto.TabIndex = 2;
            txt_salariobruto.TextChanged += txt_salariobruto_TextChanged;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(21, 92);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.RightToLeft = RightToLeft.No;
            txt_resultado.Size = new Size(183, 166);
            txt_resultado.TabIndex = 3;
            txt_resultado.Text = "";
            txt_resultado.UseWaitCursor = true;
            // 
            // FormEx11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 270);
            Controls.Add(txt_resultado);
            Controls.Add(txt_salariobruto);
            Controls.Add(lbl_salariobruto);
            Controls.Add(btn_calcular);
            Name = "FormEx11";
            Text = "FormEx11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_calcular;
        private Label lbl_salariobruto;
        private TextBox txt_salariobruto;
        private RichTextBox txt_resultado;
    }
}