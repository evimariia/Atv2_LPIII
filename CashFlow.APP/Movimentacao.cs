using CashFlow.APP;
using CashFlow.MODEL;
using System;
using System.Collections;
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
    public partial class Movimentacao : Form
    {
        public Movimentacao()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<Categoria> categorias = BLL.CategoriaRepository.GetAll();

            foreach (Categoria categoria in categorias)
            {
                comboBox1.Items.Add(categoria.Nome);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String valorS = textBox1.Text;
            String dataS = textBox2.Text;
            String login = textBox3.Text;
            String categoriaSelecionada = comboBox1.SelectedItem.ToString();

            decimal valor = decimal.Parse(valorS);
            DateTime data = DateTime.Parse(dataS);

            Usuario usuario = BLL.UsuarioRepository.GetByLogin(login);
            Categoria categoria = BLL.CategoriaRepository.GetByNome(categoriaSelecionada);

            Extrato movimentacao = new Extrato();
            movimentacao.Valor = valor;
            movimentacao.Data = data;
            movimentacao.IdUsuario = usuario.Id;
            movimentacao.IdCategoria = categoria.Id;

            BLL.ExtratoRepository.Add(movimentacao);
            label5.Text = "Movimentacao registrada";
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}