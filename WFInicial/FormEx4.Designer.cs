namespace WFInicial
{
    partial class FormEx4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEx4));
            btn_Calcular = new Button();
            lbl_numero1 = new Label();
            lbl_numero2 = new Label();
            txt_numero1 = new TextBox();
            txt_numero2 = new TextBox();
            txt_numero3 = new TextBox();
            lbl_numero3 = new Label();
            SuspendLayout();
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(145, 157);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(100, 23);
            btn_Calcular.TabIndex = 0;
            btn_Calcular.Text = "Mostrar Maior";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // lbl_numero1
            // 
            lbl_numero1.AutoSize = true;
            lbl_numero1.Location = new Point(79, 73);
            lbl_numero1.Name = "lbl_numero1";
            lbl_numero1.Size = new Size(60, 15);
            lbl_numero1.TabIndex = 2;
            lbl_numero1.Text = "Numero 1";
            lbl_numero1.Click += label1_Click;
            // 
            // lbl_numero2
            // 
            lbl_numero2.AutoSize = true;
            lbl_numero2.Location = new Point(79, 102);
            lbl_numero2.Name = "lbl_numero2";
            lbl_numero2.Size = new Size(60, 15);
            lbl_numero2.TabIndex = 3;
            lbl_numero2.Text = "Numero 2";
            lbl_numero2.Click += label2_Click;
            // 
            // txt_numero1
            // 
            txt_numero1.Location = new Point(145, 70);
            txt_numero1.Name = "txt_numero1";
            txt_numero1.Size = new Size(100, 23);
            txt_numero1.TabIndex = 4;
            txt_numero1.TextChanged += textBox1_TextChanged;
            // 
            // txt_numero2
            // 
            txt_numero2.Location = new Point(145, 99);
            txt_numero2.Name = "txt_numero2";
            txt_numero2.Size = new Size(100, 23);
            txt_numero2.TabIndex = 5;
            // 
            // txt_numero3
            // 
            txt_numero3.Location = new Point(145, 128);
            txt_numero3.Name = "txt_numero3";
            txt_numero3.Size = new Size(100, 23);
            txt_numero3.TabIndex = 7;
            txt_numero3.TextChanged += textBox3_TextChanged;
            // 
            // lbl_numero3
            // 
            lbl_numero3.AutoSize = true;
            lbl_numero3.Location = new Point(79, 131);
            lbl_numero3.Name = "lbl_numero3";
            lbl_numero3.Size = new Size(60, 15);
            lbl_numero3.TabIndex = 6;
            lbl_numero3.Text = "Numero 3";
            // 
            // FormEx4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(356, 278);
            Controls.Add(txt_numero3);
            Controls.Add(lbl_numero3);
            Controls.Add(txt_numero2);
            Controls.Add(txt_numero1);
            Controls.Add(lbl_numero2);
            Controls.Add(lbl_numero1);
            Controls.Add(btn_Calcular);
            Name = "FormEx4";
            Text = "FormEx4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calcular;
        private Label lbl_numero1;
        private Label lbl_numero2;
        private TextBox txt_numero1;
        private TextBox txt_numero2;
        private TextBox txt_numero3;
        private Label lbl_numero3;
    }
}