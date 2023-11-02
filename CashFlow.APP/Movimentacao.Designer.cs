using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace MyProject.APP
{
    partial class Movimentacao
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 111);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 202);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 57);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 4;
            label4.Text = "R$";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(20, 228);
            button1.Name = "button1";
            button1.Size = new Size(291, 29);
            button1.TabIndex = 6;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btVoltar_CLick;
            // 
            // button2
            // 
            button2.Location = new Point(20, 193);
            button2.Name = "button2";
            button2.Size = new Size(291, 29);
            button2.TabIndex = 7;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 291);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 27);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 9;
            label6.Text = "Usuário";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(287, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Click += Categoria_Load;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(285, 111);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 12;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(538, 27);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 13;
            label8.Text = "Tipo";
            label8.Click += label8_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(538, 49);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(209, 28);
            comboBox2.TabIndex = 14;
            // 
            // Movimentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Movimentacao";
            Text = "Movimentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
    }
}