using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(Renda.Text);
            double energia = double.Parse(Energia.Text);
            double agua = double.Parse(Agua.Text);
            double internet = double.Parse(Internet.Text);
            double alimentacao = double.Parse(Alimentacao.Text);
            double outros = double.Parse(Outros.Text);

            double gasto = energia + agua + internet + alimentacao + outros;
            double saldo = renda - gasto;

            Gasto.Text = gasto.ToString("C");
            Saldo.Text = saldo.ToString("C");
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            Renda.Clear();
            Energia.Clear();
            Agua.Clear();
            Internet.Clear();
            Alimentacao.Clear();
            Outros.Clear();

            Gasto.Text = "";
            Saldo.Text = "";
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
