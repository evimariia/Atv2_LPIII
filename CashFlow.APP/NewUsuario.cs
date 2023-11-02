using CashFlow.MODEL;
using MyProject.BLL;
//using CashFlow.BLL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashFlow.APP
{
    public partial class NewUsuario : Form
    {
        public NewUsuario()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            PagInicial inicio = new PagInicial();
            inicio.ShowDialog();
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            String nome = textBox1.Text;
            String login = textBox2.Text;
            String password = textBox3.Text;

            Usuario user = new Usuario();
            user.Nome = nome;
            user.Login = login;
            user.Senha = password;

            UsuarioRepository.Add(user);

            if (UsuarioRepository.AutenticaUsuario(login, password))
            {
                label4.Text = "Usuário cadastrado com sucesso!";
                label4.Visible = true;
            }
            else
            {
                label4.Text = "Não foi possível cadastrar o usuário";
                label4.Visible = true;
            }
        }
    }


}
