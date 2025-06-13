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
    public partial class Pedidos_Realizados : Form
    {
        public Pedidos_Realizados()
        {
            InitializeComponent();
        }

        private void Pedidos_Realizados_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            // String de conexão com o banco de dados
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para buscar os pedidos e dados do cliente
                    string query = @"
                SELECT 
                    pedidos.id AS 'ID do Pedido',
                    clientes.nome AS 'Cliente',
                    clientes.endereco AS 'Endereço',
                    pedidos.valor_total AS 'Valor Total (R$)',
                    pedidos.data_pedido AS 'Data do Pedido'
                FROM pedidos
                INNER JOIN clientes ON pedidos.id_cliente = clientes.id
                ORDER BY pedidos.data_pedido DESC";

                    // Preenche o DataTable com os resultados da consulta
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Vincula os dados ao DataGridView
                        dataGridViewPedidos.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar os pedidos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Confirmação para evitar exclusões acidentais
            var confirmResult = MessageBox.Show(
                "Tem certeza de que deseja excluir todos os pedidos realizados?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";

                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Excluir primeiro os itens vinculados na tabela 'itens_pedido'
                        string deleteItensPedidoQuery = "DELETE FROM itens_pedido";
                        using (var cmdItens = new MySqlCommand(deleteItensPedidoQuery, connection))
                        {
                            cmdItens.ExecuteNonQuery();
                        }

                        // Em seguida, excluir os pedidos na tabela 'pedidos'
                        string deletePedidosQuery = "DELETE FROM pedidos";
                        using (var cmdPedidos = new MySqlCommand(deletePedidosQuery, connection))
                        {
                            cmdPedidos.ExecuteNonQuery();
                        }

                        // Atualiza o DataGridView
                        MessageBox.Show("Todos os pedidos foram excluídos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarPedidos(); // Recarrega os dados no DataGridView (que ficará vazio)
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir os pedidos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
