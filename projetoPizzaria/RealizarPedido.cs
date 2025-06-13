using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPizzaria
{
    public partial class RealizarPedido : Form
    {

        private List<(string NomePizza, int Quantidade, decimal Valor)> itensPedido = new List<(string, int, decimal)>();
        public RealizarPedido()
        {
            InitializeComponent();
        }

        private void RealizarPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            string nomePizza = txtPizza.Text;
            int quantidade;
            decimal valorUnitario;

            // Validações básicas
            if (string.IsNullOrEmpty(nomePizza) || !int.TryParse(txtQuantidade.Text, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Preencha corretamente os campos Pizza e Quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar o valor da pizza no banco
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT preco FROM produtos WHERE nome = @nomePizza";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nomePizza", nomePizza);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Pizza não encontrada no cardápio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    valorUnitario = Convert.ToDecimal(result);
                }
            }

            // Adicionar item ao pedido
            decimal valorTotalItem = valorUnitario * quantidade;
            itensPedido.Add((nomePizza, quantidade, valorTotalItem));

            // Atualizar interface
            AtualizarListaItens();
        }

        private void AtualizarListaItens()
        {
            listBoxItensPedido.Items.Clear(); // Substitua pelo nome do ListBox que exibe os itens
            decimal valorTotal = 0;

            foreach (var item in itensPedido)
            {
                listBoxItensPedido.Items.Add($"{item.NomePizza} - {item.Quantidade}x - R$ {item.Valor:F2}");
                valorTotal += item.Valor;
            }

            lblValorTotal.Text = $"Valor Total: R$ {valorTotal:F2}";
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            if (itensPedido.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um item ao pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeCliente = txtNomeCliente.Text;
            string endereco = txtEndereco.Text;

            if (string.IsNullOrEmpty(nomeCliente) || string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Preencha os dados do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // String de conexão
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Inserir cliente
                string queryCliente = "INSERT INTO clientes (nome, endereco) VALUES (@nomeCliente, @endereco); SELECT LAST_INSERT_ID();";
                int idCliente;
                using (var cmd = new MySqlCommand(queryCliente, connection))
                {
                    cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Inserir pedido
                string queryPedido = "INSERT INTO pedidos (id_cliente, valor_total) VALUES (@idCliente, @valorTotal); SELECT LAST_INSERT_ID();";
                int idPedido;
                decimal valorTotal = itensPedido.Sum(item => item.Valor);
                using (var cmd = new MySqlCommand(queryPedido, connection))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
                    idPedido = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Inserir itens do pedido
                foreach (var item in itensPedido)
                {
                    string queryItem = "INSERT INTO itens_pedido (id_pedido, nome_pizza, quantidade, valor) VALUES (@idPedido, @nomePizza, @quantidade, @valor)";
                    using (var cmd = new MySqlCommand(queryItem, connection))
                    {
                        cmd.Parameters.AddWithValue("@idPedido", idPedido);
                        cmd.Parameters.AddWithValue("@nomePizza", item.NomePizza);
                        cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                        cmd.Parameters.AddWithValue("@valor", item.Valor);
                        cmd.ExecuteNonQuery();
                    }
                }

                
                try
                {
                    using (var serial = new System.IO.Ports.SerialPort("COM3", 9600))
                    {
                        serial.Open();
                        foreach (var item in itensPedido)
                        {
                            string mensagem = $"{item.NomePizza};{item.Quantidade}\n";
                            serial.WriteLine(mensagem);
                        }
                        serial.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar para o Arduino: " + ex.Message);
                }
            }

            MessageBox.Show("Pedido realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar os campos
            itensPedido.Clear();
            AtualizarListaItens();
            txtNomeCliente.Clear();
            txtEndereco.Clear();
            txtPizza.Clear();
            txtQuantidade.Clear();
        }

    }
}
