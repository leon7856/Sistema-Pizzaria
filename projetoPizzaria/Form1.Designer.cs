namespace projetoPizzaria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblNivel = new System.Windows.Forms.Label();
            this.Pb_Led_Logado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosEmAndamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardapioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardapioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Led_Logado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.LblNivel);
            this.panel1.Controls.Add(this.Pb_Led_Logado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 100);
            this.panel1.TabIndex = 0;
            // 
            // LblNivel
            // 
            this.LblNivel.AutoSize = true;
            this.LblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivel.ForeColor = System.Drawing.Color.White;
            this.LblNivel.Location = new System.Drawing.Point(727, 48);
            this.LblNivel.Name = "LblNivel";
            this.LblNivel.Size = new System.Drawing.Size(60, 24);
            this.LblNivel.TabIndex = 5;
            this.LblNivel.Text = "label2";
            // 
            // Pb_Led_Logado
            // 
            this.Pb_Led_Logado.Image = global::projetoPizzaria.Properties.Resources.desligar;
            this.Pb_Led_Logado.Location = new System.Drawing.Point(847, 22);
            this.Pb_Led_Logado.Name = "Pb_Led_Logado";
            this.Pb_Led_Logado.Size = new System.Drawing.Size(100, 50);
            this.Pb_Led_Logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Led_Logado.TabIndex = 4;
            this.Pb_Led_Logado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(664, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nivel:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.cardapioToolStripMenuItem,
            this.administraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.acessoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.acessoToolStripMenuItem.Text = "Acesso";
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.logarToolStripMenuItem.Text = "Logar";
            this.logarToolStripMenuItem.Click += new System.EventHandler(this.logarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPedidoToolStripMenuItem,
            this.pedidosEmAndamentoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // realizarPedidoToolStripMenuItem
            // 
            this.realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            this.realizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            this.realizarPedidoToolStripMenuItem.Click += new System.EventHandler(this.realizarPedidoToolStripMenuItem_Click);
            // 
            // pedidosEmAndamentoToolStripMenuItem
            // 
            this.pedidosEmAndamentoToolStripMenuItem.Name = "pedidosEmAndamentoToolStripMenuItem";
            this.pedidosEmAndamentoToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.pedidosEmAndamentoToolStripMenuItem.Text = "Pedidos Realizados";
            this.pedidosEmAndamentoToolStripMenuItem.Click += new System.EventHandler(this.pedidosEmAndamentoToolStripMenuItem_Click);
            // 
            // cardapioToolStripMenuItem
            // 
            this.cardapioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarPizzaToolStripMenuItem,
            this.atualizarPizzaToolStripMenuItem,
            this.cardapioToolStripMenuItem1});
            this.cardapioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardapioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cardapioToolStripMenuItem.Name = "cardapioToolStripMenuItem";
            this.cardapioToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.cardapioToolStripMenuItem.Text = "Cardapio";
            // 
            // adicionarPizzaToolStripMenuItem
            // 
            this.adicionarPizzaToolStripMenuItem.Name = "adicionarPizzaToolStripMenuItem";
            this.adicionarPizzaToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.adicionarPizzaToolStripMenuItem.Text = "Adicionar Pizza";
            this.adicionarPizzaToolStripMenuItem.Click += new System.EventHandler(this.adicionarPizzaToolStripMenuItem_Click);
            // 
            // atualizarPizzaToolStripMenuItem
            // 
            this.atualizarPizzaToolStripMenuItem.Name = "atualizarPizzaToolStripMenuItem";
            this.atualizarPizzaToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.atualizarPizzaToolStripMenuItem.Text = "Atualizar Pizza";
            this.atualizarPizzaToolStripMenuItem.Click += new System.EventHandler(this.atualizarPizzaToolStripMenuItem_Click);
            // 
            // cardapioToolStripMenuItem1
            // 
            this.cardapioToolStripMenuItem1.Name = "cardapioToolStripMenuItem1";
            this.cardapioToolStripMenuItem1.Size = new System.Drawing.Size(214, 30);
            this.cardapioToolStripMenuItem1.Text = "Cardapio";
            this.cardapioToolStripMenuItem1.Click += new System.EventHandler(this.cardapioToolStripMenuItem1_Click);
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarFuncionarioToolStripMenuItem,
            this.alterarFuncionarioToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administraçãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // adicionarFuncionarioToolStripMenuItem
            // 
            this.adicionarFuncionarioToolStripMenuItem.Name = "adicionarFuncionarioToolStripMenuItem";
            this.adicionarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.adicionarFuncionarioToolStripMenuItem.Text = "Adicionar Funcionario";
            this.adicionarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.adicionarFuncionarioToolStripMenuItem_Click);
            // 
            // alterarFuncionarioToolStripMenuItem
            // 
            this.alterarFuncionarioToolStripMenuItem.Name = "alterarFuncionarioToolStripMenuItem";
            this.alterarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.alterarFuncionarioToolStripMenuItem.Text = "Alterar Funcionario";
            this.alterarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.alterarFuncionarioToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPizzaria.Properties.Resources.vilaDyNapolli1;
            this.pictureBox1.Location = new System.Drawing.Point(271, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vila Dy Napolli Pizzaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Led_Logado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosEmAndamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardapioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardapioToolStripMenuItem1;
        private System.Windows.Forms.PictureBox Pb_Led_Logado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNivel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

