namespace Exercicio25
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gastos = new System.Windows.Forms.Label();
            this.Sald = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Energia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Agua = new System.Windows.Forms.TextBox();
            this.Internet = new System.Windows.Forms.TextBox();
            this.Outros = new System.Windows.Forms.TextBox();
            this.Alimentacao = new System.Windows.Forms.TextBox();
            this.Renda = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.Gasto = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renda Familiar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Água:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TV / Fone / Internet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alimentação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Outros gastos:";
            // 
            // Gastos
            // 
            this.Gastos.AutoSize = true;
            this.Gastos.Location = new System.Drawing.Point(58, 555);
            this.Gastos.Name = "Gastos";
            this.Gastos.Size = new System.Drawing.Size(90, 13);
            this.Gastos.TabIndex = 6;
            this.Gastos.Text = "Total dos Gastos:";
            // 
            // Sald
            // 
            this.Sald.AutoSize = true;
            this.Sald.Location = new System.Drawing.Point(58, 602);
            this.Sald.Name = "Sald";
            this.Sald.Size = new System.Drawing.Size(37, 13);
            this.Sald.TabIndex = 7;
            this.Sald.Text = "Saldo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Energia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Agua);
            this.groupBox1.Controls.Add(this.Internet);
            this.groupBox1.Controls.Add(this.Outros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Alimentacao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(52, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 311);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos:";
            // 
            // Energia
            // 
            this.Energia.Location = new System.Drawing.Point(118, 49);
            this.Energia.Name = "Energia";
            this.Energia.Size = new System.Drawing.Size(260, 20);
            this.Energia.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Energia Elétrica:";
            // 
            // Agua
            // 
            this.Agua.Location = new System.Drawing.Point(118, 100);
            this.Agua.Name = "Agua";
            this.Agua.Size = new System.Drawing.Size(260, 20);
            this.Agua.TabIndex = 16;
            // 
            // Internet
            // 
            this.Internet.Location = new System.Drawing.Point(118, 149);
            this.Internet.Name = "Internet";
            this.Internet.Size = new System.Drawing.Size(260, 20);
            this.Internet.TabIndex = 15;
            // 
            // Outros
            // 
            this.Outros.Location = new System.Drawing.Point(118, 239);
            this.Outros.Name = "Outros";
            this.Outros.Size = new System.Drawing.Size(260, 20);
            this.Outros.TabIndex = 12;
            // 
            // Alimentacao
            // 
            this.Alimentacao.Location = new System.Drawing.Point(118, 197);
            this.Alimentacao.Name = "Alimentacao";
            this.Alimentacao.Size = new System.Drawing.Size(260, 20);
            this.Alimentacao.TabIndex = 11;
            // 
            // Renda
            // 
            this.Renda.Location = new System.Drawing.Point(144, 42);
            this.Renda.Name = "Renda";
            this.Renda.Size = new System.Drawing.Size(260, 20);
            this.Renda.TabIndex = 10;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(52, 460);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(86, 44);
            this.Calcular.TabIndex = 11;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(207, 460);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(86, 44);
            this.Novo.TabIndex = 12;
            this.Novo.Text = "Novo Calculo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(374, 460);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(86, 44);
            this.Fechar.TabIndex = 13;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Gasto
            // 
            this.Gasto.AutoSize = true;
            this.Gasto.Location = new System.Drawing.Point(170, 555);
            this.Gasto.Name = "Gasto";
            this.Gasto.Size = new System.Drawing.Size(0, 13);
            this.Gasto.TabIndex = 14;
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Location = new System.Drawing.Point(170, 602);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(0, 13);
            this.Saldo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 650);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.Gasto);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Renda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gastos);
            this.Controls.Add(this.Sald);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Gastos;
        private System.Windows.Forms.Label Sald;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Energia;
        private System.Windows.Forms.TextBox Agua;
        private System.Windows.Forms.TextBox Internet;
        private System.Windows.Forms.TextBox Outros;
        private System.Windows.Forms.TextBox Alimentacao;
        private System.Windows.Forms.TextBox Renda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label Gasto;
        private System.Windows.Forms.Label Saldo;
    }
}

