using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetoPizzaria
{
    public partial class Form1 : Form
    {


        private Login Login;
        public MySqlDataReader reader;

        internal string user_name;
        internal string senha;

        public string NomeUsario { get; set; }
        public int Nivel { get; set; }



        Boolean logado = false;
        int valor_Nivel;
        public Form1()
        {
            InitializeComponent();
            Login login = new Login(this);
            login.ShowDialog();
            
            if (reader != null)
            {
                ComumFormLoadOperations();
            }
        }

        

        private void adicionarPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AdicionarPizza formAdicionarPizza = new AdicionarPizza();
            formAdicionarPizza.Show();
        }

        private void atualizarPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarPizza formAtualizarPizza = new AtualizarPizza();
            formAtualizarPizza.Show();
        }

        private void cardapioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cardapio formCardapio = new Cardapio();
            formCardapio.ShowDialog();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarPedido formRealizarPedido = new RealizarPedido();
            formRealizarPedido.ShowDialog();
        }

        private void pedidosEmAndamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos_Realizados formPedidosRealizados = new Pedidos_Realizados();
            formPedidosRealizados.ShowDialog();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Login == null || Login.IsDisposed)
            {
                this.Hide();
                Login login = new Login(this);
                login.ShowDialog();
                this.Show();
            }
            else 
            
            {
            
                Login.Visible = true;

            }
        }

        private void adicionarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario formAdicionarFuncionario = new AdicionarFuncionario();
            formAdicionarFuncionario.ShowDialog();
        }
        private void ComumFormLoadOperations()
        {
            Pb_Led_Logado.Image = Properties.Resources.ligar;
            if (reader is null)
            {
                MessageBox.Show("Não encontrado");
                Close();
            }
            else
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    LblNivel.Text = reader["Nivel"].ToString();
                    valor_Nivel = int.Parse(reader["Nivel"].ToString());
                    logado = true;
                }
            }
           }

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alterarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarFuncionario formAlterarFuncionario = new AlterarFuncionario();
            formAlterarFuncionario.ShowDialog();

        }
    }
}
