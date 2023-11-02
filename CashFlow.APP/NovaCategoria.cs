using CashFlow.APP;
using CashFlow.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyProject.APP
{
    public partial class NovaCategoria : Form
    {
        public NovaCategoria()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String cat = textBox3.Text;
            String descricao = textBox1.Text;

            Categoria categoria = new Categoria();
            categoria.Nome = cat;
            categoria.Descricao = descricao;

            BLL.CategoriaRepository.Add(categoria);
            label5.Text = "Categoria cadastrada";
            label5.Visible = true;
        }

        private void btVoltar_CLick(object sender, EventArgs e)
        {

            String login = textBox3.Text;
            Usuario usuario = BLL.UsuarioRepository.GetByLogin(login);
            String user = usuario.ToString();

            this.Close();
            Opcoes voltar = new Opcoes(user);
            voltar.ShowDialog();
        }
    }
}