namespace WFInicial
{
    partial class FormEx10
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
            txt_resultado = new TextBox();
            lbl_numero = new Label();
            txt_numero = new TextBox();
            SuspendLayout();
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(63, 75);
            txt_resultado.Multiline = true;
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(203, 325);
            txt_resultado.TabIndex = 0;
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(63, 30);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(54, 15);
            lbl_numero.TabIndex = 1;
            lbl_numero.Text = "Numero:";
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(151, 27);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(115, 23);
            txt_numero.TabIndex = 2;
            txt_numero.TextChanged += txt_numero_TextChanged;
            txt_numero.Leave += txt_numero_Leave;
            // 
            // FormEx10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 450);
            Controls.Add(txt_numero);
            Controls.Add(lbl_numero);
            Controls.Add(txt_resultado);
            Name = "FormEx10";
            Text = "FormEx10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_resultado;
        private Label lbl_numero;
        private TextBox txt_numero;
    }
}