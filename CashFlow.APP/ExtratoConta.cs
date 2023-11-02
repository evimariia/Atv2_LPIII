using CashFlow.MODEL;
using Microsoft.VisualBasic;
using MyProject.BLL;
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
    public partial class ExtratoConta : Form
    {
        public ExtratoConta()
        {
            InitializeComponent();
            decimal saldoAtual = 0;

            List<Extrato> extratos = ExtratoRepository.GetAll();

            foreach (Extrato extrato in extratos)
            {
                if(extrato.Tipo == "D")
                {
                    saldoAtual -= extrato.Valor;
                }
                else if(extrato.Tipo == "R")
                {
                    saldoAtual += extrato.Valor;
                }
            }

                label2.Text = "Saldo atual: R$" + saldoAtual;
        }

        private void PopularGrade()
        {
            List<Extrato> extratos = ExtratoRepository.GetAll();

            foreach (Extrato extrato in extratos)
            {
                string[] item = new string[4];

                Extrato e = ExtratoRepository.GetById(extrato.Id);
                item[0] = e.IdCategoria.ToString();
                item[1] = e.Valor.ToString();
                DateTime dataHora = (DateTime)e.Data;
                string dataFormatada = dataHora.ToString("dd/MM/yyyy");
                item[2] = dataFormatada;
                item[3] = e.Tipo;

                ListViewItem l = new ListViewItem(item);

                listView1.Items.Add(l);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularGrade();
        }

    }
}