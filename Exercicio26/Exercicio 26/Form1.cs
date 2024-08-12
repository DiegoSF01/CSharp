using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        { 
            string produto = Produto.Text;
            double quantidade = double.Parse(Quantidade.Text);
            double valor = double.Parse(Valor.Text);

            string item = produto + "/" + quantidade + "/" + valor;

            Produtos.Items.Add(item);

            Produto.Clear();
            Quantidade.Clear();
            Valor.Clear();
        }

        private void Nova_Venda_Click(object sender, EventArgs e)
        {
            Produto.Clear();
            Quantidade.Clear();
            Valor.Clear();
            Produtos.Items.Clear();
            Valor_V.Text = "";
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
