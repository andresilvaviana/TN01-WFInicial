namespace WFInicial
{
    partial class FormInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNota1 = new Label();
            txtNota1 = new TextBox();
            btnCalcular = new Button();
            txtNota2 = new TextBox();
            lblNota2 = new Label();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(46, 47);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(45, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1:";
            lblNota1.Click += label1_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(97, 44);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(134, 23);
            txtNota1.TabIndex = 1;
            txtNota1.TextChanged += textBox1_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.ForeColor = SystemColors.ControlText;
            btnCalcular.Location = new Point(97, 130);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(134, 33);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(97, 84);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(134, 23);
            txtNota2.TabIndex = 4;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(46, 87);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(45, 15);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "Nota 2:";
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 198);
            Controls.Add(txtNota2);
            Controls.Add(lblNota2);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota1);
            Controls.Add(lblNota1);
            Name = "FormInicial";
            Text = "Calcular Média das Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private TextBox txtNota1;
        private Button btnCalcular;
        private TextBox txtNota2;
        private Label lblNota2;
    }
}
