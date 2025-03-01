namespace WFInicial
{
    partial class FormMenu
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
            btn_x1 = new Button();
            btn_ex2 = new Button();
            btn_ex4 = new Button();
            btn_ex3 = new Button();
            btn_ex7 = new Button();
            btn_ex6 = new Button();
            btn_5 = new Button();
            SuspendLayout();
            // 
            // btn_x1
            // 
            btn_x1.Location = new Point(26, 32);
            btn_x1.Name = "btn_x1";
            btn_x1.Size = new Size(75, 23);
            btn_x1.TabIndex = 0;
            btn_x1.Text = "exercicio 1";
            btn_x1.UseVisualStyleBackColor = true;
            btn_x1.Click += btn_x1_Click;
            // 
            // btn_ex2
            // 
            btn_ex2.Location = new Point(107, 32);
            btn_ex2.Name = "btn_ex2";
            btn_ex2.Size = new Size(75, 23);
            btn_ex2.TabIndex = 1;
            btn_ex2.Text = "exercicio 2";
            btn_ex2.UseVisualStyleBackColor = true;
            btn_ex2.Click += btn_ex2_Click;
            // 
            // btn_ex4
            // 
            btn_ex4.Location = new Point(269, 32);
            btn_ex4.Name = "btn_ex4";
            btn_ex4.Size = new Size(75, 23);
            btn_ex4.TabIndex = 3;
            btn_ex4.Text = "exercicio 4";
            btn_ex4.UseVisualStyleBackColor = true;
            btn_ex4.Click += btn_ex4_Click;
            // 
            // btn_ex3
            // 
            btn_ex3.Location = new Point(188, 32);
            btn_ex3.Name = "btn_ex3";
            btn_ex3.Size = new Size(75, 23);
            btn_ex3.TabIndex = 2;
            btn_ex3.Text = "exercicio 3";
            btn_ex3.UseVisualStyleBackColor = true;
            btn_ex3.Click += btn_ex3_Click;
            // 
            // btn_ex7
            // 
            btn_ex7.Location = new Point(188, 61);
            btn_ex7.Name = "btn_ex7";
            btn_ex7.Size = new Size(75, 23);
            btn_ex7.TabIndex = 6;
            btn_ex7.Text = "exercicio 7";
            btn_ex7.UseVisualStyleBackColor = true;
            btn_ex7.Click += btn_ex7_Click;
            // 
            // btn_ex6
            // 
            btn_ex6.Location = new Point(107, 61);
            btn_ex6.Name = "btn_ex6";
            btn_ex6.Size = new Size(75, 23);
            btn_ex6.TabIndex = 5;
            btn_ex6.Text = "exercicio 6";
            btn_ex6.UseVisualStyleBackColor = true;
            btn_ex6.Click += btn_ex6_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(26, 61);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(75, 23);
            btn_5.TabIndex = 4;
            btn_5.Text = "exercicio 5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ex7);
            Controls.Add(btn_ex6);
            Controls.Add(btn_5);
            Controls.Add(btn_ex4);
            Controls.Add(btn_ex3);
            Controls.Add(btn_ex2);
            Controls.Add(btn_x1);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_x1;
        private Button btn_ex2;
        private Button btn_ex4;
        private Button btn_ex3;
        private Button btn_ex7;
        private Button btn_ex6;
        private Button btn_5;
    }
}