using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace MyProject.APP
{
    partial class NovaCategoria
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
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 202);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(20, 193);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 6;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btVoltar_CLick;
            // 
            // button2
            // 
            button2.Location = new Point(20, 161);
            button2.Name = "button2";
            button2.Size = new Size(201, 29);
            button2.TabIndex = 7;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 247);
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
            label6.Size = new Size(293, 20);
            label6.TabIndex = 9;
            label6.Text = "Digite o nome da nova categoria desejada";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 114);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 91);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 12;
            label1.Text = "Descrição";
            // 
            // NovaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 315);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "NovaCategoria";
            Text = "Cadastrar categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
    }
}