namespace WFInicial
{
    partial class FormEx6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEx6));
            btb_ganho = new Button();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            txt_horas = new TextBox();
            lbl_horas = new Label();
            txt_mes = new TextBox();
            label2 = new Label();
            lbl_mes = new Label();
            SuspendLayout();
            // 
            // btb_ganho
            // 
            btb_ganho.Location = new Point(25, 135);
            btb_ganho.Name = "btb_ganho";
            btb_ganho.Size = new Size(225, 34);
            btb_ganho.TabIndex = 0;
            btb_ganho.Text = "Calcular o Ganho Mensal";
            btb_ganho.UseVisualStyleBackColor = true;
            btb_ganho.Click += button1_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(25, 39);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(150, 36);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 2;
            // 
            // txt_horas
            // 
            txt_horas.Location = new Point(150, 65);
            txt_horas.Name = "txt_horas";
            txt_horas.Size = new Size(100, 23);
            txt_horas.TabIndex = 4;
            txt_horas.TextChanged += textBox2_TextChanged;
            // 
            // lbl_horas
            // 
            lbl_horas.AutoSize = true;
            lbl_horas.Location = new Point(25, 68);
            lbl_horas.Name = "lbl_horas";
            lbl_horas.Size = new Size(97, 15);
            lbl_horas.TabIndex = 3;
            lbl_horas.Text = "Ganho por Horas";
            lbl_horas.Click += this.label1_Click;
            // 
            // txt_mes
            // 
            txt_mes.Location = new Point(150, 94);
            txt_mes.Name = "txt_mes";
            txt_mes.Size = new Size(100, 23);
            txt_mes.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // lbl_mes
            // 
            lbl_mes.AutoSize = true;
            lbl_mes.Location = new Point(25, 97);
            lbl_mes.Name = "lbl_mes";
            lbl_mes.Size = new Size(84, 15);
            lbl_mes.TabIndex = 7;
            lbl_mes.Text = "Horas por Mes";
            lbl_mes.Click += label3_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(349, 271);
            Controls.Add(lbl_mes);
            Controls.Add(txt_mes);
            Controls.Add(label2);
            Controls.Add(txt_horas);
            Controls.Add(lbl_horas);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(btb_ganho);
            Name = "FormEx6";
            Text = "FormEx6";
            Load += FormEx6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btb_ganho;
        private Label lbl_nome;
        private TextBox txt_nome;
        private TextBox txt_horas;
        private Label lbl_horas;
        private TextBox txt_mes;
        private Label label2;
        private Label lbl_mes;
    }
}