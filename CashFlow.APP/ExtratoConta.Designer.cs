using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace MyProject.APP
{
    partial class ExtratoConta
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
            listView1 = new ListView();
            Categoria = new ColumnHeader();
            Valor = new ColumnHeader();
            Data = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 1;
            label1.Text = "Extrato da conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Saldo atual: R$";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Categoria, Valor, Data });
            listView1.Location = new Point(16, 83);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(515, 238);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Categoria
            // 
            Categoria.Text = "Categoria";
            Categoria.Width = 150;
            // 
            // Valor
            // 
            Valor.Text = "Valor";
            Valor.Width = 150;
            // 
            // Data
            // 
            Data.Text = "Data";
            Data.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(391, 327);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 4;
            button1.Text = "Atualizar extrato";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 362);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 5;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ExtratoConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 443);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExtratoConta";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader Categoria;
        private ColumnHeader Valor;
        private ColumnHeader Data;
        private Button button1;
        private Button button2;
    }
}