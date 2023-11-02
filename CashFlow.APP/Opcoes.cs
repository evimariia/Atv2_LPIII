using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashFlow.MODEL;
using MyProject.APP;

namespace CashFlow.APP
{
    public partial class Opcoes : Form
    {
        public Opcoes(String usuario)
        {
            InitializeComponent();
            label2.Text = "Seja bem-vindo(a)" + usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            PagInicial pagInicial = new PagInicial();
            pagInicial.ShowDialog();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] opcoes = { "Extrato da conta", "Cadastrar nova categoria de despesa",
                                "Cadastrar nova movimentacao"};
            comboBox1.Items.AddRange(opcoes);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string valorSelecionado = comboBox1.SelectedItem.ToString();

                switch (valorSelecionado)
                {
                    case "Extrato da conta":
                        this.Hide();
                        ExtratoConta extrato = new ExtratoConta();
                        extrato.ShowDialog();

                        break;

                    case "Cadastrar nova categoria de despesa":
                        this.Hide();
                        NovaCategoria novaCategoria = new NovaCategoria();
                        novaCategoria.ShowDialog();

                        break;

                    case "Cadastrar nova movimentacao":
                        this.Hide();
                        Movimentacao movimentacao = new Movimentacao();
                        movimentacao.ShowDialog();

                        break;

                    default:
                        MessageBox.Show("Opção não reconhecida");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma opção selecionada");
            }
        }
    }
}
