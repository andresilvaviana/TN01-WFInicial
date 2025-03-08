namespace WFInicial
{
    partial class FormEx12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEx12));
            lbl_numero = new Label();
            txt_numeros = new TextBox();
            lbl_contador = new Label();
            btn_adicionar = new Button();
            lbl_numeros = new Label();
            lbl_par = new Label();
            lbl_impar = new Label();
            SuspendLayout();
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(84, 28);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(54, 15);
            lbl_numero.TabIndex = 2;
            lbl_numero.Text = "Numero:";
            // 
            // txt_numeros
            // 
            txt_numeros.Location = new Point(144, 25);
            txt_numeros.Name = "txt_numeros";
            txt_numeros.Size = new Size(125, 23);
            txt_numeros.TabIndex = 3;
            // 
            // lbl_contador
            // 
            lbl_contador.AutoSize = true;
            lbl_contador.Location = new Point(275, 28);
            lbl_contador.Name = "lbl_contador";
            lbl_contador.Size = new Size(13, 15);
            lbl_contador.TabIndex = 4;
            lbl_contador.Text = "0";
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(84, 54);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(204, 23);
            btn_adicionar.TabIndex = 6;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // lbl_numeros
            // 
            lbl_numeros.BorderStyle = BorderStyle.Fixed3D;
            lbl_numeros.Location = new Point(84, 105);
            lbl_numeros.Name = "lbl_numeros";
            lbl_numeros.Size = new Size(204, 27);
            lbl_numeros.TabIndex = 7;
            lbl_numeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_par
            // 
            lbl_par.BorderStyle = BorderStyle.Fixed3D;
            lbl_par.Location = new Point(84, 145);
            lbl_par.Name = "lbl_par";
            lbl_par.Size = new Size(204, 27);
            lbl_par.TabIndex = 10;
            lbl_par.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_impar
            // 
            lbl_impar.BorderStyle = BorderStyle.Fixed3D;
            lbl_impar.Location = new Point(84, 187);
            lbl_impar.Name = "lbl_impar";
            lbl_impar.Size = new Size(204, 27);
            lbl_impar.TabIndex = 11;
            lbl_impar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEx12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(352, 271);
            Controls.Add(lbl_impar);
            Controls.Add(lbl_par);
            Controls.Add(lbl_numeros);
            Controls.Add(btn_adicionar);
            Controls.Add(lbl_contador);
            Controls.Add(txt_numeros);
            Controls.Add(lbl_numero);
            Name = "FormEx12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEx12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_numero;
        private TextBox txt_numeros;
        private Label lbl_contador;
        private Button btn_adicionar;
        private Label lbl_numeros;
        private Label lbl_par;
        private Label lbl_impar;
    }
}