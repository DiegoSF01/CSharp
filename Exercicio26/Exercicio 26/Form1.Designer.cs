namespace Exercicio_26
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Inserir = new System.Windows.Forms.Button();
            this.Nova_Venda = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.Produto = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.TextBox();
            this.Produtos = new System.Windows.Forms.ListBox();
            this.Valor_V = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(19, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Produto:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(19, 95);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Quantidade:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(19, 143);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(64, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Vlr. Unitário:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(19, 545);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(83, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Total da Venda:";
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(201, 198);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(110, 44);
            this.Inserir.TabIndex = 4;
            this.Inserir.Text = "Inserir Produto";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Nova_Venda
            // 
            this.Nova_Venda.Location = new System.Drawing.Point(101, 575);
            this.Nova_Venda.Name = "Nova_Venda";
            this.Nova_Venda.Size = new System.Drawing.Size(110, 44);
            this.Nova_Venda.TabIndex = 5;
            this.Nova_Venda.Text = "Nova Venda";
            this.Nova_Venda.UseVisualStyleBackColor = true;
            this.Nova_Venda.Click += new System.EventHandler(this.Nova_Venda_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(307, 575);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(110, 44);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Produto
            // 
            this.Produto.Location = new System.Drawing.Point(63, 47);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(392, 20);
            this.Produto.TabIndex = 7;
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(101, 95);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(233, 20);
            this.Quantidade.TabIndex = 8;
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(101, 143);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(233, 20);
            this.Valor.TabIndex = 9;
            // 
            // Produtos
            // 
            this.Produtos.FormattingEnabled = true;
            this.Produtos.Location = new System.Drawing.Point(22, 254);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(480, 264);
            this.Produtos.TabIndex = 10;
            // 
            // Valor_V
            // 
            this.Valor_V.AutoSize = true;
            this.Valor_V.BackColor = System.Drawing.Color.Transparent;
            this.Valor_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_V.ForeColor = System.Drawing.Color.Blue;
            this.Valor_V.Location = new System.Drawing.Point(114, 530);
            this.Valor_V.Name = "Valor_V";
            this.Valor_V.Size = new System.Drawing.Size(0, 31);
            this.Valor_V.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 670);
            this.Controls.Add(this.Valor_V);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Nova_Venda);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Nova_Venda;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.TextBox Produto;
        private System.Windows.Forms.TextBox Quantidade;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.ListBox Produtos;
        private System.Windows.Forms.Label Valor_V;
    }
}

