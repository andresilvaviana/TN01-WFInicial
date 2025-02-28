namespace WFInicial
{
    partial class FormEx3
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
            btn_Calcular = new Button();
            txt_numero1 = new TextBox();
            txt_numero2 = new TextBox();
            lbl_numero2 = new Label();
            SuspendLayout();
            // 
            // lbl_numero1
            // 
            lbl_numero1.AutoSize = true;
            lbl_numero1.BackColor = Color.White;
            lbl_numero1.Location = new Point(200, 212);
            lbl_numero1.Name = "lbl_numero1";
            lbl_numero1.Size = new Size(60, 15);
            lbl_numero1.TabIndex = 0;
            lbl_numero1.Text = "Numero 1";
            lbl_numero1.Click += label1_Click;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(321, 267);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(111, 23);
            btn_Calcular.TabIndex = 1;
            btn_Calcular.Text = "Calcular o Maior Numero";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += button1_Click;
            // 
            // txt_numero1
            // 
            txt_numero1.Location = new Point(321, 209);
            txt_numero1.Name = "txt_numero1";
            txt_numero1.Size = new Size(100, 23);
            txt_numero1.TabIndex = 2;
            // 
            // txt_numero2
            // 
            txt_numero2.Location = new Point(321, 238);
            txt_numero2.Name = "txt_numero2";
            txt_numero2.Size = new Size(100, 23);
            txt_numero2.TabIndex = 4;
            txt_numero2.TextChanged += textBox2_TextChanged;
            // 
            // lbl_numero2
            // 
            lbl_numero2.AutoSize = true;
            lbl_numero2.BackColor = SystemColors.ButtonFace;
            lbl_numero2.FlatStyle = FlatStyle.System;
            lbl_numero2.ForeColor = Color.Black;
            lbl_numero2.Location = new Point(200, 241);
            lbl_numero2.Name = "lbl_numero2";
            lbl_numero2.Size = new Size(60, 15);
            lbl_numero2.TabIndex = 3;
            lbl_numero2.Text = "Numero 2";
            // 
            // FormEx3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Become_Disney_Style_Character_A1_art_;
            ClientSize = new Size(610, 568);
            Controls.Add(txt_numero2);
            Controls.Add(lbl_numero2);
            Controls.Add(txt_numero1);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_numero1);
            Name = "FormEx3";
            Text = "FormEx3";
            Load += FormEx3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_numero1;
        private Button btn_Calcular;
        private TextBox txt_numero1;
        private TextBox txt_numero2;
        private Label lbl_numero2;
    }
}