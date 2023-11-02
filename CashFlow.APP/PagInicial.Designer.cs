using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace CashFlow.APP
{
    partial class PagInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTxt = new TextBox();
            senhaTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btLogin = new Button();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // loginTxt
            // 
            loginTxt.Location = new Point(133, 137);
            loginTxt.Name = "loginTxt";
            loginTxt.Size = new Size(246, 27);
            loginTxt.TabIndex = 0;
            loginTxt.Tag = "loginTxt";
            // 
            // senhaTxt
            // 
            senhaTxt.Location = new Point(133, 204);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.PasswordChar = '*';
            senhaTxt.Size = new Size(246, 27);
            senhaTxt.TabIndex = 1;
            senhaTxt.Tag = "senhaTxt";
            senhaTxt.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 114);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 181);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.LightGreen;
            btLogin.FlatAppearance.BorderColor = Color.LightGreen;
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btLogin.Location = new Point(133, 247);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(246, 40);
            btLogin.TabIndex = 4;
            btLogin.Tag = "btLogin";
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(133, 293);
            button1.Name = "button1";
            button1.Size = new Size(246, 29);
            button1.TabIndex = 6;
            button1.Text = "Novo usuário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btNovoUsuario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Book", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(12, 351);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 7;
            label3.Text = "label3";
            label3.Visible = false;
            label3.TextChanged += textBox2_TextChanged;
            // 
            // PagInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(527, 404);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(senhaTxt);
            Controls.Add(loginTxt);
            Name = "PagInicial";
            Text = "Bem-vindo ao CIMAWallet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTxt;
        private TextBox senhaTxt;
        private Label label1;
        private Label label2;
        private Button btLogin;
        private Button button1;
        private Label label3;
    }
}