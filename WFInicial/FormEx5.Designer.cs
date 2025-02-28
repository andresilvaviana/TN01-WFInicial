namespace WFInicial
{
    partial class FormEx5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEx5));
            txt_numero3 = new TextBox();
            lbl_numero3 = new Label();
            txt_numero2 = new TextBox();
            txt_numero1 = new TextBox();
            lbl_numero2 = new Label();
            lbl_numero1 = new Label();
            btn_Calcular = new Button();
            SuspendLayout();
            // 
            // txt_numero3
            // 
            txt_numero3.Location = new Point(171, 124);
            txt_numero3.Name = "txt_numero3";
            txt_numero3.Size = new Size(100, 23);
            txt_numero3.TabIndex = 14;
            // 
            // lbl_numero3
            // 
            lbl_numero3.AutoSize = true;
            lbl_numero3.Location = new Point(105, 127);
            lbl_numero3.Name = "lbl_numero3";
            lbl_numero3.Size = new Size(60, 15);
            lbl_numero3.TabIndex = 13;
            lbl_numero3.Text = "Numero 3";
            // 
            // txt_numero2
            // 
            txt_numero2.Location = new Point(171, 95);
            txt_numero2.Name = "txt_numero2";
            txt_numero2.Size = new Size(100, 23);
            txt_numero2.TabIndex = 12;
            // 
            // txt_numero1
            // 
            txt_numero1.Location = new Point(171, 66);
            txt_numero1.Name = "txt_numero1";
            txt_numero1.Size = new Size(100, 23);
            txt_numero1.TabIndex = 11;
            // 
            // lbl_numero2
            // 
            lbl_numero2.AutoSize = true;
            lbl_numero2.Location = new Point(105, 98);
            lbl_numero2.Name = "lbl_numero2";
            lbl_numero2.Size = new Size(60, 15);
            lbl_numero2.TabIndex = 10;
            lbl_numero2.Text = "Numero 2";
            // 
            // lbl_numero1
            // 
            lbl_numero1.AutoSize = true;
            lbl_numero1.Location = new Point(105, 69);
            lbl_numero1.Name = "lbl_numero1";
            lbl_numero1.Size = new Size(60, 15);
            lbl_numero1.TabIndex = 9;
            lbl_numero1.Text = "Numero 1";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(105, 153);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(166, 23);
            btn_Calcular.TabIndex = 8;
            btn_Calcular.Text = "Mostrar Maior e Menor";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // FormEx5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(351, 271);
            Controls.Add(txt_numero3);
            Controls.Add(lbl_numero3);
            Controls.Add(txt_numero2);
            Controls.Add(txt_numero1);
            Controls.Add(lbl_numero2);
            Controls.Add(lbl_numero1);
            Controls.Add(btn_Calcular);
            Name = "FormEx5";
            Text = "FormEx5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_numero3;
        private Label lbl_numero3;
        private TextBox txt_numero2;
        private TextBox txt_numero1;
        private Label lbl_numero2;
        private Label lbl_numero1;
        private Button btn_Calcular;
    }
}