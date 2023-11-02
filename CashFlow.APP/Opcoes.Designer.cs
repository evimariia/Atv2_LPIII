namespace CashFlow.APP
{
    partial class Opcoes
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Click += Form1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 77);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 1;
            label1.Text = "Selecione a opção desejada";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 147);
            button1.Name = "button1";
            button1.Size = new Size(280, 29);
            button1.TabIndex = 2;
            button1.Text = "Selecionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btEnter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Seja bem-vindo(a),";
            // 
            // button2
            // 
            button2.Location = new Point(27, 182);
            button2.Name = "button2";
            button2.Size = new Size(280, 29);
            button2.TabIndex = 4;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btSair_Click;
            // 
            // Opcoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 259);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Opcoes";
            Text = "Opções";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}